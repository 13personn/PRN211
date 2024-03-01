using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int productId)=>ProductDAO.Instance.Remove(productId);

        public ProductObject GetProductByID(int ProductId)=>ProductDAO.Instance.GetProductByID(ProductId);

        public IEnumerable<ProductObject> GetProducts()=>ProductDAO.Instance.GetProductList();

        public void InsertProduct(ProductObject Product)=>ProductDAO.Instance.AddNew(Product);

        public void UpdateProduct(ProductObject product)=>ProductDAO.Instance.Update(product);
    }
}
