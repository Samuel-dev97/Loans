using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.contactClasses
{
    class contactClass
    {
        //creating a getter and a setter
        public string ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Nrc { get; set; }
        public string Principal { get; set; }
        public string Interest { get; set; }
        public string Installment { get; set; }
        public string Period { get; set; }
        public string From1 { get; set; }
        public string To1 { get; set; }
        public string Type { get; set; }
        public string Total { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Method for Selecting data from the database
        public DataTable Select()
        {
            //step 1 setting up a database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2 : Writing SQL Querry 
                string sql = "SELECT * FROM tbl_contact";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //closing the connection
                conn.Close();
            }
            return dt;



        }

        //Inserting Data into  the Database
        public bool Insert(contactClass c)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Step 2: Create a SQL Querry to insert Data
                string sql = "INSERT INTO tbl_contact (FirstName, LastName, ContactNo, Gender, Address, Nrc, Principal, Installment, Period, From1, To1, Type, Total) VALUES (@FirstName, @LastName, @ContactNo, @Gender, @Address, @Nrc, @Principal, @Installment, @Period, @From1, @To1, @Type, @Total)";

                //creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create Parameter to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                //additiona data
                cmd.Parameters.AddWithValue("@Nrc", c.Nrc);
                cmd.Parameters.AddWithValue("@Principal", c.Principal);
                cmd.Parameters.AddWithValue("@Interest", c.Interest);
                cmd.Parameters.AddWithValue("@Installment", c.Installment);
                cmd.Parameters.AddWithValue("@Period", c.Period);
                cmd.Parameters.AddWithValue("@From1", c.From1);
                cmd.Parameters.AddWithValue("@To1", c.To1);
                cmd.Parameters.AddWithValue("@Type", c.Type);
                cmd.Parameters.AddWithValue("@Total", c.Total);
                

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero 
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to update data in database from my desktop application
        public bool Update(contactClass c)
        {
            //Creating a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update data in our database
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Gender=@Gender, Address=@Address, Nrc=@Nrc, Pricipal=@Pricipal, Installment=@Installmet, Period=@Installment, From1=@From1, To1=@To1, Type=@Type, Total=@Total WHERE ContactID=@ContactID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //
                cmd.Parameters.AddWithValue("@Nrc", c.Nrc);
                cmd.Parameters.AddWithValue("@Principal", c.Principal);
                cmd.Parameters.AddWithValue("@Interest", c.Interest);
                cmd.Parameters.AddWithValue("@Installment", c.Installment);
                cmd.Parameters.AddWithValue("@Period", c.Period);
                cmd.Parameters.AddWithValue("@From1", c.From1);
                cmd.Parameters.AddWithValue("@To1", c.To1);
                cmd.Parameters.AddWithValue("@Type", c.Type);
                cmd.Parameters.AddWithValue("@Total", c.Total);

                //Open Database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to delete Data from the database
        public bool Delete(contactClass c)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;
            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL To Delete Data
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";

                //Create SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close Connection
                conn.Close();
            }
            return isSuccess;
        }

    }






}

