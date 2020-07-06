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

namespace IMS
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }        
        private void UserID_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnAllStock_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        // Button Add Stock
        private void AddStock_Load(object sender, EventArgs e)
        {
            UserID.Text = "User ID: " + LoginForm.userId;
            btnAdd.Enabled = false;
            txtBoxTotalPrice.ReadOnly = true;
            this.ActiveControl = txtBoxStockName;
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

        // Only Numbers in Quantity
        private void txtBoxStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxTotalPrice_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBoxStockPrice_Layout(object sender, LayoutEventArgs e)
        {

        }

        // Total Calculator
        private void txtBoxStockPrice_Leave(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtBoxStockQuantity.Text);
            int price = Convert.ToInt32(txtBoxStockPrice.Text);
            int total = Convert.ToInt32(quantity * price);
            txtBoxTotalPrice.Text = Convert.ToString(total);
        }

        // Button Submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtBoxStockName.Text != "" && txtBoxStockQuantity.Text != "" && txtBoxStockPrice.Text != "" && txtBoxTotalPrice.Text != "")
            {
                try
                {
                    errorProvider1.Clear();
                    SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("insert into dbo.stock values('"+ LoginForm.userId +"', '"+txtBoxStockName.Text +"', '"+txtBoxStockQuantity.Text + "', '" +txtBoxStockPrice.Text + "', '" +txtBoxTotalPrice.Text + "' )", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Stock Name: " + txtBoxStockName.Text + "\nStock Quantity: " + txtBoxStockQuantity.Text + "\nStock Price: " + txtBoxStockPrice.Text + "\nTotal Price: " + txtBoxTotalPrice.Text + "\nAdded Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider1.SetError(btnSubmit, "**All Fields Required");
            }
            
            // Clear
            txtBoxStockName.Text = "";
            txtBoxStockQuantity.Text = "";
            txtBoxStockPrice.Text = "";
            txtBoxTotalPrice.Text = "";

            this.ActiveControl = txtBoxStockName;
        }
    }
}
