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

        
    }
}
