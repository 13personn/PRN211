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
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
            
        }

        public IProductRepository productrrepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject productInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductObject();
                int productId, categoryId, unitsInStock;

                if (int.TryParse(txtProductID.Text, out productId) &&
                    int.TryParse(txtCategoryId.Text, out categoryId) &&
                    decimal.TryParse(txtUnitPrice.Text, out var unitPrice) &&
                    int.TryParse(txtUnitdStock.Text, out unitsInStock))
                {
                    // Dữ liệu nhập vào hợp lệ, gán giá trị cho đối tượng sản phẩm
                    product.ProductId = productId;
                    product.CategoryId = categoryId;
                    product.ProductName = txtProductName.Text;
                    product.Weight = txtWeight.Text;
                    product.UnitPrice = unitPrice;
                    product.UnitslnStock = unitsInStock;
                }
                else
                {
                    // Hiển thị thông báo hoặc xử lý lỗi khi dữ liệu không hợp lệ
                    MessageBox.Show("Invalid input. Please enter valid numeric values for Product ID, Category ID, Unit Price, and Units In Stock.");
                }
                if (InsertOrUpdate == false)
                {
                    productrrepository.InsertProduct(product);


                }
                else
                {
                    productrrepository.UpdateProduct(product);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) 
            {
            txtProductID.Text=productInfo.ProductId.ToString(); 
                txtCategoryId.Text=productInfo.CategoryId.ToString();
                txtProductName.Text=productInfo.ProductName.ToString();
                txtWeight.Text=productInfo.Weight.ToString();
                txtUnitPrice.Text=productInfo.UnitPrice.ToString();
                txtUnitdStock.Text=productInfo.UnitslnStock.ToString();
            }
        }
    }
}
