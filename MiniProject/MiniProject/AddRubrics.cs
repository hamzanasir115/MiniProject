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
    public partial class AddRubrics : Form
    {
        public AddRubrics()
        {
            InitializeComponent();
        }
        int id;
        int id2;

        /// <summary>
        /// Here we add rubrics in the database using queries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbaddrubrics_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            Rubric rubric = new Rubric();
            rubric.Details1 = txtdetail.Text;
            rubric.Id1 = Convert.ToInt32(txtid.Text);
            try
            {
                String details = txtdetail.Text;
                int id = Convert.ToInt32(txtid.Text);
                int cloid = Convert.ToInt32(cmbselect.Text);
                conn.Open();
                String cmd = String.Format("INSERT INTO Rubric(Id, Details, CloId) values('{0}', '{1}', '{2}')", id, details, cloid);
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Rubric has been added");
                txtdetail.Text = "";
                txtid.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        /// <summary>
        /// Here we take CloId from the database using query
        /// and RubricId as well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRubrics_Load(object sender, EventArgs e)
        {
            button1.Hide();
            Update.Hide();
            // TODO: This line of code loads data into the 'projectBDataSet3.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet3.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            String cmd = "SELECT Id from Clo";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // Console.WriteLine(cmbselect reader[0] + " " + reader[1]);
                cmbselect.Items.Add(reader[0]);
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
        /// <summary>
        /// Here we show rubrics which are
        /// in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM Rubric";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView1.DataSource = view;

        }
        /// <summary>
        /// Here we add rubric level in the database using queries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbaddlevel_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            Rubriclevel rub = new Rubriclevel();
            rub.Details1 = txtdet.Text;
            rub.Measurementlevel = Convert.ToInt32(txtlvl.Text);
            try
            {
                String detail = txtdet.Text;
                int lvl = Convert.ToInt32(txtlvl.Text);
                int rubid = Convert.ToInt32(cmbrubricid.Text);
                conn.Open();
                String cmd = String.Format("INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) values('{0}', '{1}', '{2}')", rubid, detail, lvl);
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Rubric Level has been added");
                txtdet.Text = "";
                txtlvl.Text = "";
                cmbrubricid.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///  Here we show rubric level which are
        /// in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bblvl_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM RubricLevel";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            id2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            conn.Open();
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                //int id5 = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
                string query = "Delete from Rubric where Id = @id2";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@id2", id2));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");
                conn.Close();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                // id3 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //id5 = Convert.ToInt32(id2);
                txtdetail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmbselect.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                bbaddrubrics.Hide();
                button1.Show();
                tabPage1.Show();
            }
        }
        /// <summary>
        /// Updation and Deletion of rubric.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)

        {

            SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            constring.Open();
            string Query = "Update Rubric Set  Details ='" + txtdetail.Text + "', CloId ='" + cmbselect.Text + "' where Id ='" + id2 + "' ";
            SqlCommand cmd = new SqlCommand(Query, constring);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been Updated");
            constring.Close();
            button1.Hide();
            bbaddrubrics.Show();
            txtid.Text = "";
            txtdetail.Text = "";
            cmbselect.Text = "";
            tabPage1.Hide();
            tabPage2.Show();
            String query = "SELECT * FROM Rubric";
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.Add(new SqlParameter("0", 1));
            constring.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(query, constring);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView1.DataSource = view;
            constring.Close();

        }
        /// <summary>
        /// Updation and Deletion of Rubric Level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            conn.Open();
            if (e.ColumnIndex == dataGridView2.Columns["deelete"].Index)
            {
                this.dataGridView2.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                var item = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                //int id5 = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
                string query = "Delete from RubricLevel where Id = @id";
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
                txtdet.Text = dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtlvl.Text = dataGridView2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbrubricid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                bbaddlevel.Hide();
                Update.Show();
                tabPage3.Show();
            }
        }
        /// <summary>
        /// Update Rubric Level here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            constring.Open();
            string Query = "Update RubricLevel Set  RubricId ='" + cmbrubricid.Text + "', Details ='" + txtdet.Text + "', MeasurementLevel ='" + txtlvl.Text + "' where Id ='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, constring);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been Updated");
            constring.Close();
            Update.Hide();
            bbaddlevel.Show();
            txtdet.Text = "";
            txtlvl.Text = "";
            tabPage3.Hide();
            tabPage4.Show();
            String query = "SELECT * FROM RubricLevel";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
