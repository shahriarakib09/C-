
namespace FoodCourtManagementSystem.PresentationLayer
{
    partial class AddAdmin
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
            this.btnShow = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtAdminUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 321);
            this.panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShow.Location = new System.Drawing.Point(509, 133);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 32);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(370, 183);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 32);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(228, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 32);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(228, 136);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(261, 25);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(228, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(228, 45);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(261, 25);
            this.txtAdminUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Username :";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 321);
            this.Controls.Add(this.panel1);
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAdmin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
    }
}