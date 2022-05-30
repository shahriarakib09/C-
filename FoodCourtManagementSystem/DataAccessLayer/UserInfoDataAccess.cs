using FoodCourtManagementSystem.DataAccessLayer.Entities;
using FoodCourtManagementSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.DataAccessLayer
{
    class UserInfoDataAccess : DataAccess
    {

        public List<UserInfo> GetUserInfo()
        {
            string sql = "SELECT * FROM UserInfo";
            SqlDataReader reader = this.GetData(sql);
            List<UserInfo> infos = new List<UserInfo>();
            while (reader.Read())
            {
                UserInfo details = new UserInfo();
                details.UserId = Convert.ToInt32(reader["UserId"]);
                details.FirstName = reader["FirstName"].ToString();
                details.LastName = reader["LastName"].ToString();
                details.UserName = reader["UserName"].ToString();
                //details.Password = reader["Password"].ToString();
                details.PhoneNumber = reader["PhoneNumber"].ToString();
                details.Email = reader["Email"].ToString();
                details.Address = reader["Address"].ToString();
                details.Gender = reader["Gender"].ToString();
                details.DateOfBirth = reader["DateOfBirth"].ToString();
                infos.Add(details);
            }
            return infos;
        }
        public UserInfo ConvertToEntity(UserInfo userInfo)
        {
            string sql = "SELECT * FROM UserInfo where UserId='"+userInfo.UserId+"'";
            SqlDataReader reader = this.GetData(sql);
            //List<UserInfo> infos = new List<UserInfo>();
            var details = new UserInfo();
            while (reader.Read())
            {
                
                details.UserId = Convert.ToInt32(reader["UserId"]);
                details.FirstName = reader["FirstName"].ToString();
                details.LastName = reader["LastName"].ToString();
                details.UserName = reader["UserName"].ToString();
                details.Password = reader["Password"].ToString();
                details.PhoneNumber = reader["PhoneNumber"].ToString();
                details.Email = reader["Email"].ToString();
                details.Address = reader["Address"].ToString();
                details.Gender = reader["Gender"].ToString();
                details.DateOfBirth = reader["DateOfBirth"].ToString();
               // infos.Add(details);
            }
            return details;
        }
        public int AdduserInfo(UserInfo userInfo)
        {
            string sql = "INSERT INTO UserInfo(FirstName,LastName,UserName,Password,PhoneNumber,Email,Address,Gender,DateOfBirth) VALUES('" + userInfo.FirstName + "', '" + userInfo.LastName + "', '" + userInfo.UserName + "', '" + userInfo.Password + "','" + userInfo.PhoneNumber + "', '" + userInfo.Email + "', '" + userInfo.Address + "' , '" + userInfo.Gender + "', '" + userInfo.DateOfBirth + "')";
            return this.ExecuteQuery(sql);
        }


        public int UpdateProfile(UserInfo upProfile)
        {
            
            string sql = "UPDATE UserInfo SET FirstName ='" + upProfile.FirstName + "',LastName= '" + upProfile.LastName + "',UserName= '" + upProfile.UserName + "',PhoneNumber= '" + upProfile.PhoneNumber + "',Email= '" + upProfile.Email + "',Address= '" + upProfile.Address + "',Gender ='" +" "+ "',DateOfBirth= '" + upProfile.DateOfBirth + "' WHERE UserId='"+upProfile.UserId+"'";
            return this.ExecuteQuery(sql);

        }
        public int ChangePassword(int id,string password)
        {
            string sql = "Update UserInfo SET Password='" + password+ "'Where UserId ='" + id + "'";
            return this.ExecuteQuery(sql);

        }
        public int RetrivePasswordDataAccess(int id,string password)
        {
            string sql = "SELECT * FROM UserInfo WHERE UserID='" + id + "'AND Password='"+password+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["UserId"]);
            }
            return -1;
        }
        public int UserLoginValidation(UserInfo userInfo)
        {
            string sql = "SELECT * FROM UserInfo WHERE UserId='" + userInfo.UserId+ "'AND Password='" + userInfo.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["UserId"]);
            }
            return -1;

        }
        public int DeleteUser(int id)
        {
            string sql = "DELETE FROM UserInfo WHERE UserId='" + id + "'";
            return ExecuteQuery(sql);
        }

        public UserInfo RetriveUserIdPassword(string UserName,string PhoneNumber)
        {
            string sql = "SELECT UserId,Password FROM UserInfo where UserName='" +UserName + "'and PhoneNumber='"+PhoneNumber+"'";
            SqlDataReader reader = this.GetData(sql);

            var details = new UserInfo();
            while (reader.Read())
            {
                details.UserId = Convert.ToInt32(reader["UserId"]);
                details.Password =reader["Password"].ToString();
            }
            return details;
        }
    }
}

    
