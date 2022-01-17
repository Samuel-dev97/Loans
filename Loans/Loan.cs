using Loan.contactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loans
{
    public partial class Loan : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, TotalPayment, MonthlyPayment;
        int numberOfYears;
        String iMonthlyPayment, iTotalPayment;
        public Loan()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();

        private void Loan_Load(object sender, EventArgs e)
        {

            //Load Data on Data Grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void dgvContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Getting value from the input field
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Gender = cmbGender.Text;
            c.Address = txtboxAddress.Text;
               //additional data
            c.Nrc = txtboxNrc.Text;
            c.Principal = txtboxPrincipal.Text;
            c.Interest = txtboxInterest.Text;
            c.Installment = txtboxInstallment.Text;
            c.Period = txtboxPeriod.Text;
            c.From1 = lblDate.Text;
            c.To1 = txtboxPayDate.Text;
            c.Type = cmbType.Text;
            c.Total = lblTotal.Text;
            

            //Inserting Data into my dataBase
            bool success = c.Insert(c);
            if (success == true)
            {
                //Successfully Inserted
                MessageBox.Show("New Client Successfully Inserted");
                //call the clear method
                Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add new Client, try again");
            }
            //Load Data on Data Grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Get the Data from textbox
            c.ContactID = txtContactID.Text;
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Gender = cmbGender.Text;
            c.Address = txtboxAddress.Text;
            //
            c.Nrc = txtboxNrc.Text;
            c.Principal = txtboxPrincipal.Text;
            c.Interest = txtboxInterest.Text;
            c.Installment = txtboxInstallment.Text;
            c.Period = txtboxPeriod.Text;
            c.From1 = lblDate.Text;
            c.To1 = txtboxPayDate.Text;
            c.Type = cmbType.Text;
            c.Total = lblTotal.Text;

            //Update Data in Database
            bool success = c.Update(c);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Client Deatails Updated successfully");
                //Load Data on Data Grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
            else
            {
                //Fail to update
                MessageBox.Show("failed to update , try again");
            }
        }

        public void Clear()
        {
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContactNo.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";
            txtContactID.Text = "";
            //
            c.Nrc = txtboxNrc.Text;
            c.Principal = txtboxPrincipal.Text;
            c.Interest = txtboxInterest.Text;
            c.Installment = txtboxInstallment.Text;
            c.Period = txtboxPeriod.Text;
            c.From1 = lblDate.Text;
            c.To1 = txtboxPayDate.Text;
            c.Type = cmbType.Text;
            c.Total = lblTotal.Text;



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data Grid View and Load it to their respective textboxes and fields
            //Identify which row the mouse select
            int rowIndex = e.RowIndex;
            txtContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
              //additional data
            txtboxNrc.Text = dgvContactList.Rows[rowIndex].Cells[6].Value.ToString();
            txtboxPrincipal.Text = dgvContactList.Rows[rowIndex].Cells[7].Value.ToString();
            txtboxInterest.Text = dgvContactList.Rows[rowIndex].Cells[8].Value.ToString();
            txtboxInstallment.Text = dgvContactList.Rows[rowIndex].Cells[9].Value.ToString();
            txtboxPeriod.Text = dgvContactList.Rows[rowIndex].Cells[10].Value.ToString();
            lblDate.Text = dgvContactList.Rows[rowIndex].Cells[11].Value.ToString();
            txtboxPayDate.Text = dgvContactList.Rows[rowIndex].Cells[12].Value.ToString();
            cmbType.Text = dgvContactList.Rows[rowIndex].Cells[13].Value.ToString();
            lblTotal.Text = dgvContactList.Rows[rowIndex].Cells[14].Value.ToString();
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //get the Contact ID front the application
            c.ContactID = txtContactID.Text;
            bool success = c.Delete(c);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Contact Deleted successfully");
                //Load Data on Data Grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call the Clear Method
                Clear();

            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Client");
                //Load Data on Data Grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
           
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Nrc LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtboxInterest.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtboxPeriod.Text);
            loanAmount = Convert.ToDouble(txtboxPrincipal.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            //------------------------------------------------------------------------------
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            txtboxInstallment.Text = (iMonthlyPayment);

            //---------------------------------------------------------------------------
            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = Convert.ToString(TotalPayment);

            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotal.Text = (iTotalPayment);
            lblDate.Text = (DateTime.Now.ToString("dddd, dd MMMM yyyy"));//

            txtboxPrincipal.Text = String.Format("{0:C}", loanAmount);

        }

        private void dgvContactList_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            //Get the data from data Grid View and Load it to their respective textboxes
            //Identify which row the mouse select
            int rowIndex = e.RowIndex;
            txtContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
            //additional data
            txtboxNrc.Text = dgvContactList.Rows[rowIndex].Cells[6].Value.ToString();
            txtboxPrincipal.Text = dgvContactList.Rows[rowIndex].Cells[7].Value.ToString();
            txtboxInterest.Text = dgvContactList.Rows[rowIndex].Cells[8].Value.ToString();
            txtboxInstallment.Text = dgvContactList.Rows[rowIndex].Cells[9].Value.ToString();
            txtboxPeriod.Text = dgvContactList.Rows[rowIndex].Cells[10].Value.ToString();
            lblDate.Text = dgvContactList.Rows[rowIndex].Cells[11].Value.ToString();
            txtboxPayDate.Text = dgvContactList.Rows[rowIndex].Cells[12].Value.ToString();
            cmbType.Text = dgvContactList.Rows[rowIndex].Cells[13].Value.ToString();
            lblTotal.Text = dgvContactList.Rows[rowIndex].Cells[14].Value.ToString();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtboxInterest.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtboxPeriod.Text);
            loanAmount = Convert.ToDouble(txtboxPrincipal.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            //------------------------------------------------------------------------------
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            txtboxInstallment.Text = (iMonthlyPayment);

            //---------------------------------------------------------------------------
            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = Convert.ToString(TotalPayment);

            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotal.Text = (iTotalPayment);
            lblDate.Text = (DateTime.Now.ToString("dddd, dd MMMM yyyy"));//

            txtboxPrincipal.Text = String.Format("{0:C}", loanAmount);


        }
    }
}
