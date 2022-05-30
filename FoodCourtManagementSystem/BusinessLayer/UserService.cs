using FoodCourtManagementSystem.DataAccessLayer;
using FoodCourtManagementSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.BusinessLayer
{
    class UserService
    {
        UserInfo userInfo = new UserInfo();
        UserInfoDataAccess userInfoDataAccess = new UserInfoDataAccess();
        public int UserLoginValidationService(int userId, string password)
        {
           
            {
                userInfo.UserId = userId;
                userInfo.Password = password;
            }
            return userInfoDataAccess.UserLoginValidation(userInfo);

        }
        public int RetriveUserPassword(int id,string  oldPassword)

        {
            return this.userInfoDataAccess.RetrivePasswordDataAccess(id,oldPassword);
        }
        public int UpdateUserPassword(int id,string newPassword)
        {
            return this.userInfoDataAccess.ChangePassword(id,newPassword);
        }
        public List<UserInfo> GetUserInfos()
        {
            return userInfoDataAccess.GetUserInfo();

        }
        public int AdduserInfo(string fstName, string lastName, string userName, string password, string phoneNumber, string eAddress, string address, string gender, string dob)
        {
            UserInfo details = new UserInfo() { FirstName = fstName, LastName = lastName, UserName = userName, Password = password, PhoneNumber = phoneNumber, Email = eAddress, Address = address, Gender = gender, DateOfBirth = dob };
            return this.userInfoDataAccess.AdduserInfo(details);
        }
        public int UpdateProfile(int id, string fstName, string lastName, string userName, string phoneNumber, string eAddress, string address, string dob)
        {
            UserInfo detailsnew = new UserInfo() { UserId=id, FirstName = fstName, LastName = lastName, UserName = userName, PhoneNumber = phoneNumber, Email = eAddress, Address = address, DateOfBirth= dob };
            return this.userInfoDataAccess.UpdateProfile(detailsnew);
        }
        public UserInfo ShowExistingUserInfo(UserInfo userInfo)
        {
            
            return this.userInfoDataAccess.ConvertToEntity(userInfo);
        }
        public int DeleteUsers(int id)
        {
            return this.userInfoDataAccess.DeleteUser(id);
        }

    }
}
