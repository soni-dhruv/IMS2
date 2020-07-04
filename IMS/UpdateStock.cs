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

        // Fetch Data
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            txtBoxStockName.ReadOnly = true;
            if(txtBoxStockName.Text == "")
            {
                errorProvider1.SetError(btnFetchData, "**Stock Name Required");
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                con.Open();
                if (txtBoxStockName.Text != "")
                {
                    //SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                    //con.Open();
                    SqlCommand cmd = new SqlCommand(" select quantity, price from stock where stockName = '"+txtBoxStockName.Text+"' and userId = '" + LoginForm.userId + "' ", con);
                    //cmd.Parameters.AddWithValue("@StockName", txtBoxStockName.Text);

                    SqlDataReader da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        txtBoxStockQuantity.Text = da.GetValue(0).ToString();
                        txtBoxStockPrice.Text = da.GetValue(1).ToString();
                    }
                    else
                    {
                        txtBoxStockName.ReadOnly = false;
                        MessageBox.Show("No Data Found for This Stock Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    con.Close();
                }
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
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
            if (txtBoxStockName.Text != "" && txtBoxStockQuantity.Text != "" && txtBoxStockPrice.Text != "" && txtBoxTotalPrice.Text != "")
            {
                try
                {
                    errorProvider2.Clear();
                    SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.stock SET quantity = '" + txtBoxStockQuantity.Text + "', price = '" + txtBoxStockPrice.Text + "', total = '"+txtBoxTotalPrice.Text +"' WHERE userId = '" + LoginForm.userId + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Stock Name: " + txtBoxStockName.Text + "\nStock Quantity: " + txtBoxStockQuantity.Text + "\nStock Price: " + txtBoxStockPrice.Text + "\nTotal Price: " + txtBoxTotalPrice.Text + "\nUpdated Successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider2.SetError(btnSubmit, "**All Fields Required");
            }
        }
    }
}
