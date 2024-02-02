namespace MyStoreWinApp
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
            txtIDdetail = new TextBox();
            txtNamedetail = new TextBox();
            txtPassworddetail = new TextBox();
            txtEmaildetail = new TextBox();
            txtCitydetail = new TextBox();
            lbID = new Label();
            lbName = new Label();
            lbPassword = new Label();
            lbEmail = new Label();
            lbCity = new Label();
            btnSave = new Button();
            btnCancle = new Button();
            txtCountrydetail = new TextBox();
            lbCountry = new Label();
            SuspendLayout();
            // 
            // txtIDdetail
            // 
            txtIDdetail.Location = new Point(241, 51);
            txtIDdetail.Name = "txtIDdetail";
            txtIDdetail.Size = new Size(213, 31);
            txtIDdetail.TabIndex = 0;
            // 
            // txtNamedetail
            // 
            txtNamedetail.Location = new Point(241, 105);
            txtNamedetail.Name = "txtNamedetail";
            txtNamedetail.Size = new Size(213, 31);
            txtNamedetail.TabIndex = 0;
            // 
            // txtPassworddetail
            // 
            txtPassworddetail.Location = new Point(241, 170);
            txtPassworddetail.Name = "txtPassworddetail";
            txtPassworddetail.Size = new Size(213, 31);
            txtPassworddetail.TabIndex = 0;
            // 
            // txtEmaildetail
            // 
            txtEmaildetail.Location = new Point(241, 241);
            txtEmaildetail.Name = "txtEmaildetail";
            txtEmaildetail.Size = new Size(213, 31);
            txtEmaildetail.TabIndex = 0;
            // 
            // txtCitydetail
            // 
            txtCitydetail.Location = new Point(241, 307);
            txtCitydetail.Name = "txtCitydetail";
            txtCitydetail.Size = new Size(213, 31);
            txtCitydetail.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(151, 54);
            lbID.Name = "lbID";
            lbID.Size = new Size(30, 25);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(151, 111);
            lbName.Name = "lbName";
            lbName.Size = new Size(59, 25);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(151, 176);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(151, 244);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(151, 313);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(42, 25);
            lbCity.TabIndex = 1;
            lbCity.Text = "City";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(618, 113);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(618, 218);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(111, 36);
            btnCancle.TabIndex = 2;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // txtCountrydetail
            // 
            txtCountrydetail.Location = new Point(241, 366);
            txtCountrydetail.Name = "txtCountrydetail";
            txtCountrydetail.Size = new Size(213, 31);
            txtCountrydetail.TabIndex = 0;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(151, 372);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(75, 25);
            lbCountry.TabIndex = 1;
            lbCountry.Text = "Country";
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Controls.Add(txtCountrydetail);
            Controls.Add(txtCitydetail);
            Controls.Add(txtEmaildetail);
            Controls.Add(txtPassworddetail);
            Controls.Add(txtNamedetail);
            Controls.Add(txtIDdetail);
            Name = "frmMemberDetail";
            Text = "FrmUpdateOrCreate";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDdetail;
        private TextBox txtNamedetail;
        private TextBox txtPassworddetail;
        private TextBox txtEmaildetail;
        private TextBox txtCitydetail;
        private Label lbID;
        private Label lbName;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbCity;
        private Button btnSave;
        private Button btnCancle;
        private TextBox txtCountrydetail;
        private Label lbCountry;
    }
}