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
    public partial class UpdateProfile : Form
    {
        int Id;
        UserService userService = new UserService();
        UserInfo userInfo = new UserInfo();

        public UpdateProfile(int id)
        {
            InitializeComponent();
            Id = id;
            txtUserId.Text = Id.ToString();
            labelHeader.Text = "Update Profile";
            btnUpdate.Visible = true;
        }
        public UpdateProfile(int id,int b)
        {
            InitializeComponent();
            Id = id;
            txtUserId.Text = Id.ToString();
            labelHeader.Text = "My Profile";
            btnUpdate.Visible = false;

            txtboxAddress.ReadOnly = true;
            txtboxEmail.ReadOnly = true;
            txtboxFname.ReadOnly = true;
            txtboxLname.ReadOnly = true;
            txtboxPhone.ReadOnly = true;
            txtUserId.ReadOnly = true;
            txtboxDateTimePicker.Enabled = false;
            txtUsername.ReadOnly = true;
            txtboxAddress.ReadOnly = true;

        }

        string gender;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxAddress.Text=="" || txtboxEmail.Text=="") //fdffddfh
            {
                MessageBox.Show("Invalid Request");
            }
            else {
                UserService userService = new UserService();
                int result = userService.UpdateProfile(Convert.ToInt32(txtUserId.Text), txtboxFname.Text, txtboxLname.Text, txtUsername.Text, txtboxPhone.Text, txtboxEmail.Text, txtboxAddress.Text, txtboxDateTimePicker.Text);
                if (result > 0)
                {
                    MessageBox.Show("User profile updated successfully !!");
                    this.Hide();
                    UserHomePage userHomePage = new UserHomePage(Id);
                    userHomePage.ShowDialog();




                }
                else
                {
                    MessageBox.Show("Error in updating.");
                } }
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            userInfo.UserId = Convert.ToInt32( txtUserId.Text);
            userInfo= userService.ShowExistingUserInfo(userInfo);

            txtboxFname.Text = userInfo.FirstName;
            txtboxLname.Text = userInfo.LastName;
            txtUsername.Text = userInfo.UserName;
            txtboxEmail.Text = userInfo.Email;
            txtboxPhone.Text = userInfo.PhoneNumber;
            txtboxAddress.Text = userInfo.Address;
            txtboxDateTimePicker.Text = userInfo.DateOfBirth;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            
                gender = "Female";
            
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();

        }

        private void UpdateProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
