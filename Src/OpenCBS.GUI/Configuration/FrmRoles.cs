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
using OpenCBS.Enums;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Extensions;
using OpenCBS.GUI.UserControl;
using OpenCBS.Services;
using OpenCBS.CoreDomain;
using OpenCBS.MultiLanguageRessources;

namespace OpenCBS.GUI.Configuration
{
    public partial class FrmRoles : SweetBaseForm
    {
        private readonly Form _mdiParent;
        private readonly List<MenuObject> _menuItems;
        private Role _role;
        
        public FrmRoles(Form pMdiParent)
        {
            InitializeComponent();
            _mdiParent = pMdiParent;
            _menuItems = new List<MenuObject>();
            _menuItems = Services.GetMenuItemServices().GetMenuList(OSecurityObjectTypes.MenuItem, OSecurityObjectTypes.ExtensionControl);
            InitListView();
            Role role = (Role) listViewRoles.Items[0].Tag;            
            InitTrees(role);
            UpdateControlStatus();
            _role = new Role();
            btnNew.Text = GetString("new");
        }

        public void EraseRole()
        {
            _role = new Role();
            txtTitle.Text = _role.RoleName;
            txtDescription.Text = _role.Description;
        }

        List<MenuObject> GetDeidMenuItems()
        {
            //look for deid menu items
            List<MenuObject> list = new List<MenuObject>();
            foreach (MenuObject item in _menuItems)
            {
                var items = _mdiParent.MainMenuStrip.Items.Find(item.Name, true);
                if (items.Length == 0)
                    list.Add(item);
            }
            return list;
        } 

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (_role.Id == 0) SaveRole();
            else UpdateRole();

            InitListView();
        }

        private void UpdateRole()
        {
            _role.RoleName = txtTitle.Text;
            _role.Description = txtDescription.Text;

            try
            {
                RoleServices.RoleErrors roleErrors = ServicesProvider.GetInstance().GetRoleServices().UpdateRole(_role);
                if (roleErrors.FindError)
                {
                    MessageBox.Show(GetString(roleErrors.ErrorCode), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UpdateControlStatus();
                User.CurrentUser = ServicesProvider.GetInstance().GetUserServices().Find(User.CurrentUser.Id, true);
                //clean deid menu
                foreach (MenuObject item in GetDeidMenuItems())
                {
                    ServicesProvider.GetInstance().GetMenuItemServices().DeleteMenuItem(item);
                }
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();  
            }
            EraseRole();
        }

        private void SaveRole()
        {
            _role.RoleName = txtTitle.Text;
            _role.Description = txtDescription.Text;

            try
            {
                RoleServices.RoleErrors roleErrors = ServicesProvider.GetInstance().GetRoleServices().SaveRole(_role);
                if (roleErrors.FindError)
                {
                    MessageBox.Show(GetString(roleErrors.ErrorCode), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UpdateControlStatus();
                User.CurrentUser = ServicesProvider.GetInstance().GetUserServices().Find(User.CurrentUser.Id, true);
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
            
            EraseRole();
        }

        private void InitListView()
        {
            listViewRoles.Items.Clear();
            List<Role> roles = new List<Role>();
            roles = ServicesProvider.GetInstance().GetRoleServices().FindAllRoles(false);
            foreach (Role role in roles)
            {
                ListViewItem lv = new ListViewItem(new []{role.RoleName,role.Description});
                lv.Tag = role;
                listViewRoles.Items.Add(lv);
            }
        }

        private void InitActionTree(Role pRole)
        {
            trvMenuItems.Nodes.Clear();

            TreeNode root = new TreeNode(MultiLanguageStrings.GetString(Ressource.FrmRoles, "menu_item.Text"));
            trvMenuItems.Nodes.Add(root);

            foreach (ToolStripMenuItem mi in (_mdiParent).MainMenuStrip.Items)
            {
                if (string.IsNullOrEmpty(mi.Text) || mi.Tag == null) continue;

                TreeNode mainNode = new TreeNode(mi.Text) {Tag = mi.Tag};
                mainNode.Checked = pRole.IsMenuAllowed(mainNode.Tag as MenuObject);
                mainNode.Expand();
                root.Nodes.Add(FillChildNodes(mainNode, mi, pRole));
            }
            root.Expand();
            Invalidate();
        }

        private void UpdateControlStatus()
        {
            UpdateControlStatus(false,"");
        }

        private void UpdateControlStatus(bool isUpdate,string roleName)
        {
            if (isUpdate)
            {
                stateLabel.Text = string.Format(GetString("updateLabel"),roleName);
                btnAdd.Text = GetString("update");
                txtTitle.Enabled = false;
            }
            else
            {
                stateLabel.Text = GetString("createLabel");
                btnAdd.Text = GetString("create");
                txtTitle.Enabled = true;
            }
        }

        private TreeNode FillChildNodes(TreeNode pParent, ToolStripMenuItem pMenuItem, Role pRole)
        {            
            if (!pMenuItem.HasDropDownItems)
            {
                MenuObject menuObject;
                var lastChildNode = AddMenuItemFromMenu(pMenuItem, out menuObject);
                if (menuObject != null)
                    lastChildNode.Checked = pRole.IsMenuAllowed(menuObject);
                return lastChildNode;
            }

            foreach (Object tsmi in pMenuItem.DropDownItems)
            {
                if (!(tsmi is ToolStripMenuItem))
                    continue;
                ToolStripMenuItem tsmiMenu = (ToolStripMenuItem)tsmi;
                MenuObject menuObject;

                var childNode = AddMenuItemFromMenu(tsmiMenu, out menuObject);
                if (menuObject == null) continue;

                childNode.Checked = pRole.IsMenuAllowed(menuObject);
                childNode.Collapse(true);
                FillChildNodes(childNode, tsmiMenu, pRole);
                pParent.Nodes.Add(childNode);
                pParent.Collapse(true);
            }
            return pParent;

        }

        private TreeNode AddMenuItemFromMenu(ToolStripMenuItem pMenuItem, out MenuObject menuObject)
        {
            TreeNode lastChildNode = new TreeNode(pMenuItem.Text);
            menuObject = GetMenuObject(pMenuItem.Name);
            lastChildNode.Tag = menuObject;
            return lastChildNode;
        }

        /*Init ActionsTreeView*/
        private void InitActionsTreeView(Role pRole)
        {
            trwActionItems.Nodes.Clear();

            TreeNode root = new TreeNode(MultiLanguageStrings.GetString(Ressource.FrmRoles, "action_item.Text"));
            trwActionItems.Nodes.Add(root);

            string prev = "";
            TreeNode mainNode = null;
            foreach (KeyValuePair<ActionItemObject, bool> _action in pRole.GetSortedActionItems())
            {
                if (!string.Equals(prev, _action.Key.ClassName))
                {
                    mainNode = new TreeNode(_action.Key.ClassName) {Tag = _action.Key};
                    mainNode.Collapse();
                    root.Nodes.Add(mainNode);
                    prev = _action.Key.ClassName;
                }
                
                    TreeNode childNode = new TreeNode(_action.Key.MethodName)
                                             {
                                                 Tag = _action.Key,
                                                 Checked = _action.Value
                                             };
                mainNode.Nodes.Add(childNode);
            }
            root.Expand();
            Invalidate();
        }

        private MenuObject GetMenuObject(string pText)
        {
            if (!string.IsNullOrEmpty(pText))
            {
                MenuObject foundObject = _menuItems.Find(item => item == pText.Trim());
                return foundObject;
            }
            return null;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (_role.Id == 0)
            {
                MessageBox.Show(GetString("RoleSelect"));
                return;
            }
            try
            {

                if (listViewRoles.SelectedItems != null)
                {
                    ServicesProvider.GetInstance().GetRoleServices().DeleteRole(listViewRoles.SelectedItems[0].Text);
                }
            }
            catch (Exception ex)
            {
                new frmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
            InitListView();
            EraseRole();
            UpdateControlStatus();
        }

        private void ListViewRolesItemCheck(object sender, ItemCheckEventArgs e)
        {
            _role = (Role) listViewRoles.SelectedItems[0].Tag;
            if (listViewRoles.SelectedItems != null)
            {
                InitTrees(_role);
            }
            UpdateControlStatus(true,_role.RoleName);
        }

        private void TreeViewMenuItemsAfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode != null)
            {
                    if (listViewRoles.SelectedItems != null)
                    {
                        Role selectedRole = _role;
                        if (selectedNode.Tag != null)
                            selectedRole.SetMenuAllowed((MenuObject)selectedNode.Tag, selectedNode.Checked);
                        _ChangeMenuAccess(selectedNode, selectedNode.Checked, selectedRole);
                    }
            }
        }

        private void _ChangeMenuAccess(TreeNode pNode, bool pChecked, Role pRole)
        {
            if (pNode.Nodes.Count < 1) 
                return;

            foreach (TreeNode child in pNode.Nodes)
                child.Checked = pChecked;
        }

        private void _ChangeActionAccess(TreeNode pNode, bool pChecked, Role pRole)
        {
            if (pNode.Nodes.Count == 0)
            {
                if (pNode.Tag != null)
                    pRole.SetActionAllowed((ActionItemObject)pNode.Tag, pNode.Checked);
                return;
            }
            foreach (TreeNode child in pNode.Nodes)
            {
                child.Checked = pChecked;
                if (pNode.Tag != null)
                    pRole.SetActionAllowed((ActionItemObject)child.Tag, child.Checked);
            }
        }

        private void ListViewRolesItemSelectionChanged1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewRoles.SelectedItems.Count>0)
            {
                Role role = (Role) listViewRoles.SelectedItems[0].Tag;
                InitTrees(role);
            }
        }

        private void InitTrees(Role role)
        {
            InitActionTree(role);
            InitActionsTreeView(role);
        }

        private void TreeViewActionItemsAfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode != null)
            {
                if (listViewRoles.SelectedItems != null)
                {
                    Role selectedRole = _role;
                    _ChangeActionAccess(selectedNode, selectedNode.Checked, selectedRole);
                }
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ListViewRolesClick(object sender, EventArgs e)
        {
            if (listViewRoles.SelectedItems.Count>0)
            {
                _role = (Role)listViewRoles.SelectedItems[0].Tag;
                LoadRoleProperties(_role);
                UpdateControlStatus(true, _role.RoleName);
            }
            else
            {
                EraseRole();
                UpdateControlStatus();
            }
        }
        
        private void LoadRoleProperties(Role role)
        {
            txtTitle.Text = role.RoleName;
            txtDescription.Text = role.Description;
        }

        private void BtnNewClick(object sender, EventArgs e)
        {
            EraseRole();
            UpdateControlStatus();
        }
    }
}
