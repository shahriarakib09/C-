using FoodCourtManagementSystem.DataAccessLayer.Entities;
using FoodCourtManagementSystem.DataAccessLayer;
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
    public partial class AddAdmin : Form
    {
        Admin admin = new Admin();
        AdminDataAccess adminDataAccess = new AdminDataAccess();
        public AddAdmin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            admin.AdminUsername = txtAdminUsername.Text;
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                admin.AdminPassword = txtPassword.Text;
            }
            else
            {
                MessageBox.Show("Password doesn't match");
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

            }
            int varify = adminDataAccess.AddNewAdmin(admin);
            if (varify > 0)
            {
                MessageBox.Show("New Admin Added succesfully ");
            }
            else
            {
                MessageBox.Show("Invalid Action");
            }


        }

        private void AddAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.ShowDialog();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "Show")
            {
                btnShow.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;

            }
            else if (btnShow.Text == "Hide")
            {
                btnShow.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (btnShow.Text == "Show")
            {
                btnShow.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;

            }
            else if (btnShow.Text == "Hide")
            {
                btnShow.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }

        }
    }
}

