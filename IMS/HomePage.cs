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
    public partial class HomePage : Form
    { 
        string connectionString = @"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True";
        public HomePage()
        {
            InitializeComponent();
        }

        
        private void HomePage_Load(object sender, EventArgs e)
        {
            UserID.Text = "User ID: " + LoginForm.userId;
            btnAllStock.Enabled = false;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select stockName, quantity, price, total from stock where userId = '"+ LoginForm.userId +"'", sqlCon);
                DataTable dtb = new DataTable();
                sqlDa.Fill(dtb);

                dgv.DataSource = dtb;
                dgv.AutoGenerateColumns = false;
            }
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
    }
}
