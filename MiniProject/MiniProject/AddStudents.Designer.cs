namespace MiniProject
{
    partial class AddStudents
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
            this.empty = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblregistration = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblfirst = new System.Windows.Forms.Label();
            this.txtregister = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowData = new System.Windows.Forms.Button();
            this.datastudent = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            this.studentBindingSource.CurrentChanged += new System.EventHandler(this.studentBindingSource_CurrentChanged);
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 68);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(70, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(749, 40);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "MINI PROJECT";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl.UseCompatibleTextRendering = true;
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
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
            this.tablelstudent.Location = new System.Drawing.Point(1, 69);
            this.tablelstudent.Name = "tablelstudent";
            this.tablelstudent.RowCount = 3;
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablelstudent.Size = new System.Drawing.Size(160, 373);
            this.tablelstudent.TabIndex = 2;
            this.tablelstudent.Paint += new System.Windows.Forms.PaintEventHandler(this.tablelstudent_Paint);
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
            this.tablelst.Location = new System.Drawing.Point(164, 72);
            this.tablelst.Name = "tablelst";
            this.tablelst.RowCount = 1;
            this.tablelst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelst.Size = new System.Drawing.Size(676, 370);
            this.tablelst.TabIndex = 3;
            this.tablelst.Paint += new System.Windows.Forms.PaintEventHandler(this.tablelst_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 364);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.empty);
            this.tabPage1.Controls.Add(this.txtstatus);
            this.tabPage1.Controls.Add(this.lblstatus);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.lblregistration);
            this.tabPage1.Controls.Add(this.lblemail);
            this.tabPage1.Controls.Add(this.lblcontact);
            this.tabPage1.Controls.Add(this.lblsecond);
            this.tabPage1.Controls.Add(this.lblfirst);
            this.tabPage1.Controls.Add(this.txtregister);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.txtcontact);
            this.tabPage1.Controls.Add(this.txtlast);
            this.tabPage1.Controls.Add(this.txtfirst);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // empty
            // 
            this.empty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empty.AutoSize = true;
            this.empty.Location = new System.Drawing.Point(77, 88);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(36, 13);
            this.empty.TabIndex = 27;
            this.empty.Text = "Empty";
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstatus.Location = new System.Drawing.Point(239, 264);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 25;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtstatus_TextChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(77, 264);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 24;
            this.lblstatus.Text = "Status";
            this.lblstatus.Click += new System.EventHandler(this.lblstatus_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Location = new System.Drawing.Point(143, 309);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 23);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add Students";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // lblregistration
            // 
            this.lblregistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblregistration.AutoSize = true;
            this.lblregistration.Location = new System.Drawing.Point(76, 216);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(103, 13);
            this.lblregistration.TabIndex = 23;
            this.lblregistration.Text = "Registration Number";
            this.lblregistration.Click += new System.EventHandler(this.lblregistration_Click);
            // 
            // lblemail
            // 
            this.lblemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(76, 162);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 22;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblcontact
            // 
            this.lblcontact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(76, 114);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(44, 13);
            this.lblcontact.TabIndex = 21;
            this.lblcontact.Text = "Contact";
            this.lblcontact.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // lblsecond
            // 
            this.lblsecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsecond.AutoSize = true;
            this.lblsecond.Location = new System.Drawing.Point(76, 61);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(58, 13);
            this.lblsecond.TabIndex = 20;
            this.lblsecond.Text = "Last Name";
            this.lblsecond.Click += new System.EventHandler(this.lblsecond_Click);
            // 
            // lblfirst
            // 
            this.lblfirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(76, 10);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(57, 13);
            this.lblfirst.TabIndex = 19;
            this.lblfirst.Text = "First Name";
            this.lblfirst.Click += new System.EventHandler(this.lblfirst_Click);
            // 
            // txtregister
            // 
            this.txtregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtregister.Location = new System.Drawing.Point(239, 213);
            this.txtregister.Name = "txtregister";
            this.txtregister.Size = new System.Drawing.Size(100, 20);
            this.txtregister.TabIndex = 17;
            this.txtregister.TextChanged += new System.EventHandler(this.txtregister_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Location = new System.Drawing.Point(239, 155);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 16;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtcontact
            // 
            this.txtcontact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcontact.Location = new System.Drawing.Point(239, 107);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 20);
            this.txtcontact.TabIndex = 15;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_Leave);
            // 
            // txtlast
            // 
            this.txtlast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlast.Location = new System.Drawing.Point(239, 54);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 20);
            this.txtlast.TabIndex = 14;
            this.txtlast.TextChanged += new System.EventHandler(this.txtlast_Leave);
            // 
            // txtfirst
            // 
            this.txtfirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfirst.Location = new System.Drawing.Point(239, 3);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 20);
            this.txtfirst.TabIndex = 13;
            this.txtfirst.TextChanged += new System.EventHandler(this.txtfirst_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowData);
            this.tabPage2.Controls.Add(this.datastudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click_1);
            // 
            // btnShowData
            // 
            this.btnShowData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowData.Location = new System.Drawing.Point(151, 49);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 23);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // datastudent
            // 
            this.datastudent.AllowUserToOrderColumns = true;
            this.datastudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datastudent.AutoGenerateColumns = false;
            this.datastudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datastudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.delete});
            this.datastudent.DataSource = this.studentBindingSource;
            this.datastudent.Location = new System.Drawing.Point(3, 107);
            this.datastudent.Name = "datastudent";
            this.datastudent.Size = new System.Drawing.Size(653, 204);
            this.datastudent.TabIndex = 0;
            this.datastudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastudent_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // delete
            // 
            this.delete.DataPropertyName = "(none)";
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Text = "delete";
            this.delete.ToolTipText = "delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 443);
            this.Controls.Add(this.tablelst);
            this.Controls.Add(this.tablelstudent);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.AddStudents_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorfirst;
        private System.Windows.Forms.ErrorProvider errorlast;
        private System.Windows.Forms.ErrorProvider errorcontact;
        private System.Windows.Forms.ErrorProvider erroremail;
        private System.Windows.Forms.ErrorProvider errorreg;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TableLayoutPanel tablelstudent;
        private System.Windows.Forms.Button btnrubric;
        private System.Windows.Forms.Button btnclo;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.TableLayoutPanel tablelst;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label empty;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.TextBox txtregister;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}