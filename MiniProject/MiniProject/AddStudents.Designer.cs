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
            this.btnadd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.empty = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.datastudent = new System.Windows.Forms.DataGridView();
            this.errorfirst = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorlast = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcontact = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroremail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorreg = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectBDataSet = new MiniProject.ProjectBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new MiniProject.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcontact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorreg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(134, 291);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 23);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add Students";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 343);
            this.tabControl1.TabIndex = 14;
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
            this.tabPage1.Size = new System.Drawing.Size(416, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // empty
            // 
            this.empty.AutoSize = true;
            this.empty.Location = new System.Drawing.Point(77, 88);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(36, 13);
            this.empty.TabIndex = 27;
            this.empty.Text = "Empty";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(239, 264);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 25;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(77, 264);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 24;
            this.lblstatus.Text = "Status";
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.Location = new System.Drawing.Point(76, 216);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(103, 13);
            this.lblregistration.TabIndex = 23;
            this.lblregistration.Text = "Registration Number";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(76, 162);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 22;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(76, 114);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(44, 13);
            this.lblcontact.TabIndex = 21;
            this.lblcontact.Text = "Contact";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Location = new System.Drawing.Point(76, 61);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(58, 13);
            this.lblsecond.TabIndex = 20;
            this.lblsecond.Text = "Last Name";
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(76, 10);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(57, 13);
            this.lblfirst.TabIndex = 19;
            this.lblfirst.Text = "First Name";
            // 
            // txtregister
            // 
            this.txtregister.Location = new System.Drawing.Point(239, 209);
            this.txtregister.Name = "txtregister";
            this.txtregister.Size = new System.Drawing.Size(100, 20);
            this.txtregister.TabIndex = 17;
            this.txtregister.Leave += new System.EventHandler(this.txtregister_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(239, 155);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 16;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(239, 107);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 20);
            this.txtcontact.TabIndex = 15;
            this.txtcontact.Leave += new System.EventHandler(this.txtcontact_Leave);
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(239, 54);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 20);
            this.txtlast.TabIndex = 14;
            this.txtlast.Leave += new System.EventHandler(this.txtlast_Leave);
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(239, 3);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 20);
            this.txtfirst.TabIndex = 13;
            this.txtfirst.Leave += new System.EventHandler(this.txtfirst_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.datastudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datastudent
            // 
            this.datastudent.AllowUserToOrderColumns = true;
            this.datastudent.AutoGenerateColumns = false;
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
            this.datastudent.Location = new System.Drawing.Point(-32, 107);
            this.datastudent.Name = "datastudent";
            this.datastudent.Size = new System.Drawing.Size(816, 204);
            this.datastudent.TabIndex = 0;
            this.datastudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastudent_CellClick);
            this.datastudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastudent_CellContentClick);
            this.datastudent.DoubleClick += new System.EventHandler(this.datastudent_DoubleClick);
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
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.ToolTipText = "Id";
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
            this.ClientSize = new System.Drawing.Size(875, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.AddStudents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcontact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorreg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblstatus;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.ErrorProvider errorfirst;
        private System.Windows.Forms.ErrorProvider errorlast;
        private System.Windows.Forms.ErrorProvider errorcontact;
        private System.Windows.Forms.ErrorProvider erroremail;
        private System.Windows.Forms.ErrorProvider errorreg;
        private System.Windows.Forms.Label empty;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
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