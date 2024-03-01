namespace SalesWinApp
{
    partial class frmLogin
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
            lbemail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancle = new Button();
            SuspendLayout();
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Location = new Point(53, 99);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(63, 25);
            lbemail.TabIndex = 0;
            lbemail.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 31);
            txtEmail.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(29, 176);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(91, 25);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(155, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(256, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(132, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(324, 288);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(112, 34);
            btnCancle.TabIndex = 2;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancle);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbemail);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbemail;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancle;
    }
}