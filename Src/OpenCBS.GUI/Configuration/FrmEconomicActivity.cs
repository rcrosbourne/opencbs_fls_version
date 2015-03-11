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
using System.Windows.Forms;
using OpenCBS.CoreDomain.EconomicActivities;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Services;
using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Configuration
{
    public partial class FrmEconomicActivity : SweetBaseForm
    {
        private TreeNode _selectedNode;
        private EconomicActivity _economicActivity;
        private string _isSame;

        public FrmEconomicActivity()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            var root = new TreeNode(GetString("doa.Text"));
            tvEconomicActivity.Nodes.Add(root);

            List<EconomicActivity> doaList = ServicesProvider.GetInstance().GetEconomicActivityServices().FindAllEconomicActivities();
            tvEconomicActivity.BeginUpdate();
            foreach (EconomicActivity domainOfApplication in doaList)
            {
                var node = new TreeNode(domainOfApplication.Name) { Tag = domainOfApplication };
                root.Nodes.Add(node);
                if (domainOfApplication.HasChildrens)
                    _DisplayAllChildrensNodes(node, domainOfApplication);
            }
            tvEconomicActivity.EndUpdate();
            root.Expand();

            tvEconomicActivity.Sort();

            SelectRootNode();
        }

        private void SelectRootNode()
        {
            // Selecting TreeView root node if any
            if (tvEconomicActivity.Nodes.Count > 0)
            {
                tvEconomicActivity.SelectedNode = tvEconomicActivity.Nodes[0];
                tvEconomicActivity.Focus();
            }
        }

        private static void _DisplayAllChildrensNodes(TreeNode pNode, EconomicActivity pApplication)
        {
            foreach (EconomicActivity domainOfApplication in pApplication.Childrens)
            {
                var node = new TreeNode(domainOfApplication.Name) { Tag = domainOfApplication };
                pNode.Nodes.Add(node);
                if (domainOfApplication.HasChildrens)
                    _DisplayAllChildrensNodes(node, domainOfApplication);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tvEconomicActivity.SelectedNode != null)
                AddDomain();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text.Equals(GetString("buttonSave")))
                EditDomain();
            else
            {
                if (tvEconomicActivity.SelectedNode != null) EditDomain();
                else MessageBox.Show(GetString("messageBoxNoSelection.Text"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _selectedNode = tvEconomicActivity.SelectedNode;
            if (_selectedNode == null)
            {
                MessageBox.Show(GetString("messageBoxNoSelection.Text"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                var economicActivityServices = ServicesProvider.GetInstance().GetEconomicActivityServices();
                bool isEditable = economicActivityServices.NodeEditable(_selectedNode.Tag);
                if (!isEditable) return;

                var economicActivity = (EconomicActivity)_selectedNode.Tag;
                var format = GetString("areYouSureMessage.Text");
                var message = string.Format(format, economicActivity.Name);
                if (MessageBox.Show(message, message, MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    DeleteEconomicActivity(economicActivity);
                }
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
        }

        private void AddDomain()
        {
            _selectedNode = tvEconomicActivity.SelectedNode;

            //var doan = new FrmEconomicActivityName { DoaName = String.Empty, Text = "Economic activity" };
            //doan.ShowDialog();
            //if (doan.IsClosed) return;

            var doa = new EconomicActivity { Name = textBoxName.Text };

            try
            {
                EconomicActivity parent;

                // add economic activity (in the root)
                if (_selectedNode.Tag == null)
                {
                    parent = new EconomicActivity();
                    doa.Parent = parent;
                }
                // add in the tree
                else
                {
                    parent = (EconomicActivity)_selectedNode.Tag;
                    doa.Parent = parent;
                }
                doa.Id = ServicesProvider.GetInstance().GetEconomicActivityServices().AddEconomicActivity(doa);
                var node = new TreeNode(doa.Name) { Tag = doa };
                _selectedNode.Nodes.Add(node);

                if (parent != null)
                {
                    parent.Childrens.Add(doa);
                    _selectedNode.Tag = parent;
                }
                _selectedNode.Expand();
            }
            catch (Exception up)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(up)).ShowDialog();
            }

            SelectRootNode();

            tvEconomicActivity.Sort();
        }

        private void EditDomain()
        {
            try
            {
                if (buttonEdit.Text.Equals(GetString("buttonEdit")))
                {
                    _selectedNode = tvEconomicActivity.SelectedNode;
                    _economicActivity = (EconomicActivity)_selectedNode.Tag;

                    if (_economicActivity != null)
                    {
                        _economicActivity.Parent = (EconomicActivity)_selectedNode.Parent.Tag;
                        textBoxName.Text = _economicActivity.Name;
                        _isSame = textBoxName.Text;
                        buttonExit.Enabled = false;
                        buttonAdd.Enabled = false;
                        buttonDelete.Enabled = false;
                        tvEconomicActivity.Enabled = false;

                        buttonEdit.Text = GetString("buttonSave");
                    }
                }
                else
                {
                    if (ServicesProvider.GetInstance().GetEconomicActivityServices().NodeEditable(_selectedNode.Tag))
                    {
                        if (_selectedNode.Level == 1)
                            _economicActivity.Parent = new EconomicActivity(); // no parent

                        if (_isSame != textBoxName.Text)
                            if (ServicesProvider.GetInstance().GetEconomicActivityServices().ChangeDomainOfApplicationName(_economicActivity, textBoxName.Text))
                            {
                                tvEconomicActivity.BeginUpdate();
                                _selectedNode.Tag = _economicActivity;
                                _selectedNode.Text = textBoxName.Text;
                                tvEconomicActivity.EndUpdate();
                            }
                    }

                    buttonExit.Enabled = true;
                    buttonAdd.Enabled = true;
                    buttonDelete.Enabled = true;
                    tvEconomicActivity.Enabled = true;
                    textBoxName.Text = string.Empty;

                    buttonEdit.Text = GetString("buttonEdit");
                }
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }

            SelectRootNode();

            tvEconomicActivity.Sort();
        }

        private void DeleteEconomicActivity(EconomicActivity economicActivity)
        {
            _economicActivity = economicActivity;
            ServicesProvider.GetInstance().GetEconomicActivityServices().DeleteEconomicActivity(_economicActivity);

            var parent = (EconomicActivity)_selectedNode.Parent.Tag;
            if (parent != null) parent.RemoveChildren(_economicActivity);

            tvEconomicActivity.BeginUpdate();
            _selectedNode.Remove();
            tvEconomicActivity.EndUpdate();

            SelectRootNode();

            tvEconomicActivity.Sort();
        }

    }
}
