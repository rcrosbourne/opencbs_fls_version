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
using System.Collections;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Enums;
using OpenCBS.Manager.Accounting;
using OpenCBS.Manager.Database;
using OpenCBS.Manager;
using OpenCBS.Shared.Settings;

namespace OpenCBS.Services
{
    /// <summary>
    /// Summary description for DatabaseParametersServices.
    /// </summary>
    public class ApplicationSettingsServices : MarshalByRefObject
    {
        private readonly ApplicationSettingsManager _dataParamManager;
        private readonly NonWorkingDateManagement _nonWorkingDateManager;
        private readonly ProvisioningRuleManager _provisioningRuleManager;
        private readonly LoanScaleManager _loanScaleManager;
        private readonly User _user;

        public ApplicationSettingsServices(User pUser)
        {
            _user = pUser;
            _dataParamManager = new ApplicationSettingsManager(pUser);
            _nonWorkingDateManager = new NonWorkingDateManagement(pUser);
            _provisioningRuleManager = new ProvisioningRuleManager(pUser);
            _loanScaleManager = new LoanScaleManager(_user);
        }

        public ApplicationSettingsServices(string pTestDb)
        {
            _dataParamManager = new ApplicationSettingsManager(pTestDb);
            _nonWorkingDateManager = new NonWorkingDateManagement(pTestDb);
            _provisioningRuleManager = new ProvisioningRuleManager(pTestDb);
            _loanScaleManager = new LoanScaleManager(pTestDb);
        }

        public void FillGeneralDatabaseParameter()
        {
            _dataParamManager.FillGeneralSettings();
        }

        public void FillNonWorkingDate()
        {
            _nonWorkingDateManager.FillNonWorkingDateHelper();
        }

        public void UpdateNonWorkingDate(DictionaryEntry pEntry)
        {
            _nonWorkingDateManager.UpdatePublicHoliday(pEntry);
        }

        public void AddNonWorkingDate(DictionaryEntry pEntry)
        {
            _nonWorkingDateManager.AddPublicHoliday(pEntry);
        }

        public void DeleteNonWorkingDate(DictionaryEntry pEntry)
        {
            _nonWorkingDateManager.DeletePublicHoliday(pEntry);
        }

        public void AddDatabaseParameter(DictionaryEntry pParameter)
        {
            _dataParamManager.AddParameter(pParameter);
        }

        public void CheckApplicationSettings()
        {
            _dataParamManager.FillGeneralSettings();
            _nonWorkingDateManager.FillNonWorkingDateHelper();
            FillProvisioningRule();
            FillLoanScaleTable();
            foreach (DictionaryEntry entry in ApplicationSettings.GetInstance(_user.Md5).DefaultParamList)
            {
                if (ApplicationSettings.GetInstance(_user.Md5).GetSpecificParameter(entry.Key.ToString()) == null &&
                    entry.Key.ToString() != OGeneralSettings.LATEDAYSAFTERACCRUALCEASES &&
                    entry.Key.ToString() != OGeneralSettings.WEEKENDDAY1 &&
                    entry.Key.ToString() != OGeneralSettings.WEEKENDDAY2)
                {
                    _dataParamManager.AddParameter(entry);
                }
            }
        }

        private void FillLoanScaleTable()
        {
            _loanScaleManager.SelectLoanScales();
        }

        private void FillProvisioningRule()
        {
            var table = ProvisionTable.GetInstance(_user);
            table.ProvisioningRates = _provisioningRuleManager.SelectAllProvisioningRates();
        }

        public int UpdateSelectedParameter(string pName, object pNewValue)
        {
            if (pNewValue == null)
                return _dataParamManager.UpdateSelectedParameter(pName);
            if (pNewValue is int)
                return _dataParamManager.UpdateSelectedParameter(pName, (int)pNewValue);
            if (pNewValue is bool)
                return _dataParamManager.UpdateSelectedParameter(pName, (bool)pNewValue);

            return _dataParamManager.UpdateSelectedParameter(pName, pNewValue.ToString());
        }

        public Guid? GetGuid()
        {
            return _dataParamManager.GetGuid();
        }

        public void SetGuid(Guid guid)
        {
            _dataParamManager.SetGuid(guid);
        }
    }
}
