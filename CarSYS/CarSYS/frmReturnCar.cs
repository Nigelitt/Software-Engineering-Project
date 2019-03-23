﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmReturnCar : Form
    {
        frmMainMenu parent;
        public frmReturnCar(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            this.cboReturnCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        
        }
        private void frmReturnCar_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Booking.getCurrentBookingInfo(ds);
                for (int i = 0; i < ds.Tables["booking"].Rows.Count; i++)
                    cboReturnCar.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
           
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {

            if (cboReturnCar.Text.Equals(""))
            {
                MessageBox.Show("Chose to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReturnCar.Focus();
                return;

            }

            DateTime endDate = DateTime.ParseExact(txtEndDate.Text.Trim(), "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);


            if (DateTime.Today > endDate)
            {
                MessageBox.Show("This should be a late return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLateReturn.Focus();
                return;
            }
            
            updateBookingCar();
            
           
        }

        private void cboReturnCar_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if resetting combo, ignore
            if (cboReturnCar.SelectedIndex == -1)
            {
                return;
            }
            //find cust details
            Booking booking = new Booking();
            booking.getBooking(Convert.ToInt32(cboReturnCar.Text));

            if (booking.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

            //display cust details
            txtBookingID.Text = booking.getBookNo().ToString("00000");
            txtCustomerID.Text = booking.getCustomerID().ToString("00000");
            txtReg.Text = booking.getRegNo();
            txtStartDate.Text = booking.getStartDate();
            txtEndDate.Text = booking.getEndDate();
            txtStatus.Text = booking.getStatus();
            txtTotal.Text = booking.getTotal().ToString();



            //display details
            cboReturnCar.Visible = true;
        }

        private void ClearUI()
        {
            txtCustomerID.Clear();
            txtBookingID.Clear();
            txtEndDate.Clear();
            txtReg.Clear();
            txtStartDate.Clear();
            txtStatus.Clear();
            txtTotal.Clear();
            cboReturnCar.ResetText();
            cboReturnCar.SelectedIndex = -1;

        }

        private void btnLateReturn_Click(object sender, EventArgs e)
        {
            if (cboReturnCar.Text.Equals(""))
            {
                MessageBox.Show("Chose to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReturnCar.Focus();
                return;

            }

            string today = DateTime.Today.ToString("yyyy-MM-dd");
            //From https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
            DateTime endDate = DateTime.ParseExact(txtEndDate.Text, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime startDate = DateTime.ParseExact(txtStartDate.Text, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime todayDate = DateTime.ParseExact(today, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);

            if (DateTime.Today < endDate)
            {
                MessageBox.Show("This should be a normal return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReturnCar.Focus();
                return;
            }
            string from = startDate.ToString("yyyy-MM-dd");
            string to = todayDate.ToString("yyyy-MM-dd");

            DataSet ds = new DataSet();
            grdTotalCost.DataSource = Rates.getBookingCost(ds, to, from, txtReg.Text).Tables["book"];

            
            updateBookingCar();
        }

        public void updateBookingCar()
        {
            Booking bookingStatus = new Booking();

            bookingStatus.setStatus(txtBookingStatus.Text);
            bookingStatus.setBookNo(Convert.ToInt32(txtBookingID.Text));
            bookingStatus.bookingStatus();
            //instantiate  Object
            Cars reCar = new Cars();

            reCar.setAvailability(txtStatusCar.Text);
            reCar.setRegNo(txtReg.Text);

            //INSERT  record into car table
            reCar.collectCar();

            //Display Confirmation Message
            print();
            MessageBox.Show("Car " + txtReg.Text + " has been returned", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearUI();
        }

        public void print()
        {
            //From https://www.youtube.com/watch?v=nAI-1w9MhwE
            pdReturn.Document = pdtReturn;
            if (pdReturn.ShowDialog() == DialogResult.OK)
            {
                pdtReturn.Print();
            }
        }

        private void pdtReturn_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBookingID.Text, new Font("Arial",12, FontStyle.Regular), Brushes.Black, 150, 125);
            e.Graphics.DrawString(txtReg.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 200, 125);
            e.Graphics.DrawString(txtStartDate.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 150, 175);
            e.Graphics.DrawString(txtEndDate.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 200, 300);
            e.Graphics.DrawString(txtCustomerID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 150, 200);
            e.Graphics.DrawString(txtTotal.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 200, 200);
            e.Graphics.DrawString(grdTotalCost.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 225, 225);
            
        }
    }
}