using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Contracts
{
    partial class FastDepositForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastDepositForm));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.udAmount = new System.Windows.Forms.NumericUpDown();
            this.lvContracts = new OpenCBS.GUI.UserControl.ListViewEx();
            this.colContract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            resources.ApplyResources(this.pnlButton, "pnlButton");
            this.pnlButton.Controls.Add(this.btnOK);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Name = "pnlButton";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            // 
            // udAmount
            // 
            resources.ApplyResources(this.udAmount, "udAmount");
            this.udAmount.Name = "udAmount";
            // 
            // lvContracts
            // 
            this.lvContracts.CheckBoxes = true;
            this.lvContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colContract,
            this.colType,
            this.colBalance,
            this.colAmount,
            this.colCurrency});
            resources.ApplyResources(this.lvContracts, "lvContracts");
            this.lvContracts.DoubleClickActivation = true;
            this.lvContracts.FullRowSelect = true;
            this.lvContracts.GridLines = true;
            this.lvContracts.MultiSelect = false;
            this.lvContracts.Name = "lvContracts";
            this.lvContracts.UseCompatibleStateImageBehavior = false;
            this.lvContracts.View = System.Windows.Forms.View.Details;
            this.lvContracts.SubItemClicked += new OpenCBS.GUI.UserControl.SubItemEventHandler(this.lvContracts_SubItemClicked);
            this.lvContracts.SubItemEndEditing += new OpenCBS.GUI.UserControl.SubItemEndEditingEventHandler(this.lvContracts_SubItemEndEditing);
            this.lvContracts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvContracts_ItemCheck);
            this.lvContracts.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvContracts_ItemChecked);
            this.lvContracts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvContracts_MouseDown);
            // 
            // colContract
            // 
            resources.ApplyResources(this.colContract, "colContract");
            // 
            // colType
            // 
            resources.ApplyResources(this.colType, "colType");
            // 
            // colBalance
            // 
            resources.ApplyResources(this.colBalance, "colBalance");
            // 
            // colAmount
            // 
            resources.ApplyResources(this.colAmount, "colAmount");
            // 
            // colCurrency
            // 
            resources.ApplyResources(this.colCurrency, "colCurrency");
            // 
            // FastDepositForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.udAmount);
            this.Controls.Add(this.lvContracts);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FastDepositForm";
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private ListViewEx lvContracts;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader colContract;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colBalance;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.NumericUpDown udAmount;
        private System.Windows.Forms.ColumnHeader colCurrency;
    }
}