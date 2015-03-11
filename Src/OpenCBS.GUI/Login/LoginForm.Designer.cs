
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Login
{
    public partial class LoginForm
    {
        private System.Windows.Forms.Button startButton;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label usernameLabel;
        private Label passwordLabel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.startButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.databaseCombobox = new System.Windows.Forms.ComboBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // usernameTextbox
            // 
            resources.ApplyResources(this.usernameTextbox, "usernameTextbox");
            this.usernameTextbox.Name = "usernameTextbox";
            // 
            // passwordTextbox
            // 
            resources.ApplyResources(this.passwordTextbox, "passwordTextbox");
            this.passwordTextbox.Name = "passwordTextbox";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // databaseCombobox
            // 
            this.databaseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseCombobox.FormattingEnabled = true;
            resources.ApplyResources(this.databaseCombobox, "databaseCombobox");
            this.databaseCombobox.Name = "databaseCombobox";
            // 
            // databaseLabel
            // 
            this.databaseLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.databaseLabel, "databaseLabel");
            this.databaseLabel.Name = "databaseLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenCBS.GUI.Properties.Resources.FLS_logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OpenCBS.GUI.Properties.Resources.LOGO;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.startButton;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.databaseCombobox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ComboBox databaseCombobox;
        private Label databaseLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;

    }
}
