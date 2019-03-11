namespace MiniProject
{
    partial class AddRubrics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.bbaddrubrics = new System.Windows.Forms.Button();
            this.cmbselect = new System.Windows.Forms.ComboBox();
            this.lblselect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bbshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbrubricid = new System.Windows.Forms.ComboBox();
            this.lblrubricno = new System.Windows.Forms.Label();
            this.lbldetails = new System.Windows.Forms.Label();
            this.txtdet = new System.Windows.Forms.TextBox();
            this.lblmeasure = new System.Windows.Forms.Label();
            this.txtlvl = new System.Windows.Forms.TextBox();
            this.bbaddlevel = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bblvl = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(45, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblid);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.bbaddrubrics);
            this.tabPage1.Controls.Add(this.cmbselect);
            this.tabPage1.Controls.Add(this.lblselect);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtdetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Rubrics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(43, 35);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(53, 13);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "Rubric no";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(151, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 7;
            // 
            // bbaddrubrics
            // 
            this.bbaddrubrics.Location = new System.Drawing.Point(107, 178);
            this.bbaddrubrics.Name = "bbaddrubrics";
            this.bbaddrubrics.Size = new System.Drawing.Size(75, 23);
            this.bbaddrubrics.TabIndex = 6;
            this.bbaddrubrics.Text = "Add Rubrics";
            this.bbaddrubrics.UseVisualStyleBackColor = true;
            this.bbaddrubrics.Click += new System.EventHandler(this.bbaddrubrics_Click);
            // 
            // cmbselect
            // 
            this.cmbselect.FormattingEnabled = true;
            this.cmbselect.Location = new System.Drawing.Point(151, 71);
            this.cmbselect.Name = "cmbselect";
            this.cmbselect.Size = new System.Drawing.Size(100, 21);
            this.cmbselect.TabIndex = 5;
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(43, 79);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(55, 13);
            this.lblselect.TabIndex = 4;
            this.lblselect.Text = "Select Clo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details";
            // 
            // txtdetail
            // 
            this.txtdetail.Location = new System.Drawing.Point(151, 120);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(100, 20);
            this.txtdetail.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bbshow);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Rubrics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bbshow
            // 
            this.bbshow.Location = new System.Drawing.Point(196, 40);
            this.bbshow.Name = "bbshow";
            this.bbshow.Size = new System.Drawing.Size(75, 23);
            this.bbshow.TabIndex = 1;
            this.bbshow.Text = "Show All";
            this.bbshow.UseVisualStyleBackColor = true;
            this.bbshow.Click += new System.EventHandler(this.bbshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bbaddlevel);
            this.tabPage3.Controls.Add(this.txtlvl);
            this.tabPage3.Controls.Add(this.lblmeasure);
            this.tabPage3.Controls.Add(this.txtdet);
            this.tabPage3.Controls.Add(this.lbldetails);
            this.tabPage3.Controls.Add(this.lblrubricno);
            this.tabPage3.Controls.Add(this.cmbrubricid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(317, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Rubrics Level";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbrubricid
            // 
            this.cmbrubricid.FormattingEnabled = true;
            this.cmbrubricid.Location = new System.Drawing.Point(150, 48);
            this.cmbrubricid.Name = "cmbrubricid";
            this.cmbrubricid.Size = new System.Drawing.Size(116, 21);
            this.cmbrubricid.TabIndex = 0;
            // 
            // lblrubricno
            // 
            this.lblrubricno.AutoSize = true;
            this.lblrubricno.Location = new System.Drawing.Point(30, 56);
            this.lblrubricno.Name = "lblrubricno";
            this.lblrubricno.Size = new System.Drawing.Size(71, 13);
            this.lblrubricno.TabIndex = 1;
            this.lblrubricno.Text = "Select Rubric";
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.Location = new System.Drawing.Point(33, 109);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(39, 13);
            this.lbldetails.TabIndex = 2;
            this.lbldetails.Text = "Details";
            // 
            // txtdet
            // 
            this.txtdet.Location = new System.Drawing.Point(150, 102);
            this.txtdet.Name = "txtdet";
            this.txtdet.Size = new System.Drawing.Size(116, 20);
            this.txtdet.TabIndex = 3;
            // 
            // lblmeasure
            // 
            this.lblmeasure.AutoSize = true;
            this.lblmeasure.Location = new System.Drawing.Point(33, 162);
            this.lblmeasure.Name = "lblmeasure";
            this.lblmeasure.Size = new System.Drawing.Size(100, 13);
            this.lblmeasure.TabIndex = 4;
            this.lblmeasure.Text = "Measurement Level";
            // 
            // txtlvl
            // 
            this.txtlvl.Location = new System.Drawing.Point(150, 155);
            this.txtlvl.Name = "txtlvl";
            this.txtlvl.Size = new System.Drawing.Size(116, 20);
            this.txtlvl.TabIndex = 5;
            // 
            // bbaddlevel
            // 
            this.bbaddlevel.Location = new System.Drawing.Point(107, 218);
            this.bbaddlevel.Name = "bbaddlevel";
            this.bbaddlevel.Size = new System.Drawing.Size(96, 23);
            this.bbaddlevel.TabIndex = 6;
            this.bbaddlevel.Text = "Add Level";
            this.bbaddlevel.UseVisualStyleBackColor = true;
            this.bbaddlevel.Click += new System.EventHandler(this.bbaddlevel_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.bblvl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(317, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Level";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bblvl
            // 
            this.bblvl.Location = new System.Drawing.Point(175, 29);
            this.bblvl.Name = "bblvl";
            this.bblvl.Size = new System.Drawing.Size(75, 23);
            this.bblvl.TabIndex = 0;
            this.bblvl.Text = "Show Level";
            this.bblvl.UseVisualStyleBackColor = true;
            this.bblvl.Click += new System.EventHandler(this.bblvl_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(305, 188);
            this.dataGridView2.TabIndex = 1;
            // 
            // AddRubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddRubrics";
            this.Text = "AddRubrics";
            this.Load += new System.EventHandler(this.AddRubrics_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bbaddrubrics;
        private System.Windows.Forms.ComboBox cmbselect;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Button bbshow;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bbaddlevel;
        private System.Windows.Forms.TextBox txtlvl;
        private System.Windows.Forms.Label lblmeasure;
        private System.Windows.Forms.TextBox txtdet;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.Label lblrubricno;
        private System.Windows.Forms.ComboBox cmbrubricid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bblvl;
    }
}