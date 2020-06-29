using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Net;
using System.Net.Mail;

namespace IMS
{
    public partial class ForgotPassword : Form
    {
        string OTPCode;
        public static string to;
        LoginForm LF = new LoginForm();

        public ForgotPassword()
        {
            InitializeComponent();
        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            verifyOTP.Hide();
            txtBoxVerifyOTP.Hide();
            btnVerifyOTP.Hide();
            newPassword.Hide();
            txtBoxNewPassword.Hide();
            confirmPassword.Hide();
            txtBoxConfirmPassword.Hide();
            LLPasswordShow.Hide();
            LLCPasswordShow.Hide();
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
            if (LLCPasswordShow.Text == "Show")
            {
                txtBoxConfirmPassword.PasswordChar = '\0';
                LLCPasswordShow.Text = "Hide";
            }
            else
            {
                txtBoxConfirmPassword.PasswordChar = '●';
                LLCPasswordShow.Text = "Show";
            }
        }

        // Back to Login Button
        private void btn2Login_Click(object sender, EventArgs e)
        {            
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

        
        private void btnOTP_Click(object sender, EventArgs e)
        {
            // Show
            verifyOTP.Show();            
            btnVerifyOTP.Show();
            txtBoxVerifyOTP.Show();
            txtBoxEmail.ReadOnly = true;
            btnOTP.Enabled = false;

            // Send OTP
            string from, pass, messageBody;
            Random rand = new Random();
            OTPCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (txtBoxEmail.Text).ToString();
            from = "";
            pass = "";
            messageBody = "Dhruv Stock System Password Reset OTP Code is: " + OTPCode + ". Dont share OTP with anyone.";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Reset Password OTP";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sent Successfully", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Verify OTP Button
        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {            
            if(OTPCode == (txtBoxVerifyOTP.Text).ToString())
            {
                //to = txtBoxEmail.Text;
                newPassword.Show();
                txtBoxNewPassword.Show();
                confirmPassword.Show();
                txtBoxConfirmPassword.Show();
                LLPasswordShow.Show();
                LLCPasswordShow.Show();
            }
            else
            {
                MessageBox.Show("Incorrect OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Change Password Button
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
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

            // Reset Password

            if (txtBoxNewPassword.Text == txtBoxConfirmPassword.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE dbo.signup SET uPassword = '"+ txtBoxNewPassword.Text + "', Cpassword = '" + txtBoxConfirmPassword.Text + "' WHERE eMail = '"+ txtBoxEmail.Text +"' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Reset Done Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("E-Mail Not Rlk;egistered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Back to Login Page
            LF.Show();
            this.Close();
        }
    }
}