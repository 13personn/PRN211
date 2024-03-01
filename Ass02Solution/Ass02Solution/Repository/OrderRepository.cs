using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOder(int orderId)=>OrderDAO.Instance.Remove(orderId);


        public OrderObject GetOrderByID(int orderId)=>OrderDAO.Instance.GetOrderByID(orderId);

        public OrderObject GetOrderByMemberID(int memberId)=>OrderDAO.Instance.GetOrderByMemberID(memberId);
        

        public IEnumerable<OrderObject> GetOrders()=>OrderDAO.Instance.GetOrderList();

        public void InsertOrder(OrderObject order)=>OrderDAO.Instance.AddNew(order);

        public void UpdateOrder(OrderObject order)=>OrderDAO.Instance.Update(order);
    }
}
