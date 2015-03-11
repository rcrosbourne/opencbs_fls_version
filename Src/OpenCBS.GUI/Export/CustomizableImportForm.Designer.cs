namespace OpenCBS.GUI.Export
{
    partial class CustomizableImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizableImportForm));
            this.splitContainerSage = new System.Windows.Forms.SplitContainer();
            this._buttonExit = new System.Windows.Forms.Button();
            this._labelTitle = new System.Windows.Forms.Label();
            this.tabControlExportations = new System.Windows.Forms.TabControl();
            this.tabPageInstallments = new System.Windows.Forms.TabPage();
            this.splitContainerAccountTiers = new System.Windows.Forms.SplitContainer();
            this.buttonOpenData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSlashInstallments = new System.Windows.Forms.Label();
            this.buttonExportAccountTiers = new System.Windows.Forms.Button();
            this.labelSelectedInstallments = new System.Windows.Forms.Label();
            this.btnSelectAllInstallments = new System.Windows.Forms.Button();
            this.labelTotalInstallments = new System.Windows.Forms.Label();
            this.btnDeselectAllInstallments = new System.Windows.Forms.Button();
            this.listViewInstallments = new System.Windows.Forms.ListView();
            this.columnHeaderInstallmentContractCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallmentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallmentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallmentAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSage)).BeginInit();
            this.splitContainerSage.Panel1.SuspendLayout();
            this.splitContainerSage.Panel2.SuspendLayout();
            this.splitContainerSage.SuspendLayout();
            this.tabControlExportations.SuspendLayout();
            this.tabPageInstallments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAccountTiers)).BeginInit();
            this.splitContainerAccountTiers.Panel1.SuspendLayout();
            this.splitContainerAccountTiers.Panel2.SuspendLayout();
            this.splitContainerAccountTiers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerSage
            // 
            resources.ApplyResources(this.splitContainerSage, "splitContainerSage");
            this.splitContainerSage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSage.Name = "splitContainerSage";
            // 
            // splitContainerSage.Panel1
            // 
            this.splitContainerSage.Panel1.Controls.Add(this._buttonExit);
            this.splitContainerSage.Panel1.Controls.Add(this._labelTitle);
            // 
            // splitContainerSage.Panel2
            // 
            this.splitContainerSage.Panel2.Controls.Add(this.tabControlExportations);
            // 
            // _buttonExit
            // 
            resources.ApplyResources(this._buttonExit, "_buttonExit");
            this._buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this._buttonExit.Name = "_buttonExit";
            this._buttonExit.UseVisualStyleBackColor = false;
            this._buttonExit.Click += new System.EventHandler(this._buttonExit_Click);
            // 
            // _labelTitle
            // 
            resources.ApplyResources(this._labelTitle, "_labelTitle");
            this._labelTitle.Name = "_labelTitle";
            // 
            // tabControlExportations
            // 
            this.tabControlExportations.Controls.Add(this.tabPageInstallments);
            resources.ApplyResources(this.tabControlExportations, "tabControlExportations");
            this.tabControlExportations.Name = "tabControlExportations";
            this.tabControlExportations.SelectedIndex = 0;
            // 
            // tabPageInstallments
            // 
            this.tabPageInstallments.Controls.Add(this.splitContainerAccountTiers);
            resources.ApplyResources(this.tabPageInstallments, "tabPageInstallments");
            this.tabPageInstallments.Name = "tabPageInstallments";
            // 
            // splitContainerAccountTiers
            // 
            resources.ApplyResources(this.splitContainerAccountTiers, "splitContainerAccountTiers");
            this.splitContainerAccountTiers.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerAccountTiers.Name = "splitContainerAccountTiers";
            // 
            // splitContainerAccountTiers.Panel1
            // 
            this.splitContainerAccountTiers.Panel1.Controls.Add(this.buttonOpenData);
            // 
            // splitContainerAccountTiers.Panel2
            // 
            this.splitContainerAccountTiers.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerAccountTiers.Panel2.Controls.Add(this.listViewInstallments);
            // 
            // buttonOpenData
            // 
            resources.ApplyResources(this.buttonOpenData, "buttonOpenData");
            this.buttonOpenData.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonOpenData.Name = "buttonOpenData";
            this.buttonOpenData.UseVisualStyleBackColor = false;
            this.buttonOpenData.Click += new System.EventHandler(this.buttonOpenData_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.labelSlashInstallments);
            this.groupBox1.Controls.Add(this.buttonExportAccountTiers);
            this.groupBox1.Controls.Add(this.labelSelectedInstallments);
            this.groupBox1.Controls.Add(this.btnSelectAllInstallments);
            this.groupBox1.Controls.Add(this.labelTotalInstallments);
            this.groupBox1.Controls.Add(this.btnDeselectAllInstallments);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // labelSlashInstallments
            // 
            resources.ApplyResources(this.labelSlashInstallments, "labelSlashInstallments");
            this.labelSlashInstallments.Name = "labelSlashInstallments";
            // 
            // buttonExportAccountTiers
            // 
            resources.ApplyResources(this.buttonExportAccountTiers, "buttonExportAccountTiers");
            this.buttonExportAccountTiers.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExportAccountTiers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonExportAccountTiers.Name = "buttonExportAccountTiers";
            this.buttonExportAccountTiers.UseVisualStyleBackColor = false;
            this.buttonExportAccountTiers.Click += new System.EventHandler(this.buttonExportAccountTiers_Click);
            // 
            // labelSelectedInstallments
            // 
            resources.ApplyResources(this.labelSelectedInstallments, "labelSelectedInstallments");
            this.labelSelectedInstallments.Name = "labelSelectedInstallments";
            // 
            // btnSelectAllInstallments
            // 
            resources.ApplyResources(this.btnSelectAllInstallments, "btnSelectAllInstallments");
            this.btnSelectAllInstallments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.btnSelectAllInstallments.Name = "btnSelectAllInstallments";
            this.btnSelectAllInstallments.UseVisualStyleBackColor = true;
            this.btnSelectAllInstallments.Click += new System.EventHandler(this.btnSelectAllInstallments_Click);
            // 
            // labelTotalInstallments
            // 
            resources.ApplyResources(this.labelTotalInstallments, "labelTotalInstallments");
            this.labelTotalInstallments.Name = "labelTotalInstallments";
            // 
            // btnDeselectAllInstallments
            // 
            resources.ApplyResources(this.btnDeselectAllInstallments, "btnDeselectAllInstallments");
            this.btnDeselectAllInstallments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.btnDeselectAllInstallments.Name = "btnDeselectAllInstallments";
            this.btnDeselectAllInstallments.UseVisualStyleBackColor = true;
            this.btnDeselectAllInstallments.Click += new System.EventHandler(this.btnDeselectAllInstallments_Click);
            // 
            // listViewInstallments
            // 
            resources.ApplyResources(this.listViewInstallments, "listViewInstallments");
            this.listViewInstallments.CheckBoxes = true;
            this.listViewInstallments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInstallmentContractCode,
            this.columnHeaderInstallmentNumber,
            this.columnHeaderInstallmentDate,
            this.columnHeaderInstallmentAmount});
            this.listViewInstallments.FullRowSelect = true;
            this.listViewInstallments.GridLines = true;
            this.listViewInstallments.Name = "listViewInstallments";
            this.listViewInstallments.UseCompatibleStateImageBehavior = false;
            this.listViewInstallments.View = System.Windows.Forms.View.Details;
            this.listViewInstallments.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewInstallments_ItemChecked);
            // 
            // columnHeaderInstallmentContractCode
            // 
            resources.ApplyResources(this.columnHeaderInstallmentContractCode, "columnHeaderInstallmentContractCode");
            // 
            // columnHeaderInstallmentNumber
            // 
            resources.ApplyResources(this.columnHeaderInstallmentNumber, "columnHeaderInstallmentNumber");
            // 
            // columnHeaderInstallmentDate
            // 
            resources.ApplyResources(this.columnHeaderInstallmentDate, "columnHeaderInstallmentDate");
            // 
            // columnHeaderInstallmentAmount
            // 
            resources.ApplyResources(this.columnHeaderInstallmentAmount, "columnHeaderInstallmentAmount");
            // 
            // openImportFileDialog
            // 
            resources.ApplyResources(this.openImportFileDialog, "openImportFileDialog");
            // 
            // CustomizableImportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerSage);
            this.Name = "CustomizableImportForm";
            this.splitContainerSage.Panel1.ResumeLayout(false);
            this.splitContainerSage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSage)).EndInit();
            this.splitContainerSage.ResumeLayout(false);
            this.tabControlExportations.ResumeLayout(false);
            this.tabPageInstallments.ResumeLayout(false);
            this.splitContainerAccountTiers.Panel1.ResumeLayout(false);
            this.splitContainerAccountTiers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAccountTiers)).EndInit();
            this.splitContainerAccountTiers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerSage;
        private System.Windows.Forms.Button _buttonExit;
        private System.Windows.Forms.Label _labelTitle;
        private System.Windows.Forms.TabControl tabControlExportations;
        private System.Windows.Forms.TabPage tabPageInstallments;
        private System.Windows.Forms.SplitContainer splitContainerAccountTiers;
        private System.Windows.Forms.Label labelSlashInstallments;
        private System.Windows.Forms.Label labelSelectedInstallments;
        private System.Windows.Forms.Label labelTotalInstallments;
        private System.Windows.Forms.Button btnDeselectAllInstallments;
        private System.Windows.Forms.Button btnSelectAllInstallments;
        private System.Windows.Forms.Button buttonExportAccountTiers;
        private System.Windows.Forms.ListView listViewInstallments;
        private System.Windows.Forms.ColumnHeader columnHeaderInstallmentContractCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeaderInstallmentNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderInstallmentDate;
        private System.Windows.Forms.ColumnHeader columnHeaderInstallmentAmount;
        private System.Windows.Forms.OpenFileDialog openImportFileDialog;
        private System.Windows.Forms.Button buttonOpenData;
        private System.Windows.Forms.OpenFileDialog openDataFileDialog;
    }
}