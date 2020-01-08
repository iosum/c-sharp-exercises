using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {   
            // decimal : decimal floating point
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            // m : decimal floating number
            decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text) / 100;
            decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
            decimal invoiceTotal = subtotal - discountAmount;

            // c: currency, it will have a dollar sign in front of the #
            txtSubtotal.Text = subtotal.ToString("c");
            // p: percentage , p1: only include a single value after decimal-point
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += numberOfInvoices;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            // display on the form
            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            txtSubtotal.Text = "";
            txtSubtotal.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtSubtotal.Focus();
        }
    }
}
