﻿using System;
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

        private void bbaddclos_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Here we add clos in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
            btnUpdate.Hide();
            lblID.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            lblID.Text = Convert.ToString(id);
            conn.Open();
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                // this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                string  qry = "Delete from Rubric where CloId = @id1";
                SqlCommand command = new SqlCommand(qry, conn);
                command.Parameters.Add(new SqlParameter("@id1", id));
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                conn.Open();
                string qr = "Delete from RubricLevel where RubricId = @id";
                 command = new SqlCommand(qr, conn);
                command.Parameters.Add(new SqlParameter("@id", id));
                reader = command.ExecuteReader();
                conn.Close();
                int row = e.RowIndex;
                var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                //int id = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
                conn.Open();
                string query = "Delete from Clo where Id = @id2";
                command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@id2", id));
                reader = command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");
                conn.Close();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //int id = Convert.ToInt32(id1);
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //button1.Text = "Update";
                button1.Hide();
                btnUpdate.Show();
                tabPage1.Show();

            }

        }
    }
}
