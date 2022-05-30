using FoodCourtManagementSystem.BusinessLayer;
using FoodCourtManagementSystem.DataAccessLayer.Entities;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            adminPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (adminUserNameTextBox.Text == "" || adminPasswordTextBox.Text == "" || adminPasswordTextBox.Text == null || adminUserNameTextBox.Text == null)
            {
                MessageBox.Show("Invalid Request");
            }
            else
            {
                AdminService adminLoginService = new AdminService();
                Admin admin = new Admin();
                admin.AdminUsername = adminUserNameTextBox.Text;
                admin.AdminPassword = adminPasswordTextBox.Text;
                int result = adminLoginService.LoginValidationService(adminUserNameTextBox.Text, adminPasswordTextBox.Text);
                if (result > 0)
                {
                    AdminPage adminPage = new AdminPage();
                    adminPage.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            


        }
    }
}
