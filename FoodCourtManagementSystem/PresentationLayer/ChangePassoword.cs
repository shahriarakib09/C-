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
    public partial class ChangePassoword : Form
    {

        UserInfo userInfo = new UserInfo();
        UserService userservice = new UserService();
        int Id;
        public ChangePassoword(int id)
        {
            InitializeComponent();
            Id = id;
            txtNewPassword.UseSystemPasswordChar = true;
            txtRetypeNewPassword.UseSystemPasswordChar = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtPreviousPassword.Text == "" || txtRetypeNewPassword.Text == "")
            {
                MessageBox.Show("Invalid Request");
            }
            else
            {
                userInfo.UserId = Convert.ToInt32(Id);
                userInfo = userservice.ShowExistingUserInfo(userInfo);
                if (txtNewPassword.Text == txtRetypeNewPassword.Text)
                {
                    if (userInfo.Password == txtPreviousPassword.Text)
                    {
                        int result = userservice.UpdateUserPassword(Id, txtNewPassword.Text);
                        if (result > 0)
                        {
                            MessageBox.Show("Password has been changed succesfully.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                            txtNewPassword.Text = "";
                            txtRetypeNewPassword.Text = "";
                            txtPreviousPassword.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match");
                        txtNewPassword.Text = "";
                        txtRetypeNewPassword.Text = "";
                        txtPreviousPassword.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Password Doesnt Match");
                    txtNewPassword.Text = "";
                    txtRetypeNewPassword.Text = "";
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "Show")
            {
                btnShow.Text = "Hide";
                txtNewPassword.UseSystemPasswordChar = false;
                txtRetypeNewPassword.UseSystemPasswordChar = false;

            }
            else if (btnShow.Text == "Hide")
            {
                btnShow.Text = "Show";
                txtNewPassword.UseSystemPasswordChar = true;
                txtRetypeNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPreviousPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePassoword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();


        }
    }
}

