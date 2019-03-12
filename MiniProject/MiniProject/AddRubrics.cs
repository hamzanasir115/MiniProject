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
                String cmd = String.Format("INSERT INTO Rubric(Id, Details, CloId) values('{0}', '{1}', '{2}')",id, details, cloid);
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
            String c = "SELECT Id from Clo";
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
                String cmd = String.Format("INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) values('{0}', '{1}', '{2}')",rubid, detail, lvl );
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Rubric Level has been added");
                txtdet.Text = "";
                txtlvl.Text = "";
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
        }
    }
}
