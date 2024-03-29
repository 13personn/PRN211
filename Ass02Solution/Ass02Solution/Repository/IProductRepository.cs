﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetProducts();
        ProductObject GetProductByID(int ProductId);
        void InsertProduct(ProductObject Product);
        void DeleteProduct(int productId);
        void UpdateProduct(ProductObject product);
    }
}
