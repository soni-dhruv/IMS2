using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            UserID.Text = "User ID: " + LoginForm.userId;
            btnChangePassword.Enabled = false;
            this.ActiveControl = txtBoxNewPassword;
        }

        // Button All Stock
        private void btnAllStock_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        // Button Add Stock
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStock ads = new AddStock();
            ads.Show();
            this.Hide();
        }

        // Button Update Stock
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStock us = new UpdateStock();
            us.Show();
            this.Hide();
        }

        // Button Delete Stock
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStock ds = new DeleteStock();
            ds.Show();
            this.Hide();
        }

        // Button Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void txtBoxStockName_Leave(object sender, EventArgs e)
        {
            int numberPass(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (char.IsDigit(ch))
                    {
                        num++;
                    }
                }
                return num;
            }

            int upperCase(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (char.IsUpper(ch))
                    {
                        num++;
                    }
                }
                return num;
            }

            int lowerCase(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (char.IsLower(ch))
                    {
                        num++;
                    }
                }
                return num;
            }

            int specialChar(string pass)
            {
                int num = 0;
                foreach (char ch in pass)
                {
                    if (ch.Equals('!') || ch.Equals('@') || ch.Equals('#') || ch.Equals('$') || ch.Equals('%') || ch.Equals('+')
                    || ch.Equals('^') || ch.Equals('&') || ch.Equals('*') || ch.Equals('(') || ch.Equals(')') || ch.Equals('-')
                    || ch.Equals('_') || ch.Equals('=') || ch.Equals('.'))
                    {
                        num++;
                    }
                }
                return num;
            }

            if (txtBoxNewPassword.Text.Length > 7 && numberPass(txtBoxNewPassword.Text) >= 1 && upperCase(txtBoxNewPassword.Text) >= 1
                && lowerCase(txtBoxNewPassword.Text) >= 1 && specialChar(txtBoxNewPassword.Text) >= 1)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtBoxNewPassword, "Uppercase, Lowercase, Numeric and Special Character Combination Required");
            }
        }

        private void txtBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxConfirmPassword.Text == "")
            {
                errorProvider2.SetError(txtBoxConfirmPassword, "Enter Confirm Password");
            }
            else if (txtBoxNewPassword.Text != "" && txtBoxNewPassword.Text == txtBoxConfirmPassword.Text)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(txtBoxConfirmPassword, "Password and Confirm Password Don't Match.");

            }
        }

        private void LLNewPasswordShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LLNewPasswordShow.Text == "Show")
            {
                txtBoxNewPassword.PasswordChar = '\0';
                LLNewPasswordShow.Text = "Hide";
            }
            else
            {
                txtBoxNewPassword.PasswordChar = '●';
                LLNewPasswordShow.Text = "Show";
            }
        }

        private void llConfirmPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llConfirmPassword.Text == "Show")
            {
                txtBoxConfirmPassword.PasswordChar = '\0';
                llConfirmPassword.Text = "Hide";
            }
            else
            {
                txtBoxConfirmPassword.PasswordChar = '●';
                llConfirmPassword.Text = "Show";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxNewPassword.Text == "")
            {
                errorProvider3.SetError(txtBoxNewPassword, "*Required Field");
            }
            else
            {
                errorProvider3.Clear();
            }

            //Confirm Password Blank Validation
            if (txtBoxNewPassword.Text == "")
            {
                errorProvider4.SetError(txtBoxConfirmPassword, "*Required Field");
            }
            else
            {
                errorProvider4.Clear();
            }

            // Button Change Password
            if(txtBoxNewPassword.Text != "" && txtBoxConfirmPassword.Text == txtBoxNewPassword.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE dbo.signup SET uPassword = '" + txtBoxNewPassword.Text + "', Cpassword = '" + txtBoxConfirmPassword.Text + "' WHERE userId = '" + LoginForm.userId + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxNewPassword.Clear();
                txtBoxConfirmPassword.Clear();
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(button1, "New Password and Confirm Password Don't Match");
            }
        }
    }
}
