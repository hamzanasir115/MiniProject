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
        private void AddAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet6.ClassAttendance);
            btnupdate.Hide();
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
            catch(Exception ex)
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
    }
}
