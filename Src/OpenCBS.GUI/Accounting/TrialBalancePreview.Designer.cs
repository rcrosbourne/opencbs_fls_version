namespace OpenCBS.GUI.Accounting
{
    partial class TrialBalancePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrialBalancePreview));
            this.tlvBalances = new BrightIdeasSoftware.TreeListView();
            this.olvColumnLACNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLACLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLACBalance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CloseBalance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLACCurrency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.tlvBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // tlvBalances
            // 
            resources.ApplyResources(this.tlvBalances, "tlvBalances");
            this.tlvBalances.AllColumns.Add(this.olvColumnLACNumber);
            this.tlvBalances.AllColumns.Add(this.olvColumnLACLabel);
            this.tlvBalances.AllColumns.Add(this.olvColumnLACBalance);
            this.tlvBalances.AllColumns.Add(this.olvColumn_CloseBalance);
            this.tlvBalances.AllColumns.Add(this.olvColumnLACCurrency);
            this.tlvBalances.CheckBoxes = false;
            this.tlvBalances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnLACNumber,
            this.olvColumnLACLabel,
            this.olvColumnLACBalance,
            this.olvColumn_CloseBalance,
            this.olvColumnLACCurrency});
            this.tlvBalances.Name = "tlvBalances";
            this.tlvBalances.OverlayText.Text = resources.GetString("resource.Text");
            this.tlvBalances.OwnerDraw = true;
            this.tlvBalances.ShowGroups = false;
            this.tlvBalances.UseCompatibleStateImageBehavior = false;
            this.tlvBalances.View = System.Windows.Forms.View.Details;
            this.tlvBalances.VirtualMode = true;
            // 
            // olvColumnLACNumber
            // 
            this.olvColumnLACNumber.AspectName = "Number";
            resources.ApplyResources(this.olvColumnLACNumber, "olvColumnLACNumber");
            // 
            // olvColumnLACLabel
            // 
            this.olvColumnLACLabel.AspectName = "Label";
            resources.ApplyResources(this.olvColumnLACLabel, "olvColumnLACLabel");
            // 
            // olvColumnLACBalance
            // 
            this.olvColumnLACBalance.AspectName = "OpenBalance";
            resources.ApplyResources(this.olvColumnLACBalance, "olvColumnLACBalance");
            this.olvColumnLACBalance.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumn_CloseBalance
            // 
            this.olvColumn_CloseBalance.AspectName = "CloseBalance";
            resources.ApplyResources(this.olvColumn_CloseBalance, "olvColumn_CloseBalance");
            this.olvColumn_CloseBalance.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumnLACCurrency
            // 
            this.olvColumnLACCurrency.AspectName = "CurrencyCode";
            resources.ApplyResources(this.olvColumnLACCurrency, "olvColumnLACCurrency");
            // 
            // TrialBalancePreview
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlvBalances);
            this.Name = "TrialBalancePreview";
            ((System.ComponentModel.ISupportInitialize)(this.tlvBalances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView tlvBalances;
        private BrightIdeasSoftware.OLVColumn olvColumnLACNumber;
        private BrightIdeasSoftware.OLVColumn olvColumnLACLabel;
        private BrightIdeasSoftware.OLVColumn olvColumnLACBalance;
        private BrightIdeasSoftware.OLVColumn olvColumnLACCurrency;
        private BrightIdeasSoftware.OLVColumn olvColumn_CloseBalance;
    }
}