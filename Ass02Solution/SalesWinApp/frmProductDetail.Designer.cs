namespace SalesWinApp
{
    partial class frmProductDetail
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            Country = new Label();
            City = new Label();
            txtUnitdStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtCategoryId = new TextBox();
            txtProductID = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(629, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(629, 126);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 179);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 39;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 125);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 40;
            label3.Text = "Categoryid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 72);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 41;
            label4.Text = "Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 340);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 38;
            label6.Text = "UnitslnStock";
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(118, 286);
            Country.Name = "Country";
            Country.Size = new Size(81, 25);
            Country.TabIndex = 37;
            Country.Text = "UnitPrice";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(131, 235);
            City.Name = "City";
            City.Size = new Size(68, 25);
            City.TabIndex = 36;
            City.Text = "Weight";
            // 
            // txtUnitdStock
            // 
            txtUnitdStock.Location = new Point(211, 337);
            txtUnitdStock.Name = "txtUnitdStock";
            txtUnitdStock.Size = new Size(293, 31);
            txtUnitdStock.TabIndex = 34;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(211, 280);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(293, 31);
            txtUnitPrice.TabIndex = 35;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(211, 179);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(293, 31);
            txtProductName.TabIndex = 33;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(211, 230);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(293, 31);
            txtWeight.TabIndex = 32;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(211, 125);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(293, 31);
            txtCategoryId.TabIndex = 31;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(211, 69);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(293, 31);
            txtProductID.TabIndex = 30;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(Country);
            Controls.Add(City);
            Controls.Add(txtUnitdStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryId);
            Controls.Add(txtProductID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProductDetail";
            Text = "frmProductDetail";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label Country;
        private Label City;
        private TextBox txtUnitdStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtCategoryId;
        private TextBox txtProductID;
    }
}