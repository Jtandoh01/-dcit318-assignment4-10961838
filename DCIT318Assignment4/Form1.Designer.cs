namespace DCIT318Assignment4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webService1 = new System.Web.Services.WebService();
            this.TboxUser = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TboxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TboxUser
            // 
            this.TboxUser.AcceptsTab = true;
            this.TboxUser.Location = new System.Drawing.Point(142, 43);
            this.TboxUser.Name = "TboxUser";
            this.TboxUser.Size = new System.Drawing.Size(319, 20);
            this.TboxUser.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.userNameLabel.Location = new System.Drawing.Point(59, 42);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(77, 19);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLable.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passwordLable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLable.Location = new System.Drawing.Point(62, 99);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(72, 19);
            this.passwordLable.TabIndex = 2;
            this.passwordLable.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LoginButton.Location = new System.Drawing.Point(140, 151);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(198, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // TboxPassword
            // 
            this.TboxPassword.Location = new System.Drawing.Point(142, 97);
            this.TboxPassword.Name = "TboxPassword";
            this.TboxPassword.Size = new System.Drawing.Size(319, 20);
            this.TboxPassword.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.LoginButton;
            this.ClientSize = new System.Drawing.Size(697, 313);
            this.Controls.Add(this.TboxPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.TboxUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Web.Services.WebService webService1;
        private System.Windows.Forms.TextBox TboxUser;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox TboxPassword;
    }
}

