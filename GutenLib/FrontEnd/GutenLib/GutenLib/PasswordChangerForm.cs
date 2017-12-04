using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GutenLib
{
    public partial class PasswordChangerForm : Form
    {
        public PasswordChangerForm()
        {
            InitializeComponent();
        }

        private bool CheckNewPassword()
        {
            bool passwordsAreSame = false;
            if (!txtRepeatNew.Text.Equals(txtNewPassword.Text))
            {
                lblChangePasswordStatus.ForeColor = Color.Red;
                lblChangePasswordStatus.Text = "ERROR: New password and repeat of new password are not the same";
            }
            else
            {
                lblChangePasswordStatus.Text = "";
                passwordsAreSame = true;
            }
            return passwordsAreSame;
        }

        private void SubmitChanges(object sender, EventArgs e)
        {
            // checks if new password and repeat of new password are the same
            if (!CheckNewPassword())
            {
                return;
            }

            // checks if current password and new password are same
            if (txtCurrentPassword.Text.Equals(txtNewPassword.Text))
            {
                lblChangePasswordStatus.ForeColor = Color.Red;
                lblChangePasswordStatus.Text = "ERROR: Current and new passwords must be different";
                return;
            }

            // validate current password
            if (false)
            {
                lblChangePasswordStatus.ForeColor = Color.Red;
                lblChangePasswordStatus.Text = "ERROR: Incorrect password";
                return;
            }

            // attempts to update password
            if (false)
            {
                lblChangePasswordStatus.ForeColor = Color.Green;
                lblChangePasswordStatus.Text = "Password updated successfully";
            }
            else
            {
                lblChangePasswordStatus.ForeColor = Color.Red;
                lblChangePasswordStatus.Text = "ERROR: Failed to update password";
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
