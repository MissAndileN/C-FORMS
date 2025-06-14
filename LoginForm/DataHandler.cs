using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;


namespace LoginForm
{
    internal class DataHandler
    {
        public DataHandler()
        {

        }
        string cononnection = "Data Source = DESKTOP-QR3A0UT\\SQLEXPRESS; Initial Catalog= TrainingProgramDB; Integrated Security= SSPI;";

        SqlConnection sqlconnect;
        SqlCommand cmd;
        SqlDataAdapter adt;
        public void Register(int programID, string ProgramName, string Instructor, string Discription, string schedule, int Capacity, string duration)
        {
            string query = $"INSERT INTO Programs VALUES ('{programID}','{ProgramName}','{Discription}','{schedule}','{Instructor}','{Capacity}','{duration}')";
            sqlconnect = new SqlConnection(cononnection);
            sqlconnect.Open();
            cmd = new SqlCommand(query, sqlconnect);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not Saved:" + ex.Message);

            }
            finally
            { sqlconnect.Close(); }

        }
        public void Update(int programID, string programName, string Description, string Instructor, string schedule, int Capacity, string duration)
        {

            string query = $"UPDATE Programs SET [programID] ='{programID}', [ProgramName] ='{programName}',[Description]='{Description}',[Instructor]= '{Instructor}', [schedule]='{schedule}',[Capacity]='{Capacity}',[duration]='{duration} ' WHERE [programID]='{programID}'";
            sqlconnect = new SqlConnection(cononnection);
            sqlconnect.Open();
            cmd = new SqlCommand(query, sqlconnect);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update sucessful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated:" + ex.Message);

            }
            finally
            { sqlconnect.Close(); }
        }
        public void Delete(int programID)
        {
            string query = $"DELETE FROM Programs WHERE programID ='{programID}'";
            sqlconnect = new SqlConnection(cononnection);
            sqlconnect.Open();
            cmd = new SqlCommand(query, sqlconnect);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not Deleted:" + ex.Message);

            }
            finally
            { sqlconnect.Close(); }
        }

        public DataTable Search(int programID)
        {
            string query = $"SELECT * FROM Programs WHERE programID ='{programID}'";
            sqlconnect = new SqlConnection(cononnection);
            adt = new SqlDataAdapter(query, sqlconnect);
            DataTable t = new DataTable();

            adt.Fill(t);

            return t;


        }

        public void RegisterMembers(int memberID, string name, string surname, string DOB, string gender, string phonenumber, string address, string trainingprogram, string startdate, string enddate)
        {
            string query = $"INSERT INTO Member VALUES ('{memberID}','{name}','{surname}','{DOB}','{gender}','{phonenumber}','{address}','{trainingprogram}' , '{startdate}' ,'{enddate}')";
            sqlconnect = new SqlConnection(cononnection);
            sqlconnect.Open();
            cmd = new SqlCommand(query, sqlconnect);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not Saved:" + ex.Message);

            }
            finally
            { sqlconnect.Close(); }

        }
        public void UpdateMembers(int memberID, string name, string surname, string DOB, string gender, string phonenumber, string address, string trainingprogram, string startdate, string enddate)
        {

            string query = $"UPDATE Member SET [memberID] ='{memberID}', [name] ='{name}',[surname]='{surname}',[DOB]= '{DOB}', [gender]='{gender}',[phonenumber]='{phonenumber}',[address]='{address} ' , [trainingprogram]= '{trainingprogram}', [startdate] = '{startdate}', [enddate]= '{enddate}' WHERE [memberID]='{memberID}'";
            sqlconnect = new SqlConnection(cononnection);
            sqlconnect.Open();
            cmd = new SqlCommand(query, sqlconnect);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update sucessful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated:" + ex.Message);

            }
            finally
            { sqlconnect.Close(); }
        }
        public void DeleteMembers(int memberID)
        {
            string query = $"DELETE FROM Member WHERE memberID ='{memberID}'";
            sqlconnect = new SqlConnection(cononnection);
            sqlconnect.Open();
            cmd = new SqlCommand(query, sqlconnect);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not Deleted:" + ex.Message);

            }
            finally
            { sqlconnect.Close(); }
        }

        public DataTable SearchMembers(int memberID)
        {
            string query = $"SELECT * FROM Member WHERE MemberID ='{memberID}'";
            sqlconnect = new SqlConnection(cononnection);
            adt = new SqlDataAdapter(query, sqlconnect);
            DataTable d = new DataTable();

            adt.Fill(d);

            return d;


        }

        public DataTable SearchInstructor(string Instructor)
        {
            string query = $"SELECT * FROM Programs WHERE Instructor ='{Instructor}'";
            sqlconnect = new SqlConnection(cononnection);
            adt = new SqlDataAdapter(query, sqlconnect);
            DataTable d = new DataTable();

            adt.Fill(d);

            return d;
        }
    }

}


