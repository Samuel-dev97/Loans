using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loans
{
    public partial class Small : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, TotalPayment, MonthlyPayment;
        int numberOfYears;
        String iMonthlyPayment, iTotalPayment;
        public Small()
        {
            InitializeComponent();
        }

        private void Small_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //receipt 
        {
            rtfReceipt.AppendText("PEAK FINANCIAL SOLUTION Loan Management System " + "\n");
            rtfReceipt.AppendText("---------------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Amount of Loan : " + "\t" + txtAmountOfLoan.Text + "\n");
            rtfReceipt.AppendText("For the Period of : " + "\t" + txtNumberOfYears + "\n");
            rtfReceipt.AppendText("The interest rate is : " + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment is : " + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Amount Payable is : " + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("On the date of : " + "\t" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\n");
            rtfReceipt.AppendText("At the time : " + "\t" + DateTime.Now.ToString("hh:mm tt") + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("------------------------Thank you and call again----------------------------" + "\n");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtNumberOfYears_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMonthlyPayment_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPayment_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            //------------------------------------------------------------------------------
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            //---------------------------------------------------------------------------
            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = Convert.ToString(TotalPayment);

            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);
            lblTotalPayment.Text = (iTotalPayment);
            txtAmountOfLoan.Text = String.Format("{0:C}", loanAmount);
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("PEAK FINANCIAL SOLUTION Loan Management System " + "\n");
            rtfReceipt.AppendText("---------------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Amount of Loan : " + "\t" + txtAmountOfLoan.Text + "\n");
            rtfReceipt.AppendText("For the Period of : " + "\t" + txtNumberOfYears + "\n");
            rtfReceipt.AppendText("The interest rate is : " + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment is : " + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Amount Payable is : " + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("On the date of : " + "\t" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\n");
            rtfReceipt.AppendText("At the time : " + "\t" + DateTime.Now.ToString("hh:mm tt") + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("------------------------Thank you and call again----------------------------" + "\n");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtInterestRate.Clear();
            txtNumberOfYears.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
        }

        private void button3_Click(object sender, EventArgs e) // reset
        {
            txtAmountOfLoan.Clear();
            txtInterestRate.Clear();
            txtNumberOfYears.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();



        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            //------------------------------------------------------------------------------
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            //---------------------------------------------------------------------------
            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = Convert.ToString(TotalPayment);

            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);
            lblTotalPayment.Text = (iTotalPayment);
            txtAmountOfLoan.Text = String.Format("{0:C}", loanAmount);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
