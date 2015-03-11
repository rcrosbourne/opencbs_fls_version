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

using System.Net.NetworkInformation;

namespace OpenCBS.Enums
{
    public static class OGeneralSettings
    {
        public static readonly string ACCOUNTINGPROCESS = "ACCOUNTING_PROCESS";
        public static readonly string COUNTRY = "COUNTRY";
        public static readonly string WEEKENDDAY1 = "WEEK_END_DAY1";
        public static readonly string WEEKENDDAY2 = "WEEK_END_DAY2";
        public static readonly string PAYFIRSTINSTALLMENTREALVALUE = "PAY_FIRST_INSTALLMENT_REAL_VALUE";
        public static readonly string CITYMANDATORY = "CITY_MANDATORY";
        public static readonly string GROUPMINMEMBERS = "GROUP_MIN_MEMBERS";
        public static readonly string GROUPMAXMEMBERS = "GROUP_MAX_MEMBERS";
        public static readonly string VILLAGEMINMEMBERS = "NSG_MIN_MEMBERS";
        public static readonly string VILLAGEMAXMEMBERS = "NSG_MAX_MEMBERS";
        public static readonly string LOANOFFICERPORTFOLIOFILTER = "LOAN_OFFICER_PORTFOLIO_FILTER";
        public static readonly string LATEDAYSAFTERACCRUALCEASES = "LATE_DAYS_AFTER_ACCRUAL_CEASES";
        public static readonly string ALLOWSMULTIPLELOANS = "ALLOWS_MULTIPLE_LOANS";
        public static readonly string ALLOWSMULTIPLEGROUPS = "ALLOWS_MULTIPLE_GROUPS";
        public static readonly string OLBBEFOREREPAYMENT = "OLB_BEFORE_REPAYMENT";
        public static readonly string CALCULATIONLATEFEESDURINGPUBLICHOLIDAYS = "CALCULATION_LATE_FEES_DURING_PUBLIC_HOLIDAYS";
        public static readonly string DONOTSKIPWEEKENDSININSTALLMENTSDATE = "DONOT_SKIP_WEEKENDS_IN_INSTALLMENTS_DATE";
        public static readonly string INCREMENTALDURINGDAYOFF = "INCREMENTAL_DURING_DAYOFFS";
        public static readonly string CONTRACT_CODE_TEMPLATE = "CONTRACT_CODE_TEMPLATE";
        public static readonly string INTERESTS_ALSO_CREDITED_IN_FL = "INTERESTS_ALSO_CREDITED_IN_FL";
        public static readonly string ID_PATTERN = "ID_PATTERN";
        public static readonly string ENFORCE_ID_PATTERN = "ENFORCE_ID_PATTERN";
        public static readonly string SAVINGS_CODE_TEMPLATE = "SAVINGS_CODE_TEMPLATE";
        public static readonly string MAX_NUMBER_INSTALLMENT = "MAX_NUMBER_INSTALLMENT";
        public static readonly string PENDING_SAVINGS_MODE = "PENDING_SAVINGS_MODE";
        public static readonly string BAD_LOAN_DAYS = "BAD_LOAN_DAYS";
        public static readonly string VAT_RATE = "VAT_RATE";
        public static readonly string CEASE_LAIE_DAYS = "CEASE_LAIE_DAYS";
        public static readonly string MFI_NAME = "MFI_NAME";
        public static readonly string REAL_EXPECTED_AMOUNT = "REAL_EXPECTED_AMOUNT";
        public static readonly string CLIENT_AGE_MIN = "CLIENT_AGE_MIN";
        public static readonly string CLIENT_AGE_MAX = "CLIENT_AGE_MAX";
        public static readonly string AUTOMATIC_ID = "AUTOMATIC_ID";
        public static readonly string MAX_LOANS_COVERED = "MAX_LOANS_COVERED";
        public static readonly string MAX_GUARANTOR_AMOUNT = "MAX_GUARANTOR_AMOUNT";
        public static readonly string REPORT_TIMEOUT = "REPORT_TIMEOUT";
        public static readonly string INTEREST_RATE_DECIMAL_PLACES = "INTEREST_RATE_DECIMAL_PLACES";
        public static readonly string STOP_WRITEOFF_PENALTY = "STOP_WRITEOFF_PENALTY";
        public static readonly string MODIFY_ENTRY_FEE = "MODIFY_ENTRY_FEE";
        public static readonly string USE_MANDATORY_SAVING_ACCOUNT = "USE_MANDATORY_SAVING_ACCOUNT";
        public static readonly string USE_DAILY_ACCRUAL_OF_PENALTY = "USE_DAILY_ACCRUAL_OF_PENALTY";
        public static readonly string NUMBER_GROUP_SEPARATOR = "NUMBER_GROUP_SEPARATOR";
        public static readonly string NUMBER_DECIMAL_SEPARATOR = "NUMBER_DECIMAL_SEPARATOR";
        public static readonly string USE_EXTERNAL_ACCOUNTING = "USE_EXTERNAL_ACCOUNTING";
        public static readonly string SHOW_EXTRA_INTEREST_COLUMN = "SHOW_EXTRA_INTEREST_COLUMN";
        public static readonly string SHORT_DATE_FORMAT = "SHORT_DATE_FORMAT";
        public static readonly string STANDARD_ZIP_CODE = "STANDARD_ZIP_CODE";
        public static readonly string STANDARD_CITY_PHONE_FORMAT = "STANDARD_CITY_PHONE_FORMAT";
        public static readonly string STANDARD_MOBILE_PHONE_FORMAT = "STANDARD_MOBILE_PHONE_FORMAT";
    }
}

