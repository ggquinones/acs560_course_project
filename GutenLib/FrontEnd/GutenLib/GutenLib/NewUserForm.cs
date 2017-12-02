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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void CheckNewUserPassword(object sender, EventArgs e)
        {
            if (!txtRepeatPassNew.Text.Equals(txtPasswordNew.Text))
            {
                lblStatusNewUser.ForeColor = Color.Red;
                lblStatusNewUser.Text = "ERROR: Password and repeat of password are not the same";
            }
            else
            {
                btnSubmitNew.Enabled = true;
                lblStatusNewUser.Text = "";
            }
        }

        private void SubmitNewUserChanges(object sender, EventArgs e)
        {
            // validate username selection
            if (false)
            {
                lblStatusNewUser.ForeColor = Color.Red;
                lblStatusNewUser.Text = "ERROR: Selected username not available";
                txtPasswordNew.Text = "";
                txtRepeatPassNew.Text = "";
                return;
            }

            // attempt to update database
            if (false)
            {
                lblStatusNewUser.ForeColor = Color.Green;
                lblStatusNewUser.Text = "New user successfully created";
                txtUsernameNew.Text = "";
            }
            else
            {
                lblStatusNewUser.ForeColor = Color.Red;
                lblStatusNewUser.Text = "ERROR: Failed to create new user";
            }

            txtPasswordNew.Text = "";
            txtRepeatPassNew.Text = "";
        }

        private void CloseNewUserForm(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
