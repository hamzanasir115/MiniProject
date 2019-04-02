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
            this.components = new System.ComponentModel.Container();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new MiniProject.ProjectBDataSet();
            this.errorfirst = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorlast = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcontact = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroremail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorreg = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentTableAdapter = new MiniProject.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.tablelstudent = new System.Windows.Forms.TableLayoutPanel();
            this.btnrubric = new System.Windows.Forms.Button();
            this.btnclo = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.tablelst = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet2 = new MiniProject.ProjectBDataSet2();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Update = new System.Windows.Forms.Button();
            this.bbaddlevel = new System.Windows.Forms.Button();
            this.txtlvl = new System.Windows.Forms.TextBox();
            this.lblmeasure = new System.Windows.Forms.Label();
            this.txtdet = new System.Windows.Forms.TextBox();
            this.lbldetails = new System.Windows.Forms.Label();
            this.lblrubricno = new System.Windows.Forms.Label();
            this.cmbrubricid = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new MiniProject.ProjectBDataSet3();
            this.bblvl = new System.Windows.Forms.Button();
            this.rubricLevelTableAdapter = new MiniProject.ProjectBDataSet3TableAdapters.RubricLevelTableAdapter();
            this.rubricTableAdapter = new MiniProject.ProjectBDataSet2TableAdapters.RubricTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcontact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorreg)).BeginInit();
            this.panel1.SuspendLayout();
            this.tablelstudent.SuspendLayout();
            this.tablelst.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorfirst
            // 
            this.errorfirst.ContainerControl = this;
            // 
            // errorlast
            // 
            this.errorlast.ContainerControl = this;
            // 
            // errorcontact
            // 
            this.errorcontact.ContainerControl = this;
            // 
            // erroremail
            // 
            this.erroremail.ContainerControl = this;
            // 
            // errorreg
            // 
            this.errorreg.ContainerControl = this;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 68);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(78, 7);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(749, 40);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "MINI PROJECT";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl.UseCompatibleTextRendering = true;
            // 
            // tablelstudent
            // 
            this.tablelstudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablelstudent.ColumnCount = 1;
            this.tablelstudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelstudent.Controls.Add(this.btnrubric, 0, 2);
            this.tablelstudent.Controls.Add(this.btnclo, 0, 1);
            this.tablelstudent.Controls.Add(this.btnstudent, 0, 0);
            this.tablelstudent.Location = new System.Drawing.Point(2, 70);
            this.tablelstudent.Name = "tablelstudent";
            this.tablelstudent.RowCount = 3;
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablelstudent.Size = new System.Drawing.Size(160, 373);
            this.tablelstudent.TabIndex = 5;
            // 
            // btnrubric
            // 
            this.btnrubric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrubric.Location = new System.Drawing.Point(3, 251);
            this.btnrubric.Name = "btnrubric";
            this.btnrubric.Size = new System.Drawing.Size(154, 119);
            this.btnrubric.TabIndex = 2;
            this.btnrubric.Text = "Rubric";
            this.btnrubric.UseVisualStyleBackColor = true;
            this.btnrubric.Click += new System.EventHandler(this.btnrubric_Click);
            // 
            // btnclo
            // 
            this.btnclo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclo.Location = new System.Drawing.Point(3, 127);
            this.btnclo.Name = "btnclo";
            this.btnclo.Size = new System.Drawing.Size(154, 118);
            this.btnclo.TabIndex = 1;
            this.btnclo.Text = "Clo";
            this.btnclo.UseVisualStyleBackColor = true;
            this.btnclo.Click += new System.EventHandler(this.btnclo_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstudent.Location = new System.Drawing.Point(3, 3);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(154, 118);
            this.btnstudent.TabIndex = 0;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // tablelst
            // 
            this.tablelst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablelst.ColumnCount = 1;
            this.tablelst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelst.Controls.Add(this.tabControl1, 0, 0);
            this.tablelst.Location = new System.Drawing.Point(165, 73);
            this.tablelst.Name = "tablelst";
            this.tablelst.RowCount = 1;
            this.tablelst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelst.Size = new System.Drawing.Size(676, 370);
            this.tablelst.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 364);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
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
            this.tabPage1.Size = new System.Drawing.Size(662, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Rubrics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(176, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblid
            // 
            this.lblid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(43, 35);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(53, 13);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "Rubric no";
            // 
            // txtid
            // 
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.Location = new System.Drawing.Point(151, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 7;
            // 
            // bbaddrubrics
            // 
            this.bbaddrubrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bbaddrubrics.Location = new System.Drawing.Point(88, 172);
            this.bbaddrubrics.Name = "bbaddrubrics";
            this.bbaddrubrics.Size = new System.Drawing.Size(75, 23);
            this.bbaddrubrics.TabIndex = 6;
            this.bbaddrubrics.Text = "Add Rubrics";
            this.bbaddrubrics.UseVisualStyleBackColor = true;
            this.bbaddrubrics.Click += new System.EventHandler(this.bbaddrubrics_Click);
            // 
            // cmbselect
            // 
            this.cmbselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbselect.FormattingEnabled = true;
            this.cmbselect.Location = new System.Drawing.Point(151, 71);
            this.cmbselect.Name = "cmbselect";
            this.cmbselect.Size = new System.Drawing.Size(100, 21);
            this.cmbselect.TabIndex = 5;
            // 
            // lblselect
            // 
            this.lblselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(43, 79);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(55, 13);
            this.lblselect.TabIndex = 4;
            this.lblselect.Text = "Select Clo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details";
            // 
            // txtdetail
            // 
            this.txtdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdetail.Location = new System.Drawing.Point(151, 120);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(100, 20);
            this.txtdetail.TabIndex = 2;
            this.txtdetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtallow);
            this.txtdetail.Validating += new System.ComponentModel.CancelEventHandler(this.txtvalid);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bbshow);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Rubrics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bbshow
            // 
            this.bbshow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn,
            this.Edit,
            this.delete});
            this.dataGridView1.DataSource = this.rubricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "(none)";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "(none)";
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet2;
            // 
            // projectBDataSet2
            // 
            this.projectBDataSet2.DataSetName = "ProjectBDataSet2";
            this.projectBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Update);
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
            this.tabPage3.Size = new System.Drawing.Size(662, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Rubrics Level";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Location = new System.Drawing.Point(268, 218);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // bbaddlevel
            // 
            this.bbaddlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bbaddlevel.Location = new System.Drawing.Point(107, 218);
            this.bbaddlevel.Name = "bbaddlevel";
            this.bbaddlevel.Size = new System.Drawing.Size(96, 23);
            this.bbaddlevel.TabIndex = 6;
            this.bbaddlevel.Text = "Add Level";
            this.bbaddlevel.UseVisualStyleBackColor = true;
            this.bbaddlevel.Click += new System.EventHandler(this.bbaddlevel_Click);
            // 
            // txtlvl
            // 
            this.txtlvl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlvl.Location = new System.Drawing.Point(150, 155);
            this.txtlvl.Name = "txtlvl";
            this.txtlvl.Size = new System.Drawing.Size(116, 20);
            this.txtlvl.TabIndex = 5;
            // 
            // lblmeasure
            // 
            this.lblmeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmeasure.AutoSize = true;
            this.lblmeasure.Location = new System.Drawing.Point(33, 162);
            this.lblmeasure.Name = "lblmeasure";
            this.lblmeasure.Size = new System.Drawing.Size(100, 13);
            this.lblmeasure.TabIndex = 4;
            this.lblmeasure.Text = "Measurement Level";
            // 
            // txtdet
            // 
            this.txtdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdet.Location = new System.Drawing.Point(150, 102);
            this.txtdet.Name = "txtdet";
            this.txtdet.Size = new System.Drawing.Size(116, 20);
            this.txtdet.TabIndex = 3;
            // 
            // lbldetails
            // 
            this.lbldetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldetails.AutoSize = true;
            this.lbldetails.Location = new System.Drawing.Point(33, 109);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(39, 13);
            this.lbldetails.TabIndex = 2;
            this.lbldetails.Text = "Details";
            // 
            // lblrubricno
            // 
            this.lblrubricno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrubricno.AutoSize = true;
            this.lblrubricno.Location = new System.Drawing.Point(30, 56);
            this.lblrubricno.Name = "lblrubricno";
            this.lblrubricno.Size = new System.Drawing.Size(71, 13);
            this.lblrubricno.TabIndex = 1;
            this.lblrubricno.Text = "Select Rubric";
            // 
            // cmbrubricid
            // 
            this.cmbrubricid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbrubricid.FormattingEnabled = true;
            this.cmbrubricid.Location = new System.Drawing.Point(150, 48);
            this.cmbrubricid.Name = "cmbrubricid";
            this.cmbrubricid.Size = new System.Drawing.Size(116, 21);
            this.cmbrubricid.TabIndex = 0;
            this.cmbrubricid.SelectedIndexChanged += new System.EventHandler(this.cmbrubricid_SelectedIndexChanged);
            this.cmbrubricid.Click += new System.EventHandler(this.cmbrubricid_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.bblvl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(662, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Level";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn1,
            this.measurementLevelDataGridViewTextBoxColumn,
            this.Editt,
            this.Deelete});
            this.dataGridView2.DataSource = this.rubricLevelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(662, 262);
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
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn1
            // 
            this.detailsDataGridViewTextBoxColumn1.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn1.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn1.Name = "detailsDataGridViewTextBoxColumn1";
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
            // 
            // Editt
            // 
            this.Editt.DataPropertyName = "(none)";
            this.Editt.HeaderText = "Editt";
            this.Editt.Name = "Editt";
            this.Editt.Text = "Editt";
            this.Editt.ToolTipText = "Editt";
            this.Editt.UseColumnTextForButtonValue = true;
            // 
            // Deelete
            // 
            this.Deelete.DataPropertyName = "(none)";
            this.Deelete.HeaderText = "Deelete";
            this.Deelete.Name = "Deelete";
            this.Deelete.Text = "Deelete";
            this.Deelete.ToolTipText = "Deelete";
            this.Deelete.UseColumnTextForButtonValue = true;
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bblvl
            // 
            this.bblvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bblvl.Location = new System.Drawing.Point(196, 32);
            this.bblvl.Name = "bblvl";
            this.bblvl.Size = new System.Drawing.Size(75, 23);
            this.bblvl.TabIndex = 0;
            this.bblvl.Text = "Show Level";
            this.bblvl.UseVisualStyleBackColor = true;
            this.bblvl.Click += new System.EventHandler(this.bblvl_Click);
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // AddRubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablelstudent);
            this.Controls.Add(this.tablelst);
            this.Name = "AddRubrics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRubrics";
            this.Load += new System.EventHandler(this.AddRubrics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcontact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorreg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tablelstudent.ResumeLayout(false);
            this.tablelst.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.ErrorProvider errorfirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TableLayoutPanel tablelstudent;
        private System.Windows.Forms.Button btnrubric;
        private System.Windows.Forms.Button btnclo;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.TableLayoutPanel tablelst;
        private System.Windows.Forms.ErrorProvider errorlast;
        private System.Windows.Forms.ErrorProvider errorcontact;
        private System.Windows.Forms.ErrorProvider erroremail;
        private System.Windows.Forms.ErrorProvider errorreg;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button bbaddrubrics;
        private System.Windows.Forms.ComboBox cmbselect;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bbshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet2 projectBDataSet2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button bbaddlevel;
        private System.Windows.Forms.TextBox txtlvl;
        private System.Windows.Forms.Label lblmeasure;
        private System.Windows.Forms.TextBox txtdet;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.Label lblrubricno;
        private System.Windows.Forms.ComboBox cmbrubricid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editt;
        private System.Windows.Forms.DataGridViewButtonColumn Deelete;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.Button bblvl;
        private ProjectBDataSet3TableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private ProjectBDataSet2TableAdapters.RubricTableAdapter rubricTableAdapter;
    }
}