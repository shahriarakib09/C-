using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.DataAccessLayer.Entities
{
    class OrderLists
    {
        public int OrderId { get; set; }
        public string FoodItem { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
    }
}
