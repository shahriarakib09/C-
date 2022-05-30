using FoodCourtManagementSystem.DataAccessLayer;
using FoodCourtManagementSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem.BusinessLayer
{
    class AdminService
    {
        AdminDataAccess adminDataAccess;
        public AdminService()
        {
            this.adminDataAccess = new AdminDataAccess();
        }

        //public string AdminUsername { get;  set; }
        //public string AdminPassword { get; set; }

        public int LoginValidationService(string username, string password)
        {
            Admin admin = new Admin();
            {
                admin.AdminUsername = username;
                admin.AdminPassword=password;
            }
            return adminDataAccess.AdminLoginValidation(admin);

        }
        public List<Admin> GetAllAdmins()
        {
            return adminDataAccess.GetAllAdmin();
        }

        public int UpdateExistingAdmin(int adminId, string adminUsername)
        {
            Admin admin = new Admin() { AdminId = adminId, AdminUsername = adminUsername };
            return this.adminDataAccess.UpdateAdmin(admin);
        }
        public int DeleteAdminVerified(int id)
        {
            return this.adminDataAccess.DeleteAdmin(id);
        }
       
    }
}
