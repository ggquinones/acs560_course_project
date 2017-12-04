namespace GutenLib
{
    partial class PasswordChangerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangerForm));
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.btnClosePasswordChanger = new System.Windows.Forms.Button();
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.txtRepeatNew = new System.Windows.Forms.TextBox();
            this.lblRepeatNew = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblChangePasswordStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlChangePassword.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.Controls.Add(this.btnClosePasswordChanger);
            this.pnlChangePassword.Controls.Add(this.btnSubmitChanges);
            this.pnlChangePassword.Controls.Add(this.txtRepeatNew);
            this.pnlChangePassword.Controls.Add(this.lblRepeatNew);
            this.pnlChangePassword.Controls.Add(this.txtNewPassword);
            this.pnlChangePassword.Controls.Add(this.lblNewPassword);
            this.pnlChangePassword.Controls.Add(this.lblCurrentPassword);
            this.pnlChangePassword.Controls.Add(this.txtCurrentPassword);
            this.pnlChangePassword.Location = new System.Drawing.Point(98, 78);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(289, 178);
            this.pnlChangePassword.TabIndex = 0;
            // 
            // btnClosePasswordChanger
            // 
            this.btnClosePasswordChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePasswordChanger.Location = new System.Drawing.Point(152, 134);
            this.btnClosePasswordChanger.Name = "btnClosePasswordChanger";
            this.btnClosePasswordChanger.Size = new System.Drawing.Size(78, 34);
            this.btnClosePasswordChanger.TabIndex = 13;
            this.btnClosePasswordChanger.Text = "Close";
            this.btnClosePasswordChanger.UseVisualStyleBackColor = true;
            this.btnClosePasswordChanger.Click += new System.EventHandler(this.CloseForm);
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitChanges.Location = new System.Drawing.Point(58, 134);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(78, 34);
            this.btnSubmitChanges.TabIndex = 12;
            this.btnSubmitChanges.Text = "Submit";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.SubmitChanges);
            // 
            // txtRepeatNew
            // 
            this.txtRepeatNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatNew.Location = new System.Drawing.Point(156, 100);
            this.txtRepeatNew.MaxLength = 20;
            this.txtRepeatNew.Name = "txtRepeatNew";
            this.txtRepeatNew.Size = new System.Drawing.Size(108, 23);
            this.txtRepeatNew.TabIndex = 11;
            this.txtRepeatNew.UseSystemPasswordChar = true;
            // 
            // lblRepeatNew
            // 
            this.lblRepeatNew.AutoSize = true;
            this.lblRepeatNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatNew.Location = new System.Drawing.Point(62, 103);
            this.lblRepeatNew.Name = "lblRepeatNew";
            this.lblRepeatNew.Size = new System.Drawing.Size(88, 16);
            this.lblRepeatNew.TabIndex = 10;
            this.lblRepeatNew.Text = "Repeat New:";
            this.lblRepeatNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(156, 65);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(108, 23);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(47, 68);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(103, 16);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New Password:";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(25, 33);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(125, 16);
            this.lblCurrentPassword.TabIndex = 8;
            this.lblCurrentPassword.Text = "Current Password:";
            this.lblCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(156, 30);
            this.txtCurrentPassword.MaxLength = 20;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(108, 23);
            this.txtCurrentPassword.TabIndex = 5;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblChangePasswordStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblChangePasswordStatus
            // 
            this.lblChangePasswordStatus.ForeColor = System.Drawing.Color.Red;
            this.lblChangePasswordStatus.Name = "lblChangePasswordStatus";
            this.lblChangePasswordStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // PasswordChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChangerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.Label lblRepeatNew;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtRepeatNew;
        private System.Windows.Forms.Button btnSubmitChanges;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblChangePasswordStatus;
        private System.Windows.Forms.Button btnClosePasswordChanger;
    }
}