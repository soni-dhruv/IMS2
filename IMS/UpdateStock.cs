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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            UserID.Text = "User ID: " + LoginForm.userId;
            btnUpdate.Enabled = false;
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

        // Button Delete Stock
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStock ds = new DeleteStock();
            ds.Show();
            this.Hide();
        }

        // Button Change Password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
            this.Hide();
        }

        // Button Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        // Only Numbers in Quantity and Price
        private void txtBoxStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
