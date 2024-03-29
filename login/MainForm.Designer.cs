﻿namespace login
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update_Employee = new System.Windows.Forms.Label();
            this.lbl_forgotPW = new System.Windows.Forms.Label();
            this.btn_reports = new System.Windows.Forms.Label();
            this.btn_accounting = new System.Windows.Forms.Label();
            this.btn_orders = new System.Windows.Forms.Label();
            this.btn_inventory = new System.Windows.Forms.Label();
            this.btn_employee_setup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.icon_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.btn_Update_Employee);
            this.panel1.Controls.Add(this.lbl_forgotPW);
            this.panel1.Controls.Add(this.btn_reports);
            this.panel1.Controls.Add(this.btn_accounting);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Controls.Add(this.btn_inventory);
            this.panel1.Controls.Add(this.btn_employee_setup);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 795);
            this.panel1.TabIndex = 0;
            // 
            // btn_Update_Employee
            // 
            this.btn_Update_Employee.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Update_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update_Employee.Font = new System.Drawing.Font("Arial", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Employee.ForeColor = System.Drawing.Color.Peru;
            this.btn_Update_Employee.Location = new System.Drawing.Point(0, 558);
            this.btn_Update_Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Update_Employee.Name = "btn_Update_Employee";
            this.btn_Update_Employee.Size = new System.Drawing.Size(777, 114);
            this.btn_Update_Employee.TabIndex = 50;
            this.btn_Update_Employee.Text = "Update Employee Information";
            this.btn_Update_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update_Employee.Click += new System.EventHandler(this.Btn_New_Employee_Click);
            this.btn_Update_Employee.MouseEnter += new System.EventHandler(this.btn_Update_Employee_MouseEnter);
            this.btn_Update_Employee.MouseLeave += new System.EventHandler(this.btn_Update_Employee_MouseLeave);
            // 
            // lbl_forgotPW
            // 
            this.lbl_forgotPW.AutoSize = true;
            this.lbl_forgotPW.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_forgotPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgotPW.ForeColor = System.Drawing.Color.Peru;
            this.lbl_forgotPW.Location = new System.Drawing.Point(408, 734);
            this.lbl_forgotPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_forgotPW.Name = "lbl_forgotPW";
            this.lbl_forgotPW.Size = new System.Drawing.Size(760, 51);
            this.lbl_forgotPW.TabIndex = 70;
            this.lbl_forgotPW.Text = "Click here to Change Your Password";
            this.lbl_forgotPW.Click += new System.EventHandler(this.Lbl_forgotPW_Click);
            this.lbl_forgotPW.MouseEnter += new System.EventHandler(this.lbl_forgotPW_MouseEnter);
            this.lbl_forgotPW.MouseLeave += new System.EventHandler(this.lbl_forgotPW_MouseLeave);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reports.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.Peru;
            this.btn_reports.Location = new System.Drawing.Point(837, 558);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(735, 114);
            this.btn_reports.TabIndex = 60;
            this.btn_reports.Text = "Reports";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reports.Click += new System.EventHandler(this.Btn_Reports_Click);
            this.btn_reports.MouseEnter += new System.EventHandler(this.Btn_Reports_MouseEnter);
            this.btn_reports.MouseLeave += new System.EventHandler(this.Btn_Reports_MouseLeave);
            // 
            // btn_accounting
            // 
            this.btn_accounting.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_accounting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accounting.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accounting.ForeColor = System.Drawing.Color.Peru;
            this.btn_accounting.Location = new System.Drawing.Point(835, 341);
            this.btn_accounting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_accounting.Name = "btn_accounting";
            this.btn_accounting.Size = new System.Drawing.Size(737, 114);
            this.btn_accounting.TabIndex = 40;
            this.btn_accounting.Text = "Accounting Information";
            this.btn_accounting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_accounting.Click += new System.EventHandler(this.Btn_Accounting_Click);
            this.btn_accounting.MouseEnter += new System.EventHandler(this.Btn_Accounting_MouseEnter);
            this.btn_accounting.MouseLeave += new System.EventHandler(this.Btn_Accounting_MouseLeave);
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orders.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.Peru;
            this.btn_orders.Location = new System.Drawing.Point(0, 118);
            this.btn_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(777, 114);
            this.btn_orders.TabIndex = 10;
            this.btn_orders.Text = "Order Review";
            this.btn_orders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_orders.Click += new System.EventHandler(this.Btn_Orders_Click);
            this.btn_orders.MouseEnter += new System.EventHandler(this.Btn_Orders_MouseEnter);
            this.btn_orders.MouseLeave += new System.EventHandler(this.Btn_Orders_MouseLeave);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventory.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.Peru;
            this.btn_inventory.Location = new System.Drawing.Point(835, 118);
            this.btn_inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(737, 114);
            this.btn_inventory.TabIndex = 20;
            this.btn_inventory.Text = "Inventory Management";
            this.btn_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_inventory.Click += new System.EventHandler(this.Btn_Inventory_Click);
            this.btn_inventory.MouseEnter += new System.EventHandler(this.Btn_Inventory_MouseEnter);
            this.btn_inventory.MouseLeave += new System.EventHandler(this.Btn_Inventory_MouseLeave);
            // 
            // btn_employee_setup
            // 
            this.btn_employee_setup.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_employee_setup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_employee_setup.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_setup.ForeColor = System.Drawing.Color.Peru;
            this.btn_employee_setup.Location = new System.Drawing.Point(-3, 341);
            this.btn_employee_setup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_employee_setup.Name = "btn_employee_setup";
            this.btn_employee_setup.Size = new System.Drawing.Size(777, 114);
            this.btn_employee_setup.TabIndex = 30;
            this.btn_employee_setup.Text = "New Employee Setup";
            this.btn_employee_setup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_employee_setup.Click += new System.EventHandler(this.Btn_Employee_Setup_Click);
            this.btn_employee_setup.MouseEnter += new System.EventHandler(this.Btn_Employee_Setup_MouseEnter);
            this.btn_employee_setup.MouseLeave += new System.EventHandler(this.Btn_Employee_Setup_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.Close_pic);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.icon_Logo);
            this.panel2.Controls.Add(this.lbl_titlePage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1572, 118);
            this.panel2.TabIndex = 0;
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.Color.MediumPurple;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(1534, 0);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(38, 40);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 46;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(1149, 94);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(129, 24);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "Today\'s Date: ";
            this.lbl_date.MouseEnter += new System.EventHandler(this.lbl_date_MouseEnter);
            this.lbl_date.MouseLeave += new System.EventHandler(this.lbl_date_MouseLeave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(175, 0);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(127, 24);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Logged In As:";
            this.lbl_username.MouseEnter += new System.EventHandler(this.lbl_username_MouseEnter);
            this.lbl_username.MouseLeave += new System.EventHandler(this.lbl_username_MouseLeave);
            // 
            // icon_Logo
            // 
            this.icon_Logo.BackColor = System.Drawing.Color.PapayaWhip;
            this.icon_Logo.Image = global::login.Properties.Resources.logo;
            this.icon_Logo.Location = new System.Drawing.Point(0, 0);
            this.icon_Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.icon_Logo.Name = "icon_Logo";
            this.icon_Logo.Size = new System.Drawing.Size(168, 118);
            this.icon_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_Logo.TabIndex = 4;
            this.icon_Logo.TabStop = false;
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(1572, 118);
            this.lbl_titlePage.TabIndex = 0;
            this.lbl_titlePage.Text = "Landing Page";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 795);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.Label btn_employee_setup;
        private System.Windows.Forms.Label btn_reports;
        private System.Windows.Forms.Label btn_accounting;
        private System.Windows.Forms.Label btn_orders;
        private System.Windows.Forms.Label btn_inventory;
        private System.Windows.Forms.PictureBox icon_Logo;
        private System.Windows.Forms.Label btn_Update_Employee;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_forgotPW;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.PictureBox Close_pic;
    }
}