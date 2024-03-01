using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.DataAccess;


namespace DataAccess
{
    internal class ProductDAO: BaseDAL
    {

        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitslnStock from Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitslnStock = dataReader.GetInt32(5),
                        

                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }

        public ProductObject GetProductByID(int productId)
        {
            ProductObject product = null;
            IDataReader dataReader = null;
            string SQLSelect = 
                "select ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitslnStock from Product where ProductId =@ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32); //chua hieu
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader!=null&& dataReader.Read())
                {
                    product= new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitslnStock = dataReader.GetInt32(5)
                       


                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return product;
        }

        public void AddNew(ProductObject product)
        {
            try
            {
                ProductObject productTest = GetProductByID(product.ProductId);
                if (productTest == null)
                {
                   

                    string SQLInsert = "Insert Product values(@ProductId,@CategoryId,@ProductName ,@Weight,@UnitPrice ,@UnitslnStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 500000, product.UnitPrice, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitslnStock", 50000, product.UnitslnStock, DbType.String));
                   
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());


                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(ProductObject product)
        {
            try
            {


                ProductObject productTest = GetProductByID(product.ProductId);
                if (productTest != null)
                {
                    string SQLUpdate = "UPDATE Product SET " +
                        "CategoryId=@CategoryId, ProductName=@ProductName,Weight=@Weight,\r\nUnitPrice=@UnitPrice,UnitslnStock=@UnitslnStock where ProductId=@ProductId";

                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, productTest.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, productTest.CategoryId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, productTest.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, productTest.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 500000, productTest.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitslnStock", 50000, productTest.UnitslnStock, DbType.Int32));

                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int productID)
        {
            try
            {
                ProductObject product = GetProductByID(productID);
                if (product != null)
                {
                    string SQLDelete = "Delete Product where ProductId=@ProductId";
                    var param = dataProvider.CreateParameter("@ProductId", 4, productID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

      /*  public ProductObject getProductByEmail(string email)
        {
            ProductObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId,  Email, CompanyName,  City, Country,Password from Member where Email =@Email";
            try
            {
                var param = dataProvider.CreateParameter("@Email", 50, email, DbType.String); //chua hieu
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new ProductObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
*/

    }
}
