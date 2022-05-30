
namespace FoodCourtManagementSystem.PresentationLayer
{
    partial class UserHomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.btnMyOrder = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblUname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FoodCourtManagementSystem.Properties.Resources._72504515_asian_food_served_on_old_wooden_table_top_view_space_for_text_chinese_and_vietnamese_cuisine_set_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUname);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnCreateNewOrder);
            this.panel1.Controls.Add(this.btnMyOrder);
            this.panel1.Controls.Add(this.btnUpdateProfile);
            this.panel1.Controls.Add(this.btnMyProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 495);
            this.panel1.TabIndex = 1;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbWelcome.Font = new System.Drawing.Font("Palace Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbWelcome.Location = new System.Drawing.Point(300, 23);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(230, 89);
            this.lbWelcome.TabIndex = 6;
            this.lbWelcome.Text = "Welcome";
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(678, 456);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 27);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out ";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(634, 293);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(82, 59);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewOrder.Location = new System.Drawing.Point(361, 293);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(75, 59);
            this.btnCreateNewOrder.TabIndex = 3;
            this.btnCreateNewOrder.Text = "Create New Order";
            this.btnCreateNewOrder.UseVisualStyleBackColor = true;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // btnMyOrder
            // 
            this.btnMyOrder.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOrder.Location = new System.Drawing.Point(492, 293);
            this.btnMyOrder.Name = "btnMyOrder";
            this.btnMyOrder.Size = new System.Drawing.Size(75, 59);
            this.btnMyOrder.TabIndex = 2;
            this.btnMyOrder.Text = "My Order";
            this.btnMyOrder.UseVisualStyleBackColor = true;
            this.btnMyOrder.Click += new System.EventHandler(this.btnMyOrder_Click_1);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(238, 292);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(75, 60);
            this.btnUpdateProfile.TabIndex = 1;
            this.btnUpdateProfile.Text = "Update My Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.Location = new System.Drawing.Point(125, 293);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(75, 59);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUname.Location = new System.Drawing.Point(367, 216);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(60, 24);
            this.lblUname.TabIndex = 7;
            this.lblUname.Text = "label1";
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 495);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "UserHomePage";
            this.Text = "UserHomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserHomePage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCreateNewOrder;
        private System.Windows.Forms.Button btnMyOrder;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Label lblUname;
    }
}