namespace SalesWinApp
{
    partial class frmProducts
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
            textBox1 = new TextBox();
            lbSearch = new Label();
            btnSearch = new Button();
            label6 = new Label();
            Password = new Label();
            Country = new Label();
            Email = new Label();
            City = new Label();
            label1 = new Label();
            txtUnitdStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtCategoryId = new TextBox();
            txtProductID = new TextBox();
            btnLoad = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProductList = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 6;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(74, 399);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(64, 25);
            lbSearch.TabIndex = 7;
            lbSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(474, 396);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 574);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 26;
            label6.Text = "UnitslnStock";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(-115, 524);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 25;
            Password.Text = "Password";
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(359, 520);
            Country.Name = "Country";
            Country.Size = new Size(81, 25);
            Country.TabIndex = 24;
            Country.Text = "UnitPrice";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(-105, 470);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 23;
            Email.Text = "Email";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(372, 469);
            City.Name = "City";
            City.Size = new Size(68, 25);
            City.TabIndex = 22;
            City.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-105, 417);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 21;
            label1.Text = "Id";
            // 
            // txtUnitdStock
            // 
            txtUnitdStock.Location = new Point(452, 571);
            txtUnitdStock.Name = "txtUnitdStock";
            txtUnitdStock.Size = new Size(150, 31);
            txtUnitdStock.TabIndex = 19;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(452, 514);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(150, 31);
            txtUnitPrice.TabIndex = 20;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(135, 571);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 18;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(452, 464);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(150, 31);
            txtWeight.TabIndex = 17;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(135, 517);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(150, 31);
            txtCategoryId.TabIndex = 16;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(135, 461);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(150, 31);
            txtProductID.TabIndex = 15;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(750, 465);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(890, 464);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(899, 534);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(619, 534);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(750, 534);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 9);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 62;
            dgvProductList.RowTemplate.Height = 33;
            dgvProductList.Size = new Size(1021, 418);
            dgvProductList.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 571);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 27;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 517);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 28;
            label3.Text = "Categoryid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 464);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 29;
            label4.Text = "Id";
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 670);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(Password);
            Controls.Add(Country);
            Controls.Add(Email);
            Controls.Add(City);
            Controls.Add(label1);
            Controls.Add(txtUnitdStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryId);
            Controls.Add(txtProductID);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvProductList);
            Controls.Add(btnSearch);
            Controls.Add(lbSearch);
            Controls.Add(textBox1);
            Name = "frmProducts";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label lbSearch;
        private Button btnSearch;
        private Label label6;
        private Label Password;
        private Label Country;
        private Label Email;
        private Label City;
        private Label label1;
        private TextBox txtUnitdStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtCategoryId;
        private TextBox txtProductID;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProductList;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}