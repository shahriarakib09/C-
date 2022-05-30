using FoodCourtManagementSystem.DataAccessLayer;
using FoodCourtManagementSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.BusinessLayer
{
    class OrderService
    {
        public OrderListsDataAccess orderListsDataAccess;
        public OrderService()
        {
            this.orderListsDataAccess = new OrderListsDataAccess();
        }
        public List<OrderLists> GetAllOrderList()
        {
            return this.orderListsDataAccess.GetOrderList();
        }
        public List<OrderLists> GetmyOrders(int id)
        {
            return this.orderListsDataAccess.GetMyOrderList(id);
        }
        public int OrderConfirmation(OrderLists orderLists)
        {
            return this.orderListsDataAccess.AddOrders(orderLists);
        }
        public int DeleteOrders(int id)
        {
            return this.orderListsDataAccess.DeleteOrder(id);
        }
    }
}
