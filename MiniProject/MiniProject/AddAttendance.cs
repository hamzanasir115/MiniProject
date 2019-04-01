using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddAttendance : Form
    {
        public AddAttendance()
        {
            InitializeComponent();
        }
        int id;
        int att_id;
        int lookid;
        int sid;
        string reg_no;
        string status;
        string att_date;
        SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");

        private void AddAttendance_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'projectBDataSet7.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet7.StudentAttendance);
            // TODO: This line of code loads data into the 'projectBDataSet6.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet6.ClassAttendance);
            btnupdate.Hide();
            btnupdates.Hide();
            constring.Open();
            String cmd = "SELECT AttendanceDate FROM ClassAttendance";
            SqlCommand command = new SqlCommand(cmd, constring);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbattid.Items.Add(reader[0]);
            }
            constring.Close();
            constring.Open();
            cmd = "SELECT RegistrationNumber FROM Student";
            command = new SqlCommand(cmd, constring);
            command.Parameters.Add(new SqlParameter("0", 1));
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbstdid.Items.Add(reader[0]);
            }
            constring.Close();
            constring.Open();
            cmd = "SELECT Name FROM Lookup where LookupId < 5";
            command = new SqlCommand(cmd, constring);
            command.Parameters.Add(new SqlParameter("0", 1));
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbattstatus.Items.Add(reader[0]);
            }
            constring.Close();
        }

        private void btndate_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            try
            {
                constring.Open();
                String cmd = String.Format("INSERT INTO ClassAttendance(AttendanceDate) values('{0}')", this.Attendencepick.SelectionEnd.Date);
                SqlCommand command = new SqlCommand(cmd, constring);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Class Attendance Added");
                constring.Close();
                //SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                cmd = "SELECT * FROM ClassAttendance";
                command = new SqlCommand(cmd, constring);
                command.Parameters.Add(new SqlParameter("0", 1));
                constring.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, constring);
                DataTable view = new DataTable();
                adapter.Fill(view);
                datadate.DataSource = view;
                constring.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datadate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            id = Convert.ToInt32(datadate.Rows[e.RowIndex].Cells[0].Value);
            conn.Open();
            /*if (e.ColumnIndex == datadate.Columns["Delete"].Index)
            {
                this.datadate.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                var item = datadate.Rows[e.RowIndex].Cells[0].Value;
                //int id5 = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
                string query = "Delete from ClassAttendance where Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");
                conn.Close();
            }*/
            if (e.ColumnIndex == datadate.Columns["Edit"].Index)
            {
                string t = datadate.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //int id5 = Convert.ToInt32(t);
                string date = datadate.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                DateTime dat = Convert.ToDateTime(date);
                Attendencepick.SetDate(dat);
                btndate.Hide();
                btnupdate.Show();
                //tabPage1.Show();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            constring.Open();
            string Query = "Update ClassAttendance Set  AttendanceDate ='" + Attendencepick.SelectionEnd + "' where Id ='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, constring);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Class Attendance has been Updated");
            constring.Close();
            String query = "SELECT * FROM ClassAttendance";
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.Add(new SqlParameter("0", 1));
            constring.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(query, constring);
            DataTable view = new DataTable();
            adapter.Fill(view);
            datadate.DataSource = view;
            constring.Close();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {

            string query1 = "SELECT Id FROM Student WHERE RegistrationNumber = '" + cmbstdid.Text + "'";
            SqlCommand cmdDataBase1 = new SqlCommand(query1, constring);
            SqlDataReader myreader1;
            constring.Open();
            cmdDataBase1.Parameters.Add(new SqlParameter("0", 1));
            myreader1 = cmdDataBase1.ExecuteReader();
            while (myreader1.Read())
            {
                sid = Convert.ToInt32(myreader1[0]);
            }


            String date = cmbattid.Text;

            DateTime d1 = Convert.ToDateTime(date);
            DateTime d2 = d1.Date;
            string query2 = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = '" + d2 + "'";

            SqlCommand cmdDataBase2 = new SqlCommand(query2, constring);
            SqlDataReader myreader2;
            cmdDataBase2.Parameters.Add(new SqlParameter("0", 1));
            myreader2 = cmdDataBase2.ExecuteReader();
            while (myreader2.Read())
            {
                att_id = Convert.ToInt32(myreader2[0]);
            }
            string query3 = "Select LookupId from Lookup where Name = '" + cmbattstatus.Text + "'";
            SqlCommand cmddatabase3 = new SqlCommand(query3, constring);
            SqlDataReader reader;
            cmddatabase3.Parameters.Add(new SqlParameter("0", 1));
            reader = cmddatabase3.ExecuteReader();
            while (reader.Read())
            {
                lookid = Convert.ToInt32(reader[0]);
            }
            string query4 = "Insert into StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + att_id + "','" + sid + "','" + lookid + "')";

            SqlCommand cmdDataBase = new SqlCommand(query4, constring);
            //SqlDataReader myreader;
            SqlDataReader myreader = cmdDataBase.ExecuteReader();
            MessageBox.Show("Attendance has been Marked");
            constring.Close();
            String cmd = "SELECT * FROM StudentAttendance";
            SqlCommand command = new SqlCommand(cmd, constring);
            command.Parameters.Add(new SqlParameter("0", 1));
            constring.Open();
            reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, constring);
            DataTable view = new DataTable();
            adapter.Fill(view);
            datadate.DataSource = view;
            constring.Close();
        }

        private void datastudentatt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datastudentatt.Columns["Editt"].Index)
            {
                //string temp = datastudentatt.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //id = Convert.ToInt32(temp);
                string attendance_id = datastudentatt.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                string student_id = datastudentatt.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                string lookup_id = datastudentatt.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                att_id = Convert.ToInt32(attendance_id);
                sid = Convert.ToInt32(student_id);
                lookid = Convert.ToInt32(lookup_id);
                string query1 = "SELECT RegistrationNumber FROM Student WHERE Id = '" + sid + "'";
                constring.Open();
                SqlCommand cmdDataBase1 = new SqlCommand(query1, constring);
                SqlDataReader myreader1;
                cmdDataBase1.Parameters.Add(new SqlParameter("0", 1));
                myreader1 = cmdDataBase1.ExecuteReader();
                while (myreader1.Read())
                {
                    reg_no = Convert.ToString(myreader1[0]);
                }
                cmbattid.Text = reg_no;
                string query2 = "Select Name from Lookup where LookupId = '" + lookid + "'";
                SqlCommand cmddatabase3 = new SqlCommand(query2, constring);
                SqlDataReader reader;
                cmddatabase3.Parameters.Add(new SqlParameter("0", 1));
                reader = cmddatabase3.ExecuteReader();
                while (reader.Read())
                {
                    status = Convert.ToString(reader[0]);
                }
                cmbattstatus.Text = status;
                String date = cmbattid.Text;
                string query3 = "SELECT AttendanceDate FROM ClassAttendance WHERE Id = '" + att_id + "'";
                SqlCommand cmdDataBase2 = new SqlCommand(query3, constring);
                SqlDataReader myreader2;
                cmdDataBase2.Parameters.Add(new SqlParameter("0", 1));
                myreader2 = cmdDataBase2.ExecuteReader();
                while (myreader2.Read())
                {
                    att_date = Convert.ToString(myreader2[0]);
                }
                cmbattid.Text = att_date;
                constring.Close();
                btnaddstudent.Hide();
                btnupdates.Show();
            }
        }

        private void btnupdates_Click(object sender, EventArgs e)
        {
            constring.Open();
            string Qeury = "Update StudentAttendance Set AttendanceId ='" + cmbattid.Text + "',StudentId ='" + cmbstdid.Text + "',AttendanceStatus ='" + cmbattstatus.Text + "' Where Id ='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Qeury, constring);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Attendance Updated");
            constring.Close();
            String query = "SELECT * FROM StudentAttendance";
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.Add(new SqlParameter("0", 1));
            constring.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(query, constring);
            DataTable view = new DataTable();
            adapter.Fill(view);
            datadate.DataSource = view;
            constring.Close();
        }
    }
}
