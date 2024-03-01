using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetOrderDetails();
        OrderDetailObject GetOrderDetailByID(int orderId);
        void InsertOrderDetail(OrderDetailObject orderDetail);
        void DeleteOderDetail(int orderId);
        void UpdateOrderDetail(OrderDetailObject orderDetail);
    }
}
