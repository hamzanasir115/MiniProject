namespace MiniProject
{
    partial class Assesment
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnassesment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.txtweightage = new System.Windows.Forms.TextBox();
            this.txtmarks = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet4 = new MiniProject.ProjectBDataSet4();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnupdates = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblassesmentid = new System.Windows.Forms.Label();
            this.lbltotalmark = new System.Windows.Forms.Label();
            this.lblrubricid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.cmbassesmentid = new System.Windows.Forms.ComboBox();
            this.cmbrubricid = new System.Windows.Forms.ComboBox();
            this.txttotalmarks = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnshowall = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deletee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet5 = new MiniProject.ProjectBDataSet5();
            this.assessmentTableAdapter = new MiniProject.ProjectBDataSet4TableAdapters.AssessmentTableAdapter();
            this.assessmentComponentTableAdapter = new MiniProject.ProjectBDataSet5TableAdapters.AssessmentComponentTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(98, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 302);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnupdate);
            this.tabPage1.Controls.Add(this.btnassesment);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Title);
            this.tabPage1.Controls.Add(this.txtweightage);
            this.tabPage1.Controls.Add(this.txtmarks);
            this.tabPage1.Controls.Add(this.txttitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Assesment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(213, 210);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnassesment
            // 
            this.btnassesment.Location = new System.Drawing.Point(76, 210);
            this.btnassesment.Name = "btnassesment";
            this.btnassesment.Size = new System.Drawing.Size(75, 23);
            this.btnassesment.TabIndex = 10;
            this.btnassesment.Text = "Add Assesment";
            this.btnassesment.UseVisualStyleBackColor = true;
            this.btnassesment.Click += new System.EventHandler(this.btnassesment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Weightage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Marks";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(35, 43);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 7;
            this.Title.Text = "Title";
            // 
            // txtweightage
            // 
            this.txtweightage.Location = new System.Drawing.Point(157, 148);
            this.txtweightage.Name = "txtweightage";
            this.txtweightage.Size = new System.Drawing.Size(100, 20);
            this.txtweightage.TabIndex = 6;
            // 
            // txtmarks
            // 
            this.txtmarks.Location = new System.Drawing.Point(157, 96);
            this.txtmarks.Name = "txtmarks";
            this.txtmarks.Size = new System.Drawing.Size(100, 20);
            this.txtmarks.TabIndex = 5;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(157, 36);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 20);
            this.txttitle.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnshow);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Assesment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(84, 19);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.totalWeightageDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.assessmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // totalWeightageDataGridViewTextBoxColumn
            // 
            this.totalWeightageDataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.HeaderText = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.Name = "totalWeightageDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "(none)";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "(none)";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet4;
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnupdates);
            this.tabPage3.Controls.Add(this.btnadd);
            this.tabPage3.Controls.Add(this.lblassesmentid);
            this.tabPage3.Controls.Add(this.lbltotalmark);
            this.tabPage3.Controls.Add(this.lblrubricid);
            this.tabPage3.Controls.Add(this.lblname);
            this.tabPage3.Controls.Add(this.cmbassesmentid);
            this.tabPage3.Controls.Add(this.cmbrubricid);
            this.tabPage3.Controls.Add(this.txttotalmarks);
            this.tabPage3.Controls.Add(this.txtname);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Assesment Component";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnupdates
            // 
            this.btnupdates.Location = new System.Drawing.Point(200, 241);
            this.btnupdates.Name = "btnupdates";
            this.btnupdates.Size = new System.Drawing.Size(75, 23);
            this.btnupdates.TabIndex = 9;
            this.btnupdates.Text = "Update";
            this.btnupdates.UseVisualStyleBackColor = true;
            this.btnupdates.Click += new System.EventHandler(this.btnupdates_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(86, 241);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add Component";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblassesmentid
            // 
            this.lblassesmentid.AutoSize = true;
            this.lblassesmentid.Location = new System.Drawing.Point(24, 205);
            this.lblassesmentid.Name = "lblassesmentid";
            this.lblassesmentid.Size = new System.Drawing.Size(75, 13);
            this.lblassesmentid.TabIndex = 7;
            this.lblassesmentid.Text = "Assessment Id";
            // 
            // lbltotalmark
            // 
            this.lbltotalmark.AutoSize = true;
            this.lbltotalmark.Location = new System.Drawing.Point(24, 147);
            this.lbltotalmark.Name = "lbltotalmark";
            this.lbltotalmark.Size = new System.Drawing.Size(63, 13);
            this.lbltotalmark.TabIndex = 6;
            this.lbltotalmark.Text = "Total Marks";
            // 
            // lblrubricid
            // 
            this.lblrubricid.AutoSize = true;
            this.lblrubricid.Location = new System.Drawing.Point(24, 89);
            this.lblrubricid.Name = "lblrubricid";
            this.lblrubricid.Size = new System.Drawing.Size(50, 13);
            this.lblrubricid.TabIndex = 5;
            this.lblrubricid.Text = "Rubric Id";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(24, 43);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name";
            // 
            // cmbassesmentid
            // 
            this.cmbassesmentid.FormattingEnabled = true;
            this.cmbassesmentid.Location = new System.Drawing.Point(147, 197);
            this.cmbassesmentid.Name = "cmbassesmentid";
            this.cmbassesmentid.Size = new System.Drawing.Size(100, 21);
            this.cmbassesmentid.TabIndex = 3;
            // 
            // cmbrubricid
            // 
            this.cmbrubricid.FormattingEnabled = true;
            this.cmbrubricid.Location = new System.Drawing.Point(147, 81);
            this.cmbrubricid.Name = "cmbrubricid";
            this.cmbrubricid.Size = new System.Drawing.Size(100, 21);
            this.cmbrubricid.TabIndex = 2;
            this.cmbrubricid.SelectedIndexChanged += new System.EventHandler(this.cmbrubricid_SelectedIndexChanged);
            this.cmbrubricid.Click += new System.EventHandler(this.cmbrubricid_Click);
            // 
            // txttotalmarks
            // 
            this.txttotalmarks.Location = new System.Drawing.Point(147, 140);
            this.txttotalmarks.Name = "txttotalmarks";
            this.txttotalmarks.Size = new System.Drawing.Size(100, 20);
            this.txttotalmarks.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(147, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnshowall);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(702, 276);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Assessment Component";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(154, 28);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 2;
            this.btnshowall.Text = "Show";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn1,
            this.dateCreatedDataGridViewTextBoxColumn1,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.assessmentIdDataGridViewTextBoxColumn,
            this.Editt,
            this.Deletee});
            this.dataGridView2.DataSource = this.assessmentComponentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(690, 204);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn1
            // 
            this.totalMarksDataGridViewTextBoxColumn1.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn1.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn1.Name = "totalMarksDataGridViewTextBoxColumn1";
            // 
            // dateCreatedDataGridViewTextBoxColumn1
            // 
            this.dateCreatedDataGridViewTextBoxColumn1.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn1.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn1.Name = "dateCreatedDataGridViewTextBoxColumn1";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            // 
            // assessmentIdDataGridViewTextBoxColumn
            // 
            this.assessmentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.Name = "assessmentIdDataGridViewTextBoxColumn";
            // 
            // Editt
            // 
            this.Editt.DataPropertyName = "(none)";
            this.Editt.HeaderText = "Editt";
            this.Editt.Name = "Editt";
            this.Editt.Text = "Edit";
            this.Editt.ToolTipText = "Edit";
            this.Editt.UseColumnTextForButtonValue = true;
            // 
            // Deletee
            // 
            this.Deletee.DataPropertyName = "(none)";
            this.Deletee.HeaderText = "Deletee";
            this.Deletee.Name = "Deletee";
            this.Deletee.Text = "Delete";
            this.Deletee.ToolTipText = "Delete";
            this.Deletee.UseColumnTextForButtonValue = true;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet5;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // Assesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 330);
            this.Controls.Add(this.tabControl1);
            this.Name = "Assesment";
            this.Text = "Assesment";
            this.Load += new System.EventHandler(this.Assesment_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnassesment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtweightage;
        private System.Windows.Forms.TextBox txtmarks;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet4 projectBDataSet4;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet4TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbassesmentid;
        private System.Windows.Forms.ComboBox cmbrubricid;
        private System.Windows.Forms.TextBox txttotalmarks;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblassesmentid;
        private System.Windows.Forms.Label lbltotalmark;
        private System.Windows.Forms.Label lblrubricid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnupdates;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet5TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editt;
        private System.Windows.Forms.DataGridViewButtonColumn Deletee;
        private System.Windows.Forms.Button btnshowall;
    }
}