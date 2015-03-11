﻿// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Contracts.Loans;
using OpenCBS.CoreDomain.Contracts.Loans.Installments;
using OpenCBS.CoreDomain.Events.Loan;
using OpenCBS.Shared;

namespace OpenCBS.Manager
{
	/// <summary>
	/// Description r�sum�e de InstallmentManagement.
	/// </summary>
	public class InstallmentManager : Manager
	{
	   
        public InstallmentManager(User pUser) : base(pUser)
        {
            
        }

		public InstallmentManager(string pTestDb) : base(pTestDb)
		{
		    
		}

        public void AddInstallments(List<Installment> pInstallments, int pLoanId)
        {
            using (var connection = GetConnection())
            using (var transaction = connection.BeginTransaction())
            {
                AddInstallments(pInstallments, pLoanId, transaction);
                transaction.Commit();
            }            
        }

        public void AddInstallments(List<Installment> pInstallments, int pLoanId, SqlTransaction pSqlTransac)
		{
            const string q = @"INSERT INTO Installments(
                                        expected_date, 
                                        interest_repayment, 
                                        capital_repayment, 
                                        contract_id, 
                                        number,
                                        paid_interest,
                                        paid_capital,
                                        fees_unpaid,
                                        paid_date,
                                        paid_fees,
                                        comment, 
                                        pending,
                                        start_date,
                                        olb,
                                        commission,
                                        paid_commission)
                                    VALUES (
                                        @expectedDate,
                                        @interestsRepayment,
                                        @capitalRepayment,
                                        @contractId,
                                        @number,
                                        @paidInterests,
                                        @paidCapital,
                                        @feesUnpaid,
                                        @paidDate, 
                                        @paid_fees, 
                                        @comment,
                                        @pending,
                                        @start_date,
                                        @olb,
                                        @commission,
                                        @paidCommission)";

            using(var c = new OpenCbsCommand(q, pSqlTransac.Connection, pSqlTransac))
            {
                foreach(var installment in pInstallments)
                {
                    SetInstallment(installment,pLoanId, c);
                    c.ExecuteNonQuery();
                    c.ResetParams();
                }
            }
        }

        public void DeleteInstallments(int pLoanId)
        {
            using (var conn = GetConnection())
            using (var t = conn.BeginTransaction())
            {
                DeleteInstallments(pLoanId, t);
                t.Commit();
            }
        }

        public void DeleteInstallments(int pLoanId, SqlTransaction pSqlTransac)
        {
            const string q = @"DELETE FROM Installments WHERE contract_id = @contractId";

            using (var c = new OpenCbsCommand(q, pSqlTransac.Connection, pSqlTransac))
            {
                c.AddParam("@contractId", pLoanId);
                c.ExecuteNonQuery();
            }
        }

        public List<Installment> SelectInstallments(int pLoanId)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                List<Installment> list = SelectInstallments(pLoanId, transaction);
                transaction.Commit();
                return list;
            }
        }

	    public List<Installment> SelectInstallments(int pLoanId, SqlTransaction pSqlTransac)
        {
            const string sqlText = @"SELECT 
                                            expected_date, 
                                            interest_repayment, 
                                            capital_repayment,
                                            number,
                                            paid_interest, 
                                            paid_capital,
                                            fees_unpaid,
                                            paid_date,
                                            paid_fees,
                                            comment,
                                            pending,
                                            start_date,
                                            olb,
                                            commission,
                                            paid_commission
                                    FROM Installments WHERE contract_id = @id";

            using (var c = new OpenCbsCommand(sqlText, pSqlTransac.Connection, pSqlTransac))
            {
                c.AddParam("@id", pLoanId);
                var installmentList = new List<Installment>();
                using (var r = c.ExecuteReader())
                {
                    if (r.Empty) return installmentList;
                    while (r.Read())
                    {
                        installmentList.Add(GetInstallment(r));
                    }
                }
                return installmentList;
            }
        }



        public List<KeyValuePair<int, Installment>> SelectInstalments()
        {
            const string q = @"SELECT 
                                            contract_id,
                                            expected_date,
                                            interest_repayment,
                                            capital_repayment,
                                            number,
                                            paid_interest, 
                                            paid_capital,
                                            fees_unpaid,
                                            paid_date,
                                            paid_fees,
                                            comment, 
                                            pending,
                                            start_date,
                                            olb,
                                            commission,
                                            paid_commission
                                  FROM Installments
                                  WHERE paid_capital = 0 
                                    AND paid_interest = 0"; 
            //select only those Installments that have not had any repayments
            using (var conn = GetConnection())
            using (var c = new OpenCbsCommand(q, conn))
            {
                using (var r = c.ExecuteReader())
                {
                    if (r == null || r.Empty) return new List<KeyValuePair<int, Installment>>();

                    var installmentList = new List<KeyValuePair<int, Installment>>();
                    while (r.Read())
                    {
                        var result = new KeyValuePair<int, Installment>(
                                        r.GetInt("contract_id"),GetInstallment(r));
                        installmentList.Add(result);
                    }
                    return installmentList;
                }
            }
        }

        public List<Installment> GetArchivedInstallments(int eventId, SqlTransaction t)
        {
            const string query = @"SELECT number, 
                                          expected_date, 
                                          capital_repayment, 
                                          interest_repayment, 
                                          paid_interest, 
                                          paid_capital, 
                                          paid_fees, 
                                          fees_unpaid, 
                                          paid_date, 
                                          comment, 
                                          pending,
                                          start_date,
                                          olb,
                                          commission,
                                          paid_commission
                                    FROM InstallmentHistory 
                                    WHERE event_id = @event_id 
                                      AND delete_date IS NULL";
            using (var c = new OpenCbsCommand(query, t.Connection, t))
            {
                c.AddParam("@event_id", eventId);
                var retval = new List<Installment>();
                using (var r = c.ExecuteReader())
                {
                    if (null == r || r.Empty) return retval;
                    while (r.Read())
                    {
                        var i = GetInstallmentHistoryFromReader(r);
                        retval.Add(i);
                    }
                }
                
                return retval;
            }
        }

	    private static Installment GetInstallmentHistoryFromReader(OpenCbsReader r)
	    {
	        var i = new Installment
	                    {
	                        Number = r.GetInt("number"),
	                        ExpectedDate = r.GetDateTime("expected_date"),
                            StartDate = r.GetDateTime("start_date"),
	                        CapitalRepayment = r.GetMoney("capital_repayment"),
	                        InterestsRepayment = r.GetMoney("interest_repayment"),
	                        PaidInterests = r.GetMoney("paid_interest"),
	                        PaidCapital = r.GetMoney("paid_capital"),
	                        PaidFees = r.GetMoney("paid_fees"),
	                        FeesUnpaid = r.GetMoney("fees_unpaid"),
	                        PaidDate = r.GetNullDateTime("paid_date"),
	                        Comment = r.GetString("comment"),
                            OLB = r.GetMoney("olb"),
	                        IsPending = r.GetBool("pending"),
                            Commission = r.GetMoney("commission"),
                            PaidCommissions = r.GetMoney("paid_commission")
	                    };
	        return i;
	    }

        public void UpdateInstallment(IInstallment installment, int contractId, int? eventId)
        {
            using (var connection = GetConnection())
            using (var transaction = connection.BeginTransaction())
            {
                UpdateInstallment(installment, contractId, eventId, transaction);
                transaction.Commit();
            }
        }

        /// <summary>
        /// this method allows us to update an installment
        /// </summary>
        /// <param name="installment">the installment modified</param>
        /// <param name="contractId"></param>
        /// <param name="sqlTransac"></param>
        /// <param name="eventId">Event linked to this installment update</param>
        public void UpdateInstallment(IInstallment installment, int contractId, int? eventId, SqlTransaction sqlTransac)
        {
            UpdateInstallment(installment, contractId, eventId, sqlTransac, false);
        }

	    private static void SetInstallment(Installment pInstallment, int pLoanId, OpenCbsCommand c)
	    {
            //primary key = loanId + number
            c.AddParam("@contractId", pLoanId);
            c.AddParam("@number", pInstallment.Number);

            c.AddParam("@expectedDate", pInstallment.ExpectedDate);
            c.AddParam("@interestsRepayment", pInstallment.InterestsRepayment.Value);
            c.AddParam("@capitalRepayment", pInstallment.CapitalRepayment.Value);
            c.AddParam("@paidInterests", pInstallment.PaidInterests.Value);
            c.AddParam("@paidCapital", pInstallment.PaidCapital.Value);
            c.AddParam("@paidDate", pInstallment.PaidDate);
            c.AddParam("@feesUnpaid", pInstallment.FeesUnpaid.Value);
            c.AddParam("@paid_fees", pInstallment.PaidFees.Value);
            c.AddParam("@comment", pInstallment.Comment);
            c.AddParam("@pending", pInstallment.IsPending);
            c.AddParam("@start_date", pInstallment.StartDate);
            c.AddParam("@olb", pInstallment.OLB);
            c.AddParam("@commission", pInstallment.Commission);
            c.AddParam("@paidCommission", pInstallment.PaidCommissions);
	    }

        private static Installment GetInstallment(OpenCbsReader r)
        {
            var installment = new Installment
            {
                Number = r.GetInt("number"),
                ExpectedDate = r.GetDateTime("expected_date"),
                InterestsRepayment = r.GetMoney("interest_repayment"),
                CapitalRepayment = r.GetMoney("capital_repayment"),
                PaidDate = r.GetNullDateTime("paid_date"),
                PaidCapital = r.GetMoney("paid_capital"),
                FeesUnpaid = r.GetMoney("fees_unpaid"),
                PaidInterests = r.GetMoney("paid_interest"),
                PaidFees = r.GetMoney("paid_fees"),
                Comment = r.GetString("comment"),
                IsPending = r.GetBool("pending"),
                StartDate = r.GetDateTime("start_date"),
                OLB = r.GetMoney("olb"),
                Commission = r.GetMoney("commission"),
                PaidCommissions = r.GetMoney("paid_commission")
            };
            return installment;
        }

        public void UpdateInstallment(IInstallment pInstallment,int pContractId, int? pEventId, bool pRescheduling)
        {
            using (var connection = GetConnection())
            using (var transaction = connection.BeginTransaction())
            {
                UpdateInstallment(pInstallment, pContractId, pEventId, transaction, pRescheduling);
                transaction.Commit();
            }
        }

        /// <summary>
		/// this method allows us to update an installment
		/// </summary>
        /// <param name="pInstallment">the installment modified</param>
        /// <param name="pContractId"></param>
        /// <param name="pEventId">Event linked to this installment update</param>
        /// <param name="pSqlTransac"></param>
        /// <param name="pRescheduling">Is it a rescheduled installment</param>
		public void UpdateInstallment(IInstallment pInstallment,int pContractId, int? pEventId,SqlTransaction pSqlTransac, bool pRescheduling)
		{
            // Update installement in database
			const string q = @"UPDATE Installments 
                                    SET expected_date = @expectedDate, 
                                        interest_repayment = @interestRepayment, 
				                        capital_repayment = @capitalRepayment, 
                                        contract_id = @contractId, 
                                        number = @number, 
                                        paid_interest = @paidInterest, 
				                        paid_capital = @paidCapital,
                                        fees_unpaid = @feesUnpaid, 
                                        paid_date = @paidDate,
                                        paid_fees = @paidFees,
                                        comment = @comment,
                                        pending = @pending,
                                        start_date = @start_date,
                                        olb = @olb,
                                        commission = @commission,
                                        paid_commission = @paidCommission
                                     WHERE contract_id = @contractId 
                                       AND number = @number";

            using (var c = new OpenCbsCommand(q, pSqlTransac.Connection, pSqlTransac))
            {
                //primary key = contractId + number
                c.AddParam("@contractId", pContractId);
                c.AddParam("@number", pInstallment.Number);
                c.AddParam("@expectedDate", pInstallment.ExpectedDate);
                c.AddParam("@interestRepayment", pInstallment.InterestsRepayment.Value);
                c.AddParam("@capitalRepayment", pInstallment.CapitalRepayment.Value);
                c.AddParam("@paidInterest", pInstallment.PaidInterests.Value);
                c.AddParam("@paidCapital", pInstallment.PaidCapital.Value);
                c.AddParam("@paidDate", pInstallment.PaidDate);
                c.AddParam("@paidFees", pInstallment.PaidFees.Value);
                c.AddParam("@comment", pInstallment.Comment);
                c.AddParam("@pending", pInstallment.IsPending);
                c.AddParam("@start_date", pInstallment.StartDate);
                c.AddParam("@olb", pInstallment.OLB);
                c.AddParam("@commission", pInstallment.Commission);
                c.AddParam("@paidCommission", pInstallment.PaidCommissions);

                if (pInstallment is Installment)
                {
                    Installment installment = (Installment) pInstallment;
                    c.AddParam("@feesUnpaid", installment.FeesUnpaid);
                }
                else
                {
                    c.AddParam("@feesUnpaid", 0);
                }

                c.ExecuteNonQuery();
            }
		}

        public void UpdateInstallment(DateTime date, int id, int number)
        {
            // Update installement in database
            const string q = @"UPDATE Installments 
                               SET expected_date = @expectedDate
                               WHERE contract_id = @contractId 
                                 AND number = @number";

            using (var conn = GetConnection())
            using (var c = new OpenCbsCommand(q, conn))
            {
                //primary key = contractId + number
                c.AddParam("@contractId", id);
                c.AddParam("@number", number);
                c.AddParam("@expectedDate", date);

                c.ExecuteNonQuery();

                c.ResetParams();
                c.CommandText = @"UPDATE dbo.Installments
                                  SET start_date = @start_date
                                  WHERE contract_id = @contractId 
                                    AND number = @number";
                c.AddParam("@contractId", id);
                c.AddParam("@number", number + 1);
                c.AddParam("@start_date", date);
                c.ExecuteNonQuery();
            }
        }

        public void UpdateInstallmentComment(string pComment, int pContractId, int pNumber)
        {
            const string q = @"UPDATE Installments
                               SET comment = @comment
                               WHERE contract_id = @contractId 
                                 AND number = @number";
            using (var conn = GetConnection())
            using (var c = new OpenCbsCommand(q, conn))
            {
                //primary key = contractId + number
                c.AddParam("@contractId", pContractId);
                c.AddParam("@number", pNumber);
                c.AddParam("@comment", pComment);

                c.ExecuteNonQuery();
            }
        }

        public void ArchiveInstallment(Installment i, int contractId, Event e, SqlTransaction transaction)
        {
            const string q = @"INSERT INTO dbo.InstallmentHistory 
                                      (contract_id, 
                                        event_id, 
                                        number, 
                                        expected_date,
                                        capital_repayment, 
                                        interest_repayment, 
                                        paid_interest, 
                                        paid_capital, 
                                        paid_fees, 
                                        fees_unpaid,
                                        paid_date, 
                                        comment, 
                                        pending,
                                        start_date,
                                        olb,
                                        commission,
                                        paid_commission) 
                                    VALUES (
                                            @contract_id,
                                            @event_id,
                                            @number, 
                                            @expected_date,
                                            @capital_repayment, 
                                            @interest_repayment,
                                            @paid_interest, 
                                            @paid_capital, 
                                            @paid_fees, 
                                            @fees_unpaid, 
                                            @paid_date, 
                                            @comment,
                                            @pending,
                                            @start_date,
                                            @olb,
                                            @commission,
                                            @paidCommission)";
            using (var c = new OpenCbsCommand(q, transaction.Connection, transaction))
            {
                c.AddParam("@contract_id", contractId);
                c.AddParam("@event_id", e.Id);
                c.AddParam("@number", i.Number);
                c.AddParam("@expected_date", i.ExpectedDate);
                c.AddParam("@capital_repayment", i.CapitalRepayment.Value);
                c.AddParam("@interest_repayment", i.InterestsRepayment.Value);
                c.AddParam("@paid_interest", i.PaidInterests.Value);
                c.AddParam("@paid_capital", i.PaidCapital.Value);
                c.AddParam("@paid_fees", i.PaidFees.Value);
                c.AddParam("@fees_unpaid", i.FeesUnpaid.Value);
                c.AddParam("@paid_date", i.PaidDate);
                c.AddParam("@comment", i.Comment);
                c.AddParam("@pending", i.IsPending);
                c.AddParam("@start_date", i.StartDate);
                c.AddParam("@olb", i.OLB);
                c.AddParam("@commission", i.Commission);
                c.AddParam("@paidCommission", i.PaidCommissions);
                c.ExecuteNonQuery();
            }
        }

        public void UnarchiveInstallments(Loan loan, Event e, SqlTransaction t)
        {
            int eventId = e.ParentId == null ? e.Id : (int) e.ParentId;
            var installments = GetArchivedInstallments(eventId, t);
            if (0 == installments.Count) return;

            // DeleteAccount existing installments
            const string queryDelete = @"DELETE FROM dbo.Installments 
                                        WHERE contract_id = @contract_id";
            using (var c = new OpenCbsCommand(queryDelete, t.Connection, t))
            {
                c.AddParam("@contract_id", loan.Id);
                c.ExecuteNonQuery();
            }

            // Copy installments from archive to Installments table
            foreach (var i in installments)
            {
                const string queryInsert = @"INSERT INTO dbo.Installments (
                                               expected_date, 
                                               interest_repayment,
                                               capital_repayment, 
                                               contract_id, 
                                               number, 
                                               paid_interest, 
                                               paid_capital, 
                                               fees_unpaid,
                                               paid_date, 
                                               paid_fees, 
                                               comment, 
                                               pending,
                                               start_date,
                                               olb,
                                               commission,
                                               paid_commission) 
                                             VALUES (
                                               @expected_date, 
                                               @interest_repayment, 
                                               @capital_repayment,
                                               @contract_id, 
                                               @number, 
                                               @paid_interest, 
                                               @paid_capital, 
                                               @fees_unpaid, 
                                               @paid_date,
                                               @paid_fees, 
                                               @comment, 
                                               @pending,
                                               @start_date,
                                               @olb,
                                               @commission,
                                               @paidCommission)";

                using (var c = new OpenCbsCommand(queryInsert, t.Connection, t))
                {
                    c.AddParam("@expected_date", i.ExpectedDate);
                    c.AddParam("@interest_repayment", i.InterestsRepayment.Value);
                    c.AddParam("@capital_repayment", i.CapitalRepayment.Value);
                    c.AddParam("@contract_id", loan.Id);
                    c.AddParam("@number", i.Number);
                    c.AddParam("@paid_interest", i.PaidInterests.Value);
                    c.AddParam("@paid_capital", i.PaidCapital.Value);
                    c.AddParam("@paid_fees", i.PaidFees.Value);
                    c.AddParam("@fees_unpaid", i.FeesUnpaid.Value);
                    c.AddParam("@paid_date", i.PaidDate);
                    c.AddParam("@comment", i.Comment);
                    c.AddParam("@pending", i.IsPending);
                    c.AddParam("@start_date", i.StartDate);
                    c.AddParam("@olb", i.OLB);
                    c.AddParam("@commission", i.Commission);
                    c.AddParam("@paidCommission", i.PaidCommissions);
                    c.ExecuteNonQuery();
                }
            }

            // Mark archived installments as deleted (set delete_date)
            const string queryUpdate = @"UPDATE dbo.InstallmentHistory 
                                         SET delete_date = @delete_date 
                                         WHERE event_id = @event_id";
            using (var c = new OpenCbsCommand(queryUpdate, t.Connection, t))
            {
                c.AddParam("@delete_date", TimeProvider.Today);
                c.AddParam("@event_id", e.Id);
                c.ExecuteNonQuery();
            }
        }
    }
}
