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

using System.Collections.Generic;
using OpenCBS.CoreDomain;
using System.Data.SqlClient;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Manager.Accounting;

namespace OpenCBS.Manager
{
    public class PaymentMethodManager:Manager
    {
        private List<PaymentMethod> _cache;

        private readonly BranchManager _branchManager;
        private readonly AccountManager _accountManager;

        public PaymentMethodManager(User user) : base(user)
        {
            _branchManager = new BranchManager(user);
            _accountManager = new AccountManager(user);
        }

        public PaymentMethodManager(string testDb):base(testDb)
        {
            _branchManager = new BranchManager(testDb);
            _accountManager = new AccountManager(testDb);
        }
        public PaymentMethodManager(string testDb, User user) : base(testDb)
        {
            
        }

        private void InitCache()
        {
            if (_cache != null) return;
            _cache = SelectPaymentMethods();
        }

        public List<PaymentMethod> SelectPaymentMethods()
        {
            string q = @"SELECT pm.[id]
                                  ,[name]
                                  ,[description]
                                  ,[pending]
                                  ,0 AS [account_id]
                            FROM [PaymentMethods] pm
                            ORDER BY pm.[id]";

            List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            using (OpenCbsReader r = c.ExecuteReader())
            {
                if (r!=null && !r.Empty)
                while (r.Read())
                {
                    paymentMethods.Add(GetPaymentMethodFromReader(r));
                }
            }
            return paymentMethods;
        }

        public List<PaymentMethod> SelectPaymentMethodsForClosure()
        {
            string q = @"SELECT pm.[id]
                                  ,[name]
                                  ,[description]
                                  ,[pending]
                                  ,[account_id]
                            FROM [PaymentMethods] pm
                            INNER JOIN LinkBranchesPaymentMethods lbpm ON lbpm.payment_method_id = pm.id
                            ORDER BY pm.[id]";

            List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            using (OpenCbsReader r = c.ExecuteReader())
            {
                if (r != null && !r.Empty)
                    while (r.Read())
                    {
                        paymentMethods.Add(GetPaymentMethodFromReader(r));
                    }
            }
            return paymentMethods;
        }

        public List<PaymentMethod>  SelectPaymentMethodOfBranch(int branchId)
        {
            string q = @"SELECT [lbpm].[payment_method_id], 
                                [lbpm].[id], 
                                [pm].[name], 
                                [pm].[description], 
                                [pm].[pending], 
                                [lbpm].[branch_id], 
                                [lbpm].[date], 
                                [lbpm].[account_id] 
                         FROM PaymentMethods pm
                         INNER JOIN LinkBranchesPaymentMethods lbpm ON lbpm.payment_method_id = pm.id
                         WHERE [lbpm].[branch_id] = @id AND [lbpm].[deleted] = 0";

            List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", branchId);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r.Empty) return paymentMethods;
                    while (r.Read())
                    {
                        PaymentMethod paymentMethod = new PaymentMethod
                                                          {
                                                              Id = r.GetInt("payment_method_id"),
                                                              Name = r.GetString("name"),
                                                              Description = r.GetString("description"),
                                                              IsPending = r.GetBool("pending"),
                                                              LinkId = r.GetInt("id"),
                                                              Branch = _branchManager.Select(r.GetInt("branch_id")),
                                                              Date = r.GetDateTime("date"),
                                                              Account = _accountManager.Select(r.GetInt("account_id"))
                                                          };
                        paymentMethods.Add(paymentMethod);
                    }
                }
            }
            return paymentMethods;
        }

        public PaymentMethod SelectPaymentMethodById(int paymentMethodId)
        {
            InitCache();
            return _cache.Find(pm2 => pm2.Id == paymentMethodId);
            string q = @"SELECT pm.[id]
                                  ,[name]
                                  ,[description]
                                  ,[pending]
                                  , 0 AS account_id
                            FROM [dbo].[PaymentMethods] pm
                            WHERE pm.id = @id";
            PaymentMethod pm = new PaymentMethod();
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@id", paymentMethodId);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r != null && !r.Empty)
                    {
                        r.Read();
                        pm = GetPaymentMethodFromReader(r);
                    }
                }
            }
            return pm;
        }

        public PaymentMethod SelectPaymentMethodByName(string name)
        {
            const string q = @"SELECT pm.[id]
                                  ,[name]
                                  ,[description]
                                  ,[pending]
                                  ,0 AS account_id
                            FROM [PaymentMethods] pm
                            WHERE [name] = @name";
            PaymentMethod pm = new PaymentMethod();
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@name", name);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r != null && !r.Empty)
                    {
                        r.Read();
                        pm = GetPaymentMethodFromReader(r);
                    }
                }
            }
            return pm;
        }
        
        private PaymentMethod GetPaymentMethodFromReader(OpenCbsReader r)
        {
            //Do not change this calling of constructor by Object initializer
            PaymentMethod pm = new PaymentMethod(
                                                    r.GetInt("id"), 
                                                    r.GetString("name"), 
                                                    r.GetString("description"),
                                                    r.GetBool("pending")
                                                );
            pm.Account = _accountManager.Select(r.GetInt("account_id"));
            return pm;
        }

        public void AddPaymentMethodToBranch(PaymentMethod paymentMethod)
        {
            const string q =
                @"INSERT INTO LinkBranchesPaymentMethods (branch_id, payment_method_id, account_id)
                                            VALUES (@branch_id, @payment_method_id, @account_id)";
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@branch_id", paymentMethod.Branch.Id);
                c.AddParam("@payment_method_id", paymentMethod.Id);
                c.AddParam("@account_id", paymentMethod.Account.Id);
                c.ExecuteNonQuery();
            }
        }

        public void DeletePaymentMethodFromBranach(PaymentMethod paymentMethod)
        {
            const string q =
                @"UPDATE LinkBranchesPaymentMethods SET deleted = 1
                                     WHERE id = @link_id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@link_id", paymentMethod.LinkId);
                c.ExecuteNonQuery();
            }
        }

        public void UpdatePaymentMethodFromBranch(PaymentMethod paymentMethod)
        {
            const string q =
                @"UPDATE LinkBranchesPaymentMethods SET account_id = @account_id, payment_method_id = @payment_method_id
                                    WHERE id = @id";

            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@account_id", paymentMethod.Account.Id);
                c.AddParam("@payment_method_id", paymentMethod.Id);
                c.AddParam("@id", paymentMethod.LinkId);
                c.ExecuteNonQuery();
            }
        }
    }
}
