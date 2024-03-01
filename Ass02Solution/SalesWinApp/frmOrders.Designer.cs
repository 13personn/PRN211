namespace SalesWinApp
{
    partial class frmOrders
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
            label6 = new Label();
            Country = new Label();
            City = new Label();
            txtShippedDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtFreight = new TextBox();
            txtMemberId = new TextBox();
            txtOrderDate = new TextBox();
            txtOrderId = new TextBox();
            btnLoad = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvOrderList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnloadOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 546);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 17;
            label6.Text = "Shipped Date";
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(30, 495);
            Country.Name = "Country";
            Country.Size = new Size(95, 25);
            Country.TabIndex = 18;
            Country.Text = "OrderDate";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(48, 444);
            City.Name = "City";
            City.Size = new Size(74, 25);
            City.TabIndex = 19;
            City.Text = "OrderId";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(446, 546);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(150, 31);
            txtShippedDate.TabIndex = 11;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(446, 489);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(150, 31);
            txtRequiredDate.TabIndex = 12;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(131, 546);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(150, 31);
            txtFreight.TabIndex = 13;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(446, 439);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(150, 31);
            txtMemberId.TabIndex = 14;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(131, 492);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(150, 31);
            txtOrderDate.TabIndex = 15;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(131, 436);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(150, 31);
            txtOrderId.TabIndex = 16;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(796, 446);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(936, 439);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(945, 509);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(641, 509);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(796, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(48, 2);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 62;
            dgvOrderList.RowTemplate.Height = 33;
            dgvOrderList.Size = new Size(1021, 428);
            dgvOrderList.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 446);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 19;
            label1.Text = "Member Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 489);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 18;
            label2.Text = "Required Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 549);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 18;
            label3.Text = "Freight";
            // 
            // btnloadOrder
            // 
            btnloadOrder.Location = new Point(641, 444);
            btnloadOrder.Name = "btnloadOrder";
            btnloadOrder.Size = new Size(112, 34);
            btnloadOrder.TabIndex = 6;
            btnloadOrder.Text = "Load Order";
            btnloadOrder.UseVisualStyleBackColor = true;
            btnloadOrder.Click += btnloadOrder_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 597);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(Country);
            Controls.Add(City);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberId);
            Controls.Add(txtOrderDate);
            Controls.Add(txtOrderId);
            Controls.Add(btnloadOrder);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvOrderList);
            Name = "frmOrders";
            Text = "Orders";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label Country;
        private Label City;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private TextBox txtFreight;
        private TextBox txtMemberId;
        private TextBox txtOrderDate;
        private TextBox txtOrderId;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvOrderList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnloadOrder;
    }
}