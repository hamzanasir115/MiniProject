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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace MiniProject
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
        private void Report_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
        private void bindgrid()
        {

            string query1 = "Select * FROM Student";
            SqlCommand cmd1 = new SqlCommand(query1, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd1;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void exportgridtopdf(DataGridView d, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable1 = new PdfPTable(d.Columns.Count);

            pdftable1.DefaultCell.Padding = 2;
            pdftable1.WidthPercentage = 100;
            pdftable1.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable1.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);


            //Header
            foreach (DataGridViewColumn column in d.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable1.AddCell(cell);

            }

            // Data Row
            foreach (DataGridViewRow row in d.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable1.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = filename;
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable1);
                    pdfdoc.Close();
                    stream.Close();
                    MessageBox.Show("PDF generated and saved to your PC.");
                }
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridView1, "Report Evaluations");
        }
    }
}
