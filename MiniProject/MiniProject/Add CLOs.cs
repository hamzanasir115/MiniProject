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
    public partial class Add_CLOs : Form
    {
        public Add_CLOs()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
        /// <summary>
        /// Here we add clos in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool Name = false;
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                Name = false;
            }
            else
            {
                Name = true;
            }
            if(Name == true)
            {
                SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                CLO clo = new CLO();
                clo.Name1 = txtname.Text;
                clo.DateCreated1 = DateTime.Now;
                clo.DateUpdated1 = DateTime.Now;
                try
                {
                    String name = txtname.Text;
                    DateTime datecreated = DateTime.Now;
                    DateTime dateupdated = DateTime.Now;
                    conn.Open();
                    String cmd = String.Format("INSERT INTO Clo(Name, DateCreated,DateUpdated) values('{0}','{1}','{2}')", name, datecreated, dateupdated);
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("CLO has been added");
                    txtname.Text = "";
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
        /// <summary>
        /// Here we show clos which are
        /// in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM Clo";
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

        private void Add_CLOs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet8.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet8.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            // this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
            btnUpdate.Hide();
            lblID.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Update data for CLos module.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            bool Name = false;
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                Name = false;
            }
            else
            {
                Name = true;
            }
            if (Name == true)
            {
                SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                constring.Open();
                int id = Convert.ToInt32(lblID.Text);

                string Query = "Update Clo Set Name ='" + txtname.Text + "', DateUpdated ='" + DateTime.Now + "' where id ='" + id + "' ";
                SqlCommand command = new SqlCommand(Query, constring);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                conn.Close();
                btnUpdate.Hide();
                button1.Show();
                txtname.Text = "";
                tabPage1.Hide();
                tabPage2.Show();
                String cmd = "SELECT * FROM Clo";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable view = new DataTable();
                adapter.Fill(view);
                dataGridView1.DataSource = view;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Put Valid Inputs");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// deletion and updation of Clos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            lblID.Text = Convert.ToString(id);

            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                conn.Open();
                int[] rubric = new int[5];
                int i = 0;
                int[] assessment = new int[20];
                string qeury = "Select Id from Rubric where CLoId = '"+ id+ "'";
                SqlCommand com = new SqlCommand(qeury, conn);
                com.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    rubric[i] = Convert.ToInt32(r[0]);
                    i++;
                }
                
                foreach (int rubricid in rubric)
                {
                    int k = 0;
                    int[] rubriclvl = new int[5];
                    string qeury1 = "Select Id from RubricLevel where RubricId = "+ rubricid +"";
                    SqlCommand com1 = new SqlCommand(qeury1, conn);
                    com1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader r1 = com1.ExecuteReader();
                    while (r1.Read())
                    {
                        rubriclvl[k] = Convert.ToInt32(r1[0]);
                        k++;
                    }
                    foreach (int levelid in rubriclvl)
                    {
                        string qeury2 = "Delete from StudentResult where RubricMeasurementId = " + levelid + "";
                        SqlCommand com2 = new SqlCommand(qeury2, conn);
                        com2.ExecuteNonQuery();

                    }
                    string qeury3 = "Delete from RubricLevel where Rubricid = " + rubricid + "";
                    SqlCommand com3 = new SqlCommand(qeury3, conn);
                    com3.ExecuteNonQuery();
                }
                foreach(int rubricid in rubric)
                {
                    int k = 0;
                    int[] assessmentlvl = new int[5];
                    string qeury1 = "Select Id from AssessmentComponent where RubricId = " + rubricid + "";
                    SqlCommand com1 = new SqlCommand(qeury1, conn);
                    com1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader r1 = com1.ExecuteReader();
                    while (r1.Read())
                    {
                        assessmentlvl[k] = Convert.ToInt32(r1[0]);
                        k++;
                    }
                    foreach (int assessmentid in assessmentlvl)
                    {
                        string qeury2 = "Delete from StudentResult where AssessmentComponentId = " + assessmentid + "";
                        SqlCommand com2 = new SqlCommand(qeury2, conn);
                        com2.ExecuteNonQuery();

                    }
                    string qeury3 = "Delete from AssessmentComponent where Rubricid = " + rubricid + "";
                    SqlCommand com3 = new SqlCommand(qeury3, conn);
                    com3.ExecuteNonQuery();
                }

                string qeury4 = "Delete from Rubric where Cloid = '" + id + "'";
                SqlCommand com4 = new SqlCommand(qeury4, conn);
                com4.ExecuteNonQuery();

                string qeury5 = "Delete from Clo where Id = '" + id + "'";
                SqlCommand com5 = new SqlCommand(qeury5, conn);
                com5.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Succesfully");
                String cmd = "SELECT * FROM Clo";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable view = new DataTable();
                adapter.Fill(view);
                dataGridView1.DataSource = view;
                conn.Close();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                button1.Hide();
                btnUpdate.Show();
                tabPage1.Show();

            }

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            AddStudents student = new AddStudents();
            this.Hide();
            student.Show();
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
            Add_CLOs clo = new Add_CLOs();
            this.Hide();
            clo.Show();
        }

        private void btnrubric_Click(object sender, EventArgs e)
        {
            AddRubrics rubric = new AddRubrics();
            this.Hide();
            rubric.Show();
        }

        private void isstr(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (string.IsNullOrWhiteSpace(t.Text) == true)
            {
                e.Cancel = false;
                return;
            }
        }

        private void txtname_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                txtname.ContextMenu = new ContextMenu();
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

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report att = new Report();
            this.Hide();
            att.Show();
        }
    }
}
