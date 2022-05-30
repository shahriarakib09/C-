
namespace FoodCourtManagementSystem.PresentationLayer
{
    partial class ChangePassoword
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
            this.lbConfirmNewPass = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.txtRetypeNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtPreviousPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FoodCourtManagementSystem.Properties.Resources._428;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.lbConfirmNewPass);
            this.panel1.Controls.Add(this.lbNewPassword);
            this.panel1.Controls.Add(this.lbCurrentPassword);
            this.panel1.Controls.Add(this.txtRetypeNewPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.txtPreviousPassword);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(709, 198);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(70, 30);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbConfirmNewPass
            // 
            this.lbConfirmNewPass.AutoSize = true;
            this.lbConfirmNewPass.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmNewPass.Location = new System.Drawing.Point(314, 225);
            this.lbConfirmNewPass.Name = "lbConfirmNewPass";
            this.lbConfirmNewPass.Size = new System.Drawing.Size(165, 19);
            this.lbConfirmNewPass.TabIndex = 8;
            this.lbConfirmNewPass.Text = "Confirm New Password";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(372, 180);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(107, 19);
            this.lbNewPassword.TabIndex = 7;
            this.lbNewPassword.Text = "New Password";
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.Location = new System.Drawing.Point(352, 139);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(127, 19);
            this.lbCurrentPassword.TabIndex = 6;
            this.lbCurrentPassword.Text = "Current Password";
            // 
            // txtRetypeNewPassword
            // 
            this.txtRetypeNewPassword.Location = new System.Drawing.Point(498, 224);
            this.txtRetypeNewPassword.Name = "txtRetypeNewPassword";
            this.txtRetypeNewPassword.Size = new System.Drawing.Size(175, 20);
            this.txtRetypeNewPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(498, 179);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(175, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtPreviousPassword
            // 
            this.txtPreviousPassword.Location = new System.Drawing.Point(498, 138);
            this.txtPreviousPassword.Name = "txtPreviousPassword";
            this.txtPreviousPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPreviousPassword.TabIndex = 3;
            this.txtPreviousPassword.TextChanged += new System.EventHandler(this.txtPreviousPassword_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(605, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(693, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChangePassoword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePassoword";
            this.Text = "ChangePassoword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassoword_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbConfirmNewPass;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.TextBox txtRetypeNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtPreviousPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}