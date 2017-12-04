namespace GutenLib
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.pnlLoginCenter = new System.Windows.Forms.Panel();
            this.btnCloseNew = new System.Windows.Forms.Button();
            this.lblRepeatPassNew = new System.Windows.Forms.Label();
            this.txtRepeatPassNew = new System.Windows.Forms.TextBox();
            this.btnSubmitNew = new System.Windows.Forms.Button();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.lblUsernameNew = new System.Windows.Forms.Label();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtUsernameNew = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusNewUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLoginCenter.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginCenter
            // 
            this.pnlLoginCenter.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLoginCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginCenter.Controls.Add(this.btnCloseNew);
            this.pnlLoginCenter.Controls.Add(this.lblRepeatPassNew);
            this.pnlLoginCenter.Controls.Add(this.txtRepeatPassNew);
            this.pnlLoginCenter.Controls.Add(this.btnSubmitNew);
            this.pnlLoginCenter.Controls.Add(this.lblPasswordNew);
            this.pnlLoginCenter.Controls.Add(this.lblUsernameNew);
            this.pnlLoginCenter.Controls.Add(this.txtPasswordNew);
            this.pnlLoginCenter.Controls.Add(this.txtUsernameNew);
            this.pnlLoginCenter.Location = new System.Drawing.Point(115, 92);
            this.pnlLoginCenter.Name = "pnlLoginCenter";
            this.pnlLoginCenter.Size = new System.Drawing.Size(437, 248);
            this.pnlLoginCenter.TabIndex = 1;
            // 
            // btnCloseNew
            // 
            this.btnCloseNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNew.Location = new System.Drawing.Point(243, 181);
            this.btnCloseNew.Name = "btnCloseNew";
            this.btnCloseNew.Size = new System.Drawing.Size(111, 33);
            this.btnCloseNew.TabIndex = 4;
            this.btnCloseNew.Text = "Close";
            this.btnCloseNew.UseVisualStyleBackColor = false;
            this.btnCloseNew.Click += new System.EventHandler(this.CloseNewUserForm);
            // 
            // lblRepeatPassNew
            // 
            this.lblRepeatPassNew.AutoSize = true;
            this.lblRepeatPassNew.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPassNew.Location = new System.Drawing.Point(60, 131);
            this.lblRepeatPassNew.Name = "lblRepeatPassNew";
            this.lblRepeatPassNew.Size = new System.Drawing.Size(149, 25);
            this.lblRepeatPassNew.TabIndex = 7;
            this.lblRepeatPassNew.Text = "Repeat Pass.:";
            this.lblRepeatPassNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRepeatPassNew
            // 
            this.txtRepeatPassNew.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPassNew.Location = new System.Drawing.Point(215, 128);
            this.txtRepeatPassNew.MaxLength = 20;
            this.txtRepeatPassNew.Name = "txtRepeatPassNew";
            this.txtRepeatPassNew.Size = new System.Drawing.Size(160, 32);
            this.txtRepeatPassNew.TabIndex = 2;
            this.txtRepeatPassNew.UseSystemPasswordChar = true;
            // 
            // btnSubmitNew
            // 
            this.btnSubmitNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNew.Location = new System.Drawing.Point(113, 181);
            this.btnSubmitNew.Name = "btnSubmitNew";
            this.btnSubmitNew.Size = new System.Drawing.Size(111, 33);
            this.btnSubmitNew.TabIndex = 3;
            this.btnSubmitNew.Text = "Submit";
            this.btnSubmitNew.UseVisualStyleBackColor = false;
            this.btnSubmitNew.Click += new System.EventHandler(this.SubmitNewUserChanges);
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNew.Location = new System.Drawing.Point(95, 93);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(114, 25);
            this.lblPasswordNew.TabIndex = 3;
            this.lblPasswordNew.Text = "Password:";
            this.lblPasswordNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsernameNew
            // 
            this.lblUsernameNew.AutoSize = true;
            this.lblUsernameNew.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameNew.Location = new System.Drawing.Point(92, 54);
            this.lblUsernameNew.Name = "lblUsernameNew";
            this.lblUsernameNew.Size = new System.Drawing.Size(117, 25);
            this.lblUsernameNew.TabIndex = 4;
            this.lblUsernameNew.Text = "Username:";
            this.lblUsernameNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.Location = new System.Drawing.Point(215, 90);
            this.txtPasswordNew.MaxLength = 20;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(160, 32);
            this.txtPasswordNew.TabIndex = 1;
            this.txtPasswordNew.UseSystemPasswordChar = true;
            // 
            // txtUsernameNew
            // 
            this.txtUsernameNew.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameNew.Location = new System.Drawing.Point(215, 51);
            this.txtUsernameNew.MaxLength = 20;
            this.txtUsernameNew.Name = "txtUsernameNew";
            this.txtUsernameNew.Size = new System.Drawing.Size(160, 32);
            this.txtUsernameNew.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusNewUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusNewUser
            // 
            this.lblStatusNewUser.ForeColor = System.Drawing.Color.Red;
            this.lblStatusNewUser.Name = "lblStatusNewUser";
            this.lblStatusNewUser.Size = new System.Drawing.Size(0, 17);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlLoginCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.pnlLoginCenter.ResumeLayout(false);
            this.pnlLoginCenter.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginCenter;
        private System.Windows.Forms.Button btnCloseNew;
        private System.Windows.Forms.Label lblRepeatPassNew;
        private System.Windows.Forms.TextBox txtRepeatPassNew;
        private System.Windows.Forms.Button btnSubmitNew;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.Label lblUsernameNew;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtUsernameNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusNewUser;
    }
}