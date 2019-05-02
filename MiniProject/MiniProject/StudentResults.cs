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
    public partial class StudentResults : Form
    {
        public StudentResults()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void StudentResults_Load(object sender, EventArgs e)
        {
            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssessmentComponentId"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;

            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }
            cmbComponentId.Items.Clear();
            cmbDetails.Items.Clear();
            cmbLevel.Items.Clear();
            cmbStudentId.Items.Clear();
            cmbTitle.Items.Clear();
            comboBox1.Items.Clear();
            string query = "SELECT Id FROM Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbStudentId.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            string query1 = "SELECT Title FROM Assessment";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1;
            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    cmbTitle.Items.Add(reader1[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            string query3 = "SELECT Id FROM RubricLevel";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            SqlDataReader reader3;
            try
            {
                conn.Open();
                reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    cmbDetails.Items.Add(reader3[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Assessment WHERE Title = '" + cmbTitle.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conn);
            conn.Open();
            int a = Convert.ToInt32(cmda.ExecuteScalar());
            conn.Close();
            string query2 = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = '" + a + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader reader2;
            try
            {
                conn.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    cmbComponentId.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void cmbComponentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT RubricId FROM AssessmentComponent WHERE Id = '" + cmbComponentId.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conn);
            conn.Open();
            int a = Convert.ToInt32(cmda.ExecuteScalar());
            conn.Close();
            string query2 = "SELECT Details FROM Rubric WHERE Id = '" + a + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmbDetails.Items.Clear();
            SqlDataReader reader2;
            try
            {
                conn.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    cmbDetails.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void cmbDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT Id FROM Rubric WHERE Details = '" + cmbDetails.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conn);
            conn.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            conn.Close();
            string query2 = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader reader2;
            try
            {
                conn.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    cmbLevel.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "SELECT Id FROM RubricLevel WHERE MeasurementLevel = '" + cmbLevel.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader reader2;
            try
            {
                conn.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    comboBox1.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            string query = "INSERT into StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values ('" + cmbStudentId.Text + "', '" + cmbComponentId.Text + "', '" + comboBox1.Text + "', '" + DateTime.Now + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            MessageBox.Show("Data is Saved");
            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssessmentComponentId"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;
            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }
            cmbComponentId.Text = "";
            cmbDetails.Text = "";
            cmbLevel.Text = "";
            cmbStudentId.Text = "";
            cmbTitle.Text = "";
            comboBox1.Text = "";
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            int id2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 1)
            {
                
                    conn.Open();
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM StudentResult WHERE StudentId = @id1 and AssessmentComponentId = @id2";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.Parameters.Add(new SqlParameter("@id2", id2));
                    cmd.ExecuteReader();
                    conn.Close();   
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report att = new Report();
            this.Hide();
            att.Show();
        }

        private void cmbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
