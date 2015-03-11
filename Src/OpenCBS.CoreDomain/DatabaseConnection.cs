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
using System.Data.SqlClient;
using OpenCBS.Shared.Settings;
using System.ComponentModel.Composition;

namespace OpenCBS.CoreDomain
{
    public class DatabaseConnection
    {
        public static bool IsProductionDatabase = true;

        [Export("GetConnection")]
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.UserID = TechnicalSettings.DatabaseLoginName;
            csb.Password = TechnicalSettings.DatabasePassword;
            csb.DataSource = TechnicalSettings.DatabaseServerName;
            csb.PersistSecurityInfo = false;
            csb.InitialCatalog = IsProductionDatabase ? TechnicalSettings.DatabaseName : "opencbs_test";
            csb.ConnectTimeout = TechnicalSettings.DatabaseTimeout;

            var localDbConnectionString =
                String.Format(@"data source=(LocalDB)\v11.0;Integrated Security=True;Initial Catalog={0}",
                              TechnicalSettings.DatabaseName);
            var conn =
                new SqlConnection(TechnicalSettings.UseDemoDatabase
                                      ? localDbConnectionString
                                      : csb.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
