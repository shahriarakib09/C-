
namespace FoodCourtManagementSystem.PresentationLayer
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminUserNameTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.adminUserNameLabel = new System.Windows.Forms.Label();
            this.adminPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.adminPictureBox);
            this.panel1.Controls.Add(this.adminPasswordTextBox);
            this.panel1.Controls.Add(this.adminUserNameTextBox);
            this.panel1.Controls.Add(this.adminPasswordLabel);
            this.panel1.Controls.Add(this.adminUserNameLabel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 312);
            this.panel1.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(177, 177);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 32);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(55, 177);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(96, 32);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(167, 125);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(176, 20);
            this.adminPasswordTextBox.TabIndex = 4;
            // 
            // adminUserNameTextBox
            // 
            this.adminUserNameTextBox.Location = new System.Drawing.Point(167, 86);
            this.adminUserNameTextBox.Name = "adminUserNameTextBox";
            this.adminUserNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.adminUserNameTextBox.TabIndex = 3;
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordLabel.Location = new System.Drawing.Point(8, 124);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(143, 19);
            this.adminPasswordLabel.TabIndex = 2;
            this.adminPasswordLabel.Text = "Admin Password :";
            // 
            // adminUserNameLabel
            // 
            this.adminUserNameLabel.AutoSize = true;
            this.adminUserNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameLabel.Location = new System.Drawing.Point(3, 85);
            this.adminUserNameLabel.Name = "adminUserNameLabel";
            this.adminUserNameLabel.Size = new System.Drawing.Size(148, 19);
            this.adminUserNameLabel.TabIndex = 1;
            this.adminUserNameLabel.Text = "Admin Username :";
            // 
            // adminPictureBox
            // 
            this.adminPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("adminPictureBox.Image")));
            this.adminPictureBox.Location = new System.Drawing.Point(349, 31);
            this.adminPictureBox.Name = "adminPictureBox";
            this.adminPictureBox.Size = new System.Drawing.Size(217, 206);
            this.adminPictureBox.TabIndex = 5;
            this.adminPictureBox.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 312);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox adminPictureBox;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.TextBox adminUserNameTextBox;
        private System.Windows.Forms.Label adminPasswordLabel;
        private System.Windows.Forms.Label adminUserNameLabel;
    }
}