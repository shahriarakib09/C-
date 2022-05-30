using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.DataAccessLayer
{
    class DataAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            try
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FoodCourtManagementSystem"].ConnectionString);
                this.connection.Open();
            }
            catch(Exception Ex)
            {

            }
        }
        public SqlDataReader GetData(String sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }
        ~DataAccess()
        {
            //this.connection.Close();
        }

    
        

        


    }
    
}
