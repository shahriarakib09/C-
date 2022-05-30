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
    public partial class AdminPage : Form
    {
        AdminService adminService = new AdminService();
        OrderService orderService = new OrderService();
        UserService userService = new UserService();

        public AdminPage()
        {
            InitializeComponent();



            PopulateGridView();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
           
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdmin addAdmin = new AddAdmin();
            
            addAdmin.ShowDialog();
            
        }

        private void updateAdminButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            UpdateAdmin updateAdmin = new UpdateAdmin();
           
            updateAdmin.Show();
           
        }

       

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            
            PopulateGridView();
         }

        private void adminInfoButton_Click(object sender, EventArgs e)
        {

            // dataGridViewAdminInfo.DataSource = adminService.GetAllAdmins();
            PopulateGridView();
        }

        private void btnGoForOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FoodMenu foodMenu = new FoodMenu(Id);
            //foodMenu.ShowDialog();
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {

            PopulateGridView();
           

        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewOrders.SelectedRows.Count!=1)
            {
                MessageBox.Show("Please select a row first");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id =Convert.ToInt32( this.dataGridViewOrders.CurrentRow.Cells["OrderId"].Value);
            int verifyDeletion = orderService.DeleteOrders(id);
                if(verifyDeletion==0)
            {
                MessageBox.Show("Deletion Successful");
                PopulateGridView();
            }
        }
        public void PopulateGridView()
        {
            this.dataGridViewAdminInfo.AutoGenerateColumns = false;
            this.dataGridViewAdminInfo.DataSource = adminService.GetAllAdmins();
            this.dataGridViewAdminInfo.ClearSelection();
            this.dataGridViewAdminInfo.Refresh();

            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.DataSource = orderService.GetAllOrderList();
            this.dataGridViewOrders.ClearSelection();
            this.dataGridViewOrders.Refresh();

            this.dataGridViewUserInfo.AutoGenerateColumns = false;
            this.dataGridViewUserInfo.DataSource = userService.GetUserInfos();
            this.dataGridViewUserInfo.ClearSelection();
            this.dataGridViewUserInfo.Refresh();

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewUserInfo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row first");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = Convert.ToInt32(this.dataGridViewUserInfo.CurrentRow.Cells["uid"].Value);
            int verifyDeletion = userService.DeleteUsers(id);
            if (verifyDeletion == 0)
            {
                MessageBox.Show("Deletion Successful");
                PopulateGridView();
            }
        }
    }
}
