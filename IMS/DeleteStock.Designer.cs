namespace IMS
{
    partial class DeleteStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStock));
            this.namePanel = new System.Windows.Forms.Panel();
            this.lblSignUpForm = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAllStock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DeleteStocks = new System.Windows.Forms.Label();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.txtBoxStockPrice = new System.Windows.Forms.TextBox();
            this.txtBoxStockQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxStockName = new System.Windows.Forms.TextBox();
            this.StockPrice = new System.Windows.Forms.Label();
            this.StockQuantity = new System.Windows.Forms.Label();
            this.StockName = new System.Windows.Forms.Label();
            this.txtBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.totalPrice = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.namePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.Blue;
            this.namePanel.Controls.Add(this.lblSignUpForm);
            this.namePanel.Controls.Add(this.UserID);
            this.namePanel.Location = new System.Drawing.Point(-1, 0);
            this.namePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(1381, 69);
            this.namePanel.TabIndex = 15;
            // 
            // lblSignUpForm
            // 
            this.lblSignUpForm.AutoSize = true;
            this.lblSignUpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpForm.ForeColor = System.Drawing.Color.White;
            this.lblSignUpForm.Location = new System.Drawing.Point(529, 15);
            this.lblSignUpForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpForm.Name = "lblSignUpForm";
            this.lblSignUpForm.Size = new System.Drawing.Size(356, 42);
            this.lblSignUpForm.TabIndex = 2;
            this.lblSignUpForm.Text = "Dhruv Stock System";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.White;
            this.UserID.Location = new System.Drawing.Point(0, 43);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(98, 26);
            this.UserID.TabIndex = 3;
            this.UserID.Text = "User ID: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnAllStock);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 683);
            this.panel1.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 172);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Stock";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAllStock
            // 
            this.btnAllStock.BackColor = System.Drawing.Color.Green;
            this.btnAllStock.FlatAppearance.BorderSize = 0;
            this.btnAllStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStock.ForeColor = System.Drawing.Color.White;
            this.btnAllStock.Location = new System.Drawing.Point(0, 86);
            this.btnAllStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllStock.Name = "btnAllStock";
            this.btnAllStock.Size = new System.Drawing.Size(267, 37);
            this.btnAllStock.TabIndex = 7;
            this.btnAllStock.Text = "All Stocks";
            this.btnAllStock.UseVisualStyleBackColor = false;
            this.btnAllStock.Click += new System.EventHandler(this.btnAllStock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 633);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(267, 37);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Green;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 431);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(267, 37);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 258);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(267, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Stock";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 345);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Stock";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // DeleteStocks
            // 
            this.DeleteStocks.AutoSize = true;
            this.DeleteStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStocks.Location = new System.Drawing.Point(707, 74);
            this.DeleteStocks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteStocks.Name = "DeleteStocks";
            this.DeleteStocks.Size = new System.Drawing.Size(169, 29);
            this.DeleteStocks.TabIndex = 17;
            this.DeleteStocks.Text = "Delete Stock";
            // 
            // btnFetchData
            // 
            this.btnFetchData.BackColor = System.Drawing.Color.Green;
            this.btnFetchData.FlatAppearance.BorderSize = 0;
            this.btnFetchData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchData.ForeColor = System.Drawing.Color.White;
            this.btnFetchData.Location = new System.Drawing.Point(660, 281);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(568, 37);
            this.btnFetchData.TabIndex = 42;
            this.btnFetchData.Text = "Fetch Data";
            this.btnFetchData.UseVisualStyleBackColor = false;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStock.FlatAppearance.BorderSize = 0;
            this.btnDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStock.Location = new System.Drawing.Point(660, 620);
            this.btnDeleteStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(568, 37);
            this.btnDeleteStock.TabIndex = 43;
            this.btnDeleteStock.Text = "Delete Stock";
            this.btnDeleteStock.UseVisualStyleBackColor = false;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // txtBoxStockPrice
            // 
            this.txtBoxStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockPrice.Location = new System.Drawing.Point(660, 453);
            this.txtBoxStockPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStockPrice.Name = "txtBoxStockPrice";
            this.txtBoxStockPrice.Size = new System.Drawing.Size(567, 28);
            this.txtBoxStockPrice.TabIndex = 43;
            // 
            // txtBoxStockQuantity
            // 
            this.txtBoxStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockQuantity.Location = new System.Drawing.Point(660, 370);
            this.txtBoxStockQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStockQuantity.Name = "txtBoxStockQuantity";
            this.txtBoxStockQuantity.Size = new System.Drawing.Size(567, 28);
            this.txtBoxStockQuantity.TabIndex = 43;
            // 
            // txtBoxStockName
            // 
            this.txtBoxStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockName.Location = new System.Drawing.Point(660, 196);
            this.txtBoxStockName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStockName.Name = "txtBoxStockName";
            this.txtBoxStockName.Size = new System.Drawing.Size(567, 28);
            this.txtBoxStockName.TabIndex = 41;
            // 
            // StockPrice
            // 
            this.StockPrice.AutoSize = true;
            this.StockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StockPrice.Location = new System.Drawing.Point(433, 455);
            this.StockPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockPrice.Name = "StockPrice";
            this.StockPrice.Size = new System.Drawing.Size(129, 26);
            this.StockPrice.TabIndex = 40;
            this.StockPrice.Text = "Stock Price:";
            // 
            // StockQuantity
            // 
            this.StockQuantity.AutoSize = true;
            this.StockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StockQuantity.Location = new System.Drawing.Point(399, 373);
            this.StockQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.Size = new System.Drawing.Size(160, 26);
            this.StockQuantity.TabIndex = 39;
            this.StockQuantity.Text = "Stock Quantity:";
            // 
            // StockName
            // 
            this.StockName.AutoSize = true;
            this.StockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StockName.Location = new System.Drawing.Point(425, 198);
            this.StockName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockName.Name = "StockName";
            this.StockName.Size = new System.Drawing.Size(138, 26);
            this.StockName.TabIndex = 38;
            this.StockName.Text = "Stock Name:";
            // 
            // txtBoxTotalPrice
            // 
            this.txtBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalPrice.Location = new System.Drawing.Point(660, 534);
            this.txtBoxTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            this.txtBoxTotalPrice.Size = new System.Drawing.Size(567, 28);
            this.txtBoxTotalPrice.TabIndex = 47;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.totalPrice.Location = new System.Drawing.Point(439, 534);
            this.totalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(121, 26);
            this.totalPrice.TabIndex = 46;
            this.totalPrice.Text = "Total Price:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // DeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 752);
            this.Controls.Add(this.txtBoxTotalPrice);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.txtBoxStockPrice);
            this.Controls.Add(this.txtBoxStockQuantity);
            this.Controls.Add(this.txtBoxStockName);
            this.Controls.Add(this.StockPrice);
            this.Controls.Add(this.StockQuantity);
            this.Controls.Add(this.StockName);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteStocks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DeleteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStock";
            this.Load += new System.EventHandler(this.DeleteStock_Load);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label lblSignUpForm;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAllStock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label DeleteStocks;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.TextBox txtBoxStockPrice;
        private System.Windows.Forms.TextBox txtBoxStockQuantity;
        private System.Windows.Forms.TextBox txtBoxStockName;
        private System.Windows.Forms.Label StockPrice;
        private System.Windows.Forms.Label StockQuantity;
        private System.Windows.Forms.Label StockName;
        private System.Windows.Forms.TextBox txtBoxTotalPrice;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}