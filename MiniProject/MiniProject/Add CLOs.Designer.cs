namespace MiniProject
{
    partial class Add_CLOs
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
            this.Add = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bbshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new MiniProject.ProjectBDataSet1();
            this.cloTableAdapter = new MiniProject.ProjectBDataSet1TableAdapters.CloTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.Add.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Controls.Add(this.tabPage1);
            this.Add.Controls.Add(this.tabPage2);
            this.Add.Location = new System.Drawing.Point(31, 35);
            this.Add.Name = "Add";
            this.Add.SelectedIndex = 0;
            this.Add.Size = new System.Drawing.Size(776, 375);
            this.Add.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdUpdate);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtname);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Clos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add CLOs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(184, 79);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bbshow);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Clos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bbshow
            // 
            this.bbshow.Location = new System.Drawing.Point(183, 43);
            this.bbshow.Name = "bbshow";
            this.bbshow.Size = new System.Drawing.Size(75, 23);
            this.bbshow.TabIndex = 1;
            this.bbshow.Text = "Show All";
            this.bbshow.UseVisualStyleBackColor = true;
            this.bbshow.Click += new System.EventHandler(this.bbshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.delete,
            this.Edit});
            this.dataGridView1.DataSource = this.cloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
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
            // Edit
            // 
            this.Edit.DataPropertyName = "(none)";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(263, 152);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 6;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // Add_CLOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 468);
            this.Controls.Add(this.Add);
            this.Name = "Add_CLOs";
            this.Text = "Add_CLOs";
            this.Load += new System.EventHandler(this.Add_CLOs_Load);
            this.Add.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Add;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button bbshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet1TableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button cmdUpdate;
    }
}