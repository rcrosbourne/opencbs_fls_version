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
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using OpenCBS.CoreDomain;
using OpenCBS.Shared.Settings;

namespace OpenCBS.Reports
{
    public abstract partial class ReportParamV2
    {
        protected static Color ForeColor = Color.FromArgb(0, 88, 56);
        protected static Color BackColor = Color.Transparent;
        protected static Font ControlFont = new Font("Arial", 9F);
        protected static Font LabelFont = new Font("Arial", 9F, FontStyle.Bold);
        public abstract Control Control { get; }
        public virtual bool Visible
        {
            get { return true; }
        }
        public virtual bool AddLabel
        {
            get { return true; }
        }
        public abstract object Value { get; }
        public abstract void InitControl();
        /// <summary>
        /// This property is used for internal reports, and indicates whether paramater should be requested.
        /// </summary>
        public bool Additional { get; set; }
    }

    public class IntParam : ReportParamV2
    {
        private readonly int _value;
        private TextBox _control;

        public IntParam(int value)
        {
            _value = value;
        }

        public IntParam(string value)
        {
            _value = string.IsNullOrEmpty(value) ? 0 : int.Parse(value);
        }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new TextBox();
            _control.Name = Name + "_control";
            _control.Font = ControlFont;
            _control.Size = new Size(100, 20);
            _control.Text = _value.ToString();
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get { return null == _control ? _value : Convert.ToInt32(_control.Text); }
        }
    }

    public class DoubleParam : ReportParamV2
    {
        private readonly double _value;
        private TextBox _control;

        public DoubleParam(double value)
        {
            _value = value;
        }

        public DoubleParam(string value)
        {
            _value = string.IsNullOrEmpty(value) ? 0d : double.Parse(value);
        }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new TextBox();
            _control.Name = Name + "_control";
            _control.Font = ControlFont;
            _control.Size = new Size(100, 20);
            _control.Text = _value.ToString();
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get { return null == _control ? _value : Convert.ToDouble(_control.Text); }
        }
    }

    public class DecimalParam : ReportParamV2
    {
        private readonly decimal _value;
        private TextBox _control;

        public DecimalParam(decimal value)
        {
            _value = value;
        }

        public DecimalParam(string value)
        {
            _value = string.IsNullOrEmpty(value) ? decimal.Zero : decimal.Parse(value);
        }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new TextBox();
            _control.Name = Name + "_control";
            _control.Font = ControlFont;
            _control.Size = new Size(100, 20);
            _control.Text = _value.ToString();
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get { return null == _control ? _value : Convert.ToDecimal(_control.Text); }
        }
    }

    public class StringParam : ReportParamV2
    {
        private readonly string _value;
        private TextBox _control;

        public StringParam(string value)
        {
            _value = string.IsNullOrEmpty(value) ? string.Empty : value;
        }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new TextBox();
            _control.Name = Name + "_control";
            _control.Font = ControlFont;
            _control.Size = new Size(100, 20);
            _control.Text = _value;
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get { return null == _control ? _value : _control.Text; }
        }
    }

    public class CharParam : ReportParamV2
    {
        private readonly char _value;
        private TextBox _control;

        public CharParam(char value) { _value = value; }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new TextBox();
            _control.Name = Name + "_control";
            _control.Font = ControlFont;
            _control.Size = new Size(100, 20);
            _control.MaxLength = 1;
            _control.Text = _value.ToString(CultureInfo.CurrentCulture);
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get
            {
                string text = _control.Text;
                return string.IsNullOrEmpty(text) ? ' ' : text[0];
            }
        }
    }

    public class BoolParam : ReportParamV2
    {
        private readonly bool _value;
        private CheckBox _control;

        public BoolParam(bool value)
        {
            _value = value;
        }

        public BoolParam(string value)
        {
            _value = string.IsNullOrEmpty(value) ? false : ("true" == value ? true : false);
        }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new CheckBox();
            _control.Name = Name + "_control";
            _control.Text = Label;
            _control.Font = LabelFont;
            _control.AutoSize = true;
            _control.ForeColor = ForeColor;
            _control.BackColor = BackColor;
            _control.Checked = _value;
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override bool AddLabel
        {
            get { return false; }
        }

        public override object Value
        {
            get { return null == _control ? _value : _control.Checked; }
        }
    }

    public class DateParam : ReportParamV2
    {
        private readonly DateTime _value;
        private DateTimePicker _control;

        public DateParam(DateTime value)
        {
            _value = value;
        }

        public DateParam(string value)
        {
            switch (value)
            {
                case "bom":
                    _value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    break;

                case "eom":
                    _value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                    break;

                default:
                    _value = DateTime.Today;
                    break;
            }
        }

        public override void InitControl()
        {
            if (_control != null) return;

            _control = new DateTimePicker();
            _control.Name = Name + "_control";
            _control.Format = DateTimePickerFormat.Custom;
            _control.CustomFormat = ApplicationSettings.GetInstance("").SHORT_DATE_FORMAT;
            _control.Font = ControlFont;
            _control.Size = new Size(100, 20);
            _control.Value = _value;
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get { return null == _control ? _value : _control.Value; }
        }
    }

    public class TreeViewParam : ReportParamV2
    {
        private readonly string _rootNodeText;
        private readonly string _sql;
        private TreeView _control;

        public TreeViewParam(string sql, string rootNodeText)
        {
            _sql = sql;
            _rootNodeText = rootNodeText;
            if (string.IsNullOrEmpty(_rootNodeText)) _rootNodeText = "All";
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override object Value
        {
            get
            {
                var node = _control.SelectedNode;
                if (node == null) return "0,0";

                var item = (TreeViewItem) node.Tag;
                return string.Format("{0},{1}", item.Id, node.Level);
            }
        }

        private TreeNode FindNode(int id, TreeNode rootNode)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (((TreeViewItem) node.Tag).Id == id) return node;
                var next = FindNode(id, node);
                if (next != null) return next;
            }
            return null;
        }

        public override void InitControl()
        {
            if (_control == null)
            {
                _control = new TreeView
                {
                    Name = Name + "_control",
                    Font = ControlFont,
                    Size = new Size(330, 200)
                };

                var items = ReportService.GetInstance().GetTreeViewItems(_sql);
                var rootNode = new TreeNode(_rootNodeText);
                rootNode.Tag = new TreeViewItem { Id = 0, Name = _rootNodeText, ParentId = -1 };
                _control.Nodes.Add(rootNode);
                foreach (var item in items)
                {
                    var node = new TreeNode(item.Name) { Tag = item };
                    TreeNode addToNode;
                    if (item.ParentId == 0)
                    {
                        addToNode = rootNode;
                    }
                    else
                    {
                        addToNode = FindNode(item.ParentId, rootNode);
                    }
                    if (addToNode != null) addToNode.Nodes.Add(node);
                }
                _control.ExpandAll();
            }
        }
    }

    public class QueryParam : ReportParamV2
    {
        protected class Item
        {
            public Item(object key, object value)
            {
                Key = key;
                Value = value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }

            public object Key { get; private set; }
            public object Value { get; private set; }
        }

        protected string _query;
        protected ComboBox _control;
        public int HideIfrows { get; set; }

        public QueryParam()
        {
        }

        public QueryParam(string query)
        {
            _query = query.Replace("{USER_ID}", User.CurrentUser.Id.ToString());
        }

        public override void InitControl()
        {
            if (null == _control)
            {
                _control = new ComboBox();
                _control.Name = Name + "_control";
                _control.Font = ControlFont;
                _control.Size = new Size(330, 20);
                _control.DropDownStyle = ComboBoxStyle.DropDownList;

                List<KeyValuePair<object, object>> r = ReportService.GetInstance().GetQueryResult(_query);
                foreach (KeyValuePair<object, object> pair in r)
                {
                    Item item = new Item(pair.Key, pair.Value);
                    _control.Items.Add(item);
                }
            }
            if (_control.Items.Count > 0) _control.SelectedIndex = 0;
        }

        public override Control Control
        {
            get { return _control; }
        }

        public override bool Visible
        {
            get
            {
                if (null == _control) return false;
                return HideIfrows != _control.Items.Count;
            }
        }

        public override object Value
        {
            get
            {
                if (null == _control) return null;
                if (0 == _control.Items.Count) return null;
                return (_control.SelectedItem as Item).Key;
            }
        }

        public override string ToString()
        {
            if (null == _control) return string.Empty;
            if (0 == _control.Items.Count) return string.Empty;
            return (_control.SelectedItem as Item).Value.ToString();
        }
    }

    public class QueryParamMulti : QueryParam
    {
        protected ListBox _control;

        public QueryParamMulti(string query)
            : base(query)
        {
        }

        public override void InitControl()
        {
            if (_control != null) return;
            _control = new ListBox();
            _control.Name = Name + "_control";
            _control.Font = ControlFont;
            _control.Size = new Size(330, 150);
            _control.SelectionMode = SelectionMode.MultiExtended;

            List<KeyValuePair<object, object>> r = ReportService.GetInstance().GetQueryResult(_query);
            foreach (KeyValuePair<object, object> pair in r)
            {
                Item item = new Item(pair.Key, pair.Value);
                _control.Items.Add(item);
            }
        }

        public override object Value
        {
            get
            {
                if (null == _control) return string.Empty;
                if (!Visible) _control.SelectedIndex = 0;
                if (0 == _control.SelectedItems.Count) return string.Empty;
                var list = new List<string>();
                foreach (var item in _control.SelectedItems)
                {
                    list.Add(((Item) item).Key.ToString());
                }
                return string.Join(",", list.ToArray());
            }
        }

        public override bool Visible
        {
            get
            {
                if (null == _control) return false;
                return HideIfrows != _control.Items.Count;
            }
        }

        public override Control Control
        {
            get { return _control; }
        }
    }

    public class CurrencyParam : QueryParam
    {
        public static string AllCurrencies = "All currencies";
        private bool _includeAll;
        public CurrencyParam(bool includeAll)
        {
            _includeAll = includeAll;
            //if (ApplicationSettings.GetInstance("").ConsolidationMode)
            //{
            //    _query = "SELECT id, name FROM dbo.Currencies WHERE is_pivot = 1";
            //}
            //else
            //{
            _query = "SELECT id, name FROM dbo.Currencies";

        }

        public override void InitControl()
        {
            if (_control != null) return;

            base.InitControl();
            if (_includeAll)
            {
                _control.Items.Insert(0, new Item(0, AllCurrencies));
            }
        }
    }

    public class BranchParam : QueryParam
    {
        public static string AllBranches = "All branches";

        public BranchParam(string consoTable)
        {
            _query = @"SELECT DISTINCT id, name
                FROM dbo.Branches b
                INNER JOIN dbo.UsersBranches ub ON ub.branch_id = b.id
                WHERE ub.user_id = {0}";
            _query = string.Format(_query, User.CurrentUser.Id);
        }

        public override void InitControl()
        {
            if (_control != null) return;

            base.InitControl();
            _control.Items.Insert(0, new Item(0, AllBranches));
        }
    }
}
