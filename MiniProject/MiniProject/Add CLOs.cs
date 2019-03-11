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

        private void bbaddclos_Click(object sender, EventArgs e)
        {
            
        }

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


        }
    }
}
