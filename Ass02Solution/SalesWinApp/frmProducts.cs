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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            loadProductList();
        }

        public void loadProductList()
        {
            var products = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitdStock.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitdStock.DataBindings.Add("Text", source, "UnitslnStock");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");


                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (products == null)
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

                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail productDetail = new frmProductDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                productrrepository = productRepository
            };
            if (productDetail.ShowDialog() == DialogResult.OK)
            {
                loadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductDetail productDetail = new frmProductDetail
            {
                Text = "Update car",
                InsertOrUpdate = true,
                productInfo = GetProductObject(),
                productrrepository = productRepository


            };
            if (productDetail.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {

                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                    UnitslnStock = int.Parse(txtUnitdStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product.ProductId);
                loadProductList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
