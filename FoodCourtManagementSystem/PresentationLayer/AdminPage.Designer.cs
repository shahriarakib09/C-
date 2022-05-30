
namespace FoodCourtManagementSystem.PresentationLayer
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.updateAdminButton = new System.Windows.Forms.Button();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.adminInfoButton = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewAdminInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewUserInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.userInfoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.cmsUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.viewOrderButton);
            this.panel1.Controls.Add(this.updateAdminButton);
            this.panel1.Controls.Add(this.addAdminButton);
            this.panel1.Controls.Add(this.adminInfoButton);
            this.panel1.Controls.Add(this.userInfoButton);
            this.panel1.Controls.Add(this.dataGridViewOrders);
            this.panel1.Controls.Add(this.dataGridViewAdminInfo);
            this.panel1.Controls.Add(this.dataGridViewUserInfo);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 583);
            this.panel1.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Red;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(99, 529);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(149, 35);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // updateAdminButton
            // 
            this.updateAdminButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateAdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdminButton.Location = new System.Drawing.Point(99, 447);
            this.updateAdminButton.Name = "updateAdminButton";
            this.updateAdminButton.Size = new System.Drawing.Size(149, 35);
            this.updateAdminButton.TabIndex = 8;
            this.updateAdminButton.Text = "Update Admin";
            this.updateAdminButton.UseVisualStyleBackColor = false;
            this.updateAdminButton.Click += new System.EventHandler(this.updateAdminButton_Click);
            // 
            // addAdminButton
            // 
            this.addAdminButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addAdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminButton.Location = new System.Drawing.Point(99, 406);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(149, 35);
            this.addAdminButton.TabIndex = 7;
            this.addAdminButton.Text = "Add Admin";
            this.addAdminButton.UseVisualStyleBackColor = false;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // adminInfoButton
            // 
            this.adminInfoButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminInfoButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInfoButton.Location = new System.Drawing.Point(99, 365);
            this.adminInfoButton.Name = "adminInfoButton";
            this.adminInfoButton.Size = new System.Drawing.Size(149, 35);
            this.adminInfoButton.TabIndex = 6;
            this.adminInfoButton.Text = "View Admin Info";
            this.adminInfoButton.UseVisualStyleBackColor = false;
            this.adminInfoButton.Click += new System.EventHandler(this.adminInfoButton_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.Date,
            this.FoodItem,
            this.Price,
            this.UserId});
            this.dataGridViewOrders.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewOrders.Location = new System.Drawing.Point(351, 227);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(681, 265);
            this.dataGridViewOrders.TabIndex = 3;
            // 
            // dataGridViewAdminInfo
            // 
            this.dataGridViewAdminInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.AdminUserName});
            this.dataGridViewAdminInfo.Location = new System.Drawing.Point(12, 227);
            this.dataGridViewAdminInfo.Name = "dataGridViewAdminInfo";
            this.dataGridViewAdminInfo.ReadOnly = true;
            this.dataGridViewAdminInfo.Size = new System.Drawing.Size(333, 132);
            this.dataGridViewAdminInfo.TabIndex = 2;
            // 
            // dataGridViewUserInfo
            // 
            this.dataGridViewUserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uid,
            this.FirstName,
            this.LastName,
            this.UserName,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.Gender,
            this.DateOfBirth});
            this.dataGridViewUserInfo.ContextMenuStrip = this.cmsUser;
            this.dataGridViewUserInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUserInfo.Name = "dataGridViewUserInfo";
            this.dataGridViewUserInfo.ReadOnly = true;
            this.dataGridViewUserInfo.Size = new System.Drawing.Size(1044, 180);
            this.dataGridViewUserInfo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 59);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(107, 22);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // OrderId
            // 
            this.OrderId.ContextMenuStrip = this.contextMenuStrip;
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Order Id";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.ContextMenuStrip = this.contextMenuStrip;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date Of Order";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // FoodItem
            // 
            this.FoodItem.ContextMenuStrip = this.contextMenuStrip;
            this.FoodItem.DataPropertyName = "FoodItem";
            this.FoodItem.HeaderText = "Food Item";
            this.FoodItem.Name = "FoodItem";
            this.FoodItem.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.ContextMenuStrip = this.contextMenuStrip;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.ContextMenuStrip = this.contextMenuStrip;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // AdminId
            // 
            this.AdminId.DataPropertyName = "AdminId";
            this.AdminId.HeaderText = "Admin Id";
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            // 
            // AdminUserName
            // 
            this.AdminUserName.DataPropertyName = "AdminUserName";
            this.AdminUserName.HeaderText = "Admin Username";
            this.AdminUserName.Name = "AdminUserName";
            this.AdminUserName.ReadOnly = true;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "UserId";
            this.uid.HeaderText = "User Id";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewOrderButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderButton.Location = new System.Drawing.Point(645, 498);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(142, 35);
            this.viewOrderButton.TabIndex = 10;
            this.viewOrderButton.Text = "View Orders";
            this.viewOrderButton.UseVisualStyleBackColor = false;
            this.viewOrderButton.Click += new System.EventHandler(this.viewOrderButton_Click);
            // 
            // userInfoButton
            // 
            this.userInfoButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userInfoButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoButton.Location = new System.Drawing.Point(423, 186);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(142, 35);
            this.userInfoButton.TabIndex = 5;
            this.userInfoButton.Text = "View User Info";
            this.userInfoButton.UseVisualStyleBackColor = false;
            this.userInfoButton.Click += new System.EventHandler(this.userInfoButton_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.cmsUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button updateAdminButton;
        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.Button adminInfoButton;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewAdminInfo;
        private System.Windows.Forms.DataGridView dataGridViewUserInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Button userInfoButton;
    }
}