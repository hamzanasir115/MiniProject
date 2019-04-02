namespace MiniProject
{
    partial class AddAttendance
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
            this.datadate = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new MiniProject.ProjectBDataSet6();
            this.btndate = new System.Windows.Forms.Button();
            this.Attendencepick = new System.Windows.Forms.MonthCalendar();
            this.tabStudentAttendance = new System.Windows.Forms.TabPage();
            this.datastudentatt = new System.Windows.Forms.DataGridView();
            this.attendanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deletee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet7 = new MiniProject.ProjectBDataSet7();
            this.btnupdates = new System.Windows.Forms.Button();
            this.btnaddstudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbattstatus = new System.Windows.Forms.ComboBox();
            this.cmbstdid = new System.Windows.Forms.ComboBox();
            this.cmbattid = new System.Windows.Forms.ComboBox();
            this.classAttendanceTableAdapter = new MiniProject.ProjectBDataSet6TableAdapters.ClassAttendanceTableAdapter();
            this.studentAttendanceTableAdapter = new MiniProject.ProjectBDataSet7TableAdapters.StudentAttendanceTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            this.tabStudentAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastudentatt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabStudentAttendance);
            this.tabControl1.Location = new System.Drawing.Point(109, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnupdate);
            this.tabPage1.Controls.Add(this.datadate);
            this.tabPage1.Controls.Add(this.btndate);
            this.tabPage1.Controls.Add(this.Attendencepick);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class Attendance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(322, 123);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // datadate
            // 
            this.datadate.AutoGenerateColumns = false;
            this.datadate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.datadate.DataSource = this.classAttendanceBindingSource;
            this.datadate.Location = new System.Drawing.Point(9, 194);
            this.datadate.Name = "datadate";
            this.datadate.Size = new System.Drawing.Size(545, 150);
            this.datadate.TabIndex = 2;
            this.datadate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadate_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
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
            // Delete
            // 
            this.Delete.DataPropertyName = "(none)";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndate
            // 
            this.btndate.Location = new System.Drawing.Point(322, 68);
            this.btndate.Name = "btndate";
            this.btndate.Size = new System.Drawing.Size(75, 23);
            this.btndate.TabIndex = 1;
            this.btndate.Text = "Add Date";
            this.btndate.UseVisualStyleBackColor = true;
            this.btndate.Click += new System.EventHandler(this.btndate_Click);
            // 
            // Attendencepick
            // 
            this.Attendencepick.Location = new System.Drawing.Point(9, 9);
            this.Attendencepick.Name = "Attendencepick";
            this.Attendencepick.TabIndex = 0;
            // 
            // tabStudentAttendance
            // 
            this.tabStudentAttendance.Controls.Add(this.datastudentatt);
            this.tabStudentAttendance.Controls.Add(this.btnupdates);
            this.tabStudentAttendance.Controls.Add(this.btnaddstudent);
            this.tabStudentAttendance.Controls.Add(this.label3);
            this.tabStudentAttendance.Controls.Add(this.label2);
            this.tabStudentAttendance.Controls.Add(this.label1);
            this.tabStudentAttendance.Controls.Add(this.cmbattstatus);
            this.tabStudentAttendance.Controls.Add(this.cmbstdid);
            this.tabStudentAttendance.Controls.Add(this.cmbattid);
            this.tabStudentAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabStudentAttendance.Name = "tabStudentAttendance";
            this.tabStudentAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentAttendance.Size = new System.Drawing.Size(560, 353);
            this.tabStudentAttendance.TabIndex = 1;
            this.tabStudentAttendance.Text = "Student Attendance";
            this.tabStudentAttendance.UseVisualStyleBackColor = true;
            this.tabStudentAttendance.Click += new System.EventHandler(this.tabStudentAttendance_Click);
            // 
            // datastudentatt
            // 
            this.datastudentatt.AutoGenerateColumns = false;
            this.datastudentatt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastudentatt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewTextBoxColumn,
            this.Editt,
            this.Deletee});
            this.datastudentatt.DataSource = this.studentAttendanceBindingSource;
            this.datastudentatt.Location = new System.Drawing.Point(6, 200);
            this.datastudentatt.Name = "datastudentatt";
            this.datastudentatt.Size = new System.Drawing.Size(548, 150);
            this.datastudentatt.TabIndex = 8;
            this.datastudentatt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastudentatt_CellContentClick);
            // 
            // attendanceIdDataGridViewTextBoxColumn
            // 
            this.attendanceIdDataGridViewTextBoxColumn.DataPropertyName = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.HeaderText = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.Name = "attendanceIdDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // attendanceStatusDataGridViewTextBoxColumn
            // 
            this.attendanceStatusDataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.Name = "attendanceStatusDataGridViewTextBoxColumn";
            // 
            // Editt
            // 
            this.Editt.DataPropertyName = "(none)";
            this.Editt.HeaderText = "Editt";
            this.Editt.Name = "Editt";
            this.Editt.Text = "Editt";
            this.Editt.ToolTipText = "Edit";
            this.Editt.UseColumnTextForButtonValue = true;
            // 
            // Deletee
            // 
            this.Deletee.DataPropertyName = "(none)";
            this.Deletee.HeaderText = "Deletee";
            this.Deletee.Name = "Deletee";
            this.Deletee.Text = "Deletee";
            this.Deletee.ToolTipText = "Delete";
            this.Deletee.UseColumnTextForButtonValue = true;
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet7;
            // 
            // projectBDataSet7
            // 
            this.projectBDataSet7.DataSetName = "ProjectBDataSet7";
            this.projectBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnupdates
            // 
            this.btnupdates.Location = new System.Drawing.Point(331, 126);
            this.btnupdates.Name = "btnupdates";
            this.btnupdates.Size = new System.Drawing.Size(75, 23);
            this.btnupdates.TabIndex = 7;
            this.btnupdates.Text = "Update";
            this.btnupdates.UseVisualStyleBackColor = true;
            this.btnupdates.Click += new System.EventHandler(this.btnupdates_Click);
            // 
            // btnaddstudent
            // 
            this.btnaddstudent.Location = new System.Drawing.Point(331, 66);
            this.btnaddstudent.Name = "btnaddstudent";
            this.btnaddstudent.Size = new System.Drawing.Size(75, 23);
            this.btnaddstudent.TabIndex = 6;
            this.btnaddstudent.Text = "Add ";
            this.btnaddstudent.UseVisualStyleBackColor = true;
            this.btnaddstudent.Click += new System.EventHandler(this.btnaddstudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attendance Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attendance ID";
            // 
            // cmbattstatus
            // 
            this.cmbattstatus.FormattingEnabled = true;
            this.cmbattstatus.Location = new System.Drawing.Point(138, 151);
            this.cmbattstatus.Name = "cmbattstatus";
            this.cmbattstatus.Size = new System.Drawing.Size(115, 21);
            this.cmbattstatus.TabIndex = 2;
            // 
            // cmbstdid
            // 
            this.cmbstdid.FormattingEnabled = true;
            this.cmbstdid.Location = new System.Drawing.Point(138, 89);
            this.cmbstdid.Name = "cmbstdid";
            this.cmbstdid.Size = new System.Drawing.Size(115, 21);
            this.cmbstdid.TabIndex = 1;
            // 
            // cmbattid
            // 
            this.cmbattid.FormattingEnabled = true;
            this.cmbattid.Location = new System.Drawing.Point(138, 35);
            this.cmbattid.Name = "cmbattid";
            this.cmbattid.Size = new System.Drawing.Size(115, 21);
            this.cmbattid.TabIndex = 0;
            this.cmbattid.SelectedIndexChanged += new System.EventHandler(this.cmbattid_SelectedIndexChanged);
            this.cmbattid.Click += new System.EventHandler(this.cmbattid_Click);
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // AddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddAttendance";
            this.Text = "AddAttendance";
            this.Load += new System.EventHandler(this.AddAttendance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datadate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            this.tabStudentAttendance.ResumeLayout(false);
            this.tabStudentAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastudentatt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView datadate;
        private System.Windows.Forms.Button btndate;
        private System.Windows.Forms.MonthCalendar Attendencepick;
        private System.Windows.Forms.TabPage tabStudentAttendance;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSet6TableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView datastudentatt;
        private System.Windows.Forms.Button btnupdates;
        private System.Windows.Forms.Button btnaddstudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbattstatus;
        private System.Windows.Forms.ComboBox cmbstdid;
        private System.Windows.Forms.ComboBox cmbattid;
        private ProjectBDataSet7 projectBDataSet7;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet7TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editt;
        private System.Windows.Forms.DataGridViewButtonColumn Deletee;
    }
}