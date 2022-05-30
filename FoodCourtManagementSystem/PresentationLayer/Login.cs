using FoodCourtManagementSystem.DataAccessLayer.Entities;
using FoodCourtManagementSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem.PresentationLayer
{
    public partial class Login : Form

    {
        private UserInfo userInfo = new UserInfo();
        UserService UserService = new UserService();

        public Login()
        {

            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void adminUserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            {
                if (txtUserName.Text == "" || txtPassword.Text == "" || txtUserName.Text ==null || txtPassword.Text ==null)
                {
                    MessageBox.Show("Invalid Request");
                }
                else
                {
                    userInfo.UserId = Convert.ToInt32(txtUserName.Text);
                    userInfo.Password = txtPassword.Text;
                    int result = UserService.UserLoginValidationService(userInfo.UserId, userInfo.Password);
                    if (result > 0)
                    {
                        this.Hide();
                        UserHomePage userHomePage = new UserHomePage(Convert.ToInt32(txtUserName.Text));
                        userHomePage.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");


                    }
                }

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}

