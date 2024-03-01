using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        public MemberObject memberObjecttest { get; set; }

        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            loadOrderList();
        }

        public void loadOrderList()
        {
            var orders = orderRepository.GetOrders();
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");


                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                if (orders == null)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderDetail orderDetail = new frmOrderDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                orderrepository = orderRepository
            };
            if (orderDetail.ShowDialog() == DialogResult.OK)
            {
                loadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderdetail = new frmOrderDetail
            {
                Text = "Update order",
                InsertOrUpdate = true,
                orderInfo = GetOrderObject(),
                orderrepository = orderRepository


            };
            if (frmOrderdetail.ShowDialog() == DialogResult.OK)
            {
                loadOrderList();
            }

        }

        private OrderObject GetOrderObject()
        {
            OrderObject orders = null;
            try
            {
                orders = new OrderObject
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtOrderId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = Decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get orders");
            }
            return orders;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.DeleteOder(order.OrderId);
                loadOrderList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnloadOrder_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled= true;
            OrderObject order = orderRepository.GetOrderByMemberID(memberObjecttest.MemberId);
            try
            {
                source = new BindingSource();
                source.DataSource = order;

                txtOrderId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");


                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                if (order == null)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            if (memberObjecttest != null) 
            {
            btnLoad.Enabled = false;
               
            }
            
        }
    }
}
