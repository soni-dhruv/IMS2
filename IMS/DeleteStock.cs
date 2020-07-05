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
    public partial class DeleteStock : Form
    {
        public DeleteStock()
        {
            InitializeComponent();
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            UserID.Text = "User ID: " + LoginForm.userId;
            txtBoxStockQuantity.ReadOnly = true;
            txtBoxStockPrice.ReadOnly = true;
            txtBoxTotalPrice.ReadOnly = true;
            btnDelete.Enabled = false;
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

        //Button Change Password
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

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            txtBoxStockName.ReadOnly = true;
            if (txtBoxStockName.Text == "")
            {
                errorProvider1.SetError(btnFetchData, "**Stock Name Required");
                txtBoxStockName.ReadOnly = false;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                con.Open();
                if (txtBoxStockName.Text != "")
                {
                    errorProvider1.Clear();
                    SqlCommand cmd = new SqlCommand(" select quantity, price, total from stock where stockName = '" + txtBoxStockName.Text + "' and userId = '" + LoginForm.userId + "' ", con);
                    SqlDataReader da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        txtBoxStockQuantity.Text = da.GetValue(0).ToString();
                        txtBoxStockPrice.Text = da.GetValue(1).ToString();
                        txtBoxTotalPrice.Text = da.GetValue(2).ToString();
                    }
                    else
                    {
                        txtBoxStockName.ReadOnly = false;
                        MessageBox.Show("No Data Found for This Stock Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (txtBoxStockName.Text != "" && txtBoxStockQuantity.Text != "" && txtBoxStockPrice.Text != "" && txtBoxTotalPrice.Text != "")
            {
                try
                {
                    errorProvider2.Clear();
                    SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("delete dbo.stock where userId = '"+ LoginForm.userId +"' and stockName = '"+ txtBoxStockName.Text +"'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Stock Name: " + txtBoxStockName.Text + "\nStock Quantity: " + txtBoxStockQuantity.Text + "\nStock Price: " + txtBoxStockPrice.Text + "\nTotal Price: " + txtBoxTotalPrice.Text + "\nDeleted Successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxStockName.Text = "";
                    txtBoxStockQuantity.Text = "";
                    txtBoxStockPrice.Text = "";
                    txtBoxTotalPrice.Text = "";
                    txtBoxStockName.ReadOnly = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                errorProvider2.SetError(btnDelete, "**All Fields Required");
            }
        }
    }
}
