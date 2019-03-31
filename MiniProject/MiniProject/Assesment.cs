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

        private void btnassesment_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            bool IsValidTitle = false;
            IsValidTitle = IsString(txttitle.Text);
            if(IsValidTitle == true)
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
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet4.Assessment);
            btnupdate.Hide();
            label1.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int row = e.RowIndex;
                string query = "Delete from Assessment where Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", Id));
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
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
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
            if(IsValidTitle == true)
            {
                SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                constring.Open();
                int id = Convert.ToInt32(label1.Text);

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
           

        }
    }