using AutomobileLibrary.DataAccess;
using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDAO:BaseDAL
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderObject> GetOrderList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight from [Order] ";
            var orders = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)

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
            return orders;
        }

        public OrderObject GetOrderByID(int orderId)
        {
            OrderObject order = null;
            IDataReader dataReader = null;
            string SQLSelect = "select OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight from [Order] where OrderId =@OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32); //chua hieu
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                   order = new OrderObject
                    {
                       OrderId = dataReader.GetInt32(0),
                       MemberId = dataReader.GetInt32(1),
                       OrderDate = dataReader.GetDateTime(2),
                       RequiredDate = dataReader.GetDateTime(3),
                       ShippedDate = dataReader.GetDateTime(4),
                       Freight = dataReader.GetDecimal(5)
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
            return order;
        }

        public void AddNew(OrderObject order)
        {
            try
            {
                OrderObject orderTest = GetOrderByID(order.OrderId);
                if (orderTest == null)
                {
                    string SQLInsert = "Insert [Order] values(@OrderId,@MemberId,@OrderDate ,@RequiredDate,@ShippedDate ,@Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 4, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 500000, order.Freight, DbType.Decimal));
                    
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());


                }
                else
                {
                    throw new Exception("The order is already exist.");
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

        public void Update(OrderObject order)
        {
            try
            {


                OrderObject orderTest = GetOrderByID(order.OrderId);
                if (orderTest != null)
                {
                    
                    string SQLUpdate =
                       "UPDATE [Order] SET Freight = @Freight, " +
                "MemberId = @MemberId, OrderDate = @OrderDate, " +
                "RequiredDate = @RequiredDate, ShippedDate = @ShippedDate " +
                "WHERE OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 4, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 500000, order.Freight, DbType.Decimal));
                   
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not exist.");
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

        public void Remove(int orderId)
        {
            try
            {
                OrderObject orderTest = GetOrderByID(orderId);
                if (orderTest != null)
                {
                    string SQLDelete = "Delete OrderDetail where OrderId = @OrderID1;" +
                        "Delete [Order] where OrderId = @OrderID2";
                    var parameters = new List<SqlParameter>();
                     parameters.Add(dataProvider.CreateParameter("@OrderID1", 4, orderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderID2", 4, orderId, DbType.Int32));
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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

        public OrderObject GetOrderByMemberID(int memberId)
        {
            OrderObject order = null;
            IDataReader dataReader = null;
            string SQLSelect = "select OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight from [Order] where MemberId =@MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32); //chua hieu
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return order;
        }

    }
}
