
namespace FoodCourtManagementSystem.PresentationLayer
{
    partial class UpdateAdmin
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
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.adminUserNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewAllAdmin = new System.Windows.Forms.DataGridView();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAdmin)).BeginInit();
            this.contextMenuStripDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtAdminUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtAdminId);
            this.panel1.Controls.Add(this.adminUserNameLabel);
            this.panel1.Controls.Add(this.dataGridViewAllAdmin);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 356);
            this.panel1.TabIndex = 3;
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(166, 232);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(203, 20);
            this.txtAdminUsername.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin Username :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(397, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(211, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Admin";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAdminId
            // 
            this.txtAdminId.Location = new System.Drawing.Point(166, 199);
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(203, 20);
            this.txtAdminId.TabIndex = 3;
            // 
            // adminUserNameLabel
            // 
            this.adminUserNameLabel.AutoSize = true;
            this.adminUserNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameLabel.Location = new System.Drawing.Point(74, 198);
            this.adminUserNameLabel.Name = "adminUserNameLabel";
            this.adminUserNameLabel.Size = new System.Drawing.Size(86, 19);
            this.adminUserNameLabel.TabIndex = 2;
            this.adminUserNameLabel.Text = "Admin Id :";
            // 
            // dataGridViewAllAdmin
            // 
            this.dataGridViewAllAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.AdminUserName});
            this.dataGridViewAllAdmin.ContextMenuStrip = this.contextMenuStripDelete;
            this.dataGridViewAllAdmin.Location = new System.Drawing.Point(16, 3);
            this.dataGridViewAllAdmin.Name = "dataGridViewAllAdmin";
            this.dataGridViewAllAdmin.Size = new System.Drawing.Size(494, 150);
            this.dataGridViewAllAdmin.TabIndex = 0;
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
            // contextMenuStripDelete
            // 
            this.contextMenuStripDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStripDelete.Name = "contextMenuStripDelete";
            this.contextMenuStripDelete.Size = new System.Drawing.Size(181, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 352);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateAdmin_FormClosing);
            this.Load += new System.EventHandler(this.UpdateAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAdmin)).EndInit();
            this.contextMenuStripDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.Label adminUserNameLabel;
        private System.Windows.Forms.DataGridView dataGridViewAllAdmin;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}