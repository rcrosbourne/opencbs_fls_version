
using System.ComponentModel;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Products
{
    public partial class FrmAddLoanProduct
    {
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private IContainer components;
        private TabPage tabPageMainParameters;
        private TabPage tabPageOptionalParameters;
        private Label labelName;
        private TextBox textBoxRateMax;
        private TextBox textBoxRate;
        private TextBox textBoxRateMin;
        private GroupBox groupBoxGracePeriod;
        private GroupBox groupBoxNumberOfInstallments;
        private GroupBox groupBoxInterestRate;
        private TextBox textBoxNbOfInstallmentMax;
        private TextBox textBoxNbOfInstallment;
        private TextBox textBoxNbOfInstallmentMin;
        private TextBox textBoxGracePeriodMax;
        private TextBox textBoxGracePeriod;
        private TextBox textBoxGracePeriodMin;
        private ComboBox comboBoxExoticProduct;
        private ComboBox comboBoxInstallmentType;
        private GroupBox groupBoxExoticProducts;
        private Label labelNbIMax;
        private Label labelNbIMin;
        private Label labelNbIOr;
        private Label labelGPOr;
        private Label labelInstallmentType;
        private Label labelRateMax;
        private Label labelRateMin;
        private Label labelRateOr;
        private TabControl tabCreditInsurance;
        private TextBox textBoxName;
        private Label labelGPMin;
        private Label labelGPMax;
        private GroupBox groupBox1;
        private CheckBox checkBoxUseExceptionalInstallmen;
        private Label label6;
        private GroupBox groupBox;
        private GroupBox groupBoxInterestRateType;
        private GroupBox groupBoxType;
        private GroupBox groupBoxChargeInterestWithinGracePeriod;
        private RadioButton radioButtonChargeInterestNo;
        private RadioButton radioButtonChargeInterestYes;
        private GroupBox groupBox2;
        private GroupBox groupBoxDetailsOptionalParameters;
        private Splitter splitter2;
        private GroupBox groupBox4;
        private Panel panelExoticProduct;
        private System.Windows.Forms.Button buttonCancelExoticProduct;
        private System.Windows.Forms.Button buttonSaveExoticProduct;
        private GroupBox groupBoxExoticInstallmentProperties;
        private Panel panelExoticInstallment;
        private TextBox textBoxExoticInstallmentInterest;
        private TextBox textBoxExoticInstallmentPrincipal;
        private Label label9;
        private Label label10;
        private Panel panelExoticProductNavigationButtons;
        private System.Windows.Forms.Button buttonDecreaseExoticInstallment;
        private System.Windows.Forms.Button buttonIncreaseExoticInstallment;
        private System.Windows.Forms.Button buttonRemoveExoticInstallment;
        private System.Windows.Forms.Button buttonAddExoticInstallment;
        private ListView listViewExoticInstallments;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label12;
        private Label label11;
        private Label labelTotalInterest;
        private Label labelTotalPrincipal;
        private Label labelTotalExoticInstallments;
        private Panel panel1;
        private TabPage tabPageFees;
        private GroupBox groupBox8;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox tBInitialAmountMax;
        private TextBox tBInitialAmountValue;
        private TextBox tBInitialAmountMin;
        private GroupBox groupBox7;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox tBOLBMax;
        private TextBox tBOLBValue;
        private TextBox tBOLBMin;
        private GroupBox groupBox6;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox tBOverdueInterestMax;
        private TextBox tBOverdueInterestValue;
        private TextBox tBOverdueInterestMin;
        private GroupBox groupBox5;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tBOverduePrincipalMax;
        private TextBox tBOverduePrincipalValue;
        private TextBox tBOverduePrincipalMin;
        private GroupBox groupBoxLateFees;
        private RadioButton radioButtonAmountCycle;
        private RadioButton radioButtonSpecifiedAmount;
        private GroupBox groupBoxAmount;
        private Label labelLoanCycle;
        private Label labelLoanCycleMax;
        private Label labelLoanCycleMin;
        private Label labelAmountMax;
        private Label labelAmountMin;
        private Label labelAmountOr;
        private TextBox textBoxAmountMax;
        private TextBox textBoxAmount;
        private TextBox textBoxAmountMin;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label8;
        private Label label1;
        private GroupBox groupBox3;
        private Label label7;
        private GroupBox groupBoxAmountCycles;
        private Panel panelAmountCycles;
        private System.Windows.Forms.Button buttonRemoveAmountCycles;
        private System.Windows.Forms.Button buttonCancelAmountCycles;
        private System.Windows.Forms.Button buttonAddAmountCycle;
        private System.Windows.Forms.Button buttonAmountCyclesSave;
        private GroupBox groupBoxAmountCycle;
        private TextBox textBoxCycleMax;
        private TextBox textBoxCycleMin;
        private Label label29;
        private Label label30;
        private Label label31;
        private System.Windows.Forms.Button buttonNewAmountCycles;
        private ComboBox comboBoxLoanCyclesName;
        private GroupBox groupBox10;
        private ComboBox comboBoxFundingLine;
        private Label label32;
        private TextBox textBoxCode;

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLoanProduct));
            this.tabCreditInsurance = new System.Windows.Forms.TabControl();
            this.tabPageMainParameters = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.gbAdvancedParameters = new System.Windows.Forms.GroupBox();
            this.cbUseLoanCycle = new System.Windows.Forms.CheckBox();
            this.groupBoxNumberOfInstallments = new System.Windows.Forms.GroupBox();
            this.labelNbIMax = new System.Windows.Forms.Label();
            this.labelNbIMin = new System.Windows.Forms.Label();
            this.labelNbIOr = new System.Windows.Forms.Label();
            this.textBoxNbOfInstallmentMax = new System.Windows.Forms.TextBox();
            this.textBoxNbOfInstallment = new System.Windows.Forms.TextBox();
            this.textBoxNbOfInstallmentMin = new System.Windows.Forms.TextBox();
            this.groupBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.labelRateMax = new System.Windows.Forms.Label();
            this.labelRateMin = new System.Windows.Forms.Label();
            this.labelRateOr = new System.Windows.Forms.Label();
            this.textBoxRateMax = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxRateMin = new System.Windows.Forms.TextBox();
            this.groupBoxAmount = new System.Windows.Forms.GroupBox();
            this.labelLoanCycle = new System.Windows.Forms.Label();
            this.labelLoanCycleMax = new System.Windows.Forms.Label();
            this.labelLoanCycleMin = new System.Windows.Forms.Label();
            this.labelAmountMax = new System.Windows.Forms.Label();
            this.labelAmountMin = new System.Windows.Forms.Label();
            this.labelAmountOr = new System.Windows.Forms.Label();
            this.textBoxAmountMax = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxAmountMin = new System.Windows.Forms.TextBox();
            this.panelAmountCycles = new System.Windows.Forms.Panel();
            this.groupBoxAmountCycle = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxCycleMax = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxCycleMin = new System.Windows.Forms.TextBox();
            this.cbxCycleObjects = new System.Windows.Forms.ComboBox();
            this.listViewLoanCycles = new OpenCBS.GUI.UserControl.ListViewEx();
            this.colCycle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveAmountCycles = new System.Windows.Forms.Button();
            this.buttonAmountCyclesSave = new System.Windows.Forms.Button();
            this.buttonCancelAmountCycles = new System.Windows.Forms.Button();
            this.buttonAddAmountCycle = new System.Windows.Forms.Button();
            this.lblCycleObjects = new System.Windows.Forms.Label();
            this.groupBoxAmountCycles = new System.Windows.Forms.GroupBox();
            this.comboBoxLoanCyclesName = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.buttonNewAmountCycles = new System.Windows.Forms.Button();
            this.groupBoxRoundingType = new System.Windows.Forms.GroupBox();
            this.cmbInterestScheme = new System.Windows.Forms.ComboBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
            this.comboBoxFundingLine = new System.Windows.Forms.ComboBox();
            this.groupBoxChargeInterestWithinGracePeriod = new System.Windows.Forms.GroupBox();
            this.radioButtonChargeInterestNo = new System.Windows.Forms.RadioButton();
            this.radioButtonChargeInterestYes = new System.Windows.Forms.RadioButton();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.clientTypeIndivCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeVillageCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeCorpCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTypeAllCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBoxInterestRateType = new System.Windows.Forms.GroupBox();
            this.cmbInterestRateType = new System.Windows.Forms.ComboBox();
            this.groupBoxGracePeriod = new System.Windows.Forms.GroupBox();
            this.labelGPMax = new System.Windows.Forms.Label();
            this.labelGPMin = new System.Windows.Forms.Label();
            this.labelGPOr = new System.Windows.Forms.Label();
            this.textBoxGracePeriodMax = new System.Windows.Forms.TextBox();
            this.textBoxGracePeriod = new System.Windows.Forms.TextBox();
            this.textBoxGracePeriodMin = new System.Windows.Forms.TextBox();
            this.comboBoxInstallmentType = new System.Windows.Forms.ComboBox();
            this.labelInstallmentType = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageFees = new System.Windows.Forms.TabPage();
            this.gbAnticipatedRepayment = new System.Windows.Forms.GroupBox();
            this.groupBoxAPR = new System.Windows.Forms.GroupBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxAnticipatedPartialRepaimentMax = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBoxAnticipatedPartialRepaiment = new System.Windows.Forms.TextBox();
            this.textBoxAnticipatedPartialRepaimentMin = new System.Windows.Forms.TextBox();
            this.groupBoxPartialAnticipatedRepaymentBase = new System.Windows.Forms.GroupBox();
            this.rbPrepaidPrincipal = new System.Windows.Forms.RadioButton();
            this.rbPartialRemainingOLB = new System.Windows.Forms.RadioButton();
            this.rbPartialRemainingInterest = new System.Windows.Forms.RadioButton();
            this.groupBoxTotalAnticipatedRepaymentBase = new System.Windows.Forms.GroupBox();
            this.rbRemainingOLB = new System.Windows.Forms.RadioButton();
            this.rbRemainingInterest = new System.Windows.Forms.RadioButton();
            this.groupBoxAnticipatedRepayment = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnticipatedRepaymentPenaltiesMax = new System.Windows.Forms.TextBox();
            this.textBoxAnticipatedRepaymentPenalties = new System.Windows.Forms.TextBox();
            this.textBoxAnticipatedRepaymentPenaltiesMin = new System.Windows.Forms.TextBox();
            this.groupBoxLateFees = new System.Windows.Forms.GroupBox();
            this.labelLateFeeGracePeriod = new System.Windows.Forms.Label();
            this.textBoxGracePeriodLateFee = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tBInitialAmountMax = new System.Windows.Forms.TextBox();
            this.tBInitialAmountValue = new System.Windows.Forms.TextBox();
            this.tBInitialAmountMin = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tBOverduePrincipalMax = new System.Windows.Forms.TextBox();
            this.tBOverduePrincipalValue = new System.Windows.Forms.TextBox();
            this.tBOverduePrincipalMin = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tBOLBMax = new System.Windows.Forms.TextBox();
            this.tBOLBValue = new System.Windows.Forms.TextBox();
            this.tBOLBMin = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tBOverdueInterestMax = new System.Windows.Forms.TextBox();
            this.tBOverdueInterestValue = new System.Windows.Forms.TextBox();
            this.tBOverdueInterestMin = new System.Windows.Forms.TextBox();
            this.groupBoxEntryFees = new System.Windows.Forms.GroupBox();
            this.swbtnEntryFeesRemoveCycle = new System.Windows.Forms.Button();
            this.swbtnEntryFeesAddCycle = new System.Windows.Forms.Button();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.cbxRate = new System.Windows.Forms.CheckBox();
            this.tbEntryFeesValues = new System.Windows.Forms.TextBox();
            this.lvEntryFees = new OpenCBS.GUI.UserControl.ListViewEx();
            this.chEntryFeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeIsAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeCycleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeNewId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntryFeeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudEntryFeescycleFrom = new System.Windows.Forms.NumericUpDown();
            this.lblEntryFeesFromCycle = new System.Windows.Forms.Label();
            this.cbEnableEntryFeesCycle = new System.Windows.Forms.CheckBox();
            this.lblEntryFeesCycle = new System.Windows.Forms.Label();
            this.cmbEntryFeesCycles = new System.Windows.Forms.ComboBox();
            this.tabPageOptionalParameters = new System.Windows.Forms.TabPage();
            this.groupBoxDetailsOptionalParameters = new System.Windows.Forms.GroupBox();
            this.groupBoxExoticProducts = new System.Windows.Forms.GroupBox();
            this.panelExoticProduct = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalInterest = new System.Windows.Forms.Label();
            this.labelTotalPrincipal = new System.Windows.Forms.Label();
            this.labelTotalExoticInstallments = new System.Windows.Forms.Label();
            this.buttonCancelExoticProduct = new System.Windows.Forms.Button();
            this.buttonSaveExoticProduct = new System.Windows.Forms.Button();
            this.groupBoxExoticInstallmentProperties = new System.Windows.Forms.GroupBox();
            this.panelExoticInstallment = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxExoticInstallmentInterest = new System.Windows.Forms.TextBox();
            this.textBoxExoticInstallmentPrincipal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelExoticProductNavigationButtons = new System.Windows.Forms.Panel();
            this.buttonDecreaseExoticInstallment = new System.Windows.Forms.Button();
            this.buttonIncreaseExoticInstallment = new System.Windows.Forms.Button();
            this.buttonRemoveExoticInstallment = new System.Windows.Forms.Button();
            this.buttonAddExoticInstallment = new System.Windows.Forms.Button();
            this.listViewExoticInstallments = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNewExoticProduct = new System.Windows.Forms.Button();
            this.comboBoxExoticProduct = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseExceptionalInstallmen = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.checkBoxFlexPackage = new System.Windows.Forms.CheckBox();
            this.tabLOC = new System.Windows.Forms.TabPage();
            this.drawNumGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfDrawings = new System.Windows.Forms.TextBox();
            this.drawingNumberLabel = new System.Windows.Forms.Label();
            this.useLOCCheckBox = new System.Windows.Forms.CheckBox();
            this.maxLOCMaturityGroupBox = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBoxLOCMaturityMax = new System.Windows.Forms.TextBox();
            this.textBoxLOCMaturity = new System.Windows.Forms.TextBox();
            this.textBoxLOCMaturityMin = new System.Windows.Forms.TextBox();
            this.maxLOCAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.labelLOCAmount = new System.Windows.Forms.Label();
            this.labelLOCMaxAmount = new System.Windows.Forms.Label();
            this.labelLOCMinAmount = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxAmountUnderLOCMax = new System.Windows.Forms.TextBox();
            this.textBoxAmountUnderLOC = new System.Windows.Forms.TextBox();
            this.textBoxAmountUnderLOCMin = new System.Windows.Forms.TextBox();
            this.tabGuarantorsCollaterals = new System.Windows.Forms.TabPage();
            this.cbUseCompulsorySavings = new System.Windows.Forms.CheckBox();
            this.gbCSAmount = new System.Windows.Forms.GroupBox();
            this.rbCompulsoryAmountRate = new System.Windows.Forms.RadioButton();
            this.rbCompulsoryAmountFlat = new System.Windows.Forms.RadioButton();
            this.lbCompulsoryAmountType = new System.Windows.Forms.Label();
            this.lbCompulsoryAmountValue = new System.Windows.Forms.Label();
            this.lbCompulsoryAmountMax = new System.Windows.Forms.Label();
            this.lbCompulsoryAmountMin = new System.Windows.Forms.Label();
            this.lbCompulsoryAmountOr = new System.Windows.Forms.Label();
            this.txbCompulsoryAmountMax = new System.Windows.Forms.TextBox();
            this.txbCompulsoryAmountValue = new System.Windows.Forms.TextBox();
            this.txbCompulsoryAmountMin = new System.Windows.Forms.TextBox();
            this.checkBoxSetSepCollGuar = new System.Windows.Forms.CheckBox();
            this.groupBoxTotGuarColl = new System.Windows.Forms.GroupBox();
            this.textBoxCollGuar = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBoxSepGuarColl = new System.Windows.Forms.GroupBox();
            this.textBoxColl = new System.Windows.Forms.TextBox();
            this.textBoxGuar = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.labelMinPercColl = new System.Windows.Forms.Label();
            this.labelMinPercGuar = new System.Windows.Forms.Label();
            this.checkBoxGuarCollRequired = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.tbCreditInsuranceMax = new System.Windows.Forms.TextBox();
            this.tbCreditInsuranceMin = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.entryFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.radioButtonAmountCycle = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecifiedAmount = new System.Windows.Forms.RadioButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabCreditInsurance.SuspendLayout();
            this.tabPageMainParameters.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.gbAdvancedParameters.SuspendLayout();
            this.groupBoxNumberOfInstallments.SuspendLayout();
            this.groupBoxInterestRate.SuspendLayout();
            this.groupBoxAmount.SuspendLayout();
            this.panelAmountCycles.SuspendLayout();
            this.groupBoxAmountCycle.SuspendLayout();
            this.groupBoxAmountCycles.SuspendLayout();
            this.groupBoxRoundingType.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBoxChargeInterestWithinGracePeriod.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxInterestRateType.SuspendLayout();
            this.groupBoxGracePeriod.SuspendLayout();
            this.tabPageFees.SuspendLayout();
            this.gbAnticipatedRepayment.SuspendLayout();
            this.groupBoxAPR.SuspendLayout();
            this.groupBoxPartialAnticipatedRepaymentBase.SuspendLayout();
            this.groupBoxTotalAnticipatedRepaymentBase.SuspendLayout();
            this.groupBoxAnticipatedRepayment.SuspendLayout();
            this.groupBoxLateFees.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxEntryFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntryFeescycleFrom)).BeginInit();
            this.tabPageOptionalParameters.SuspendLayout();
            this.groupBoxDetailsOptionalParameters.SuspendLayout();
            this.groupBoxExoticProducts.SuspendLayout();
            this.panelExoticProduct.SuspendLayout();
            this.groupBoxExoticInstallmentProperties.SuspendLayout();
            this.panelExoticInstallment.SuspendLayout();
            this.panelExoticProductNavigationButtons.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabLOC.SuspendLayout();
            this.drawNumGroupBox.SuspendLayout();
            this.maxLOCMaturityGroupBox.SuspendLayout();
            this.maxLOCAmountGroupBox.SuspendLayout();
            this.tabGuarantorsCollaterals.SuspendLayout();
            this.gbCSAmount.SuspendLayout();
            this.groupBoxTotGuarColl.SuspendLayout();
            this.groupBoxSepGuarColl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryFeeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCreditInsurance
            // 
            this.tabCreditInsurance.Controls.Add(this.tabPageMainParameters);
            this.tabCreditInsurance.Controls.Add(this.tabPageFees);
            this.tabCreditInsurance.Controls.Add(this.tabPageOptionalParameters);
            this.tabCreditInsurance.Controls.Add(this.tabLOC);
            this.tabCreditInsurance.Controls.Add(this.tabGuarantorsCollaterals);
            this.tabCreditInsurance.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabCreditInsurance, "tabCreditInsurance");
            this.tabCreditInsurance.Name = "tabCreditInsurance";
            this.tabCreditInsurance.SelectedIndex = 0;
            // 
            // tabPageMainParameters
            // 
            this.tabPageMainParameters.Controls.Add(this.groupBox);
            resources.ApplyResources(this.tabPageMainParameters, "tabPageMainParameters");
            this.tabPageMainParameters.Name = "tabPageMainParameters";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.gbAdvancedParameters);
            this.groupBox.Controls.Add(this.groupBoxRoundingType);
            this.groupBox.Controls.Add(this.textBoxCode);
            this.groupBox.Controls.Add(this.label32);
            this.groupBox.Controls.Add(this.groupBox10);
            this.groupBox.Controls.Add(this.groupBoxChargeInterestWithinGracePeriod);
            this.groupBox.Controls.Add(this.groupBoxType);
            this.groupBox.Controls.Add(this.groupBoxInterestRateType);
            this.groupBox.Controls.Add(this.groupBoxGracePeriod);
            this.groupBox.Controls.Add(this.comboBoxInstallmentType);
            this.groupBox.Controls.Add(this.labelInstallmentType);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.labelName);
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // gbAdvancedParameters
            // 
            this.gbAdvancedParameters.Controls.Add(this.cbUseLoanCycle);
            this.gbAdvancedParameters.Controls.Add(this.groupBoxNumberOfInstallments);
            this.gbAdvancedParameters.Controls.Add(this.groupBoxInterestRate);
            this.gbAdvancedParameters.Controls.Add(this.groupBoxAmount);
            this.gbAdvancedParameters.Controls.Add(this.panelAmountCycles);
            this.gbAdvancedParameters.Controls.Add(this.groupBoxAmountCycles);
            resources.ApplyResources(this.gbAdvancedParameters, "gbAdvancedParameters");
            this.gbAdvancedParameters.Name = "gbAdvancedParameters";
            this.gbAdvancedParameters.TabStop = false;
            // 
            // cbUseLoanCycle
            // 
            resources.ApplyResources(this.cbUseLoanCycle, "cbUseLoanCycle");
            this.cbUseLoanCycle.Name = "cbUseLoanCycle";
            this.cbUseLoanCycle.CheckedChanged += new System.EventHandler(this.cbUseLoanCycle_CheckedChanged);
            // 
            // groupBoxNumberOfInstallments
            // 
            this.groupBoxNumberOfInstallments.Controls.Add(this.labelNbIMax);
            this.groupBoxNumberOfInstallments.Controls.Add(this.labelNbIMin);
            this.groupBoxNumberOfInstallments.Controls.Add(this.labelNbIOr);
            this.groupBoxNumberOfInstallments.Controls.Add(this.textBoxNbOfInstallmentMax);
            this.groupBoxNumberOfInstallments.Controls.Add(this.textBoxNbOfInstallment);
            this.groupBoxNumberOfInstallments.Controls.Add(this.textBoxNbOfInstallmentMin);
            resources.ApplyResources(this.groupBoxNumberOfInstallments, "groupBoxNumberOfInstallments");
            this.groupBoxNumberOfInstallments.Name = "groupBoxNumberOfInstallments";
            this.groupBoxNumberOfInstallments.TabStop = false;
            // 
            // labelNbIMax
            // 
            resources.ApplyResources(this.labelNbIMax, "labelNbIMax");
            this.labelNbIMax.Name = "labelNbIMax";
            // 
            // labelNbIMin
            // 
            resources.ApplyResources(this.labelNbIMin, "labelNbIMin");
            this.labelNbIMin.Name = "labelNbIMin";
            // 
            // labelNbIOr
            // 
            resources.ApplyResources(this.labelNbIOr, "labelNbIOr");
            this.labelNbIOr.Name = "labelNbIOr";
            // 
            // textBoxNbOfInstallmentMax
            // 
            resources.ApplyResources(this.textBoxNbOfInstallmentMax, "textBoxNbOfInstallmentMax");
            this.textBoxNbOfInstallmentMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNbOfInstallmentMax.Name = "textBoxNbOfInstallmentMax";
            this.textBoxNbOfInstallmentMax.Tag = "1";
            this.textBoxNbOfInstallmentMax.TextChanged += new System.EventHandler(this.textBoxNbOfInstallmentMax_TextChanged);
            // 
            // textBoxNbOfInstallment
            // 
            resources.ApplyResources(this.textBoxNbOfInstallment, "textBoxNbOfInstallment");
            this.textBoxNbOfInstallment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNbOfInstallment.Name = "textBoxNbOfInstallment";
            this.textBoxNbOfInstallment.TextChanged += new System.EventHandler(this.textBoxNbOfInstallment_TextChanged);
            // 
            // textBoxNbOfInstallmentMin
            // 
            resources.ApplyResources(this.textBoxNbOfInstallmentMin, "textBoxNbOfInstallmentMin");
            this.textBoxNbOfInstallmentMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNbOfInstallmentMin.Name = "textBoxNbOfInstallmentMin";
            this.textBoxNbOfInstallmentMin.Tag = "1";
            this.textBoxNbOfInstallmentMin.TextChanged += new System.EventHandler(this.textBoxNbOfInstallmentMin_TextChanged);
            // 
            // groupBoxInterestRate
            // 
            this.groupBoxInterestRate.Controls.Add(this.labelRateMax);
            this.groupBoxInterestRate.Controls.Add(this.labelRateMin);
            this.groupBoxInterestRate.Controls.Add(this.labelRateOr);
            this.groupBoxInterestRate.Controls.Add(this.textBoxRateMax);
            this.groupBoxInterestRate.Controls.Add(this.textBoxRate);
            this.groupBoxInterestRate.Controls.Add(this.textBoxRateMin);
            resources.ApplyResources(this.groupBoxInterestRate, "groupBoxInterestRate");
            this.groupBoxInterestRate.Name = "groupBoxInterestRate";
            this.groupBoxInterestRate.TabStop = false;
            // 
            // labelRateMax
            // 
            resources.ApplyResources(this.labelRateMax, "labelRateMax");
            this.labelRateMax.Name = "labelRateMax";
            // 
            // labelRateMin
            // 
            resources.ApplyResources(this.labelRateMin, "labelRateMin");
            this.labelRateMin.Name = "labelRateMin";
            // 
            // labelRateOr
            // 
            resources.ApplyResources(this.labelRateOr, "labelRateOr");
            this.labelRateOr.Name = "labelRateOr";
            // 
            // textBoxRateMax
            // 
            resources.ApplyResources(this.textBoxRateMax, "textBoxRateMax");
            this.textBoxRateMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRateMax.Name = "textBoxRateMax";
            this.textBoxRateMax.Tag = "1";
            this.textBoxRateMax.TextChanged += new System.EventHandler(this.textBoxRateMax_TextChanged);
            // 
            // textBoxRate
            // 
            resources.ApplyResources(this.textBoxRate, "textBoxRate");
            this.textBoxRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.TextChanged += new System.EventHandler(this.textBoxRate_TextChanged);
            // 
            // textBoxRateMin
            // 
            resources.ApplyResources(this.textBoxRateMin, "textBoxRateMin");
            this.textBoxRateMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRateMin.Name = "textBoxRateMin";
            this.textBoxRateMin.Tag = "1";
            this.textBoxRateMin.TextChanged += new System.EventHandler(this.textBoxRateMin_TextChanged);
            // 
            // groupBoxAmount
            // 
            this.groupBoxAmount.Controls.Add(this.labelLoanCycle);
            this.groupBoxAmount.Controls.Add(this.labelLoanCycleMax);
            this.groupBoxAmount.Controls.Add(this.labelLoanCycleMin);
            this.groupBoxAmount.Controls.Add(this.labelAmountMax);
            this.groupBoxAmount.Controls.Add(this.labelAmountMin);
            this.groupBoxAmount.Controls.Add(this.labelAmountOr);
            this.groupBoxAmount.Controls.Add(this.textBoxAmountMax);
            this.groupBoxAmount.Controls.Add(this.textBoxAmount);
            this.groupBoxAmount.Controls.Add(this.textBoxAmountMin);
            resources.ApplyResources(this.groupBoxAmount, "groupBoxAmount");
            this.groupBoxAmount.Name = "groupBoxAmount";
            this.groupBoxAmount.TabStop = false;
            // 
            // labelLoanCycle
            // 
            resources.ApplyResources(this.labelLoanCycle, "labelLoanCycle");
            this.labelLoanCycle.Name = "labelLoanCycle";
            // 
            // labelLoanCycleMax
            // 
            resources.ApplyResources(this.labelLoanCycleMax, "labelLoanCycleMax");
            this.labelLoanCycleMax.Name = "labelLoanCycleMax";
            // 
            // labelLoanCycleMin
            // 
            resources.ApplyResources(this.labelLoanCycleMin, "labelLoanCycleMin");
            this.labelLoanCycleMin.Name = "labelLoanCycleMin";
            // 
            // labelAmountMax
            // 
            resources.ApplyResources(this.labelAmountMax, "labelAmountMax");
            this.labelAmountMax.BackColor = System.Drawing.Color.Transparent;
            this.labelAmountMax.Name = "labelAmountMax";
            // 
            // labelAmountMin
            // 
            resources.ApplyResources(this.labelAmountMin, "labelAmountMin");
            this.labelAmountMin.Name = "labelAmountMin";
            // 
            // labelAmountOr
            // 
            resources.ApplyResources(this.labelAmountOr, "labelAmountOr");
            this.labelAmountOr.Name = "labelAmountOr";
            // 
            // textBoxAmountMax
            // 
            resources.ApplyResources(this.textBoxAmountMax, "textBoxAmountMax");
            this.textBoxAmountMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAmountMax.Name = "textBoxAmountMax";
            this.textBoxAmountMax.TextChanged += new System.EventHandler(this.textBoxAmountMax_TextChanged);
            // 
            // textBoxAmount
            // 
            resources.ApplyResources(this.textBoxAmount, "textBoxAmount");
            this.textBoxAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxAmountMin
            // 
            resources.ApplyResources(this.textBoxAmountMin, "textBoxAmountMin");
            this.textBoxAmountMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAmountMin.Name = "textBoxAmountMin";
            this.textBoxAmountMin.TextChanged += new System.EventHandler(this.textBoxAmountMin_TextChanged);
            // 
            // panelAmountCycles
            // 
            this.panelAmountCycles.Controls.Add(this.groupBoxAmountCycle);
            this.panelAmountCycles.Controls.Add(this.cbxCycleObjects);
            this.panelAmountCycles.Controls.Add(this.listViewLoanCycles);
            this.panelAmountCycles.Controls.Add(this.buttonRemoveAmountCycles);
            this.panelAmountCycles.Controls.Add(this.buttonAmountCyclesSave);
            this.panelAmountCycles.Controls.Add(this.buttonCancelAmountCycles);
            this.panelAmountCycles.Controls.Add(this.buttonAddAmountCycle);
            this.panelAmountCycles.Controls.Add(this.lblCycleObjects);
            resources.ApplyResources(this.panelAmountCycles, "panelAmountCycles");
            this.panelAmountCycles.Name = "panelAmountCycles";
            // 
            // groupBoxAmountCycle
            // 
            this.groupBoxAmountCycle.Controls.Add(this.label29);
            this.groupBoxAmountCycle.Controls.Add(this.textBoxCycleMax);
            this.groupBoxAmountCycle.Controls.Add(this.label30);
            this.groupBoxAmountCycle.Controls.Add(this.textBoxCycleMin);
            resources.ApplyResources(this.groupBoxAmountCycle, "groupBoxAmountCycle");
            this.groupBoxAmountCycle.Name = "groupBoxAmountCycle";
            this.groupBoxAmountCycle.TabStop = false;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // textBoxCycleMax
            // 
            this.textBoxCycleMax.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxCycleMax, "textBoxCycleMax");
            this.textBoxCycleMax.Name = "textBoxCycleMax";
            this.textBoxCycleMax.TextChanged += new System.EventHandler(this.textBoxCycleMax_TextChanged);
            this.textBoxCycleMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            this.textBoxCycleMax.Leave += new System.EventHandler(this.textBoxCycleMax_Leave);
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // textBoxCycleMin
            // 
            this.textBoxCycleMin.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxCycleMin, "textBoxCycleMin");
            this.textBoxCycleMin.Name = "textBoxCycleMin";
            this.textBoxCycleMin.TextChanged += new System.EventHandler(this.textBoxCycleMin_TextChanged);
            this.textBoxCycleMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            this.textBoxCycleMin.Leave += new System.EventHandler(this.textBoxCycleMin_Leave);
            // 
            // cbxCycleObjects
            // 
            this.cbxCycleObjects.DisplayMember = "CycleObject.Name";
            this.cbxCycleObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCycleObjects.DropDownWidth = 175;
            resources.ApplyResources(this.cbxCycleObjects, "cbxCycleObjects");
            this.cbxCycleObjects.FormattingEnabled = true;
            this.cbxCycleObjects.Name = "cbxCycleObjects";
            this.cbxCycleObjects.ValueMember = "CycleObject.Id";
            this.cbxCycleObjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxCycleParams_SelectedIndexChanged);
            // 
            // listViewLoanCycles
            // 
            this.listViewLoanCycles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCycle,
            this.colMin,
            this.colMax});
            this.listViewLoanCycles.DoubleClickActivation = false;
            resources.ApplyResources(this.listViewLoanCycles, "listViewLoanCycles");
            this.listViewLoanCycles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewLoanCycles.FullRowSelect = true;
            this.listViewLoanCycles.GridLines = true;
            this.listViewLoanCycles.MultiSelect = false;
            this.listViewLoanCycles.Name = "listViewLoanCycles";
            this.listViewLoanCycles.UseCompatibleStateImageBehavior = false;
            this.listViewLoanCycles.View = System.Windows.Forms.View.Details;
            this.listViewLoanCycles.SelectedIndexChanged += new System.EventHandler(this.listViewLoanCycles_Click);
            this.listViewLoanCycles.Click += new System.EventHandler(this.listViewLoanCycles_Click);
            // 
            // colCycle
            // 
            resources.ApplyResources(this.colCycle, "colCycle");
            // 
            // colMin
            // 
            resources.ApplyResources(this.colMin, "colMin");
            // 
            // colMax
            // 
            resources.ApplyResources(this.colMax, "colMax");
            // 
            // buttonRemoveAmountCycles
            // 
            resources.ApplyResources(this.buttonRemoveAmountCycles, "buttonRemoveAmountCycles");
            this.buttonRemoveAmountCycles.Name = "buttonRemoveAmountCycles";
            this.buttonRemoveAmountCycles.Click += new System.EventHandler(this.buttonRemoveAmountCycles_Click);
            // 
            // buttonAmountCyclesSave
            // 
            resources.ApplyResources(this.buttonAmountCyclesSave, "buttonAmountCyclesSave");
            this.buttonAmountCyclesSave.Name = "buttonAmountCyclesSave";
            this.buttonAmountCyclesSave.Click += new System.EventHandler(this.buttonAmountCyclesSave_Click);
            // 
            // buttonCancelAmountCycles
            // 
            resources.ApplyResources(this.buttonCancelAmountCycles, "buttonCancelAmountCycles");
            this.buttonCancelAmountCycles.Name = "buttonCancelAmountCycles";
            this.buttonCancelAmountCycles.Click += new System.EventHandler(this.buttonCancelAmountCycles_Click);
            // 
            // buttonAddAmountCycle
            // 
            resources.ApplyResources(this.buttonAddAmountCycle, "buttonAddAmountCycle");
            this.buttonAddAmountCycle.Name = "buttonAddAmountCycle";
            this.buttonAddAmountCycle.Click += new System.EventHandler(this.buttonAddAmountCycle_Click);
            // 
            // lblCycleObjects
            // 
            resources.ApplyResources(this.lblCycleObjects, "lblCycleObjects");
            this.lblCycleObjects.Name = "lblCycleObjects";
            // 
            // groupBoxAmountCycles
            // 
            this.groupBoxAmountCycles.Controls.Add(this.comboBoxLoanCyclesName);
            this.groupBoxAmountCycles.Controls.Add(this.label31);
            this.groupBoxAmountCycles.Controls.Add(this.buttonNewAmountCycles);
            resources.ApplyResources(this.groupBoxAmountCycles, "groupBoxAmountCycles");
            this.groupBoxAmountCycles.Name = "groupBoxAmountCycles";
            this.groupBoxAmountCycles.TabStop = false;
            // 
            // comboBoxLoanCyclesName
            // 
            this.comboBoxLoanCyclesName.DisplayMember = "Name";
            this.comboBoxLoanCyclesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoanCyclesName.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.comboBoxLoanCyclesName, "comboBoxLoanCyclesName");
            this.comboBoxLoanCyclesName.Name = "comboBoxLoanCyclesName";
            this.comboBoxLoanCyclesName.ValueMember = "Id";
            this.comboBoxLoanCyclesName.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoanCyclesName_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // buttonNewAmountCycles
            // 
            resources.ApplyResources(this.buttonNewAmountCycles, "buttonNewAmountCycles");
            this.buttonNewAmountCycles.Name = "buttonNewAmountCycles";
            this.buttonNewAmountCycles.Click += new System.EventHandler(this.buttonNewAmountCycles_Click);
            // 
            // groupBoxRoundingType
            // 
            this.groupBoxRoundingType.Controls.Add(this.cmbInterestScheme);
            resources.ApplyResources(this.groupBoxRoundingType, "groupBoxRoundingType");
            this.groupBoxRoundingType.Name = "groupBoxRoundingType";
            this.groupBoxRoundingType.TabStop = false;
            // 
            // cmbInterestScheme
            // 
            this.cmbInterestScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbInterestScheme, "cmbInterestScheme");
            this.cmbInterestScheme.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbInterestScheme.FormattingEnabled = true;
            this.cmbInterestScheme.Name = "cmbInterestScheme";
            this.cmbInterestScheme.SelectedValueChanged += new System.EventHandler(this.cmbInterestScheme_SelectedValueChanged);
            // 
            // textBoxCode
            // 
            resources.ApplyResources(this.textBoxCode, "textBoxCode");
            this.textBoxCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Name = "label32";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBoxCurrencies);
            this.groupBox10.Controls.Add(this.comboBoxFundingLine);
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.DisplayMember = "Currency.Name";
            this.comboBoxCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxCurrencies, "comboBoxCurrencies");
            this.comboBoxCurrencies.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencies_SelectedIndexChanged);
            // 
            // comboBoxFundingLine
            // 
            this.comboBoxFundingLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxFundingLine, "comboBoxFundingLine");
            this.comboBoxFundingLine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFundingLine.Name = "comboBoxFundingLine";
            this.comboBoxFundingLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxFundingLine_SelectedIndexChanged);
            // 
            // groupBoxChargeInterestWithinGracePeriod
            // 
            this.groupBoxChargeInterestWithinGracePeriod.Controls.Add(this.radioButtonChargeInterestNo);
            this.groupBoxChargeInterestWithinGracePeriod.Controls.Add(this.radioButtonChargeInterestYes);
            resources.ApplyResources(this.groupBoxChargeInterestWithinGracePeriod, "groupBoxChargeInterestWithinGracePeriod");
            this.groupBoxChargeInterestWithinGracePeriod.Name = "groupBoxChargeInterestWithinGracePeriod";
            this.groupBoxChargeInterestWithinGracePeriod.TabStop = false;
            // 
            // radioButtonChargeInterestNo
            // 
            resources.ApplyResources(this.radioButtonChargeInterestNo, "radioButtonChargeInterestNo");
            this.radioButtonChargeInterestNo.Name = "radioButtonChargeInterestNo";
            this.radioButtonChargeInterestNo.TabStop = true;
            this.radioButtonChargeInterestNo.CheckedChanged += new System.EventHandler(this.radioButtonChargeInterestNo_CheckedChanged);
            // 
            // radioButtonChargeInterestYes
            // 
            this.radioButtonChargeInterestYes.Checked = true;
            resources.ApplyResources(this.radioButtonChargeInterestYes, "radioButtonChargeInterestYes");
            this.radioButtonChargeInterestYes.Name = "radioButtonChargeInterestYes";
            this.radioButtonChargeInterestYes.TabStop = true;
            this.radioButtonChargeInterestYes.CheckedChanged += new System.EventHandler(this.radioButtonChargeInterestYes_CheckedChanged);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.clientTypeIndivCheckBox);
            this.groupBoxType.Controls.Add(this.clientTypeVillageCheckBox);
            this.groupBoxType.Controls.Add(this.clientTypeCorpCheckBox);
            this.groupBoxType.Controls.Add(this.clientTypeGroupCheckBox);
            this.groupBoxType.Controls.Add(this.clientTypeAllCheckBox);
            resources.ApplyResources(this.groupBoxType, "groupBoxType");
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.TabStop = false;
            // 
            // clientTypeIndivCheckBox
            // 
            resources.ApplyResources(this.clientTypeIndivCheckBox, "clientTypeIndivCheckBox");
            this.clientTypeIndivCheckBox.Name = "clientTypeIndivCheckBox";
            this.clientTypeIndivCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeGroupCheckBox_CheckedChanged);
            this.clientTypeIndivCheckBox.Click += new System.EventHandler(this.clientTypeGroupCheckBox_Click);
            // 
            // clientTypeVillageCheckBox
            // 
            resources.ApplyResources(this.clientTypeVillageCheckBox, "clientTypeVillageCheckBox");
            this.clientTypeVillageCheckBox.Name = "clientTypeVillageCheckBox";
            this.clientTypeVillageCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeGroupCheckBox_CheckedChanged);
            this.clientTypeVillageCheckBox.Click += new System.EventHandler(this.clientTypeGroupCheckBox_Click);
            // 
            // clientTypeCorpCheckBox
            // 
            resources.ApplyResources(this.clientTypeCorpCheckBox, "clientTypeCorpCheckBox");
            this.clientTypeCorpCheckBox.Name = "clientTypeCorpCheckBox";
            this.clientTypeCorpCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeGroupCheckBox_CheckedChanged);
            this.clientTypeCorpCheckBox.Click += new System.EventHandler(this.clientTypeGroupCheckBox_Click);
            // 
            // clientTypeGroupCheckBox
            // 
            resources.ApplyResources(this.clientTypeGroupCheckBox, "clientTypeGroupCheckBox");
            this.clientTypeGroupCheckBox.Name = "clientTypeGroupCheckBox";
            this.clientTypeGroupCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeGroupCheckBox_CheckedChanged);
            this.clientTypeGroupCheckBox.Click += new System.EventHandler(this.clientTypeGroupCheckBox_Click);
            // 
            // clientTypeAllCheckBox
            // 
            resources.ApplyResources(this.clientTypeAllCheckBox, "clientTypeAllCheckBox");
            this.clientTypeAllCheckBox.Name = "clientTypeAllCheckBox";
            this.clientTypeAllCheckBox.CheckedChanged += new System.EventHandler(this.clientTypeAllCheckBox_CheckedChanged);
            this.clientTypeAllCheckBox.Click += new System.EventHandler(this.clientTypeAllCheckBox_Click);
            // 
            // groupBoxInterestRateType
            // 
            this.groupBoxInterestRateType.Controls.Add(this.cmbInterestRateType);
            resources.ApplyResources(this.groupBoxInterestRateType, "groupBoxInterestRateType");
            this.groupBoxInterestRateType.Name = "groupBoxInterestRateType";
            this.groupBoxInterestRateType.TabStop = false;
            // 
            // cmbInterestRateType
            // 
            this.cmbInterestRateType.DisplayMember = "installmentType.Name";
            this.cmbInterestRateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbInterestRateType, "cmbInterestRateType");
            this.cmbInterestRateType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbInterestRateType.Name = "cmbInterestRateType";
            this.cmbInterestRateType.SelectedIndexChanged += new System.EventHandler(this.cmbInterestRateType_SelectedIndexChanged);
            this.cmbInterestRateType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxInstallmentType_SelectionChangeCommitted);
            // 
            // groupBoxGracePeriod
            // 
            this.groupBoxGracePeriod.Controls.Add(this.labelGPMax);
            this.groupBoxGracePeriod.Controls.Add(this.labelGPMin);
            this.groupBoxGracePeriod.Controls.Add(this.labelGPOr);
            this.groupBoxGracePeriod.Controls.Add(this.textBoxGracePeriodMax);
            this.groupBoxGracePeriod.Controls.Add(this.textBoxGracePeriod);
            this.groupBoxGracePeriod.Controls.Add(this.textBoxGracePeriodMin);
            resources.ApplyResources(this.groupBoxGracePeriod, "groupBoxGracePeriod");
            this.groupBoxGracePeriod.Name = "groupBoxGracePeriod";
            this.groupBoxGracePeriod.TabStop = false;
            // 
            // labelGPMax
            // 
            resources.ApplyResources(this.labelGPMax, "labelGPMax");
            this.labelGPMax.Name = "labelGPMax";
            // 
            // labelGPMin
            // 
            resources.ApplyResources(this.labelGPMin, "labelGPMin");
            this.labelGPMin.Name = "labelGPMin";
            // 
            // labelGPOr
            // 
            resources.ApplyResources(this.labelGPOr, "labelGPOr");
            this.labelGPOr.Name = "labelGPOr";
            // 
            // textBoxGracePeriodMax
            // 
            resources.ApplyResources(this.textBoxGracePeriodMax, "textBoxGracePeriodMax");
            this.textBoxGracePeriodMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxGracePeriodMax.Name = "textBoxGracePeriodMax";
            this.textBoxGracePeriodMax.Tag = "1";
            this.textBoxGracePeriodMax.TextChanged += new System.EventHandler(this.textBoxGracePeriodMax_TextChanged);
            this.textBoxGracePeriodMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            // 
            // textBoxGracePeriod
            // 
            resources.ApplyResources(this.textBoxGracePeriod, "textBoxGracePeriod");
            this.textBoxGracePeriod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxGracePeriod.Name = "textBoxGracePeriod";
            this.textBoxGracePeriod.TextChanged += new System.EventHandler(this.textBoxGracePeriod_TextChanged);
            this.textBoxGracePeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            // 
            // textBoxGracePeriodMin
            // 
            resources.ApplyResources(this.textBoxGracePeriodMin, "textBoxGracePeriodMin");
            this.textBoxGracePeriodMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxGracePeriodMin.Name = "textBoxGracePeriodMin";
            this.textBoxGracePeriodMin.Tag = "1";
            this.textBoxGracePeriodMin.TextChanged += new System.EventHandler(this.textBoxGracePeriodMin_TextChanged);
            this.textBoxGracePeriodMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            // 
            // comboBoxInstallmentType
            // 
            this.comboBoxInstallmentType.DisplayMember = "installmentType.Name";
            this.comboBoxInstallmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxInstallmentType, "comboBoxInstallmentType");
            this.comboBoxInstallmentType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxInstallmentType.Name = "comboBoxInstallmentType";
            this.comboBoxInstallmentType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxInstallmentType_SelectionChangeCommitted);
            // 
            // labelInstallmentType
            // 
            resources.ApplyResources(this.labelInstallmentType, "labelInstallmentType");
            this.labelInstallmentType.BackColor = System.Drawing.Color.Transparent;
            this.labelInstallmentType.Name = "labelInstallmentType";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Name = "labelName";
            // 
            // tabPageFees
            // 
            this.tabPageFees.Controls.Add(this.gbAnticipatedRepayment);
            this.tabPageFees.Controls.Add(this.groupBoxLateFees);
            this.tabPageFees.Controls.Add(this.groupBoxEntryFees);
            resources.ApplyResources(this.tabPageFees, "tabPageFees");
            this.tabPageFees.Name = "tabPageFees";
            // 
            // gbAnticipatedRepayment
            // 
            this.gbAnticipatedRepayment.Controls.Add(this.groupBoxAPR);
            this.gbAnticipatedRepayment.Controls.Add(this.groupBoxPartialAnticipatedRepaymentBase);
            this.gbAnticipatedRepayment.Controls.Add(this.groupBoxTotalAnticipatedRepaymentBase);
            this.gbAnticipatedRepayment.Controls.Add(this.groupBoxAnticipatedRepayment);
            resources.ApplyResources(this.gbAnticipatedRepayment, "gbAnticipatedRepayment");
            this.gbAnticipatedRepayment.Name = "gbAnticipatedRepayment";
            this.gbAnticipatedRepayment.TabStop = false;
            // 
            // groupBoxAPR
            // 
            this.groupBoxAPR.Controls.Add(this.label43);
            this.groupBoxAPR.Controls.Add(this.label40);
            this.groupBoxAPR.Controls.Add(this.label42);
            this.groupBoxAPR.Controls.Add(this.textBoxAnticipatedPartialRepaimentMax);
            this.groupBoxAPR.Controls.Add(this.label41);
            this.groupBoxAPR.Controls.Add(this.textBoxAnticipatedPartialRepaiment);
            this.groupBoxAPR.Controls.Add(this.textBoxAnticipatedPartialRepaimentMin);
            resources.ApplyResources(this.groupBoxAPR, "groupBoxAPR");
            this.groupBoxAPR.Name = "groupBoxAPR";
            this.groupBoxAPR.TabStop = false;
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // textBoxAnticipatedPartialRepaimentMax
            // 
            resources.ApplyResources(this.textBoxAnticipatedPartialRepaimentMax, "textBoxAnticipatedPartialRepaimentMax");
            this.textBoxAnticipatedPartialRepaimentMax.Name = "textBoxAnticipatedPartialRepaimentMax";
            this.textBoxAnticipatedPartialRepaimentMax.TextChanged += new System.EventHandler(this.textBoxBoxAnticipatedPartialRepaimentMax_TextChanged);
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // textBoxAnticipatedPartialRepaiment
            // 
            resources.ApplyResources(this.textBoxAnticipatedPartialRepaiment, "textBoxAnticipatedPartialRepaiment");
            this.textBoxAnticipatedPartialRepaiment.Name = "textBoxAnticipatedPartialRepaiment";
            this.textBoxAnticipatedPartialRepaiment.TextChanged += new System.EventHandler(this.textBoxAnticipatedPartialRepaiment_TextChanged);
            // 
            // textBoxAnticipatedPartialRepaimentMin
            // 
            resources.ApplyResources(this.textBoxAnticipatedPartialRepaimentMin, "textBoxAnticipatedPartialRepaimentMin");
            this.textBoxAnticipatedPartialRepaimentMin.Name = "textBoxAnticipatedPartialRepaimentMin";
            this.textBoxAnticipatedPartialRepaimentMin.TextChanged += new System.EventHandler(this.textBoxAnticipatedPartialRepaimentMin_TextChanged);
            // 
            // groupBoxPartialAnticipatedRepaymentBase
            // 
            this.groupBoxPartialAnticipatedRepaymentBase.Controls.Add(this.rbPrepaidPrincipal);
            this.groupBoxPartialAnticipatedRepaymentBase.Controls.Add(this.rbPartialRemainingOLB);
            this.groupBoxPartialAnticipatedRepaymentBase.Controls.Add(this.rbPartialRemainingInterest);
            resources.ApplyResources(this.groupBoxPartialAnticipatedRepaymentBase, "groupBoxPartialAnticipatedRepaymentBase");
            this.groupBoxPartialAnticipatedRepaymentBase.Name = "groupBoxPartialAnticipatedRepaymentBase";
            this.groupBoxPartialAnticipatedRepaymentBase.TabStop = false;
            // 
            // rbPrepaidPrincipal
            // 
            resources.ApplyResources(this.rbPrepaidPrincipal, "rbPrepaidPrincipal");
            this.rbPrepaidPrincipal.Name = "rbPrepaidPrincipal";
            // 
            // rbPartialRemainingOLB
            // 
            resources.ApplyResources(this.rbPartialRemainingOLB, "rbPartialRemainingOLB");
            this.rbPartialRemainingOLB.Checked = true;
            this.rbPartialRemainingOLB.Name = "rbPartialRemainingOLB";
            this.rbPartialRemainingOLB.TabStop = true;
            this.rbPartialRemainingOLB.CheckedChanged += new System.EventHandler(this.radioButtonPartialRemainingOLB_CheckedChanged);
            this.rbPartialRemainingOLB.TextChanged += new System.EventHandler(this.radioButtonPartialRemainingOLB_CheckedChanged);
            // 
            // rbPartialRemainingInterest
            // 
            resources.ApplyResources(this.rbPartialRemainingInterest, "rbPartialRemainingInterest");
            this.rbPartialRemainingInterest.Name = "rbPartialRemainingInterest";
            this.rbPartialRemainingInterest.CheckedChanged += new System.EventHandler(this.radioButtonPartialRemainingInterest_TextChanged);
            this.rbPartialRemainingInterest.TextChanged += new System.EventHandler(this.radioButtonPartialRemainingInterest_TextChanged);
            // 
            // groupBoxTotalAnticipatedRepaymentBase
            // 
            this.groupBoxTotalAnticipatedRepaymentBase.Controls.Add(this.rbRemainingOLB);
            this.groupBoxTotalAnticipatedRepaymentBase.Controls.Add(this.rbRemainingInterest);
            resources.ApplyResources(this.groupBoxTotalAnticipatedRepaymentBase, "groupBoxTotalAnticipatedRepaymentBase");
            this.groupBoxTotalAnticipatedRepaymentBase.Name = "groupBoxTotalAnticipatedRepaymentBase";
            this.groupBoxTotalAnticipatedRepaymentBase.TabStop = false;
            // 
            // rbRemainingOLB
            // 
            resources.ApplyResources(this.rbRemainingOLB, "rbRemainingOLB");
            this.rbRemainingOLB.Checked = true;
            this.rbRemainingOLB.Name = "rbRemainingOLB";
            this.rbRemainingOLB.TabStop = true;
            this.rbRemainingOLB.CheckedChanged += new System.EventHandler(this.radioButtonRemainingOLB_CheckedChanged);
            // 
            // rbRemainingInterest
            // 
            resources.ApplyResources(this.rbRemainingInterest, "rbRemainingInterest");
            this.rbRemainingInterest.Name = "rbRemainingInterest";
            this.rbRemainingInterest.CheckedChanged += new System.EventHandler(this.radioButtonRemainingInterest_CheckedChanged);
            // 
            // groupBoxAnticipatedRepayment
            // 
            this.groupBoxAnticipatedRepayment.Controls.Add(this.label2);
            this.groupBoxAnticipatedRepayment.Controls.Add(this.label3);
            this.groupBoxAnticipatedRepayment.Controls.Add(this.label4);
            this.groupBoxAnticipatedRepayment.Controls.Add(this.label5);
            this.groupBoxAnticipatedRepayment.Controls.Add(this.textBoxAnticipatedRepaymentPenaltiesMax);
            this.groupBoxAnticipatedRepayment.Controls.Add(this.textBoxAnticipatedRepaymentPenalties);
            this.groupBoxAnticipatedRepayment.Controls.Add(this.textBoxAnticipatedRepaymentPenaltiesMin);
            resources.ApplyResources(this.groupBoxAnticipatedRepayment, "groupBoxAnticipatedRepayment");
            this.groupBoxAnticipatedRepayment.Name = "groupBoxAnticipatedRepayment";
            this.groupBoxAnticipatedRepayment.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxAnticipatedRepaymentPenaltiesMax
            // 
            resources.ApplyResources(this.textBoxAnticipatedRepaymentPenaltiesMax, "textBoxAnticipatedRepaymentPenaltiesMax");
            this.textBoxAnticipatedRepaymentPenaltiesMax.Name = "textBoxAnticipatedRepaymentPenaltiesMax";
            this.textBoxAnticipatedRepaymentPenaltiesMax.TextChanged += new System.EventHandler(this.textBoxAnticipatedRepaymentPenaltiesMax_TextChanged);
            // 
            // textBoxAnticipatedRepaymentPenalties
            // 
            resources.ApplyResources(this.textBoxAnticipatedRepaymentPenalties, "textBoxAnticipatedRepaymentPenalties");
            this.textBoxAnticipatedRepaymentPenalties.Name = "textBoxAnticipatedRepaymentPenalties";
            this.textBoxAnticipatedRepaymentPenalties.TextChanged += new System.EventHandler(this.textBoxAnticipatedRepaymentPenalties_TextChanged);
            // 
            // textBoxAnticipatedRepaymentPenaltiesMin
            // 
            resources.ApplyResources(this.textBoxAnticipatedRepaymentPenaltiesMin, "textBoxAnticipatedRepaymentPenaltiesMin");
            this.textBoxAnticipatedRepaymentPenaltiesMin.Name = "textBoxAnticipatedRepaymentPenaltiesMin";
            this.textBoxAnticipatedRepaymentPenaltiesMin.TextChanged += new System.EventHandler(this.textBoxAnticipatedRepaymentPenaltiesMin_TextChanged);
            // 
            // groupBoxLateFees
            // 
            this.groupBoxLateFees.Controls.Add(this.labelLateFeeGracePeriod);
            this.groupBoxLateFees.Controls.Add(this.textBoxGracePeriodLateFee);
            this.groupBoxLateFees.Controls.Add(this.groupBox8);
            this.groupBoxLateFees.Controls.Add(this.groupBox5);
            this.groupBoxLateFees.Controls.Add(this.groupBox7);
            this.groupBoxLateFees.Controls.Add(this.groupBox6);
            resources.ApplyResources(this.groupBoxLateFees, "groupBoxLateFees");
            this.groupBoxLateFees.Name = "groupBoxLateFees";
            this.groupBoxLateFees.TabStop = false;
            // 
            // labelLateFeeGracePeriod
            // 
            resources.ApplyResources(this.labelLateFeeGracePeriod, "labelLateFeeGracePeriod");
            this.labelLateFeeGracePeriod.Name = "labelLateFeeGracePeriod";
            // 
            // textBoxGracePeriodLateFee
            // 
            resources.ApplyResources(this.textBoxGracePeriodLateFee, "textBoxGracePeriodLateFee");
            this.textBoxGracePeriodLateFee.Name = "textBoxGracePeriodLateFee";
            this.textBoxGracePeriodLateFee.TextChanged += new System.EventHandler(this.textBoxGracePeriodLateFee_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.tBInitialAmountMax);
            this.groupBox8.Controls.Add(this.tBInitialAmountValue);
            this.groupBox8.Controls.Add(this.tBInitialAmountMin);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // tBInitialAmountMax
            // 
            resources.ApplyResources(this.tBInitialAmountMax, "tBInitialAmountMax");
            this.tBInitialAmountMax.Name = "tBInitialAmountMax";
            this.tBInitialAmountMax.Tag = "2";
            this.tBInitialAmountMax.TextChanged += new System.EventHandler(this.tBInitialAmountMax_TextChanged);
            // 
            // tBInitialAmountValue
            // 
            resources.ApplyResources(this.tBInitialAmountValue, "tBInitialAmountValue");
            this.tBInitialAmountValue.Name = "tBInitialAmountValue";
            this.tBInitialAmountValue.TextChanged += new System.EventHandler(this.tBInitialAmountValue_TextChanged);
            // 
            // tBInitialAmountMin
            // 
            resources.ApplyResources(this.tBInitialAmountMin, "tBInitialAmountMin");
            this.tBInitialAmountMin.Name = "tBInitialAmountMin";
            this.tBInitialAmountMin.Tag = "1";
            this.tBInitialAmountMin.TextChanged += new System.EventHandler(this.tBInitialAmountMin_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.tBOverduePrincipalMax);
            this.groupBox5.Controls.Add(this.tBOverduePrincipalValue);
            this.groupBox5.Controls.Add(this.tBOverduePrincipalMin);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // tBOverduePrincipalMax
            // 
            resources.ApplyResources(this.tBOverduePrincipalMax, "tBOverduePrincipalMax");
            this.tBOverduePrincipalMax.Name = "tBOverduePrincipalMax";
            this.tBOverduePrincipalMax.Tag = "1";
            this.tBOverduePrincipalMax.TextChanged += new System.EventHandler(this.tBOverduePrincipalMax_TextChanged);
            // 
            // tBOverduePrincipalValue
            // 
            resources.ApplyResources(this.tBOverduePrincipalValue, "tBOverduePrincipalValue");
            this.tBOverduePrincipalValue.Name = "tBOverduePrincipalValue";
            this.tBOverduePrincipalValue.TextChanged += new System.EventHandler(this.tBOverduePrincipalValue_TextChanged);
            // 
            // tBOverduePrincipalMin
            // 
            resources.ApplyResources(this.tBOverduePrincipalMin, "tBOverduePrincipalMin");
            this.tBOverduePrincipalMin.Name = "tBOverduePrincipalMin";
            this.tBOverduePrincipalMin.Tag = "1";
            this.tBOverduePrincipalMin.TextChanged += new System.EventHandler(this.tBOverduePrincipalMin_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.tBOLBMax);
            this.groupBox7.Controls.Add(this.tBOLBValue);
            this.groupBox7.Controls.Add(this.tBOLBMin);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // tBOLBMax
            // 
            resources.ApplyResources(this.tBOLBMax, "tBOLBMax");
            this.tBOLBMax.Name = "tBOLBMax";
            this.tBOLBMax.Tag = "1";
            this.tBOLBMax.TextChanged += new System.EventHandler(this.tBOLBMax_TextChanged);
            // 
            // tBOLBValue
            // 
            resources.ApplyResources(this.tBOLBValue, "tBOLBValue");
            this.tBOLBValue.Name = "tBOLBValue";
            this.tBOLBValue.TextChanged += new System.EventHandler(this.tBOLBValue_TextChanged);
            // 
            // tBOLBMin
            // 
            resources.ApplyResources(this.tBOLBMin, "tBOLBMin");
            this.tBOLBMin.Name = "tBOLBMin";
            this.tBOLBMin.Tag = "1";
            this.tBOLBMin.TextChanged += new System.EventHandler(this.tBOLBMin_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.tBOverdueInterestMax);
            this.groupBox6.Controls.Add(this.tBOverdueInterestValue);
            this.groupBox6.Controls.Add(this.tBOverdueInterestMin);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // tBOverdueInterestMax
            // 
            resources.ApplyResources(this.tBOverdueInterestMax, "tBOverdueInterestMax");
            this.tBOverdueInterestMax.Name = "tBOverdueInterestMax";
            this.tBOverdueInterestMax.Tag = "1";
            this.tBOverdueInterestMax.TextChanged += new System.EventHandler(this.tBOverdueInterestMax_TextChanged);
            // 
            // tBOverdueInterestValue
            // 
            resources.ApplyResources(this.tBOverdueInterestValue, "tBOverdueInterestValue");
            this.tBOverdueInterestValue.Name = "tBOverdueInterestValue";
            this.tBOverdueInterestValue.TextChanged += new System.EventHandler(this.tBOverdueInterestValue_TextChanged);
            // 
            // tBOverdueInterestMin
            // 
            resources.ApplyResources(this.tBOverdueInterestMin, "tBOverdueInterestMin");
            this.tBOverdueInterestMin.Name = "tBOverdueInterestMin";
            this.tBOverdueInterestMin.Tag = "1";
            this.tBOverdueInterestMin.TextChanged += new System.EventHandler(this.tBOverdueInterestMin_TextChanged);
            // 
            // groupBoxEntryFees
            // 
            this.groupBoxEntryFees.Controls.Add(this.swbtnEntryFeesRemoveCycle);
            this.groupBoxEntryFees.Controls.Add(this.swbtnEntryFeesAddCycle);
            this.groupBoxEntryFees.Controls.Add(this.cbRate);
            this.groupBoxEntryFees.Controls.Add(this.cbxRate);
            this.groupBoxEntryFees.Controls.Add(this.tbEntryFeesValues);
            this.groupBoxEntryFees.Controls.Add(this.lvEntryFees);
            this.groupBoxEntryFees.Controls.Add(this.nudEntryFeescycleFrom);
            this.groupBoxEntryFees.Controls.Add(this.lblEntryFeesFromCycle);
            this.groupBoxEntryFees.Controls.Add(this.cbEnableEntryFeesCycle);
            this.groupBoxEntryFees.Controls.Add(this.lblEntryFeesCycle);
            this.groupBoxEntryFees.Controls.Add(this.cmbEntryFeesCycles);
            resources.ApplyResources(this.groupBoxEntryFees, "groupBoxEntryFees");
            this.groupBoxEntryFees.Name = "groupBoxEntryFees";
            this.groupBoxEntryFees.TabStop = false;
            // 
            // swbtnEntryFeesRemoveCycle
            // 
            resources.ApplyResources(this.swbtnEntryFeesRemoveCycle, "swbtnEntryFeesRemoveCycle");
            this.swbtnEntryFeesRemoveCycle.Name = "swbtnEntryFeesRemoveCycle";
            this.swbtnEntryFeesRemoveCycle.Click += new System.EventHandler(this.swbtnEntryFeesRemoveCycle_Click);
            // 
            // swbtnEntryFeesAddCycle
            // 
            resources.ApplyResources(this.swbtnEntryFeesAddCycle, "swbtnEntryFeesAddCycle");
            this.swbtnEntryFeesAddCycle.Name = "swbtnEntryFeesAddCycle";
            this.swbtnEntryFeesAddCycle.Click += new System.EventHandler(this.swbtnEntryFeesAddCycle_Click);
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            resources.GetString("cbRate.Items"),
            resources.GetString("cbRate.Items1")});
            resources.ApplyResources(this.cbRate, "cbRate");
            this.cbRate.Name = "cbRate";
            // 
            // cbxRate
            // 
            resources.ApplyResources(this.cbxRate, "cbxRate");
            this.cbxRate.Name = "cbxRate";
            // 
            // tbEntryFeesValues
            // 
            resources.ApplyResources(this.tbEntryFeesValues, "tbEntryFeesValues");
            this.tbEntryFeesValues.Name = "tbEntryFeesValues";
            // 
            // lvEntryFees
            // 
            this.lvEntryFees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEntryFeeId,
            this.chEntryFeeName,
            this.chEntryFeeMin,
            this.chEntryFeeMax,
            this.chEntryFeeValue,
            this.chEntryFeeRate,
            this.chEntryFeeIsAdded,
            this.chEntryFeeCycleId,
            this.chEntryFeeNewId,
            this.chEntryFeeIndex});
            resources.ApplyResources(this.lvEntryFees, "lvEntryFees");
            this.lvEntryFees.DoubleClickActivation = false;
            this.lvEntryFees.FullRowSelect = true;
            this.lvEntryFees.GridLines = true;
            this.lvEntryFees.Name = "lvEntryFees";
            this.lvEntryFees.UseCompatibleStateImageBehavior = false;
            this.lvEntryFees.View = System.Windows.Forms.View.Details;
            this.lvEntryFees.SubItemClicked += new OpenCBS.GUI.UserControl.SubItemEventHandler(this.lvEntryFees_SubItemClicked);
            this.lvEntryFees.SubItemEndEditing += new OpenCBS.GUI.UserControl.SubItemEndEditingEventHandler(this.lvEntryFees_SubItemEndEditing);
            // 
            // chEntryFeeId
            // 
            resources.ApplyResources(this.chEntryFeeId, "chEntryFeeId");
            // 
            // chEntryFeeName
            // 
            resources.ApplyResources(this.chEntryFeeName, "chEntryFeeName");
            // 
            // chEntryFeeMin
            // 
            resources.ApplyResources(this.chEntryFeeMin, "chEntryFeeMin");
            // 
            // chEntryFeeMax
            // 
            resources.ApplyResources(this.chEntryFeeMax, "chEntryFeeMax");
            // 
            // chEntryFeeValue
            // 
            resources.ApplyResources(this.chEntryFeeValue, "chEntryFeeValue");
            // 
            // chEntryFeeRate
            // 
            resources.ApplyResources(this.chEntryFeeRate, "chEntryFeeRate");
            // 
            // chEntryFeeIsAdded
            // 
            resources.ApplyResources(this.chEntryFeeIsAdded, "chEntryFeeIsAdded");
            // 
            // chEntryFeeCycleId
            // 
            resources.ApplyResources(this.chEntryFeeCycleId, "chEntryFeeCycleId");
            // 
            // chEntryFeeNewId
            // 
            resources.ApplyResources(this.chEntryFeeNewId, "chEntryFeeNewId");
            // 
            // chEntryFeeIndex
            // 
            resources.ApplyResources(this.chEntryFeeIndex, "chEntryFeeIndex");
            // 
            // nudEntryFeescycleFrom
            // 
            resources.ApplyResources(this.nudEntryFeescycleFrom, "nudEntryFeescycleFrom");
            this.nudEntryFeescycleFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEntryFeescycleFrom.Name = "nudEntryFeescycleFrom";
            this.nudEntryFeescycleFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEntryFeesFromCycle
            // 
            resources.ApplyResources(this.lblEntryFeesFromCycle, "lblEntryFeesFromCycle");
            this.lblEntryFeesFromCycle.Name = "lblEntryFeesFromCycle";
            // 
            // cbEnableEntryFeesCycle
            // 
            resources.ApplyResources(this.cbEnableEntryFeesCycle, "cbEnableEntryFeesCycle");
            this.cbEnableEntryFeesCycle.Name = "cbEnableEntryFeesCycle";
            this.cbEnableEntryFeesCycle.CheckedChanged += new System.EventHandler(this.cbEnableEntryFeesCycle_CheckedChanged);
            // 
            // lblEntryFeesCycle
            // 
            resources.ApplyResources(this.lblEntryFeesCycle, "lblEntryFeesCycle");
            this.lblEntryFeesCycle.Name = "lblEntryFeesCycle";
            // 
            // cmbEntryFeesCycles
            // 
            this.cmbEntryFeesCycles.DisplayMember = "Name";
            this.cmbEntryFeesCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryFeesCycles.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEntryFeesCycles, "cmbEntryFeesCycles");
            this.cmbEntryFeesCycles.Name = "cmbEntryFeesCycles";
            this.cmbEntryFeesCycles.ValueMember = "Id";
            this.cmbEntryFeesCycles.SelectedValueChanged += new System.EventHandler(this.cmbEntryFeesCycle_SelectedValueChanged);
            // 
            // tabPageOptionalParameters
            // 
            this.tabPageOptionalParameters.Controls.Add(this.groupBoxDetailsOptionalParameters);
            resources.ApplyResources(this.tabPageOptionalParameters, "tabPageOptionalParameters");
            this.tabPageOptionalParameters.Name = "tabPageOptionalParameters";
            // 
            // groupBoxDetailsOptionalParameters
            // 
            this.groupBoxDetailsOptionalParameters.Controls.Add(this.groupBoxExoticProducts);
            this.groupBoxDetailsOptionalParameters.Controls.Add(this.groupBox4);
            this.groupBoxDetailsOptionalParameters.Controls.Add(this.groupBox12);
            resources.ApplyResources(this.groupBoxDetailsOptionalParameters, "groupBoxDetailsOptionalParameters");
            this.groupBoxDetailsOptionalParameters.Name = "groupBoxDetailsOptionalParameters";
            this.groupBoxDetailsOptionalParameters.TabStop = false;
            // 
            // groupBoxExoticProducts
            // 
            this.groupBoxExoticProducts.Controls.Add(this.panelExoticProduct);
            this.groupBoxExoticProducts.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.groupBoxExoticProducts, "groupBoxExoticProducts");
            this.groupBoxExoticProducts.Name = "groupBoxExoticProducts";
            this.groupBoxExoticProducts.TabStop = false;
            // 
            // panelExoticProduct
            // 
            this.panelExoticProduct.Controls.Add(this.panel1);
            this.panelExoticProduct.Controls.Add(this.labelTotalInterest);
            this.panelExoticProduct.Controls.Add(this.labelTotalPrincipal);
            this.panelExoticProduct.Controls.Add(this.labelTotalExoticInstallments);
            this.panelExoticProduct.Controls.Add(this.buttonCancelExoticProduct);
            this.panelExoticProduct.Controls.Add(this.buttonSaveExoticProduct);
            this.panelExoticProduct.Controls.Add(this.groupBoxExoticInstallmentProperties);
            this.panelExoticProduct.Controls.Add(this.panelExoticProductNavigationButtons);
            this.panelExoticProduct.Controls.Add(this.buttonRemoveExoticInstallment);
            this.panelExoticProduct.Controls.Add(this.buttonAddExoticInstallment);
            this.panelExoticProduct.Controls.Add(this.listViewExoticInstallments);
            resources.ApplyResources(this.panelExoticProduct, "panelExoticProduct");
            this.panelExoticProduct.Name = "panelExoticProduct";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labelTotalInterest
            // 
            resources.ApplyResources(this.labelTotalInterest, "labelTotalInterest");
            this.labelTotalInterest.Name = "labelTotalInterest";
            // 
            // labelTotalPrincipal
            // 
            resources.ApplyResources(this.labelTotalPrincipal, "labelTotalPrincipal");
            this.labelTotalPrincipal.Name = "labelTotalPrincipal";
            // 
            // labelTotalExoticInstallments
            // 
            resources.ApplyResources(this.labelTotalExoticInstallments, "labelTotalExoticInstallments");
            this.labelTotalExoticInstallments.Name = "labelTotalExoticInstallments";
            // 
            // buttonCancelExoticProduct
            // 
            resources.ApplyResources(this.buttonCancelExoticProduct, "buttonCancelExoticProduct");
            this.buttonCancelExoticProduct.Name = "buttonCancelExoticProduct";
            this.buttonCancelExoticProduct.Click += new System.EventHandler(this.buttonCancelExoticProduct_Click);
            // 
            // buttonSaveExoticProduct
            // 
            resources.ApplyResources(this.buttonSaveExoticProduct, "buttonSaveExoticProduct");
            this.buttonSaveExoticProduct.Name = "buttonSaveExoticProduct";
            this.buttonSaveExoticProduct.Click += new System.EventHandler(this.buttonSaveExoticProduct_Click);
            // 
            // groupBoxExoticInstallmentProperties
            // 
            this.groupBoxExoticInstallmentProperties.Controls.Add(this.panelExoticInstallment);
            resources.ApplyResources(this.groupBoxExoticInstallmentProperties, "groupBoxExoticInstallmentProperties");
            this.groupBoxExoticInstallmentProperties.Name = "groupBoxExoticInstallmentProperties";
            this.groupBoxExoticInstallmentProperties.TabStop = false;
            // 
            // panelExoticInstallment
            // 
            this.panelExoticInstallment.Controls.Add(this.label12);
            this.panelExoticInstallment.Controls.Add(this.label11);
            this.panelExoticInstallment.Controls.Add(this.textBoxExoticInstallmentInterest);
            this.panelExoticInstallment.Controls.Add(this.textBoxExoticInstallmentPrincipal);
            this.panelExoticInstallment.Controls.Add(this.label9);
            this.panelExoticInstallment.Controls.Add(this.label10);
            this.panelExoticInstallment.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.panelExoticInstallment, "panelExoticInstallment");
            this.panelExoticInstallment.Name = "panelExoticInstallment";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxExoticInstallmentInterest
            // 
            resources.ApplyResources(this.textBoxExoticInstallmentInterest, "textBoxExoticInstallmentInterest");
            this.textBoxExoticInstallmentInterest.Name = "textBoxExoticInstallmentInterest";
            this.textBoxExoticInstallmentInterest.TextChanged += new System.EventHandler(this.textBoxExoticInstallmentInterest_TextChanged);
            this.textBoxExoticInstallmentInterest.Leave += new System.EventHandler(this.textBoxExoticInstallmentInterest_Leave);
            // 
            // textBoxExoticInstallmentPrincipal
            // 
            resources.ApplyResources(this.textBoxExoticInstallmentPrincipal, "textBoxExoticInstallmentPrincipal");
            this.textBoxExoticInstallmentPrincipal.Name = "textBoxExoticInstallmentPrincipal";
            this.textBoxExoticInstallmentPrincipal.TextChanged += new System.EventHandler(this.textBoxExoticInstallmentPrincipal_TextChanged);
            this.textBoxExoticInstallmentPrincipal.Leave += new System.EventHandler(this.textBoxExoticInstallmentPrincipal_Leave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // panelExoticProductNavigationButtons
            // 
            this.panelExoticProductNavigationButtons.Controls.Add(this.buttonDecreaseExoticInstallment);
            this.panelExoticProductNavigationButtons.Controls.Add(this.buttonIncreaseExoticInstallment);
            resources.ApplyResources(this.panelExoticProductNavigationButtons, "panelExoticProductNavigationButtons");
            this.panelExoticProductNavigationButtons.Name = "panelExoticProductNavigationButtons";
            // 
            // buttonDecreaseExoticInstallment
            // 
            resources.ApplyResources(this.buttonDecreaseExoticInstallment, "buttonDecreaseExoticInstallment");
            this.buttonDecreaseExoticInstallment.Name = "buttonDecreaseExoticInstallment";
            this.buttonDecreaseExoticInstallment.Click += new System.EventHandler(this.buttonDecreaseExoticInstallment_Click);
            // 
            // buttonIncreaseExoticInstallment
            // 
            resources.ApplyResources(this.buttonIncreaseExoticInstallment, "buttonIncreaseExoticInstallment");
            this.buttonIncreaseExoticInstallment.Name = "buttonIncreaseExoticInstallment";
            this.buttonIncreaseExoticInstallment.Click += new System.EventHandler(this.buttonIncreaseExoticInstallment_Click);
            // 
            // buttonRemoveExoticInstallment
            // 
            resources.ApplyResources(this.buttonRemoveExoticInstallment, "buttonRemoveExoticInstallment");
            this.buttonRemoveExoticInstallment.Name = "buttonRemoveExoticInstallment";
            this.buttonRemoveExoticInstallment.Click += new System.EventHandler(this.buttonRemoveExoticInstallment_Click);
            // 
            // buttonAddExoticInstallment
            // 
            resources.ApplyResources(this.buttonAddExoticInstallment, "buttonAddExoticInstallment");
            this.buttonAddExoticInstallment.Name = "buttonAddExoticInstallment";
            this.buttonAddExoticInstallment.Click += new System.EventHandler(this.buttonAddExoticInstallment_Click);
            // 
            // listViewExoticInstallments
            // 
            this.listViewExoticInstallments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            resources.ApplyResources(this.listViewExoticInstallments, "listViewExoticInstallments");
            this.listViewExoticInstallments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(56)))));
            this.listViewExoticInstallments.FullRowSelect = true;
            this.listViewExoticInstallments.GridLines = true;
            this.listViewExoticInstallments.Name = "listViewExoticInstallments";
            this.listViewExoticInstallments.UseCompatibleStateImageBehavior = false;
            this.listViewExoticInstallments.View = System.Windows.Forms.View.Details;
            this.listViewExoticInstallments.SelectedIndexChanged += new System.EventHandler(this.listViewExoticInstallments_SelectedIndexChanged);
            this.listViewExoticInstallments.Click += new System.EventHandler(this.listViewExoticInstallments_Click);
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonNewExoticProduct);
            this.groupBox2.Controls.Add(this.comboBoxExoticProduct);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // buttonNewExoticProduct
            // 
            resources.ApplyResources(this.buttonNewExoticProduct, "buttonNewExoticProduct");
            this.buttonNewExoticProduct.Name = "buttonNewExoticProduct";
            this.buttonNewExoticProduct.Click += new System.EventHandler(this.buttonNewExoticProduct_Click);
            // 
            // comboBoxExoticProduct
            // 
            this.comboBoxExoticProduct.DisplayMember = "exoticProduct.Name";
            this.comboBoxExoticProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxExoticProduct, "comboBoxExoticProduct");
            this.comboBoxExoticProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxExoticProduct.Name = "comboBoxExoticProduct";
            this.comboBoxExoticProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxExoticProduct_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxUseExceptionalInstallmen);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // checkBoxUseExceptionalInstallmen
            // 
            resources.ApplyResources(this.checkBoxUseExceptionalInstallmen, "checkBoxUseExceptionalInstallmen");
            this.checkBoxUseExceptionalInstallmen.Name = "checkBoxUseExceptionalInstallmen";
            this.checkBoxUseExceptionalInstallmen.CheckedChanged += new System.EventHandler(this.checkBoxUseExceptionalInstallmen_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.checkBoxFlexPackage);
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            // 
            // checkBoxFlexPackage
            // 
            resources.ApplyResources(this.checkBoxFlexPackage, "checkBoxFlexPackage");
            this.checkBoxFlexPackage.Name = "checkBoxFlexPackage";
            this.checkBoxFlexPackage.CheckedChanged += new System.EventHandler(this.checkBoxFlexPackage_CheckedChanged);
            // 
            // tabLOC
            // 
            this.tabLOC.Controls.Add(this.drawNumGroupBox);
            this.tabLOC.Controls.Add(this.useLOCCheckBox);
            this.tabLOC.Controls.Add(this.maxLOCMaturityGroupBox);
            this.tabLOC.Controls.Add(this.maxLOCAmountGroupBox);
            resources.ApplyResources(this.tabLOC, "tabLOC");
            this.tabLOC.Name = "tabLOC";
            // 
            // drawNumGroupBox
            // 
            this.drawNumGroupBox.Controls.Add(this.textBoxNumOfDrawings);
            this.drawNumGroupBox.Controls.Add(this.drawingNumberLabel);
            resources.ApplyResources(this.drawNumGroupBox, "drawNumGroupBox");
            this.drawNumGroupBox.Name = "drawNumGroupBox";
            this.drawNumGroupBox.TabStop = false;
            // 
            // textBoxNumOfDrawings
            // 
            this.textBoxNumOfDrawings.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxNumOfDrawings, "textBoxNumOfDrawings");
            this.textBoxNumOfDrawings.Name = "textBoxNumOfDrawings";
            this.textBoxNumOfDrawings.TextChanged += new System.EventHandler(this.textBoxNumOfDrawings_TextChanged);
            this.textBoxNumOfDrawings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumOfDrawings_KeyPress);
            // 
            // drawingNumberLabel
            // 
            resources.ApplyResources(this.drawingNumberLabel, "drawingNumberLabel");
            this.drawingNumberLabel.Name = "drawingNumberLabel";
            // 
            // useLOCCheckBox
            // 
            resources.ApplyResources(this.useLOCCheckBox, "useLOCCheckBox");
            this.useLOCCheckBox.Name = "useLOCCheckBox";
            this.useLOCCheckBox.CheckedChanged += new System.EventHandler(this.useLOCCheckBox_CheckedChanged);
            // 
            // maxLOCMaturityGroupBox
            // 
            this.maxLOCMaturityGroupBox.Controls.Add(this.label45);
            this.maxLOCMaturityGroupBox.Controls.Add(this.label46);
            this.maxLOCMaturityGroupBox.Controls.Add(this.label47);
            this.maxLOCMaturityGroupBox.Controls.Add(this.label48);
            this.maxLOCMaturityGroupBox.Controls.Add(this.textBoxLOCMaturityMax);
            this.maxLOCMaturityGroupBox.Controls.Add(this.textBoxLOCMaturity);
            this.maxLOCMaturityGroupBox.Controls.Add(this.textBoxLOCMaturityMin);
            resources.ApplyResources(this.maxLOCMaturityGroupBox, "maxLOCMaturityGroupBox");
            this.maxLOCMaturityGroupBox.Name = "maxLOCMaturityGroupBox";
            this.maxLOCMaturityGroupBox.TabStop = false;
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Name = "label46";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // textBoxLOCMaturityMax
            // 
            resources.ApplyResources(this.textBoxLOCMaturityMax, "textBoxLOCMaturityMax");
            this.textBoxLOCMaturityMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLOCMaturityMax.Name = "textBoxLOCMaturityMax";
            this.textBoxLOCMaturityMax.TextChanged += new System.EventHandler(this.textBoxLOCMaturityMax_TextChanged);
            // 
            // textBoxLOCMaturity
            // 
            resources.ApplyResources(this.textBoxLOCMaturity, "textBoxLOCMaturity");
            this.textBoxLOCMaturity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLOCMaturity.Name = "textBoxLOCMaturity";
            this.textBoxLOCMaturity.TextChanged += new System.EventHandler(this.textBoxLOCMaturity_TextChanged);
            // 
            // textBoxLOCMaturityMin
            // 
            resources.ApplyResources(this.textBoxLOCMaturityMin, "textBoxLOCMaturityMin");
            this.textBoxLOCMaturityMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLOCMaturityMin.Name = "textBoxLOCMaturityMin";
            this.textBoxLOCMaturityMin.TextChanged += new System.EventHandler(this.textBoxLOCMaturityMin_TextChanged);
            // 
            // maxLOCAmountGroupBox
            // 
            this.maxLOCAmountGroupBox.Controls.Add(this.labelLOCAmount);
            this.maxLOCAmountGroupBox.Controls.Add(this.labelLOCMaxAmount);
            this.maxLOCAmountGroupBox.Controls.Add(this.labelLOCMinAmount);
            this.maxLOCAmountGroupBox.Controls.Add(this.label36);
            this.maxLOCAmountGroupBox.Controls.Add(this.label37);
            this.maxLOCAmountGroupBox.Controls.Add(this.label38);
            this.maxLOCAmountGroupBox.Controls.Add(this.label39);
            this.maxLOCAmountGroupBox.Controls.Add(this.textBoxAmountUnderLOCMax);
            this.maxLOCAmountGroupBox.Controls.Add(this.textBoxAmountUnderLOC);
            this.maxLOCAmountGroupBox.Controls.Add(this.textBoxAmountUnderLOCMin);
            resources.ApplyResources(this.maxLOCAmountGroupBox, "maxLOCAmountGroupBox");
            this.maxLOCAmountGroupBox.Name = "maxLOCAmountGroupBox";
            this.maxLOCAmountGroupBox.TabStop = false;
            // 
            // labelLOCAmount
            // 
            resources.ApplyResources(this.labelLOCAmount, "labelLOCAmount");
            this.labelLOCAmount.Name = "labelLOCAmount";
            // 
            // labelLOCMaxAmount
            // 
            resources.ApplyResources(this.labelLOCMaxAmount, "labelLOCMaxAmount");
            this.labelLOCMaxAmount.Name = "labelLOCMaxAmount";
            // 
            // labelLOCMinAmount
            // 
            resources.ApplyResources(this.labelLOCMinAmount, "labelLOCMinAmount");
            this.labelLOCMinAmount.Name = "labelLOCMinAmount";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Name = "label37";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // textBoxAmountUnderLOCMax
            // 
            resources.ApplyResources(this.textBoxAmountUnderLOCMax, "textBoxAmountUnderLOCMax");
            this.textBoxAmountUnderLOCMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAmountUnderLOCMax.Name = "textBoxAmountUnderLOCMax";
            this.textBoxAmountUnderLOCMax.TextChanged += new System.EventHandler(this.textBoxAmountUnderLOCMax_TextChanged);
            // 
            // textBoxAmountUnderLOC
            // 
            resources.ApplyResources(this.textBoxAmountUnderLOC, "textBoxAmountUnderLOC");
            this.textBoxAmountUnderLOC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAmountUnderLOC.Name = "textBoxAmountUnderLOC";
            this.textBoxAmountUnderLOC.TextChanged += new System.EventHandler(this.textBoxAmountUnderLOC_TextChanged);
            // 
            // textBoxAmountUnderLOCMin
            // 
            resources.ApplyResources(this.textBoxAmountUnderLOCMin, "textBoxAmountUnderLOCMin");
            this.textBoxAmountUnderLOCMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAmountUnderLOCMin.Name = "textBoxAmountUnderLOCMin";
            this.textBoxAmountUnderLOCMin.TextChanged += new System.EventHandler(this.textBoxAmountUnderLOCMin_TextChanged);
            // 
            // tabGuarantorsCollaterals
            // 
            this.tabGuarantorsCollaterals.Controls.Add(this.cbUseCompulsorySavings);
            this.tabGuarantorsCollaterals.Controls.Add(this.gbCSAmount);
            this.tabGuarantorsCollaterals.Controls.Add(this.checkBoxSetSepCollGuar);
            this.tabGuarantorsCollaterals.Controls.Add(this.groupBoxTotGuarColl);
            this.tabGuarantorsCollaterals.Controls.Add(this.groupBoxSepGuarColl);
            this.tabGuarantorsCollaterals.Controls.Add(this.checkBoxGuarCollRequired);
            resources.ApplyResources(this.tabGuarantorsCollaterals, "tabGuarantorsCollaterals");
            this.tabGuarantorsCollaterals.Name = "tabGuarantorsCollaterals";
            // 
            // cbUseCompulsorySavings
            // 
            resources.ApplyResources(this.cbUseCompulsorySavings, "cbUseCompulsorySavings");
            this.cbUseCompulsorySavings.Name = "cbUseCompulsorySavings";
            this.cbUseCompulsorySavings.CheckedChanged += new System.EventHandler(this.checkBoxUseCompulsorySavings_CheckedChanged);
            // 
            // gbCSAmount
            // 
            this.gbCSAmount.Controls.Add(this.rbCompulsoryAmountRate);
            this.gbCSAmount.Controls.Add(this.rbCompulsoryAmountFlat);
            this.gbCSAmount.Controls.Add(this.lbCompulsoryAmountType);
            this.gbCSAmount.Controls.Add(this.lbCompulsoryAmountValue);
            this.gbCSAmount.Controls.Add(this.lbCompulsoryAmountMax);
            this.gbCSAmount.Controls.Add(this.lbCompulsoryAmountMin);
            this.gbCSAmount.Controls.Add(this.lbCompulsoryAmountOr);
            this.gbCSAmount.Controls.Add(this.txbCompulsoryAmountMax);
            this.gbCSAmount.Controls.Add(this.txbCompulsoryAmountValue);
            this.gbCSAmount.Controls.Add(this.txbCompulsoryAmountMin);
            resources.ApplyResources(this.gbCSAmount, "gbCSAmount");
            this.gbCSAmount.Name = "gbCSAmount";
            this.gbCSAmount.TabStop = false;
            // 
            // rbCompulsoryAmountRate
            // 
            resources.ApplyResources(this.rbCompulsoryAmountRate, "rbCompulsoryAmountRate");
            this.rbCompulsoryAmountRate.Checked = true;
            this.rbCompulsoryAmountRate.Name = "rbCompulsoryAmountRate";
            this.rbCompulsoryAmountRate.TabStop = true;
            // 
            // rbCompulsoryAmountFlat
            // 
            resources.ApplyResources(this.rbCompulsoryAmountFlat, "rbCompulsoryAmountFlat");
            this.rbCompulsoryAmountFlat.Name = "rbCompulsoryAmountFlat";
            // 
            // lbCompulsoryAmountType
            // 
            resources.ApplyResources(this.lbCompulsoryAmountType, "lbCompulsoryAmountType");
            this.lbCompulsoryAmountType.Name = "lbCompulsoryAmountType";
            // 
            // lbCompulsoryAmountValue
            // 
            resources.ApplyResources(this.lbCompulsoryAmountValue, "lbCompulsoryAmountValue");
            this.lbCompulsoryAmountValue.Name = "lbCompulsoryAmountValue";
            // 
            // lbCompulsoryAmountMax
            // 
            resources.ApplyResources(this.lbCompulsoryAmountMax, "lbCompulsoryAmountMax");
            this.lbCompulsoryAmountMax.Name = "lbCompulsoryAmountMax";
            // 
            // lbCompulsoryAmountMin
            // 
            resources.ApplyResources(this.lbCompulsoryAmountMin, "lbCompulsoryAmountMin");
            this.lbCompulsoryAmountMin.Name = "lbCompulsoryAmountMin";
            // 
            // lbCompulsoryAmountOr
            // 
            resources.ApplyResources(this.lbCompulsoryAmountOr, "lbCompulsoryAmountOr");
            this.lbCompulsoryAmountOr.Name = "lbCompulsoryAmountOr";
            // 
            // txbCompulsoryAmountMax
            // 
            resources.ApplyResources(this.txbCompulsoryAmountMax, "txbCompulsoryAmountMax");
            this.txbCompulsoryAmountMax.Name = "txbCompulsoryAmountMax";
            this.txbCompulsoryAmountMax.Tag = "1";
            this.txbCompulsoryAmountMax.TextChanged += new System.EventHandler(this.textBoxCompulsoryAmountMax_TextChanged);
            // 
            // txbCompulsoryAmountValue
            // 
            resources.ApplyResources(this.txbCompulsoryAmountValue, "txbCompulsoryAmountValue");
            this.txbCompulsoryAmountValue.Name = "txbCompulsoryAmountValue";
            this.txbCompulsoryAmountValue.TextChanged += new System.EventHandler(this.textBoxCompulsoryAmountValue_TextChanged);
            // 
            // txbCompulsoryAmountMin
            // 
            resources.ApplyResources(this.txbCompulsoryAmountMin, "txbCompulsoryAmountMin");
            this.txbCompulsoryAmountMin.Name = "txbCompulsoryAmountMin";
            this.txbCompulsoryAmountMin.Tag = "1";
            this.txbCompulsoryAmountMin.TextChanged += new System.EventHandler(this.textBoxCompulsoryAmountMin_TextChanged);
            // 
            // checkBoxSetSepCollGuar
            // 
            resources.ApplyResources(this.checkBoxSetSepCollGuar, "checkBoxSetSepCollGuar");
            this.checkBoxSetSepCollGuar.Name = "checkBoxSetSepCollGuar";
            this.checkBoxSetSepCollGuar.CheckedChanged += new System.EventHandler(this.checkBoxSetSepCollGuar_CheckedChanged);
            // 
            // groupBoxTotGuarColl
            // 
            this.groupBoxTotGuarColl.Controls.Add(this.textBoxCollGuar);
            this.groupBoxTotGuarColl.Controls.Add(this.label34);
            this.groupBoxTotGuarColl.Controls.Add(this.label33);
            resources.ApplyResources(this.groupBoxTotGuarColl, "groupBoxTotGuarColl");
            this.groupBoxTotGuarColl.Name = "groupBoxTotGuarColl";
            this.groupBoxTotGuarColl.TabStop = false;
            // 
            // textBoxCollGuar
            // 
            resources.ApplyResources(this.textBoxCollGuar, "textBoxCollGuar");
            this.textBoxCollGuar.Name = "textBoxCollGuar";
            this.textBoxCollGuar.TextChanged += new System.EventHandler(this.textBoxCollGuar_TextChanged);
            this.textBoxCollGuar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumOfDrawings_KeyPress);
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // groupBoxSepGuarColl
            // 
            this.groupBoxSepGuarColl.Controls.Add(this.textBoxColl);
            this.groupBoxSepGuarColl.Controls.Add(this.textBoxGuar);
            this.groupBoxSepGuarColl.Controls.Add(this.label49);
            this.groupBoxSepGuarColl.Controls.Add(this.label44);
            this.groupBoxSepGuarColl.Controls.Add(this.label35);
            this.groupBoxSepGuarColl.Controls.Add(this.labelMinPercColl);
            this.groupBoxSepGuarColl.Controls.Add(this.labelMinPercGuar);
            resources.ApplyResources(this.groupBoxSepGuarColl, "groupBoxSepGuarColl");
            this.groupBoxSepGuarColl.Name = "groupBoxSepGuarColl";
            this.groupBoxSepGuarColl.TabStop = false;
            // 
            // textBoxColl
            // 
            resources.ApplyResources(this.textBoxColl, "textBoxColl");
            this.textBoxColl.Name = "textBoxColl";
            this.textBoxColl.TextChanged += new System.EventHandler(this.textBoxColl_TextChanged);
            this.textBoxColl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumOfDrawings_KeyPress);
            // 
            // textBoxGuar
            // 
            resources.ApplyResources(this.textBoxGuar, "textBoxGuar");
            this.textBoxGuar.Name = "textBoxGuar";
            this.textBoxGuar.TextChanged += new System.EventHandler(this.textBoxGuar_TextChanged);
            this.textBoxGuar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumOfDrawings_KeyPress);
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // labelMinPercColl
            // 
            resources.ApplyResources(this.labelMinPercColl, "labelMinPercColl");
            this.labelMinPercColl.Name = "labelMinPercColl";
            // 
            // labelMinPercGuar
            // 
            resources.ApplyResources(this.labelMinPercGuar, "labelMinPercGuar");
            this.labelMinPercGuar.Name = "labelMinPercGuar";
            // 
            // checkBoxGuarCollRequired
            // 
            resources.ApplyResources(this.checkBoxGuarCollRequired, "checkBoxGuarCollRequired");
            this.checkBoxGuarCollRequired.Name = "checkBoxGuarCollRequired";
            this.checkBoxGuarCollRequired.CheckedChanged += new System.EventHandler(this.checkBoxGuarCollRequired_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label53);
            this.groupBox9.Controls.Add(this.label52);
            this.groupBox9.Controls.Add(this.tbCreditInsuranceMax);
            this.groupBox9.Controls.Add(this.tbCreditInsuranceMin);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.label51);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.Name = "label53";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // tbCreditInsuranceMax
            // 
            resources.ApplyResources(this.tbCreditInsuranceMax, "tbCreditInsuranceMax");
            this.tbCreditInsuranceMax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCreditInsuranceMax.Name = "tbCreditInsuranceMax";
            this.tbCreditInsuranceMax.TextChanged += new System.EventHandler(this.tbCreditInsuranceMax_TextChanged);
            this.tbCreditInsuranceMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            // 
            // tbCreditInsuranceMin
            // 
            resources.ApplyResources(this.tbCreditInsuranceMin, "tbCreditInsuranceMin");
            this.tbCreditInsuranceMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCreditInsuranceMin.Name = "tbCreditInsuranceMin";
            this.tbCreditInsuranceMin.TextChanged += new System.EventHandler(this.tbCreditInsuranceMin_TextChanged);
            this.tbCreditInsuranceMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGracePeriodMin_KeyPress);
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Name = "label50";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.Name = "label51";
            // 
            // entryFeeBindingSource
            // 
            this.entryFeeBindingSource.DataSource = typeof(OpenCBS.CoreDomain.EntryFee);
            // 
            // splitter2
            // 
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // radioButtonAmountCycle
            // 
            resources.ApplyResources(this.radioButtonAmountCycle, "radioButtonAmountCycle");
            this.radioButtonAmountCycle.Name = "radioButtonAmountCycle";
            // 
            // radioButtonSpecifiedAmount
            // 
            this.radioButtonSpecifiedAmount.Checked = true;
            resources.ApplyResources(this.radioButtonSpecifiedAmount, "radioButtonSpecifiedAmount");
            this.radioButtonSpecifiedAmount.Name = "radioButtonSpecifiedAmount";
            this.radioButtonSpecifiedAmount.TabStop = true;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // FrmAddLoanProduct
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.tabCreditInsurance);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddLoanProduct";
            this.Load += new System.EventHandler(this.AddPackageForm_Load);
            this.tabCreditInsurance.ResumeLayout(false);
            this.tabPageMainParameters.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.gbAdvancedParameters.ResumeLayout(false);
            this.gbAdvancedParameters.PerformLayout();
            this.groupBoxNumberOfInstallments.ResumeLayout(false);
            this.groupBoxNumberOfInstallments.PerformLayout();
            this.groupBoxInterestRate.ResumeLayout(false);
            this.groupBoxInterestRate.PerformLayout();
            this.groupBoxAmount.ResumeLayout(false);
            this.groupBoxAmount.PerformLayout();
            this.panelAmountCycles.ResumeLayout(false);
            this.panelAmountCycles.PerformLayout();
            this.groupBoxAmountCycle.ResumeLayout(false);
            this.groupBoxAmountCycle.PerformLayout();
            this.groupBoxAmountCycles.ResumeLayout(false);
            this.groupBoxRoundingType.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBoxChargeInterestWithinGracePeriod.ResumeLayout(false);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxInterestRateType.ResumeLayout(false);
            this.groupBoxGracePeriod.ResumeLayout(false);
            this.groupBoxGracePeriod.PerformLayout();
            this.tabPageFees.ResumeLayout(false);
            this.gbAnticipatedRepayment.ResumeLayout(false);
            this.groupBoxAPR.ResumeLayout(false);
            this.groupBoxAPR.PerformLayout();
            this.groupBoxPartialAnticipatedRepaymentBase.ResumeLayout(false);
            this.groupBoxPartialAnticipatedRepaymentBase.PerformLayout();
            this.groupBoxTotalAnticipatedRepaymentBase.ResumeLayout(false);
            this.groupBoxTotalAnticipatedRepaymentBase.PerformLayout();
            this.groupBoxAnticipatedRepayment.ResumeLayout(false);
            this.groupBoxAnticipatedRepayment.PerformLayout();
            this.groupBoxLateFees.ResumeLayout(false);
            this.groupBoxLateFees.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxEntryFees.ResumeLayout(false);
            this.groupBoxEntryFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntryFeescycleFrom)).EndInit();
            this.tabPageOptionalParameters.ResumeLayout(false);
            this.groupBoxDetailsOptionalParameters.ResumeLayout(false);
            this.groupBoxExoticProducts.ResumeLayout(false);
            this.panelExoticProduct.ResumeLayout(false);
            this.panelExoticProduct.PerformLayout();
            this.groupBoxExoticInstallmentProperties.ResumeLayout(false);
            this.panelExoticInstallment.ResumeLayout(false);
            this.panelExoticInstallment.PerformLayout();
            this.panelExoticProductNavigationButtons.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.tabLOC.ResumeLayout(false);
            this.drawNumGroupBox.ResumeLayout(false);
            this.drawNumGroupBox.PerformLayout();
            this.maxLOCMaturityGroupBox.ResumeLayout(false);
            this.maxLOCMaturityGroupBox.PerformLayout();
            this.maxLOCAmountGroupBox.ResumeLayout(false);
            this.maxLOCAmountGroupBox.PerformLayout();
            this.tabGuarantorsCollaterals.ResumeLayout(false);
            this.tabGuarantorsCollaterals.PerformLayout();
            this.gbCSAmount.ResumeLayout(false);
            this.gbCSAmount.PerformLayout();
            this.groupBoxTotGuarColl.ResumeLayout(false);
            this.groupBoxTotGuarColl.PerformLayout();
            this.groupBoxSepGuarColl.ResumeLayout(false);
            this.groupBoxSepGuarColl.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryFeeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

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
        private ComboBox comboBoxCurrencies;
        private GroupBox groupBoxRoundingType;
        private ComboBox cmbInterestScheme;
        private Label labelLateFeeGracePeriod;
        private TextBox textBoxGracePeriodLateFee;
        private TabPage tabLOC;
        private GroupBox maxLOCAmountGroupBox;
        private Label labelLOCAmount;
        private Label labelLOCMaxAmount;
        private Label labelLOCMinAmount;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private TextBox textBoxAmountUnderLOCMax;
        private TextBox textBoxAmountUnderLOC;
        private TextBox textBoxAmountUnderLOCMin;
        private GroupBox maxLOCMaturityGroupBox;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private TextBox textBoxLOCMaturityMax;
        private TextBox textBoxLOCMaturity;
        private TextBox textBoxLOCMaturityMin;
        private CheckBox useLOCCheckBox;
        private GroupBox drawNumGroupBox;
        private Label drawingNumberLabel;
        private GroupBox gbAnticipatedRepayment;
        private GroupBox groupBoxTotalAnticipatedRepaymentBase;
        private RadioButton rbRemainingOLB;
        private RadioButton rbRemainingInterest;
        private GroupBox groupBoxAnticipatedRepayment;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAnticipatedRepaymentPenaltiesMax;
        private TextBox textBoxAnticipatedRepaymentPenalties;
        private TextBox textBoxAnticipatedRepaymentPenaltiesMin;
        private TextBox textBoxAnticipatedPartialRepaimentMax;
        private TextBox textBoxAnticipatedPartialRepaiment;
        private TextBox textBoxAnticipatedPartialRepaimentMin;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private GroupBox groupBoxPartialAnticipatedRepaymentBase;
        private RadioButton rbPartialRemainingOLB;
        private RadioButton rbPartialRemainingInterest;
        private GroupBox groupBoxAPR;
        private CheckBox checkBoxFlexPackage;
        private TabPage tabGuarantorsCollaterals;
        private CheckBox checkBoxGuarCollRequired;
        private GroupBox groupBoxSepGuarColl;
        private CheckBox checkBoxSetSepCollGuar;
        private GroupBox groupBoxTotGuarColl;
        private Label label33;
        private Label labelMinPercGuar;
        private Label labelMinPercColl;
        private Label label34;
        private Label label44;
        private Label label35;
        private Label label49;
        private TextBox textBoxNumOfDrawings;
        private TextBox textBoxCollGuar;
        private TextBox textBoxGuar;
        private TextBox textBoxColl;
        private GroupBox groupBox12;
        private CheckBox clientTypeVillageCheckBox;
        private CheckBox clientTypeCorpCheckBox;
        private CheckBox clientTypeIndivCheckBox;
        private CheckBox clientTypeGroupCheckBox;
        private CheckBox clientTypeAllCheckBox;
        private CheckBox cbUseCompulsorySavings;
        private GroupBox gbCSAmount;
        private Label lbCompulsoryAmountValue;
        private Label lbCompulsoryAmountMax;
        private Label lbCompulsoryAmountMin;
        private Label lbCompulsoryAmountOr;
        private TextBox txbCompulsoryAmountMax;
        private TextBox txbCompulsoryAmountValue;
        private TextBox txbCompulsoryAmountMin;
        private RadioButton rbCompulsoryAmountRate;
        private RadioButton rbCompulsoryAmountFlat;
        private Label lbCompulsoryAmountType;
        private GroupBox groupBoxEntryFees;
        private BindingSource entryFeeBindingSource;
        private GroupBox gbAdvancedParameters;
        private CheckBox cbUseLoanCycle;
        private OpenCBS.GUI.UserControl.ListViewEx listViewLoanCycles;
        private ColumnHeader colCycle;
        private ColumnHeader colMin;
        private ColumnHeader colMax;
        private RadioButton rbPrepaidPrincipal;
        private ComboBox cbxCycleObjects;
        private Label lblCycleObjects;
        private TabPage tabPage1;
        private GroupBox groupBox9;
        private TextBox tbCreditInsuranceMax;
        private TextBox tbCreditInsuranceMin;
        private Label label50;
        private Label label51;
        private Label label53;
        private Label label52;
        private Label lblEntryFeesCycle;
        private ComboBox cmbEntryFeesCycles;
        private CheckBox cbEnableEntryFeesCycle;
        private Label lblEntryFeesFromCycle;
        private NumericUpDown nudEntryFeescycleFrom;
        private DataGridViewTextBoxColumn nameOfFee;
        private OpenCBS.GUI.UserControl.ListViewEx lvEntryFees;
        private ColumnHeader chEntryFeeId;
        private ColumnHeader chEntryFeeName;
        private ColumnHeader chEntryFeeMin;
        private ColumnHeader chEntryFeeMax;
        private ColumnHeader chEntryFeeValue;
        private ColumnHeader chEntryFeeRate;
        private ColumnHeader chEntryFeeIsAdded;
        private ColumnHeader chEntryFeeCycleId;
        private ColumnHeader chEntryFeeNewId;
        private ColumnHeader chEntryFeeIndex;
        private TextBox tbEntryFeesValues;
        private CheckBox cbxRate;
        private ComboBox cbRate;
        private System.Windows.Forms.Button swbtnEntryFeesAddCycle;
        private System.Windows.Forms.Button swbtnEntryFeesRemoveCycle;
        private System.Windows.Forms.Button buttonNewExoticProduct;
        private ComboBox cmbInterestRateType;
    }
}