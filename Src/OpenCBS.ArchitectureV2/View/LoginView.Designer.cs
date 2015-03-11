using System.Windows.Forms;

namespace OpenCBS.ArchitectureV2.View
{
    public partial class LoginView
    {
        private System.Windows.Forms.Button _loginButton;
        private TextBox _usernameTextBox;
        private TextBox _passwordTextBox;
        private Label _usernameLabel;
        private Label _passwordLabel;
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.Container components = null;

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

        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this._loginButton = new System.Windows.Forms.Button();
            this._usernameTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._databaseComboBox = new System.Windows.Forms.ComboBox();
            this._databaseLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _loginButton
            // 
            resources.ApplyResources(this._loginButton, "_loginButton");
            this._loginButton.BackColor = System.Drawing.SystemColors.Control;
            this._loginButton.Name = "_loginButton";
            this._loginButton.UseVisualStyleBackColor = false;
            // 
            // _usernameTextBox
            // 
            resources.ApplyResources(this._usernameTextBox, "_usernameTextBox");
            this._usernameTextBox.Name = "_usernameTextBox";
            this._usernameTextBox.TextChanged += new System.EventHandler(this._usernameTextBox_TextChanged);
            // 
            // _passwordTextBox
            // 
            resources.ApplyResources(this._passwordTextBox, "_passwordTextBox");
            this._passwordTextBox.Name = "_passwordTextBox";
            // 
            // _usernameLabel
            // 
            resources.ApplyResources(this._usernameLabel, "_usernameLabel");
            this._usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Click += new System.EventHandler(this._usernameLabel_Click);
            // 
            // _passwordLabel
            // 
            resources.ApplyResources(this._passwordLabel, "_passwordLabel");
            this._passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Click += new System.EventHandler(this._passwordLabel_Click);
            // 
            // _databaseComboBox
            // 
            resources.ApplyResources(this._databaseComboBox, "_databaseComboBox");
            this._databaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._databaseComboBox.FormattingEnabled = true;
            this._databaseComboBox.Name = "_databaseComboBox";
            // 
            // _databaseLabel
            // 
            resources.ApplyResources(this._databaseLabel, "_databaseLabel");
            this._databaseLabel.BackColor = System.Drawing.Color.Transparent;
            this._databaseLabel.Name = "_databaseLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenCBS.ArchitectureV2.Properties.Resources.FLS_logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OpenCBS.ArchitectureV2.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // LoginView
            // 
            this.AcceptButton = this._loginButton;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._databaseComboBox);
            this.Controls.Add(this._usernameTextBox);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._databaseLabel);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ComboBox _databaseComboBox;
        private Label _databaseLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;

    }
}
