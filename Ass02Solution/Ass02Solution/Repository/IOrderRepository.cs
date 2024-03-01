using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetOrders();
        OrderObject GetOrderByID(int orderId);
        OrderObject GetOrderByMemberID(int orderId);
        void InsertOrder(OrderObject order);
        void DeleteOder(int orderId);
        void UpdateOrder(OrderObject order);
    }
}
