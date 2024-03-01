using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
        }
        public IOrderRepository orderrepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderObject orderInfo { get; set; }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId, memberId;
                decimal freight;
                DateTime orderDate, requiredDate, shippedDate;

                if (!int.TryParse(txtOrderId.Text, out orderId) || !int.TryParse(txtMemberId.Text, out memberId) ||
                    !decimal.TryParse(txtFreight.Text, out freight) ||
                    !DateTime.TryParse(DtpOrderDate.Text, out orderDate) ||
                    !DateTime.TryParse(DtpRequiredDate.Text, out requiredDate) ||
                    !DateTime.TryParse(DtpShippedDate.Text, out shippedDate))
                {
                    MessageBox.Show("Invalid input format. Please check your input.", "Error");
                    return;
                }

                var order = new OrderObject
                {
                    OrderId = orderId,
                    MemberId = memberId,
                    OrderDate = orderDate,
                    RequiredDate = requiredDate,
                    ShippedDate = shippedDate,
                    Freight = freight
                };

                if (InsertOrUpdate == false)
                {
                    orderrepository.InsertOrder(order);
                    MessageBox.Show("New order added successfully.", "Success");
                }
                else
                {
                    orderrepository.UpdateOrder(order);
                    MessageBox.Show("Order updated successfully.", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true) 
            {
                txtOrderId.Text = orderInfo.OrderId.ToString();
                txtMemberId.Text = orderInfo.MemberId.ToString();
                txtFreight.Text = orderInfo.Freight.ToString();
                DtpOrderDate.Text = orderInfo.OrderDate.ToString();
                DtpRequiredDate.Text = orderInfo.RequiredDate.ToString();
                DtpShippedDate.Text = orderInfo.ShippedDate.ToString();
            }
        }
    }
}
