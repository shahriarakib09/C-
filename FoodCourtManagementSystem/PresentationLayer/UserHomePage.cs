using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodCourtManagementSystem.DataAccessLayer;
using FoodCourtManagementSystem.DataAccessLayer.Entities;

namespace FoodCourtManagementSystem.PresentationLayer
{
    public partial class UserHomePage : Form
    {
        int Id;
        public UserHomePage(int id)
        {
            UserInfoDataAccess userInfoDataAccess = new UserInfoDataAccess();
            UserInfo userInfo = new UserInfo();

            InitializeComponent();
            userInfo.UserId = id;
            Id = id;
            lbWelcome.BackColor = System.Drawing.Color.Transparent;
            userInfo = userInfoDataAccess.ConvertToEntity(userInfo);
            lblUname.Text = userInfo.FirstName+" "+userInfo.LastName;

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdateProfile updateProfile = new UpdateProfile(Id,1);
            updateProfile.ShowDialog();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfile updateProfile = new UpdateProfile(Id);
            updateProfile.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassoword changePassword = new ChangePassoword(Id);
            changePassword.Show();
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            
            FoodMenu foodmenu = new FoodMenu (Id);
          
            foodmenu.ShowDialog();
        }

        private void btnMyOrder_Click_1(object sender, EventArgs e)
        {
            MyOrder myorder = new MyOrder(Id);
            myorder.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void UserHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
