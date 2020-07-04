namespace IMS
{
    partial class AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
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
            this.AddStocks = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.txtBoxStockPrice = new System.Windows.Forms.TextBox();
            this.txtBoxStockQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxStockName = new System.Windows.Forms.TextBox();
            this.StockPrice = new System.Windows.Forms.Label();
            this.StockQuantity = new System.Windows.Forms.Label();
            this.StockName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.namePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.Blue;
            this.namePanel.Controls.Add(this.lblSignUpForm);
            this.namePanel.Controls.Add(this.UserID);
            this.namePanel.Location = new System.Drawing.Point(-1, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(1036, 56);
            this.namePanel.TabIndex = 2;
            // 
            // lblSignUpForm
            // 
            this.lblSignUpForm.AutoSize = true;
            this.lblSignUpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpForm.ForeColor = System.Drawing.Color.White;
            this.lblSignUpForm.Location = new System.Drawing.Point(397, 12);
            this.lblSignUpForm.Name = "lblSignUpForm";
            this.lblSignUpForm.Size = new System.Drawing.Size(280, 33);
            this.lblSignUpForm.TabIndex = 2;
            this.lblSignUpForm.Text = "Dhruv Stock System";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.White;
            this.UserID.Location = new System.Drawing.Point(0, 35);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(80, 22);
            this.UserID.TabIndex = 3;
            this.UserID.Text = "User ID: ";
            this.UserID.Click += new System.EventHandler(this.UserID_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 555);
            this.panel1.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Stock";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAllStock
            // 
            this.btnAllStock.BackColor = System.Drawing.Color.Green;
            this.btnAllStock.FlatAppearance.BorderSize = 0;
            this.btnAllStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStock.ForeColor = System.Drawing.Color.White;
            this.btnAllStock.Location = new System.Drawing.Point(0, 70);
            this.btnAllStock.Name = "btnAllStock";
            this.btnAllStock.Size = new System.Drawing.Size(200, 30);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 514);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 30);
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
            this.btnChangePassword.Location = new System.Drawing.Point(0, 350);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 30);
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
            this.btnUpdate.Location = new System.Drawing.Point(0, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 30);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Stock";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddStocks
            // 
            this.AddStocks.AutoSize = true;
            this.AddStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStocks.Location = new System.Drawing.Point(530, 60);
            this.AddStocks.Name = "AddStocks";
            this.AddStocks.Size = new System.Drawing.Size(112, 25);
            this.AddStocks.TabIndex = 11;
            this.AddStocks.Text = "Add Stock";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(495, 451);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(426, 30);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxTotalPrice
            // 
            this.txtBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalPrice.Location = new System.Drawing.Point(495, 360);
            this.txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            this.txtBoxTotalPrice.Size = new System.Drawing.Size(426, 24);
            this.txtBoxTotalPrice.TabIndex = 26;
            this.txtBoxTotalPrice.Leave += new System.EventHandler(this.txtBoxTotalPrice_Leave);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TotalPrice.Location = new System.Drawing.Point(329, 362);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(102, 22);
            this.TotalPrice.TabIndex = 25;
            this.TotalPrice.Text = "Total Price:";
            // 
            // txtBoxStockPrice
            // 
            this.txtBoxStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockPrice.Location = new System.Drawing.Point(495, 295);
            this.txtBoxStockPrice.Name = "txtBoxStockPrice";
            this.txtBoxStockPrice.Size = new System.Drawing.Size(426, 24);
            this.txtBoxStockPrice.TabIndex = 24;
            this.txtBoxStockPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStockQuantity_KeyPress);
            this.txtBoxStockPrice.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtBoxStockPrice_Layout);
            this.txtBoxStockPrice.Leave += new System.EventHandler(this.txtBoxStockPrice_Leave);
            // 
            // txtBoxStockQuantity
            // 
            this.txtBoxStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockQuantity.Location = new System.Drawing.Point(495, 228);
            this.txtBoxStockQuantity.Name = "txtBoxStockQuantity";
            this.txtBoxStockQuantity.Size = new System.Drawing.Size(426, 24);
            this.txtBoxStockQuantity.TabIndex = 23;
            this.txtBoxStockQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStockQuantity_KeyPress);
            // 
            // txtBoxStockName
            // 
            this.txtBoxStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStockName.Location = new System.Drawing.Point(495, 159);
            this.txtBoxStockName.Name = "txtBoxStockName";
            this.txtBoxStockName.Size = new System.Drawing.Size(426, 24);
            this.txtBoxStockName.TabIndex = 22;
            // 
            // StockPrice
            // 
            this.StockPrice.AutoSize = true;
            this.StockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StockPrice.Location = new System.Drawing.Point(325, 297);
            this.StockPrice.Name = "StockPrice";
            this.StockPrice.Size = new System.Drawing.Size(106, 22);
            this.StockPrice.TabIndex = 21;
            this.StockPrice.Text = "Stock Price:";
            // 
            // StockQuantity
            // 
            this.StockQuantity.AutoSize = true;
            this.StockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StockQuantity.Location = new System.Drawing.Point(299, 230);
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.Size = new System.Drawing.Size(132, 22);
            this.StockQuantity.TabIndex = 20;
            this.StockQuantity.Text = "Stock Quantity:";
            // 
            // StockName
            // 
            this.StockName.AutoSize = true;
            this.StockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StockName.Location = new System.Drawing.Point(319, 161);
            this.StockName.Name = "StockName";
            this.StockName.Size = new System.Drawing.Size(112, 22);
            this.StockName.TabIndex = 19;
            this.StockName.Text = "Stock Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxTotalPrice);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.txtBoxStockPrice);
            this.Controls.Add(this.txtBoxStockQuantity);
            this.Controls.Add(this.txtBoxStockName);
            this.Controls.Add(this.StockPrice);
            this.Controls.Add(this.StockQuantity);
            this.Controls.Add(this.StockName);
            this.Controls.Add(this.AddStocks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.namePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label AddStocks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxTotalPrice;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.TextBox txtBoxStockPrice;
        private System.Windows.Forms.TextBox txtBoxStockQuantity;
        private System.Windows.Forms.TextBox txtBoxStockName;
        private System.Windows.Forms.Label StockPrice;
        private System.Windows.Forms.Label StockQuantity;
        private System.Windows.Forms.Label StockName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}