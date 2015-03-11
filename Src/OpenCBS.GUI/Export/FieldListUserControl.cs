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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Export;
using OpenCBS.MultiLanguageRessources;
using BrightIdeasSoftware;
using OpenCBS.CoreDomain.Export.Fields;
using OpenCBS.CoreDomain.Export.FieldType;

namespace OpenCBS.GUI.Export
{
    public partial class FieldListUserControl : System.Windows.Forms.UserControl
    {
        private List<IField> _defaultList;
        private bool _useSpecficLenght = true;

        public FieldListUserControl()
        {
            InitializeComponent();
        }

        public List<IField> SelectedFields
        {
            get 
            {
                if (olvSelectedFields.Objects != null)
                    return olvSelectedFields.Objects.OfType<IField>().ToList();
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        _addField(item);
                    }
                }
            }
        }

        public void ClearSelectedFields()
        {
            olvSelectedFields.Items.Clear();
        }

        public bool ExportMode
        {
            set;
            private get;
        }

        public List<IField> DefaultList
        {
            set
            { 
                _defaultList = value;
                _initializeDefaultFields(value); 
            }
        }

        public bool UseSpecificLenght
        {
            set
            {
                _useSpecficLenght = value;
                if (value)
                {
                    textNumericUserControl1.Enabled = true;
                    if (comboBoxDefaultFields.Items.Count > 0)
                        _displayLenghtFromCombox();
                    if (olvSelectedFields.Objects != null)
                    {
                        foreach (IField field in olvSelectedFields.Objects)
                        {
                            if (field is Field)
                                field.Length = ((Field)field).DefaultLength;
                            else
                                field.Length = 0;

                            olvSelectedFields.RefreshObjects(olvSelectedFields.Objects.OfType<IField>().ToList());
                        }
                    }
                }
                else
                {
                    textNumericUserControl1.Text = string.Empty;
                    textNumericUserControl1.Enabled = false;
                    if (olvSelectedFields.Objects != null)
                    {

                        foreach (IField field in olvSelectedFields.Objects)
                        {
                            field.Length = null;
                        }
                        olvSelectedFields.RefreshObjects(olvSelectedFields.Objects.OfType<IField>().ToList());
                    }
                }
            }
        }

        public void _initializeDefaultFields(List<IField> list)
        {
            comboBoxDefaultFields.DataSource = list;
            comboBoxDefaultFields.DisplayMember = "DisplayName";
        }

        private void _addField(IField pField)
        {
            olvSelectedFields.AddObject(pField);
        }

        private void comboBoxDefaultFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            _displayLenghtFromCombox();
            _displayHeaderFromCombobox();
        }

        private void _displayLenghtFromCombox()
        {
            IField field = comboBoxDefaultFields.SelectedItem as IField;
            if (field is Field)
                textNumericUserControl1.Text = ((Field)field).DefaultLength.ToString();
            else
                textNumericUserControl1.Text = field.Length.ToString();
        }

        private void _displayHeaderFromCombobox()
        {
            IField field = comboBoxDefaultFields.SelectedItem as IField;
            if (field is Field)
            {
                textBoxHeader.Text = ((Field)field).Header;
            }
            else
                textBoxHeader.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            olvSelectedFields.RemoveObject(olvSelectedFields.SelectedObject);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (olvSelectedFields.SelectedIndex > 0)
            {
                List<IField> list = new List<IField>();
                foreach (IField field in olvSelectedFields.Objects)
                {
                    if (field != olvSelectedFields.SelectedObject)
                        list.Add(field);
                }

                list.Insert(olvSelectedFields.SelectedIndex - 1, olvSelectedFields.SelectedObject as IField);

                olvSelectedFields.Items.Clear();
                olvSelectedFields.SetObjects(list);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (olvSelectedFields.SelectedIndex < olvSelectedFields.Items.Count - 1)
            {
                List<IField> list = new List<IField>();
                foreach (IField field in olvSelectedFields.Objects)
                {
                    if (field != olvSelectedFields.SelectedObject)
                        list.Add(field);
                }

                list.Insert(olvSelectedFields.SelectedIndex + 1, olvSelectedFields.SelectedObject as IField);

                olvSelectedFields.Items.Clear();
                olvSelectedFields.SetObjects(list);
            }
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            if (olvSelectedFields.SelectedObject != null)
            {
                IField selectedField = (IField)olvSelectedFields.SelectedObject;
                if (selectedField is Field)
                {
                    if (((Field)selectedField).FieldType is StringFieldType)
                    {
                        StringFieldPropertiesForm frm = new StringFieldPropertiesForm { StringFieldType = ((Field)selectedField).FieldType as StringFieldType };
                        if (frm.ShowDialog() == DialogResult.OK)
                            ((Field)selectedField).FieldType = frm.StringFieldType;
                    }
                    else if (((Field)selectedField).FieldType is DateFieldType)
                    {
                        DateFieldPropertiesForm frm = new DateFieldPropertiesForm { DateFieldType = ((Field)selectedField).FieldType as DateFieldType };
                        if (frm.ShowDialog() == DialogResult.OK)
                            ((Field)selectedField).FieldType = frm.DateFieldType;
                    }
                    else if (((Field)selectedField).FieldType is DecimalFieldType)
                    {
                        DecimalFieldPropertiesForm frm = new DecimalFieldPropertiesForm { DecimalFieldType = ((Field)selectedField).FieldType as DecimalFieldType };
                        if (frm.ShowDialog() == DialogResult.OK)
                            ((Field)selectedField).FieldType = frm.DecimalFieldType;
                    }
                    else if (((Field)selectedField).FieldType is IntegerFieldType)
                    {
                        IntegerFieldPropertiesForm frm = new IntegerFieldPropertiesForm { IntegerFieldType = ((Field)selectedField).FieldType as IntegerFieldType };
                        if (frm.ShowDialog() == DialogResult.OK)
                            ((Field)selectedField).FieldType = frm.IntegerFieldType;
                    }
                }
                else if (selectedField is ComplexField)
                {
                    ComplexFieldPropertiesForm frm = new ComplexFieldPropertiesForm
                    {
                        DefaultFields = _defaultList,
                        ComplexField = selectedField as ComplexField,
                        UseSpecificLength = _useSpecficLenght,
                        ExportMode = this.ExportMode
                    };
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                       ((ComplexField)olvSelectedFields.SelectedObject).DisplayName = frm.ComplexField.DisplayName;
                       ((ComplexField)olvSelectedFields.SelectedObject).Name = frm.ComplexField.Name;
                       ((ComplexField)olvSelectedFields.SelectedObject).Fields = frm.ComplexField.Fields;
                       ((ComplexField)olvSelectedFields.SelectedObject).Length = frm.ComplexField.Length;
                        olvSelectedFields.RefreshObject(olvSelectedFields.SelectedObject);
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            IField field = ((IField) comboBoxDefaultFields.SelectedItem).Clone() as IField;
            field.Header = textBoxHeader.Text;
            if (_useSpecficLenght)
                try
                {
                    field.Length = Convert.ToInt32(textNumericUserControl1.Text);
                }
                catch
                {
                    field.Length = ((Field) field).DefaultLength;
                }
            _addField(field);
        }

        private void listViewSelectedFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExportMode)
            {
                regroupToolStripMenuItem.Enabled = true;
                if (olvSelectedFields.SelectedObjects.Count > 1)
                {
                    foreach (IField field in olvSelectedFields.SelectedObjects)
                    {
                        if (field is ComplexField)
                        {
                            regroupToolStripMenuItem.Enabled = false;
                            return;
                        }
                    }
                }
                else
                    regroupToolStripMenuItem.Enabled = false;
            }
            else
                regroupToolStripMenuItem.Enabled = false;

            if (olvSelectedFields.SelectedObject != null)
            {
                buttonProperties.Enabled = ExportMode
                    ? true
                    : (((Field)olvSelectedFields.SelectedObject).FieldType is DateFieldType || ((Field)olvSelectedFields.SelectedObject).FieldType is DecimalFieldType);

                buttonDelete.Enabled = true;
                buttonDown.Enabled = (olvSelectedFields.SelectedIndex < olvSelectedFields.Items.Count - 1);
                buttonUp.Enabled = (olvSelectedFields.SelectedIndex > 0);

            }
            else
            {
                buttonProperties.Enabled = false;
                buttonDelete.Enabled = false;
                buttonDown.Enabled = false;
                buttonUp.Enabled = false;
            }
        }

        private void regroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplexField complexField = new ComplexField();
            foreach (IField field in olvSelectedFields.SelectedObjects)
                complexField.Fields.Add(field);

            ComplexFieldPropertiesForm frm = new ComplexFieldPropertiesForm
            {
                UseSpecificLength = _useSpecficLenght,
                DefaultFields = _defaultList,
                ComplexField = complexField
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                olvSelectedFields.RemoveObjects(olvSelectedFields.SelectedObjects);
                _addField(frm.ComplexField);
            }
        }

        private void olvSelectedFields_CellEditStarting(object sender, CellEditEventArgs e)
        {
            if (!_useSpecficLenght)
                e.Cancel = true;

            if (e.RowObject is ComplexField && e.Column == olvColumnLength)
                e.Cancel = true;
        }
    }
}
