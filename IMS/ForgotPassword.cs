using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        // X Close Button
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Password Policy in New Password
        private void textBox2_Leave(object sender, EventArgs e)
        {
            string userName = txtBoxNewPassword.Text;
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
                errorProvider1.SetError(newPassword, "Uppercase, Lowercase, Numeric and Special Character Combination Required");
            }
        }

        // New Password Hide Show
        private void LLPasswordShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LLPasswordShow.Text == "Show")
            {
                txtBoxNewPassword.PasswordChar = '\0';
                LLPasswordShow.Text = "Hide";
            }
            else
            {
                txtBoxNewPassword.PasswordChar = '●';
                LLPasswordShow.Text = "Show";
            }
        }

        // Confirm Password Hide Show
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Show")
            {
                txtBoxConfirmPassword.PasswordChar = '\0';
                linkLabel1.Text = "Hide";
            }
            else
            {
                txtBoxConfirmPassword.PasswordChar = '●';
                linkLabel1.Text = "Show";
            }
        }

        // Back to Login Button
        private void btn2Login_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        // Confirm Password Match Validation
        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxConfirmPassword.Text == "")
            {
                errorProvider2.SetError(confirmPassword, "Enter Confirm Password");
            }
            else if (txtBoxConfirmPassword.Text != "" && txtBoxConfirmPassword.Text == txtBoxNewPassword.Text)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(confirmPassword, "Password and Confirm Password Don't Match.");

            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // User ID Blank Validation
            if (txtBoxuID.Text == "")
            {
                errorProvider3.SetError(userId, "*Required Field");
            }
            else
            {
                errorProvider3.Clear();
            }

            // Mobile Number Blank Validation
            if (txtBoxMobileNo.Text == "")
            {
                errorProvider4.SetError(mobileNo, "*Required Field");
            }
            else
            {
                errorProvider4.Clear();
            }

            // E-Mail Blank Validation
            if (txtBoxEmail.Text == "")
            {
                errorProvider5.SetError(eMail, "*Required Field");
            }
            else
            {
                errorProvider5.Clear();
            }

            //New Password Blank Validation
            if (txtBoxNewPassword.Text == "")
            {
                errorProvider6.SetError(newPassword, "*Required Field");
            }
            else
            {
                errorProvider6.Clear();
            }

            //Confirm Password Blank Validation
            if (txtBoxNewPassword.Text == "")
            {
                errorProvider7.SetError(confirmPassword, "*Required Field");
            }
            else
            {
                errorProvider7.Clear();
            }
        }
    }
}