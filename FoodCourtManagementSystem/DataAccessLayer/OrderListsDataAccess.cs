using FoodCourtManagementSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.DataAccessLayer
{
    class OrderListsDataAccess:DataAccess
    {
        
            public List<OrderLists> GetOrderList()
            {
                string sql = "SELECT * From OrderLists";
                SqlDataReader reader = this.GetData(sql);
                List<OrderLists> orders = new List<OrderLists>();
                while (reader.Read())
                {
                 OrderLists order = new OrderLists();
                 order.OrderId = Convert.ToInt32(reader["OrderId"]);
                 order.FoodItem = Convert.ToString(reader["FoodItem"]);
                 order.Price = Convert.ToInt32(reader["Price"]);
                 order.Date = Convert.ToString(reader["Date"]);
                 order.UserID = Convert.ToInt32(reader["UserId"]);
                 orders.Add(order);
                }
                return orders;
            }
        public List<OrderLists> GetMyOrderList(int id)
        {
            string sql = "SELECT * From OrderLists where UserId='"+id+"'";
            SqlDataReader reader = this.GetData(sql);
            List<OrderLists> orders = new List<OrderLists>();
            while (reader.Read())
            {
                OrderLists order = new OrderLists();
                order.OrderId = Convert.ToInt32(reader["OrderId"]);
                order.FoodItem = Convert.ToString(reader["FoodItem"]);
                order.Price = Convert.ToInt32(reader["Price"]);
                order.Date = Convert.ToString(reader["Date"]);
                order.UserID = Convert.ToInt32(reader["UserId"]);
                orders.Add(order);
            }
            return orders;
        }
        public int AddOrders(OrderLists orderLists)
        {
            string sql="INSERT INTO OrderLists(FoodItem,Price,Date,UserId) VALUES('"+orderLists.FoodItem+"','"+orderLists.Price+"','"+orderLists.Date+"','"+orderLists.UserID+"')";
            return this.ExecuteQuery(sql);
        }
        //public int SpecificUserOrders(int id)
        //{
        //    string sql = "SELECT * FROM ORDERLIST WHERE UserId=" + id;
        //    SqlDataReader reader = this.GetData(sql);
        //    if(reader.Read())
        //    {
        //        OrderLists orderLists = new OrderLists();
        //        orderLists.OrderId = Convert.ToInt32(reader["OrderId"]);
        //        orderLists.FoodItem = Convert.ToString(reader["FoodItem"]);
        //        orderLists.Price = Convert.ToInt32(reader["Price"]);
        //        orderLists.Date = Convert.ToString(reader["Date"]);
        //        orderLists.UserID = Convert.ToInt32(reader["UserId"]);
        //        return Convert.ToInt32(orderLists);
        //    }
        //    return Convert.ToInt32(null);

        //}
        public int DeleteOrder(int id)
        {
            string sql = "DELETE FROM OrderLists WHERE UserID='" + id + "'";
            return ExecuteQuery(sql);
        }
        
    }
}
