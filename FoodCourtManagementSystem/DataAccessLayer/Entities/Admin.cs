using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.DataAccessLayer.Entities
{
    class Admin
    {
        public int AdminId { get; set; }
        public string  AdminUsername { get; set; }
        public string AdminPassword { get; set; }
    }
}
