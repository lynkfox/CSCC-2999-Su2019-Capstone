﻿using CcnSession;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace login
{
    public partial class OrderReviewForm : Form
    {

        DataTable orderHistoryData = new DataTable();
        int orderNum = 0;

        public OrderReviewForm()
        {
            InitializeComponent();
            DisplayData();
            lbl_store.Text = SQL.DefaultStore;
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");

        }

        public void DisplayData()
        {
            try
            {
                orderHistoryData = SQL.GetOrders();

                dataGridView1.DataSource = orderHistoryData;
                dataGridView1.Columns[0].HeaderText = "Account Number";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Delivery Address";
                dataGridView1.Columns[2].HeaderText = "Ordered On";
                dataGridView1.Columns[2].DefaultCellStyle.Format = "d";
                dataGridView1.Columns[3].HeaderText = "Delivery By";
                dataGridView1.Columns[3].DefaultCellStyle.Format = "d";
                dataGridView1.Columns[4].HeaderText = "Total Cost";
                dataGridView1.Columns[4].DefaultCellStyle.Format = "c2";
                dataGridView1.Columns[5].HeaderText = "Payment Status";
                dataGridView1.Columns[6].HeaderText = "Order Status";
                dataGridView1.Columns[7].HeaderText = "Order Number";
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonViewOrd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DisplayData();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {

            int.TryParse(dataGridView1.CurrentRow.Cells[7].Value.ToString(), out orderNum);
            var orderDetails = new OrdersDetails(orderNum);
            orderDetails.Show();
            this.Hide();
        }

        private void Btn_viewOrders_Click(object sender, EventArgs e)
        {

            DateTime.TryParseExact(dateTimePicker_orders.Value.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null, 0, out DateTime filterDate);

            var dv = new DataView(orderHistoryData);
            dv.RowFilter = " (CONVERT(del_date,System.DateTime) >= #" + filterDate + "#)";

            dataGridView1.DataSource = dv;

        }

        private void Btn_ViewToday_Click(object sender, EventArgs e)
        {
            DateTime.TryParseExact(DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null, 0, out DateTime filterDate);

            var dv = new DataView(orderHistoryData);
            dv.RowFilter = " (CONVERT(del_date,System.DateTime) = #" + filterDate + "#)";

            dataGridView1.DataSource = dv;
        }

        private void Close_pic_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();

            var LoginF = new LoginForm();
            LoginF.Show();
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
