using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{

    public partial class Assesment : Form
    {
        public Assesment()
        {
            InitializeComponent();
        }
        int id;
        private void btnassesment_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            bool IsValidTitle = false;
            IsValidTitle = IsString(txttitle.Text);
            if (IsValidTitle == true)
            {
                AddAssesment ass = new AddAssesment();
                ass.Title1 = txttitle.Text;
                ass.DateCreated1 = DateTime.Now;
                ass.TotalMarks1 = Convert.ToInt32(txtmarks.Text);
                ass.TotalWeightage1 = Convert.ToInt32(txtweightage.Text);

                try
                {
                    String title = txttitle.Text;
                    DateTime datecreated = DateTime.Now;
                    int marks = Convert.ToInt32(txtmarks.Text);
                    int weightage = Convert.ToInt32(txtweightage.Text);
                    conn.Open();
                    String cmd = String.Format("INSERT INTO Assessment(Title, DateCreated,TotalMarks, TotalWeightage) values('{0}','{1}','{2}', '{3}')", title, datecreated, marks, weightage);
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Assesment has been added");
                    txttitle.Text = "";
                    txtmarks.Text = "";
                    txtweightage.Text = "";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Give Valid Input");
            }
        }
        bool IsString(String Capital)
        {
            string path;
            path = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            bool Isstring;
            Isstring = false;
            if (!Regex.IsMatch(Capital, path))
            {
                Isstring = false;
            }
            else
            {
                Isstring = true;
            }
            return Isstring;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM Assessment";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView1.DataSource = view;
            conn.Close();
        }

        private void Assesment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet10.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet10.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet9.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet9.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet5.AssessmentComponent' table. You can move, or remove it, as needed.
           // this.assessmentComponentTableAdapter.Fill(this.projectBDataSet5.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
            //this.assessmentTableAdapter.Fill(this.projectBDataSet4.Assessment);
            btnupdate.Hide();
            //label1.Hide();
            //button1.Hide();
            btnupdates.Hide();
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            String cmd = "SELECT Id from Assessment";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // Console.WriteLine(cmbselect reader[0] + " " + reader[1]);
                cmbassesmentid.Items.Add(reader[0]);
            }
            conn.Close();
            conn.Open();
            String c = "SELECT Id from rubric";
            SqlCommand cd = new SqlCommand(c, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader re = cd.ExecuteReader();
            while (re.Read())
            {
                // Console.WriteLine(cmbselect reader[0] + " " + reader[1]);
                cmbrubricid.Items.Add(re[0]);
            }
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int row = e.RowIndex;
                string query = "Delete from AssessmentComponent where AssessmentId = @Id1";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id1", Id));
                command.ExecuteReader();
                string query1 = "Delete from Assessment where Id = @id";
                command = new SqlCommand(query1, conn);
                command.Parameters.Add(new SqlParameter("@id", Id));
                command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");
                conn.Close();

                String cmd = "SELECT * FROM Assessment";
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable view = new DataTable();
                adapter.Fill(view);
                dataGridView1.DataSource = view;
                conn.Close();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int row = e.RowIndex;
                id = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
                //int id = Convert.ToInt32(id1);
                txttitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                //int id = Convert.ToInt32(id1);
                txtmarks.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtweightage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                btnassesment.Hide();
                btnupdate.Show();
                tabPage1.Show();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(label1.Text);
            bool IsValidTitle = false;
            IsValidTitle = IsString(txttitle.Text);
            if (IsValidTitle == true)
            {
                SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                constring.Open();
                //int id = Convert.ToInt32(label1.Text);

                string Query = "Update Assessment Set Title ='" + txttitle.Text + "', DateCreated ='" + DateTime.Now + "', TotalMarks = '" + txtmarks.Text + "', TotalWeightage ='" + txtweightage.Text + "' where id ='" + id + "' ";
                SqlCommand command = new SqlCommand(Query, constring);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                constring.Close();
                btnupdate.Hide();
                btnassesment.Show();
                txttitle.Text = "";
                txtmarks.Text = "";
                txtweightage.Text = "";
                tabPage1.Hide();
                tabPage2.Show();
                String cmd = "SELECT * FROM Assessment";
                command = new SqlCommand(cmd, constring);
                command.Parameters.Add(new SqlParameter("0", 1));
                constring.Open();
                SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, constring);
                DataTable view = new DataTable();
                adapter.Fill(view);
                dataGridView1.DataSource = view;
                constring.Close();
            }
            else
            {
                MessageBox.Show("Put Valid Inputs");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            try
            {
                String name = txtname.Text;
                int assessmentid = Convert.ToInt32(cmbassesmentid.Text);
                int rubid = Convert.ToInt32(cmbrubricid.Text);
                int totalmarks =Convert.ToInt32(txttotalmarks.Text);
                DateTime datecreated = DateTime.Now;
                DateTime dateupdated = DateTime.Now;
                conn.Open();
                String cmd = String.Format("INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )", name, rubid, totalmarks, datecreated,dateupdated, assessmentid);
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Assessment Component has been added");
                txtname.Text = "";
                cmbrubricid.Text = "";
                cmbassesmentid.Text = "";
                txttotalmarks.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM AssessmentComponent";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView2.DataSource = view;
            conn.Close(); */
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            conn.Open();
            if (e.ColumnIndex == dataGridView2.Columns["Deletee"].Index)
            {
                this.dataGridView2.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                var item = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                //int id5 = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
                string query1 = "Delete from dbo.StudentResult where AssessmentComponentId = @id";
                SqlCommand command1 = new SqlCommand(query1, conn);
                command1.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader reader1 = command1.ExecuteReader();
                //MessageBox.Show("Data Deleted Succesfully");
                conn.Close();
                conn.Open();
                string query = "Delete from AssessmentComponent where Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");
                conn.Close();
            }
            if (e.ColumnIndex == dataGridView2.Columns["Editt"].Index)
            {
                string id2 = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //id5 = Convert.ToInt32(id2);
                txtname.Text = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmbrubricid.Text = dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txttotalmarks.Text = dataGridView2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbassesmentid.Text = dataGridView2.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                btnadd.Hide();
                btnupdates.Show();
                tabPage3.Show();
            }
        }

        private void btnupdates_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            constring.Open();
            string Query = "Update AssessmentComponent Set  Name ='" + txtname.Text + "', RubricId ='" + cmbrubricid.Text + "', TotalMarks ='" + txttotalmarks.Text + "', DateUpdated = '" + DateTime.Now +"', AssessmentId = '" + cmbassesmentid.Text +"' where Id ='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, constring);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been Updated");
            constring.Close();
            btnupdates.Hide();
            btnadd.Show();
            txtname.Text = "";
            txttotalmarks.Text = "";
            cmbassesmentid.Text = "";
            cmbrubricid.Text = "";
            tabPage3.Hide();
            tabPage4.Show();
            String query = "SELECT * FROM AssessmentComponent";
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.Add(new SqlParameter("0", 1));
            constring.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(query, constring);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView2.DataSource = view;
            constring.Close();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM AssessmentComponent";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView2.DataSource = view;
            conn.Close();
        }

        private void cmbrubricid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbrubricid_Click(object sender, EventArgs e)
        {

        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            AddStudents stu = new AddStudents();
            this.Hide();
            stu.Show();
        }

        private void btnCLO_Click(object sender, EventArgs e)
        {
            Add_CLOs clo = new Add_CLOs();
            this.Hide();
            clo.Show();
        }

        private void btnRubric_Click(object sender, EventArgs e)
        {
            AddRubrics rub = new AddRubrics();
            this.Hide();
            rub.Show();
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            Assesment ass = new Assesment();
            this.Hide();
            ass.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance att = new AddAttendance();
            this.Hide();
            att.Show();
        }

        private void btnStudentResult_Click(object sender, EventArgs e)
        {

            StudentResults att = new StudentResults();
            this.Hide();
            att.Show();
        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }
    }
}