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
using System.Data.SqlClient;
using FoodCourtManagementSystem.PresentationLayer;
using FoodCourtManagementSystem.DataAccessLayer;
using FoodCourtManagementSystem.DataAccessLayer.Entities;

namespace FoodCourtManagementSystem
{
    public partial class Registration : Form
    {
        UserInfoDataAccess userInfoDataAccess = new UserInfoDataAccess();
        UserInfo userInfo = new UserInfo();
        public Registration()
        {
            InitializeComponent();
            UserService userInfoService = new UserService();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowHiddenPass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ShowHiddenPass.Checked;
            switch (check)
            {
                case true:
                    txtboxPass.UseSystemPasswordChar = true;
                    break;
                default:
                    txtboxPass.UseSystemPasswordChar = false;
                    break;


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserService userInfoService = new UserService();

            if (txtboxFname.Text != null && txtboxLname.Text != null && txtboxUname.Text != null &&
               txtboxPass != null && txtboxConPass != null && txtboxPhone != null && txtboxEmail != null &&
              (radioButton1.Checked || radioButton2.Checked) &&
              txtboxAddress.Text != null && txtboxAddress.Text != "")
            {
                string fname = txtboxFname.Text;
                string lname = txtboxLname.Text;
                string uname = txtboxUname.Text;
                string password = txtboxConPass.Text;
                string phone = txtboxPhone.Text;
                string email = txtboxEmail.Text;
                string address = txtboxAddress.Text;
                string gender = "";
                string dob = dateTimePicker1.Text;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }


                try
                {
                    int query = userInfoService.AdduserInfo(fname, lname, uname, password, phone, email, address, gender, dob);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    bool verifyValues = NullValidation();

                    if (verifyValues)
                    {
                        if (IsValidEmail(txtboxEmail.Text))
                        {
                            userInfo = userInfoDataAccess.RetriveUserIdPassword(txtboxUname.Text, txtboxPhone.Text);
                            string message = "User Id=" + userInfo.UserId + "  Password=" + userInfo.Password;
                            MessageBox.Show(message, "Registration successfull");

                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email");
                            txtboxEmail.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Info");
                        clearFields();
                    }



                    //this.Close();
                }

            }
            else
            {
                MessageBox.Show("Please check the form again!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public bool NullValidation()
        {

            if (txtboxEmail.Text != null && txtboxFname != null && txtboxLname != null && txtboxPass != null && txtboxPhone != null && txtboxUname != null && txtboxAddress != null && radioButton1.Checked || radioButton2.Checked)
                return true;
            else
                return false;
            
        }
        

        private bool IsValidEmail(string email)
    {
        try
        {
            
            if (email.Contains(".") && email.Contains("@"))
            {
                return true;
            }
            else
                return false;
        }
        catch
        {
            return false;
        }
     }
        void clearFields()
        {
            txtboxFname.Text = "";
            txtboxLname.Text = "";
            txtboxUname.Text = "";
            txtboxPhone.Text = "";
            txtboxEmail.Text = "";
            txtboxPass.Text = "";
            txtboxConPass.Text = "";
        }
} 
}   


