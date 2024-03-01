namespace SalesWinApp
{
    partial class frmMemberDetail
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
            btnCancel = new Button();
            btnSave = new Button();
            txtMemberid = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberCompanyName = new TextBox();
            txtMemberCity = new TextBox();
            txtMemberCountry = new TextBox();
            txtMemberPassword = new TextBox();
            lbMemberId = new Label();
            lbEmail = new Label();
            lbCompanyName = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(582, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(582, 111);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMemberid
            // 
            txtMemberid.Location = new Point(168, 50);
            txtMemberid.Name = "txtMemberid";
            txtMemberid.Size = new Size(269, 31);
            txtMemberid.TabIndex = 6;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(168, 108);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(269, 31);
            txtMemberEmail.TabIndex = 6;
            // 
            // txtMemberCompanyName
            // 
            txtMemberCompanyName.Location = new Point(168, 166);
            txtMemberCompanyName.Name = "txtMemberCompanyName";
            txtMemberCompanyName.Size = new Size(269, 31);
            txtMemberCompanyName.TabIndex = 6;
            // 
            // txtMemberCity
            // 
            txtMemberCity.Location = new Point(168, 227);
            txtMemberCity.Name = "txtMemberCity";
            txtMemberCity.Size = new Size(269, 31);
            txtMemberCity.TabIndex = 6;
            // 
            // txtMemberCountry
            // 
            txtMemberCountry.Location = new Point(168, 282);
            txtMemberCountry.Name = "txtMemberCountry";
            txtMemberCountry.Size = new Size(269, 31);
            txtMemberCountry.TabIndex = 6;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.Location = new Point(168, 339);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(269, 31);
            txtMemberPassword.TabIndex = 6;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(71, 53);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(27, 25);
            lbMemberId.TabIndex = 7;
            lbMemberId.Text = "id";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(71, 111);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(12, 169);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(141, 25);
            lbCompanyName.TabIndex = 7;
            lbCompanyName.Text = "Company Name";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(71, 230);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(42, 25);
            lbCity.TabIndex = 7;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(71, 285);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(75, 25);
            lbCountry.TabIndex = 7;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(71, 342);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 7;
            lbPassword.Text = "Password";
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberId);
            Controls.Add(txtMemberPassword);
            Controls.Add(txtMemberCountry);
            Controls.Add(txtMemberCity);
            Controls.Add(txtMemberCompanyName);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberid);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmMemberDetail";
            Text = "MemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMemberid;
        private TextBox txtMemberEmail;
        private TextBox txtMemberCompanyName;
        private TextBox txtMemberCity;
        private TextBox txtMemberCountry;
        private TextBox txtMemberPassword;
        private Label lbMemberId;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
    }
}