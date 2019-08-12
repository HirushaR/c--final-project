namespace Hotel_Manager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.signinButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(217, 117);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.passwordLabel.Location = new System.Drawing.Point(216, 188);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordLabel.Visible = false;
            // 
            // signinButton
            // 
            this.signinButton.DisplayFocus = true;
            this.signinButton.Location = new System.Drawing.Point(220, 287);
            this.signinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(271, 37);
            this.signinButton.Style = MetroFramework.MetroColorStyle.Green;
            this.signinButton.TabIndex = 6;
            this.signinButton.Text = "Sign in";
            this.signinButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signinButton.UseCustomForeColor = true;
            this.signinButton.UseSelectable = true;
            this.signinButton.UseStyleColors = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.Icon")));
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(219, 215);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PromptText = "Password";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(272, 36);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.UseStyleColors = true;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.usernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usernameTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.Icon")));
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(219, 148);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PromptText = "Username";
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(272, 36);
            this.usernameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.UseStyleColors = true;
            this.usernameTextBox.Click += new System.EventHandler(this.usernameTextBox_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 464);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.usernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroButton signinButton;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        
       
    }
}

