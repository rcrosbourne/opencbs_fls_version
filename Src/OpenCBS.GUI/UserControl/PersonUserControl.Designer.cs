using System.Windows.Forms;
using System;
using System.ComponentModel;
using OpenCBS.Shared.Settings;

namespace OpenCBS.GUI.UserControl
{
    public partial class PersonUserControl
    {
        private GroupBox groupBoxCivilities;
        private Label labelDateOfBirth;
        private TextBoxLimit textBoxIdentificationData;
        private Label labelPassport;
        private ComboBox comboBoxSex;
        private Label labelSex;
        private Panel panelBottom;
        private Panel panelEconomicActivity;
        private CheckBox checkBoxHeadOfHousehold;
        private IContainer components;
        public event EventHandler ButtonCancelClick;
        public event EventHandler ButtonSaveClick;
        public event EventHandler ButtonBadLoanClick;
        public event EventHandler ButtonAddProjectClick;
        public event EventHandler ListViewHistoryDoubleClick;
        public event EventHandler ViewProject;
        private DateTimePicker dateTimePickerDateOfBirth;
        private TextBoxLimit textBoxLastname;
        private Label labelLastname;
        private Label labelFirstName;
        private TextBoxLimit textBoxFirstName;
        private AddressUserControl addressUserControlFirst;
        private AddressUserControl addressUserControlSecondaryAddress;
        private ImageList imageListEconomicInfo;
        private LinkLabel changePhotoLinkLabel;
        private TextBoxLimit textBoxFatherName;
        private Label labelFatherName;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelRangeOfAge;
        private TextBoxLimit textBoxBirthPlace;
        private Label labelIN;
        private TextBoxLimit textBoxNationality;
        private Label labelNationality;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label10;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private Label label13;
        private TextBox textBox3;
        private Label label14;
        private TextBox textBox4;
        private Label label15;
        private ComboBox comboBox3;
        private Label label16;
        private ComboBox comboBox4;
        private TextBox textBox5;
        private Label label17;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker2;
        private Label label18;
        private Label label19;
        private TextBox textBox6;
        private Label label20;
        private TextBox textBox7;
        private Label label21;
        private TextBox textBox8;
        private Label label22;
        private TextBox textBoxLoanCycle;
        private Label labelLoanCycle;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonUserControl));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listViewContracts = new System.Windows.Forms.ListView();
            this.columnProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInterestRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallmentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNbOfInstallments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCloseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxProjectButton = new System.Windows.Forms.GroupBox();
            this.buttonProjectAddGuarantee = new System.Windows.Forms.Button();
            this.buttonProjectViewContract = new System.Windows.Forms.Button();
            this.buttonProjectAddContract = new System.Windows.Forms.Button();
            this.imageListEconomicInfo = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSaving = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tabControlEconomicInfo = new System.Windows.Forms.TabControl();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelAddress = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFirstAddress = new System.Windows.Forms.GroupBox();
            this.groupBoxSecondaryAddress = new System.Windows.Forms.GroupBox();
            this.tabPage1FollowUp = new System.Windows.Forms.TabPage();
            this.lblAnd2 = new System.Windows.Forms.Label();
            this.lblAnd1 = new System.Windows.Forms.Label();
            this.textBoxSponsor2 = new System.Windows.Forms.TextBox();
            this.textBoxSponsor1 = new System.Windows.Forms.TextBox();
            this.richTextBoxCommentsActivity = new System.Windows.Forms.RichTextBox();
            this.comboBoxSponsor2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSponsor1 = new System.Windows.Forms.ComboBox();
            this.labelSponsor2 = new System.Windows.Forms.Label();
            this.labelCommentsTypeActivity = new System.Windows.Forms.Label();
            this.dateTimePickerFirstAppointment = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFirstContact = new System.Windows.Forms.DateTimePicker();
            this.labelFirstAppointment = new System.Windows.Forms.Label();
            this.labelFirstContact = new System.Windows.Forms.Label();
            this.labelSponsor1 = new System.Windows.Forms.Label();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewProjects = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNbOfCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNbOfGuarantees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxProjects = new System.Windows.Forms.GroupBox();
            this.buttonViewProject = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.tabPageSavings = new System.Windows.Forms.TabPage();
            this.tabPageGroupMember = new System.Windows.Forms.TabPage();
            this.listViewGroup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxCivilities = new System.Windows.Forms.GroupBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblEconomicActivity = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.textBoxLoanCycle = new System.Windows.Forms.TextBox();
            this.labelIN = new System.Windows.Forms.Label();
            this.labelLoanCycle = new System.Windows.Forms.Label();
            this.labelRangeOfAge = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.changePhotoLinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.changePhotoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.checkBoxHeadOfHousehold = new System.Windows.Forms.CheckBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panelEconomicActivity = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.clSavingList = new OpenCBS.GUI.UserControl.SavingsListUserControl();
            this.eacPerson = new OpenCBS.GUI.UserControl.EconomicActivityControl();
            this.textBoxNationality = new OpenCBS.GUI.UserControl.TextBoxLimit();
            this.textBoxBirthPlace = new OpenCBS.GUI.UserControl.TextBoxLimit();
            this.textBoxFatherName = new OpenCBS.GUI.UserControl.TextBoxLimit();
            this.textBoxLastname = new OpenCBS.GUI.UserControl.TextBoxLimit();
            this.textBoxIdentificationData = new OpenCBS.GUI.UserControl.TextBoxLimit();
            this.textBoxFirstName = new OpenCBS.GUI.UserControl.TextBoxLimit();
            this.btnPrint = new OpenCBS.GUI.UserControl.PrintButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBoxProjectButton.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControlEconomicInfo.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tableLayoutPanelAddress.SuspendLayout();
            this.tabPage1FollowUp.SuspendLayout();
            this.tabPageProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxProjects.SuspendLayout();
            this.tabPageSavings.SuspendLayout();
            this.tabPageGroupMember.SuspendLayout();
            this.groupBoxCivilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelEconomicActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listViewContracts);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBoxProjectButton);
            // 
            // listViewContracts
            // 
            this.listViewContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductType,
            this.columnHeader13,
            this.columnHeaderStatus,
            this.columnHeaderAmount,
            this.columnHeaderInterestRate,
            this.columnHeaderInstallmentType,
            this.columnHeaderNbOfInstallments,
            this.columnHeaderCreationDate,
            this.columnHeaderStartDate,
            this.columnHeaderCloseDate});
            resources.ApplyResources(this.listViewContracts, "listViewContracts");
            this.listViewContracts.FullRowSelect = true;
            this.listViewContracts.GridLines = true;
            this.listViewContracts.MultiSelect = false;
            this.listViewContracts.Name = "listViewContracts";
            this.listViewContracts.UseCompatibleStateImageBehavior = false;
            this.listViewContracts.View = System.Windows.Forms.View.Details;
            // 
            // columnProductType
            // 
            resources.ApplyResources(this.columnProductType, "columnProductType");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeaderStatus
            // 
            resources.ApplyResources(this.columnHeaderStatus, "columnHeaderStatus");
            // 
            // columnHeaderAmount
            // 
            resources.ApplyResources(this.columnHeaderAmount, "columnHeaderAmount");
            // 
            // columnHeaderInterestRate
            // 
            resources.ApplyResources(this.columnHeaderInterestRate, "columnHeaderInterestRate");
            // 
            // columnHeaderInstallmentType
            // 
            resources.ApplyResources(this.columnHeaderInstallmentType, "columnHeaderInstallmentType");
            // 
            // columnHeaderNbOfInstallments
            // 
            resources.ApplyResources(this.columnHeaderNbOfInstallments, "columnHeaderNbOfInstallments");
            // 
            // columnHeaderCreationDate
            // 
            resources.ApplyResources(this.columnHeaderCreationDate, "columnHeaderCreationDate");
            // 
            // columnHeaderStartDate
            // 
            resources.ApplyResources(this.columnHeaderStartDate, "columnHeaderStartDate");
            // 
            // columnHeaderCloseDate
            // 
            resources.ApplyResources(this.columnHeaderCloseDate, "columnHeaderCloseDate");
            // 
            // groupBoxProjectButton
            // 
            this.groupBoxProjectButton.Controls.Add(this.buttonProjectAddGuarantee);
            this.groupBoxProjectButton.Controls.Add(this.buttonProjectViewContract);
            this.groupBoxProjectButton.Controls.Add(this.buttonProjectAddContract);
            resources.ApplyResources(this.groupBoxProjectButton, "groupBoxProjectButton");
            this.groupBoxProjectButton.Name = "groupBoxProjectButton";
            this.groupBoxProjectButton.TabStop = false;
            // 
            // buttonProjectAddGuarantee
            // 
            resources.ApplyResources(this.buttonProjectAddGuarantee, "buttonProjectAddGuarantee");
            this.buttonProjectAddGuarantee.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonProjectAddGuarantee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonProjectAddGuarantee.Name = "buttonProjectAddGuarantee";
            this.buttonProjectAddGuarantee.UseVisualStyleBackColor = false;
            // 
            // buttonProjectViewContract
            // 
            resources.ApplyResources(this.buttonProjectViewContract, "buttonProjectViewContract");
            this.buttonProjectViewContract.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonProjectViewContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonProjectViewContract.Name = "buttonProjectViewContract";
            this.buttonProjectViewContract.UseVisualStyleBackColor = false;
            // 
            // buttonProjectAddContract
            // 
            resources.ApplyResources(this.buttonProjectAddContract, "buttonProjectAddContract");
            this.buttonProjectAddContract.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonProjectAddContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.buttonProjectAddContract.Name = "buttonProjectAddContract";
            this.buttonProjectAddContract.UseVisualStyleBackColor = false;
            // 
            // imageListEconomicInfo
            // 
            this.imageListEconomicInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEconomicInfo.ImageStream")));
            this.imageListEconomicInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEconomicInfo.Images.SetKeyName(0, "");
            this.imageListEconomicInfo.Images.SetKeyName(1, "");
            this.imageListEconomicInfo.Images.SetKeyName(2, "");
            this.imageListEconomicInfo.Images.SetKeyName(3, "");
            this.imageListEconomicInfo.Images.SetKeyName(4, "");
            this.imageListEconomicInfo.Images.SetKeyName(5, "");
            this.imageListEconomicInfo.Images.SetKeyName(6, "group_32x32.png");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Name = "label12";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Name = "label13";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Name = "label14";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Name = "label15";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Name = "label16";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.Name = "comboBox4";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Name = "label17";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Name = "label19";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Name = "label20";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Name = "label21";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Name = "label22";
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // contextMenuStripSaving
            // 
            this.contextMenuStripSaving.Name = "contextMenuStripSaving";
            resources.ApplyResources(this.contextMenuStripSaving, "contextMenuStripSaving");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.BackColor = System.Drawing.Color.Gainsboro;
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxCivilities, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelEconomicActivity, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panelBottom
            // 
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Controls.Add(this.tabControlEconomicInfo);
            this.panelBottom.Name = "panelBottom";
            // 
            // tabControlEconomicInfo
            // 
            this.tabControlEconomicInfo.Controls.Add(this.tabPageAddress);
            this.tabControlEconomicInfo.Controls.Add(this.tabPage1FollowUp);
            this.tabControlEconomicInfo.Controls.Add(this.tabPageProjects);
            this.tabControlEconomicInfo.Controls.Add(this.tabPageSavings);
            this.tabControlEconomicInfo.Controls.Add(this.tabPageGroupMember);
            resources.ApplyResources(this.tabControlEconomicInfo, "tabControlEconomicInfo");
            this.tabControlEconomicInfo.ImageList = this.imageListEconomicInfo;
            this.tabControlEconomicInfo.Name = "tabControlEconomicInfo";
            this.tabControlEconomicInfo.SelectedIndex = 0;
            this.tabControlEconomicInfo.SelectedIndexChanged += new System.EventHandler(this.tabControlEconomicInfo_SelectedIndexChanged);
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.tableLayoutPanelAddress);
            resources.ApplyResources(this.tabPageAddress, "tabPageAddress");
            this.tabPageAddress.Name = "tabPageAddress";
            // 
            // tableLayoutPanelAddress
            // 
            resources.ApplyResources(this.tableLayoutPanelAddress, "tableLayoutPanelAddress");
            this.tableLayoutPanelAddress.Controls.Add(this.groupBoxFirstAddress, 0, 0);
            this.tableLayoutPanelAddress.Controls.Add(this.groupBoxSecondaryAddress, 1, 0);
            this.tableLayoutPanelAddress.Name = "tableLayoutPanelAddress";
            // 
            // groupBoxFirstAddress
            // 
            resources.ApplyResources(this.groupBoxFirstAddress, "groupBoxFirstAddress");
            this.groupBoxFirstAddress.Name = "groupBoxFirstAddress";
            this.groupBoxFirstAddress.TabStop = false;
            // 
            // groupBoxSecondaryAddress
            // 
            resources.ApplyResources(this.groupBoxSecondaryAddress, "groupBoxSecondaryAddress");
            this.groupBoxSecondaryAddress.Name = "groupBoxSecondaryAddress";
            this.groupBoxSecondaryAddress.TabStop = false;
            // 
            // tabPage1FollowUp
            // 
            this.tabPage1FollowUp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1FollowUp.Controls.Add(this.lblAnd2);
            this.tabPage1FollowUp.Controls.Add(this.lblAnd1);
            this.tabPage1FollowUp.Controls.Add(this.textBoxSponsor2);
            this.tabPage1FollowUp.Controls.Add(this.textBoxSponsor1);
            this.tabPage1FollowUp.Controls.Add(this.richTextBoxCommentsActivity);
            this.tabPage1FollowUp.Controls.Add(this.comboBoxSponsor2);
            this.tabPage1FollowUp.Controls.Add(this.comboBoxSponsor1);
            this.tabPage1FollowUp.Controls.Add(this.labelSponsor2);
            this.tabPage1FollowUp.Controls.Add(this.labelCommentsTypeActivity);
            this.tabPage1FollowUp.Controls.Add(this.dateTimePickerFirstAppointment);
            this.tabPage1FollowUp.Controls.Add(this.dateTimePickerFirstContact);
            this.tabPage1FollowUp.Controls.Add(this.labelFirstAppointment);
            this.tabPage1FollowUp.Controls.Add(this.labelFirstContact);
            this.tabPage1FollowUp.Controls.Add(this.labelSponsor1);
            resources.ApplyResources(this.tabPage1FollowUp, "tabPage1FollowUp");
            this.tabPage1FollowUp.Name = "tabPage1FollowUp";
            // 
            // lblAnd2
            // 
            resources.ApplyResources(this.lblAnd2, "lblAnd2");
            this.lblAnd2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnd2.Name = "lblAnd2";
            // 
            // lblAnd1
            // 
            resources.ApplyResources(this.lblAnd1, "lblAnd1");
            this.lblAnd1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnd1.Name = "lblAnd1";
            // 
            // textBoxSponsor2
            // 
            this.textBoxSponsor2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxSponsor2, "textBoxSponsor2");
            this.textBoxSponsor2.Name = "textBoxSponsor2";
            this.textBoxSponsor2.TextChanged += new System.EventHandler(this.textBoxSponsor2_TextChanged);
            // 
            // textBoxSponsor1
            // 
            this.textBoxSponsor1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxSponsor1, "textBoxSponsor1");
            this.textBoxSponsor1.Name = "textBoxSponsor1";
            this.textBoxSponsor1.TextChanged += new System.EventHandler(this.textBoxSponsor1_TextChanged);
            // 
            // richTextBoxCommentsActivity
            // 
            this.richTextBoxCommentsActivity.AcceptsTab = true;
            resources.ApplyResources(this.richTextBoxCommentsActivity, "richTextBoxCommentsActivity");
            this.richTextBoxCommentsActivity.Name = "richTextBoxCommentsActivity";
            this.richTextBoxCommentsActivity.TextChanged += new System.EventHandler(this.richTextBoxCommentsActivity_TextChanged);
            // 
            // comboBoxSponsor2
            // 
            this.comboBoxSponsor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSponsor2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSponsor2, "comboBoxSponsor2");
            this.comboBoxSponsor2.Name = "comboBoxSponsor2";
            // 
            // comboBoxSponsor1
            // 
            this.comboBoxSponsor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSponsor1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSponsor1, "comboBoxSponsor1");
            this.comboBoxSponsor1.Name = "comboBoxSponsor1";
            // 
            // labelSponsor2
            // 
            resources.ApplyResources(this.labelSponsor2, "labelSponsor2");
            this.labelSponsor2.BackColor = System.Drawing.Color.Transparent;
            this.labelSponsor2.Name = "labelSponsor2";
            // 
            // labelCommentsTypeActivity
            // 
            resources.ApplyResources(this.labelCommentsTypeActivity, "labelCommentsTypeActivity");
            this.labelCommentsTypeActivity.BackColor = System.Drawing.Color.Transparent;
            this.labelCommentsTypeActivity.Name = "labelCommentsTypeActivity";
            // 
            // dateTimePickerFirstAppointment
            // 
            this.dateTimePickerFirstAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dateTimePickerFirstAppointment, "dateTimePickerFirstAppointment");
            this.dateTimePickerFirstAppointment.Name = "dateTimePickerFirstAppointment";
            // 
            // dateTimePickerFirstContact
            // 
            this.dateTimePickerFirstContact.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dateTimePickerFirstContact, "dateTimePickerFirstContact");
            this.dateTimePickerFirstContact.Name = "dateTimePickerFirstContact";
            // 
            // labelFirstAppointment
            // 
            resources.ApplyResources(this.labelFirstAppointment, "labelFirstAppointment");
            this.labelFirstAppointment.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstAppointment.Name = "labelFirstAppointment";
            // 
            // labelFirstContact
            // 
            resources.ApplyResources(this.labelFirstContact, "labelFirstContact");
            this.labelFirstContact.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstContact.Name = "labelFirstContact";
            // 
            // labelSponsor1
            // 
            resources.ApplyResources(this.labelSponsor1, "labelSponsor1");
            this.labelSponsor1.BackColor = System.Drawing.Color.Transparent;
            this.labelSponsor1.Name = "labelSponsor1";
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.tabPageProjects, "tabPageProjects");
            this.tabPageProjects.Name = "tabPageProjects";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewProjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxProjects);
            // 
            // listViewProjects
            // 
            this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderCode,
            this.columnHeaderName,
            this.columnHeaderNbOfCredits,
            this.columnHeaderNbOfGuarantees});
            resources.ApplyResources(this.listViewProjects, "listViewProjects");
            this.listViewProjects.FullRowSelect = true;
            this.listViewProjects.GridLines = true;
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.UseCompatibleStateImageBehavior = false;
            this.listViewProjects.View = System.Windows.Forms.View.Details;
            this.listViewProjects.DoubleClick += new System.EventHandler(this.listViewProjects_DoubleClick);
            // 
            // columnHeaderId
            // 
            resources.ApplyResources(this.columnHeaderId, "columnHeaderId");
            // 
            // columnHeaderCode
            // 
            resources.ApplyResources(this.columnHeaderCode, "columnHeaderCode");
            // 
            // columnHeaderName
            // 
            resources.ApplyResources(this.columnHeaderName, "columnHeaderName");
            // 
            // columnHeaderNbOfCredits
            // 
            resources.ApplyResources(this.columnHeaderNbOfCredits, "columnHeaderNbOfCredits");
            // 
            // columnHeaderNbOfGuarantees
            // 
            resources.ApplyResources(this.columnHeaderNbOfGuarantees, "columnHeaderNbOfGuarantees");
            // 
            // groupBoxProjects
            // 
            this.groupBoxProjects.Controls.Add(this.buttonViewProject);
            this.groupBoxProjects.Controls.Add(this.buttonAddProject);
            resources.ApplyResources(this.groupBoxProjects, "groupBoxProjects");
            this.groupBoxProjects.Name = "groupBoxProjects";
            this.groupBoxProjects.TabStop = false;
            // 
            // buttonViewProject
            // 
            resources.ApplyResources(this.buttonViewProject, "buttonViewProject");
            this.buttonViewProject.Name = "buttonViewProject";
            this.buttonViewProject.Click += new System.EventHandler(this.buttonViewProject_Click);
            // 
            // buttonAddProject
            // 
            resources.ApplyResources(this.buttonAddProject, "buttonAddProject");
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Click += new System.EventHandler(this.buttonAddProject_Click);
            // 
            // tabPageSavings
            // 
            this.tabPageSavings.Controls.Add(this.clSavingList);
            resources.ApplyResources(this.tabPageSavings, "tabPageSavings");
            this.tabPageSavings.Name = "tabPageSavings";
            // 
            // tabPageGroupMember
            // 
            this.tabPageGroupMember.Controls.Add(this.listViewGroup);
            resources.ApplyResources(this.tabPageGroupMember, "tabPageGroupMember");
            this.tabPageGroupMember.Name = "tabPageGroupMember";
            // 
            // listViewGroup
            // 
            this.listViewGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader2,
            this.columnHeader11,
            this.columnHeader12});
            resources.ApplyResources(this.listViewGroup, "listViewGroup");
            this.listViewGroup.FullRowSelect = true;
            this.listViewGroup.GridLines = true;
            this.listViewGroup.Name = "listViewGroup";
            this.listViewGroup.UseCompatibleStateImageBehavior = false;
            this.listViewGroup.View = System.Windows.Forms.View.Details;
            this.listViewGroup.DoubleClick += new System.EventHandler(this.listViewGroup_DoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // groupBoxCivilities
            // 
            this.groupBoxCivilities.Controls.Add(this.lblBranch);
            this.groupBoxCivilities.Controls.Add(this.lblEconomicActivity);
            this.groupBoxCivilities.Controls.Add(this.eacPerson);
            this.groupBoxCivilities.Controls.Add(this.cbBranch);
            this.groupBoxCivilities.Controls.Add(this.textBoxNationality);
            this.groupBoxCivilities.Controls.Add(this.labelNationality);
            this.groupBoxCivilities.Controls.Add(this.textBoxLoanCycle);
            this.groupBoxCivilities.Controls.Add(this.textBoxBirthPlace);
            this.groupBoxCivilities.Controls.Add(this.labelIN);
            this.groupBoxCivilities.Controls.Add(this.labelLoanCycle);
            this.groupBoxCivilities.Controls.Add(this.labelRangeOfAge);
            this.groupBoxCivilities.Controls.Add(this.textBoxFatherName);
            this.groupBoxCivilities.Controls.Add(this.labelFatherName);
            this.groupBoxCivilities.Controls.Add(this.changePhotoLinkLabel2);
            this.groupBoxCivilities.Controls.Add(this.changePhotoLinkLabel);
            this.groupBoxCivilities.Controls.Add(this.pictureBox2);
            this.groupBoxCivilities.Controls.Add(this.pictureBox);
            this.groupBoxCivilities.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupBoxCivilities.Controls.Add(this.checkBoxHeadOfHousehold);
            this.groupBoxCivilities.Controls.Add(this.labelDateOfBirth);
            this.groupBoxCivilities.Controls.Add(this.textBoxLastname);
            this.groupBoxCivilities.Controls.Add(this.labelLastname);
            this.groupBoxCivilities.Controls.Add(this.textBoxIdentificationData);
            this.groupBoxCivilities.Controls.Add(this.labelPassport);
            this.groupBoxCivilities.Controls.Add(this.comboBoxSex);
            this.groupBoxCivilities.Controls.Add(this.labelSex);
            this.groupBoxCivilities.Controls.Add(this.labelFirstName);
            this.groupBoxCivilities.Controls.Add(this.textBoxFirstName);
            resources.ApplyResources(this.groupBoxCivilities, "groupBoxCivilities");
            this.groupBoxCivilities.Name = "groupBoxCivilities";
            this.groupBoxCivilities.TabStop = false;
            // 
            // lblBranch
            // 
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblBranch, "lblBranch");
            this.lblBranch.Name = "lblBranch";
            // 
            // lblEconomicActivity
            // 
            resources.ApplyResources(this.lblEconomicActivity, "lblEconomicActivity");
            this.lblEconomicActivity.BackColor = System.Drawing.Color.Transparent;
            this.lblEconomicActivity.Name = "lblEconomicActivity";
            // 
            // cbBranch
            // 
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.FormattingEnabled = true;
            resources.ApplyResources(this.cbBranch, "cbBranch");
            this.cbBranch.Name = "cbBranch";
            // 
            // labelNationality
            // 
            this.labelNationality.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelNationality, "labelNationality");
            this.labelNationality.Name = "labelNationality";
            // 
            // textBoxLoanCycle
            // 
            resources.ApplyResources(this.textBoxLoanCycle, "textBoxLoanCycle");
            this.textBoxLoanCycle.Name = "textBoxLoanCycle";
            this.textBoxLoanCycle.TextChanged += new System.EventHandler(this.textBoxLoanCycle_TextChanged);
            // 
            // labelIN
            // 
            this.labelIN.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelIN, "labelIN");
            this.labelIN.Name = "labelIN";
            // 
            // labelLoanCycle
            // 
            this.labelLoanCycle.AllowDrop = true;
            resources.ApplyResources(this.labelLoanCycle, "labelLoanCycle");
            this.labelLoanCycle.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanCycle.Name = "labelLoanCycle";
            // 
            // labelRangeOfAge
            // 
            resources.ApplyResources(this.labelRangeOfAge, "labelRangeOfAge");
            this.labelRangeOfAge.BackColor = System.Drawing.Color.Transparent;
            this.labelRangeOfAge.Name = "labelRangeOfAge";
            // 
            // labelFatherName
            // 
            this.labelFatherName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelFatherName, "labelFatherName");
            this.labelFatherName.Name = "labelFatherName";
            // 
            // changePhotoLinkLabel2
            // 
            this.changePhotoLinkLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.changePhotoLinkLabel2, "changePhotoLinkLabel2");
            this.changePhotoLinkLabel2.Name = "changePhotoLinkLabel2";
            this.changePhotoLinkLabel2.TabStop = true;
            this.changePhotoLinkLabel2.UseCompatibleTextRendering = true;
            this.changePhotoLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // changePhotoLinkLabel
            // 
            this.changePhotoLinkLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.changePhotoLinkLabel, "changePhotoLinkLabel");
            this.changePhotoLinkLabel.Name = "changePhotoLinkLabel";
            this.changePhotoLinkLabel.TabStop = true;
            this.changePhotoLinkLabel.UseCompatibleTextRendering = true;
            this.changePhotoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // dateTimePickerDateOfBirth
            // 
            resources.ApplyResources(this.dateTimePickerDateOfBirth, "dateTimePickerDateOfBirth");
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2009, 10, 7, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfBirth_ValueChanged);
            // 
            // checkBoxHeadOfHousehold
            // 
            resources.ApplyResources(this.checkBoxHeadOfHousehold, "checkBoxHeadOfHousehold");
            this.checkBoxHeadOfHousehold.Name = "checkBoxHeadOfHousehold";
            this.checkBoxHeadOfHousehold.CheckedChanged += new System.EventHandler(this.checkBoxHeadOfHousehold_CheckedChanged);
            // 
            // labelDateOfBirth
            // 
            resources.ApplyResources(this.labelDateOfBirth, "labelDateOfBirth");
            this.labelDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            // 
            // labelLastname
            // 
            resources.ApplyResources(this.labelLastname, "labelLastname");
            this.labelLastname.BackColor = System.Drawing.Color.Transparent;
            this.labelLastname.Name = "labelLastname";
            // 
            // labelPassport
            // 
            resources.ApplyResources(this.labelPassport, "labelPassport");
            this.labelPassport.BackColor = System.Drawing.Color.Transparent;
            this.labelPassport.Name = "labelPassport";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.Color.White;
            this.comboBoxSex.DisplayMember = "Value";
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxSex, "comboBoxSex");
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.ValueMember = "Key";
            this.comboBoxSex.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSex_SelectionChangeCommitted);
            // 
            // labelSex
            // 
            resources.ApplyResources(this.labelSex, "labelSex");
            this.labelSex.BackColor = System.Drawing.Color.Transparent;
            this.labelSex.Name = "labelSex";
            // 
            // labelFirstName
            // 
            resources.ApplyResources(this.labelFirstName, "labelFirstName");
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Name = "labelFirstName";
            // 
            // panelEconomicActivity
            // 
            this.panelEconomicActivity.Controls.Add(this.btnPrint);
            this.panelEconomicActivity.Controls.Add(this.buttonCancel);
            this.panelEconomicActivity.Controls.Add(this.buttonSave);
            resources.ApplyResources(this.panelEconomicActivity, "panelEconomicActivity");
            this.panelEconomicActivity.Name = "panelEconomicActivity";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // clSavingList
            // 
            this.clSavingList.ButtonAddSavingsEnabled = true;
            this.clSavingList.ClientType = OpenCBS.Enums.OClientTypes.Person;
            resources.ApplyResources(this.clSavingList, "clSavingList");
            this.clSavingList.Name = "clSavingList";
            this.clSavingList.AddSelectedSaving += new System.EventHandler(this.savingsListUserControl_AddSelectedSaving);
            this.clSavingList.ViewSelectedSaving += new System.EventHandler(this.savingsListUserControl_ViewSelectedSaving);
            // 
            // eacPerson
            // 
            this.eacPerson.Activity = null;
            resources.ApplyResources(this.eacPerson, "eacPerson");
            this.eacPerson.IsLoanPurpose = false;
            this.eacPerson.Name = "eacPerson";
            this.eacPerson.EconomicActivityChange += new System.EventHandler<OpenCBS.GUI.UserControl.EconomicActivtyEventArgs>(this.EacPersonActivityChange);
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxNationality, "textBoxNationality");
            this.textBoxNationality.Name = "textBoxNationality";
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxBirthPlace, "textBoxBirthPlace");
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.TextChanged += new System.EventHandler(this.textBoxBirthPlace_TextChanged);
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxFatherName, "textBoxFatherName");
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.TextChanged += new System.EventHandler(this.textBoxFatherName_TextChanged);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxLastname, "textBoxLastname");
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.TextChanged += new System.EventHandler(this.textBoxLastname_TextChanged);
            // 
            // textBoxIdentificationData
            // 
            this.textBoxIdentificationData.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxIdentificationData, "textBoxIdentificationData");
            this.textBoxIdentificationData.Name = "textBoxIdentificationData";
            this.textBoxIdentificationData.Leave += new System.EventHandler(this.textBoxIdentificationData_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxFirstName, "textBoxFirstName");
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.AttachmentPoint = OpenCBS.Reports.AttachmentPoint.PersonDetails;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ReportInitializer = null;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visibility = OpenCBS.Reports.Visibility.Individual;
            // 
            // PersonUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "PersonUserControl";
            this.Load += new System.EventHandler(this.PersonUserControl_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBoxProjectButton.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.tabControlEconomicInfo.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.tableLayoutPanelAddress.ResumeLayout(false);
            this.tabPage1FollowUp.ResumeLayout(false);
            this.tabPage1FollowUp.PerformLayout();
            this.tabPageProjects.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxProjects.ResumeLayout(false);
            this.tabPageSavings.ResumeLayout(false);
            this.tabPageGroupMember.ResumeLayout(false);
            this.groupBoxCivilities.ResumeLayout(false);
            this.groupBoxCivilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelEconomicActivity.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button button9;
        private Button button10;
        private ContextMenuStrip contextMenuStripSaving;
        private SplitContainer splitContainer3;
        private ListView listViewContracts;
        private ColumnHeader columnProductType;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeaderStatus;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderInterestRate;
        private ColumnHeader columnHeaderInstallmentType;
        private ColumnHeader columnHeaderNbOfInstallments;
        private ColumnHeader columnHeaderCreationDate;
        private ColumnHeader columnHeaderStartDate;
        private ColumnHeader columnHeaderCloseDate;
        private GroupBox groupBoxProjectButton;
        private Button buttonProjectAddGuarantee;
        private Button buttonProjectViewContract;
        private Button buttonProjectAddContract;
        private Button button11;
        private Button button12;
        private Button button13;
        private LinkLabel changePhotoLinkLabel2;
        public PictureBox pictureBox;
        public PictureBox pictureBox2;
        private ComboBox cbBranch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private PrintButton btnPrint;
        private TabControl tabControlEconomicInfo;
        private TabPage tabPageAddress;
        private TableLayoutPanel tableLayoutPanelAddress;
        private GroupBox groupBoxFirstAddress;
        private GroupBox groupBoxSecondaryAddress;
        private TabPage tabPage1FollowUp;
        private Label lblAnd2;
        private Label lblAnd1;
        private TextBox textBoxSponsor2;
        private TextBox textBoxSponsor1;
        private RichTextBox richTextBoxCommentsActivity;
        private ComboBox comboBoxSponsor2;
        private ComboBox comboBoxSponsor1;
        private Label labelSponsor2;
        private Label labelCommentsTypeActivity;
        private DateTimePicker dateTimePickerFirstAppointment;
        private DateTimePicker dateTimePickerFirstContact;
        private Label labelFirstAppointment;
        private Label labelFirstContact;
        private Label labelSponsor1;
        private TabPage tabPageProjects;
        private SplitContainer splitContainer1;
        private ListView listViewProjects;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderCode;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderNbOfCredits;
        private ColumnHeader columnHeaderNbOfGuarantees;
        private GroupBox groupBoxProjects;
        private System.Windows.Forms.Button buttonViewProject;
        private System.Windows.Forms.Button buttonAddProject;
        private TabPage tabPageSavings;
        private SavingsListUserControl clSavingList;
        private TabPage tabPageGroupMember;
        private ListView listViewGroup;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private EconomicActivityControl eacPerson;
        private Label lblEconomicActivity;
        private Label lblBranch;
    }
}
