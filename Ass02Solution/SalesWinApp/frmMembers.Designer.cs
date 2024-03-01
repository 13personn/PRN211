namespace SalesWinApp
{
    partial class frmMembers
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
            dgvMemberList = new DataGridView();
            btnDelete = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnLoad = new Button();
            txtMemberID = new TextBox();
            label1 = new Label();
            txtMemberEmail = new TextBox();
            Email = new Label();
            txtMemberPassword = new TextBox();
            Password = new Label();
            txtMemberCity = new TextBox();
            txtMemberCountry = new TextBox();
            txtMemberCompanyName = new TextBox();
            City = new Label();
            Country = new Label();
            label6 = new Label();
            btnLoadProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(7, 12);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 62;
            dgvMemberList.RowTemplate.Height = 33;
            dgvMemberList.Size = new Size(1021, 418);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            dgvMemberList.CellValueChanged += dgvMemberList_CellValueChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(755, 535);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(904, 535);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(895, 465);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(600, 535);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(755, 472);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(90, 462);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(150, 31);
            txtMemberID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 468);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(90, 518);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(150, 31);
            txtMemberEmail.TabIndex = 2;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(7, 521);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.Location = new Point(90, 572);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(150, 31);
            txtMemberPassword.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(-3, 575);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtMemberCity
            // 
            txtMemberCity.Location = new Point(405, 465);
            txtMemberCity.Name = "txtMemberCity";
            txtMemberCity.Size = new Size(150, 31);
            txtMemberCity.TabIndex = 2;
            // 
            // txtMemberCountry
            // 
            txtMemberCountry.Location = new Point(405, 515);
            txtMemberCountry.Name = "txtMemberCountry";
            txtMemberCountry.Size = new Size(150, 31);
            txtMemberCountry.TabIndex = 2;
            // 
            // txtMemberCompanyName
            // 
            txtMemberCompanyName.Location = new Point(405, 572);
            txtMemberCompanyName.Name = "txtMemberCompanyName";
            txtMemberCompanyName.Size = new Size(150, 31);
            txtMemberCompanyName.TabIndex = 2;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(345, 471);
            City.Name = "City";
            City.Size = new Size(42, 25);
            City.TabIndex = 3;
            City.Text = "City";
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(312, 521);
            Country.Name = "Country";
            Country.Size = new Size(75, 25);
            Country.TabIndex = 3;
            Country.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 575);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 3;
            label6.Text = "Company Name";
            // 
            // btnLoadProfile
            // 
            btnLoadProfile.Location = new Point(578, 469);
            btnLoadProfile.Name = "btnLoadProfile";
            btnLoadProfile.Size = new Size(160, 40);
            btnLoadProfile.TabIndex = 4;
            btnLoadProfile.Text = "Load Profile";
            btnLoadProfile.UseVisualStyleBackColor = true;
            btnLoadProfile.Click += btnLoadProfile_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 703);
            Controls.Add(btnLoadProfile);
            Controls.Add(label6);
            Controls.Add(Password);
            Controls.Add(Country);
            Controls.Add(Email);
            Controls.Add(City);
            Controls.Add(label1);
            Controls.Add(txtMemberCompanyName);
            Controls.Add(txtMemberCountry);
            Controls.Add(txtMemberPassword);
            Controls.Add(txtMemberCity);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberID);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvMemberList);
            Name = "frmMembers";
            Text = "Members";
            TopMost = true;
            Load += frmMembers_Load;
            MdiChildActivate += frmMembers_MdiChildActivate;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnLoad;
        private TextBox txtMemberID;
        private Label label1;
        private TextBox txtMemberEmail;
        private Label Email;
        private TextBox txtMemberPassword;
        private Label Password;
        private TextBox txtMemberCity;
        private TextBox txtMemberCountry;
        private TextBox txtMemberCompanyName;
        private Label City;
        private Label Country;
        private Label label6;
        private Button btnLoadProfile;
    }
}