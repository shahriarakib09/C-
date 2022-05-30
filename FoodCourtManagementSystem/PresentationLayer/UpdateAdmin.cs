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
    public partial class UpdateAdmin : Form
    {
        AdminService adminService = new AdminService();
        public UpdateAdmin()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void UpdateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAdminId.Text == "" || txtAdminUsername.Text == "" || txtAdminId.Text == null || txtAdminUsername.Text == null)
            {
                MessageBox.Show("Invalid Request");
            }
            else
            {
                AdminService adminService = new AdminService();
                int result = adminService.UpdateExistingAdmin(Convert.ToInt32(txtAdminId.Text), txtAdminUsername.Text);
                if (result > 0)
                {
                    PopulateGridView();
                    MessageBox.Show("Admin updated successfully !!");



                }
                else
                {
                    MessageBox.Show("Error in updating.");
                }
            }
        }
        private void PopulateGridView()
        {
            this.dataGridViewAllAdmin.AutoGenerateColumns = false;
            this.dataGridViewAllAdmin.DataSource = adminService.GetAllAdmins();
            this.dataGridViewAllAdmin.ClearSelection();
            this.dataGridViewAllAdmin.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewAllAdmin.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row first");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = Convert.ToInt32(this.dataGridViewAllAdmin.CurrentRow.Cells["AdminId"].Value);
            int verifyDeletion = adminService.DeleteAdminVerified(id);
            if (verifyDeletion == 0)
            {
                MessageBox.Show("Deletion Successful");
                PopulateGridView();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }
    }
}
