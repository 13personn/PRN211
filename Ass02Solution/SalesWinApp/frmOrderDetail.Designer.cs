namespace SalesWinApp
{
    partial class frmOrderDetail
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
            lbPassword = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            lbCompanyName = new Label();
            lbEmail = new Label();
            lbMemberId = new Label();
            txtFreight = new TextBox();
            txtMemberId = new TextBox();
            txtOrderId = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            DtpOrderDate = new DateTimePicker();
            DtpRequiredDate = new DateTimePicker();
            DtpShippedDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(118, 360);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(67, 25);
            lbPassword.TabIndex = 16;
            lbPassword.Text = "Freight";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(77, 303);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(115, 25);
            lbCountry.TabIndex = 17;
            lbCountry.Text = "ShippedDate";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(77, 248);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(119, 25);
            lbCity.TabIndex = 18;
            lbCity.Text = "RequiredDate";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(97, 184);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(95, 25);
            lbCompanyName.TabIndex = 19;
            lbCompanyName.Text = "OrderDate";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(97, 126);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(95, 25);
            lbEmail.TabIndex = 20;
            lbEmail.Text = "MemberId";
            lbEmail.Click += lbEmail_Click;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(118, 68);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(74, 25);
            lbMemberId.TabIndex = 21;
            lbMemberId.Text = "OrderId";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(215, 354);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(300, 31);
            txtFreight.TabIndex = 10;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(215, 123);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(300, 31);
            txtMemberId.TabIndex = 14;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(215, 65);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(300, 31);
            txtOrderId.TabIndex = 15;
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
            // DtpOrderDate
            // 
            DtpOrderDate.Location = new Point(215, 184);
            DtpOrderDate.Name = "DtpOrderDate";
            DtpOrderDate.Size = new Size(300, 31);
            DtpOrderDate.TabIndex = 22;
            // 
            // DtpRequiredDate
            // 
            DtpRequiredDate.Location = new Point(215, 242);
            DtpRequiredDate.Name = "DtpRequiredDate";
            DtpRequiredDate.Size = new Size(300, 31);
            DtpRequiredDate.TabIndex = 22;
            // 
            // DtpShippedDate
            // 
            DtpShippedDate.Location = new Point(215, 298);
            DtpShippedDate.Name = "DtpShippedDate";
            DtpShippedDate.Size = new Size(300, 31);
            DtpShippedDate.TabIndex = 22;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DtpShippedDate);
            Controls.Add(DtpRequiredDate);
            Controls.Add(DtpOrderDate);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberId);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberId);
            Controls.Add(txtOrderId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPassword;
        private Label lbCountry;
        private Label lbCity;
        private Label lbCompanyName;
        private Label lbEmail;
        private Label lbMemberId;
        private TextBox txtFreight;
        private TextBox txtMemberId;
        private TextBox txtOrderId;
        private Button btnCancel;
        private Button btnSave;
        private DateTimePicker DtpOrderDate;
        private DateTimePicker DtpRequiredDate;
        private DateTimePicker DtpShippedDate;
    }
}