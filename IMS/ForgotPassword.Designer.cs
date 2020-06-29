using System;
using System.Windows.Forms;

namespace IMS
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.btn2Login = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.ResetPassword = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.Label();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LLPasswordShow = new System.Windows.Forms.LinkLabel();
            this.LLCPasswordShow = new System.Windows.Forms.LinkLabel();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOTP = new System.Windows.Forms.Button();
            this.txtBoxVerifyOTP = new System.Windows.Forms.TextBox();
            this.verifyOTP = new System.Windows.Forms.Label();
            this.btnVerifyOTP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 56);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dhruv Stock System";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Blue;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(335, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 31;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btn2Login
            // 
            this.btn2Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2Login.FlatAppearance.BorderSize = 0;
            this.btn2Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Login.ForeColor = System.Drawing.Color.White;
            this.btn2Login.Location = new System.Drawing.Point(50, 436);
            this.btn2Login.Name = "btn2Login";
            this.btn2Login.Size = new System.Drawing.Size(262, 30);
            this.btn2Login.TabIndex = 30;
            this.btn2Login.Text = "Back To Login";
            this.btn2Login.UseVisualStyleBackColor = false;
            this.btn2Login.Click += new System.EventHandler(this.btn2Login_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Green;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(50, 394);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(262, 30);
            this.btnChangePassword.TabIndex = 29;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ResetPassword
            // 
            this.ResetPassword.AutoSize = true;
            this.ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ResetPassword.Location = new System.Drawing.Point(71, 57);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(227, 33);
            this.ResetPassword.TabIndex = 16;
            this.ResetPassword.Text = "Reset Password";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(50, 118);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(262, 23);
            this.txtBoxEmail.TabIndex = 21;
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.eMail.Location = new System.Drawing.Point(46, 93);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(60, 22);
            this.eMail.TabIndex = 27;
            this.eMail.Text = "E-Mail";
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.newPassword.Location = new System.Drawing.Point(46, 279);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(130, 22);
            this.newPassword.TabIndex = 30;
            this.newPassword.Text = "New Password";
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPassword.Location = new System.Drawing.Point(50, 304);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PasswordChar = '●';
            this.txtBoxNewPassword.Size = new System.Drawing.Size(262, 23);
            this.txtBoxNewPassword.TabIndex = 25;
            this.txtBoxNewPassword.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(50, 362);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.PasswordChar = '●';
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(262, 23);
            this.txtBoxConfirmPassword.TabIndex = 27;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.confirmPassword.Location = new System.Drawing.Point(46, 338);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(156, 22);
            this.confirmPassword.TabIndex = 33;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LLPasswordShow
            // 
            this.LLPasswordShow.AutoSize = true;
            this.LLPasswordShow.BackColor = System.Drawing.Color.White;
            this.LLPasswordShow.Location = new System.Drawing.Point(273, 310);
            this.LLPasswordShow.Name = "LLPasswordShow";
            this.LLPasswordShow.Size = new System.Drawing.Size(34, 13);
            this.LLPasswordShow.TabIndex = 26;
            this.LLPasswordShow.TabStop = true;
            this.LLPasswordShow.Text = "Show";
            this.LLPasswordShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLPasswordShow_LinkClicked);
            // 
            // LLCPasswordShow
            // 
            this.LLCPasswordShow.AutoSize = true;
            this.LLCPasswordShow.BackColor = System.Drawing.Color.White;
            this.LLCPasswordShow.Location = new System.Drawing.Point(274, 368);
            this.LLCPasswordShow.Name = "LLCPasswordShow";
            this.LLCPasswordShow.Size = new System.Drawing.Size(34, 13);
            this.LLCPasswordShow.TabIndex = 28;
            this.LLCPasswordShow.TabStop = true;
            this.LLCPasswordShow.Text = "Show";
            this.LLCPasswordShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // btnOTP
            // 
            this.btnOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOTP.FlatAppearance.BorderSize = 0;
            this.btnOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTP.ForeColor = System.Drawing.Color.White;
            this.btnOTP.Location = new System.Drawing.Point(50, 148);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(262, 30);
            this.btnOTP.TabIndex = 22;
            this.btnOTP.Text = "Send OTP";
            this.btnOTP.UseVisualStyleBackColor = false;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // txtBoxVerifyOTP
            // 
            this.txtBoxVerifyOTP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVerifyOTP.Location = new System.Drawing.Point(49, 212);
            this.txtBoxVerifyOTP.Name = "txtBoxVerifyOTP";
            this.txtBoxVerifyOTP.Size = new System.Drawing.Size(262, 23);
            this.txtBoxVerifyOTP.TabIndex = 23;
            // 
            // verifyOTP
            // 
            this.verifyOTP.AutoSize = true;
            this.verifyOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyOTP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.verifyOTP.Location = new System.Drawing.Point(45, 187);
            this.verifyOTP.Name = "verifyOTP";
            this.verifyOTP.Size = new System.Drawing.Size(96, 22);
            this.verifyOTP.TabIndex = 38;
            this.verifyOTP.Text = "Enter OTP";
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.BackColor = System.Drawing.Color.Green;
            this.btnVerifyOTP.FlatAppearance.BorderSize = 0;
            this.btnVerifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyOTP.ForeColor = System.Drawing.Color.White;
            this.btnVerifyOTP.Location = new System.Drawing.Point(51, 242);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(262, 30);
            this.btnVerifyOTP.TabIndex = 24;
            this.btnVerifyOTP.Text = "Verify OTP";
            this.btnVerifyOTP.UseVisualStyleBackColor = false;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 480);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.txtBoxVerifyOTP);
            this.Controls.Add(this.verifyOTP);
            this.Controls.Add(this.btnOTP);
            this.Controls.Add(this.LLCPasswordShow);
            this.Controls.Add(this.LLPasswordShow);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn2Login);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.ResetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
            
        }

        private void llPasswordShowHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btn2Login;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label ResetPassword;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private LinkLabel LLCPasswordShow;
        private LinkLabel LLPasswordShow;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private Button btnOTP;
        private TextBox txtBoxVerifyOTP;
        private Label verifyOTP;
        private Button btnVerifyOTP;
    }
}