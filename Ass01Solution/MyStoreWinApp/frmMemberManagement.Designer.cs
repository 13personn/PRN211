namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            btnNew = new Button();
            cbxCountry = new ComboBox();
            cbxCity = new ComboBox();
            btnExit = new Button();
            btnLoad = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            lbID = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbName = new Label();
            btnDelete = new Button();
            txtEmail = new TextBox();
            btnEmail = new Label();
            btnUpdate = new Button();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnClear = new Button();
            btnSort = new Button();
            txtSearchByID = new TextBox();
            txtSearchByName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(579, 149);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 62;
            dgvMemberList.RowTemplate.Height = 33;
            dgvMemberList.Size = new Size(595, 336);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellClick += dgvMemberList_CellClick;
            dgvMemberList.CellContentClick += dgvMemberList_CellDoubleClick;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(63, 478);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(104, 39);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // cbxCountry
            // 
            cbxCountry.FormattingEnabled = true;
            cbxCountry.Location = new Point(178, 196);
            cbxCountry.Name = "cbxCountry";
            cbxCountry.Size = new Size(224, 33);
            cbxCountry.TabIndex = 5;
            // 
            // cbxCity
            // 
            cbxCity.FormattingEnabled = true;
            cbxCity.Location = new Point(178, 141);
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new Size(224, 33);
            cbxCity.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(867, 491);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 39);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(437, 478);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 39);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(178, 42);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 31);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 31);
            txtName.TabIndex = 1;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(111, 45);
            lbID.Name = "lbID";
            lbID.Size = new Size(30, 25);
            lbID.TabIndex = 4;
            lbID.Text = "ID";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(92, 149);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(42, 25);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(92, 204);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(75, 25);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(98, 98);
            lbName.Name = "lbName";
            lbName.Size = new Size(59, 25);
            lbName.TabIndex = 4;
            lbName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(249, 374);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 37);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(562, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 31);
            txtEmail.TabIndex = 3;
            // 
            // btnEmail
            // 
            btnEmail.AutoSize = true;
            btnEmail.Location = new Point(487, 98);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(54, 25);
            btnEmail.TabIndex = 6;
            btnEmail.Text = "Email";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(63, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(469, 44);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(562, 45);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 31);
            txtPassword.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(437, 372);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 37);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(249, 478);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 9;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtSearchByID
            // 
            txtSearchByID.Location = new Point(178, 262);
            txtSearchByID.Name = "txtSearchByID";
            txtSearchByID.Size = new Size(224, 31);
            txtSearchByID.TabIndex = 0;
            txtSearchByID.TextChanged += txtSearchByID_TextChanged;
            // 
            // txtSearchByName
            // 
            txtSearchByName.Location = new Point(178, 316);
            txtSearchByName.Name = "txtSearchByName";
            txtSearchByName.Size = new Size(224, 31);
            txtSearchByName.TabIndex = 0;
            txtSearchByName.TextChanged += btnSearchByName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 268);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 10;
            label1.Text = "Search By ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 316);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 10;
            label2.Text = "Search By Name";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 529);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSort);
            Controls.Add(btnClear);
            Controls.Add(txtPassword);
            Controls.Add(btnUpdate);
            Controls.Add(btnEmail);
            Controls.Add(txtEmail);
            Controls.Add(lbName);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(lbCity);
            Controls.Add(lbID);
            Controls.Add(txtName);
            Controls.Add(txtSearchByName);
            Controls.Add(txtSearchByID);
            Controls.Add(txtID);
            Controls.Add(cbxCity);
            Controls.Add(cbxCountry);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(btnExit);
            Controls.Add(dgvMemberList);
            Name = "frmMemberManagement";
            Text = "Form1";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Button btnNew;
        private ComboBox cbxCountry;
        private ComboBox cbxCity;
        private Button btnExit;
        private Button btnLoad;
        private TextBox txtID;
        private TextBox txtName;
        private Label lbID;
        private Label lbCity;
        private Label lbCountry;
        private Label lbName;
        private Button btnDelete;
        private TextBox txtEmail;
        private Label btnEmail;
        private Button btnUpdate;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnClear;
        private Button btnSort;
        private TextBox txtSearchByID;
        private TextBox txtSearchByName;
        private Label label1;
        private Label label2;
    }
}