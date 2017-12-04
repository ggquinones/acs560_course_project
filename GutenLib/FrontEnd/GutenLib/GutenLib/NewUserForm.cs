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

        private bool CheckNewUserPassword()
        {
            if (!txtRepeatPassNew.Text.Equals(txtPasswordNew.Text))
            {
                lblStatusNewUser.ForeColor = Color.Red;
                lblStatusNewUser.Text = "ERROR: Password and repeat of password are not the same";
                return false;
            }
            else
            {
                lblStatusNewUser.Text = "";
                return true;
            }
        }

        private void SubmitNewUserChanges(object sender, EventArgs e)
        {
            // validates password and repeat password are same
            if (!CheckNewUserPassword())
            {
                return;
            }

            // validate username selection
            if (ServerProxy.UsernameExistsInDB(txtUsernameNew.Text))
            {
                lblStatusNewUser.ForeColor = Color.Red;
                lblStatusNewUser.Text = "ERROR: Selected username not available";
                txtPasswordNew.Text = "";
                txtRepeatPassNew.Text = "";
                return;
            }
            
            // attempt to update database
            if (ServerProxy.AddUserToDB(txtUsernameNew.Text, txtPasswordNew.Text))
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
