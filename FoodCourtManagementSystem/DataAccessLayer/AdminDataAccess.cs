using FoodCourtManagementSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.DataAccessLayer
{
    class AdminDataAccess : DataAccess
    {
        public List<Admin> GetAllAdmin()
        {
            string sql = "SELECT * From Admin";
            SqlDataReader reader = this.GetData(sql);
            List<Admin> admins = new List<Admin>();
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.AdminId = Convert.ToInt32(reader["AdminId"]);
                admin.AdminUsername = Convert.ToString(reader["AdminUsername"]);
                admin.AdminPassword = Convert.ToString(reader["AdminPassword"]);
                admins.Add(admin);
            }
            return admins;


        }

        internal int AdminLoginValidation()
        {
            throw new NotImplementedException();
        }

        public int AddNewAdmin(Admin admin)
        {
            string sql = "INSERT INTO Admin(AdminUsername,AdminPassword) VALUES('" + admin.AdminUsername + "','" + admin.AdminPassword + "')";
            return this.ExecuteQuery(sql);
        }
        public int UpdateAdmin(Admin admin)
        {
            string sql = "UPDATE Admin SET AdminUsername='" + admin.AdminUsername +"'  WHERE AdminId='" + admin.AdminId+"'";
            return this.ExecuteQuery(sql);
        }
        public int DeleteAdmin(int id)
        {
            string sql = "DELETE FROM Admin Where AdminId='" +id + "'";
            return this.ExecuteQuery(sql);
        }
        public int AdminLoginValidation(Admin admin)
        {
            string sql = "SELECT * FROM Admin WHERE AdminUsername='" + admin.AdminUsername + "'AND AdminPassword='" + admin.AdminPassword + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["AdminId"]);
            }
            return -1;


        }
    }
}
