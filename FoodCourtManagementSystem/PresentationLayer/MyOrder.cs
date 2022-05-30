using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodCourtManagementSystem.BusinessLayer;

namespace FoodCourtManagementSystem.PresentationLayer
{
    public partial class MyOrder : Form
    {
        int Id;
        OrderService orderService = new OrderService();
        public MyOrder(int id)
        {
            InitializeComponent();
            Id = id;
            PopulateGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
           

        }

        private void MyOrder_Load(object sender, EventArgs e)
        {
            
            //  dataGridViewOrders.DataSource = orderService.GetmyOrders(Id);
            PopulateGridView();
        }

        private void MyOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row first");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = Convert.ToInt32(this.dataGridViewOrders.CurrentRow.Cells["OrderId"].Value);
            int verifyDeletion = orderService.DeleteOrders(id);
            if (verifyDeletion == 0)
            {
                MessageBox.Show("Deletion Successful");
                PopulateGridView();
            }
        }
        private void PopulateGridView()
        {
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.DataSource = orderService.GetmyOrders(Id);
            this.dataGridViewOrders.ClearSelection();
            this.dataGridViewOrders.Refresh();
        }
    }
}
