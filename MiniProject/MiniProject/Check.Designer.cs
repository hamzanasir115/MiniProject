namespace MiniProject
{
    partial class Check
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
            this.tablelst = new System.Windows.Forms.TableLayoutPanel();
            this.lbl = new System.Windows.Forms.Label();
            this.tablelstudent = new System.Windows.Forms.TableLayoutPanel();
            this.btnrubric = new System.Windows.Forms.Button();
            this.btnclo = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcontact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorreg)).BeginInit();
            this.tablelstudent.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // tablelst
            // 
            this.tablelst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablelst.ColumnCount = 1;
            this.tablelst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelst.Location = new System.Drawing.Point(165, 67);
            this.tablelst.Name = "tablelst";
            this.tablelst.RowCount = 1;
            this.tablelst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelst.Size = new System.Drawing.Size(808, 421);
            this.tablelst.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(70, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(869, 40);
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
            this.tablelstudent.Location = new System.Drawing.Point(2, 67);
            this.tablelstudent.Name = "tablelstudent";
            this.tablelstudent.RowCount = 3;
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablelstudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablelstudent.Size = new System.Drawing.Size(160, 421);
            this.tablelstudent.TabIndex = 5;
            // 
            // btnrubric
            // 
            this.btnrubric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrubric.Location = new System.Drawing.Point(3, 283);
            this.btnrubric.Name = "btnrubric";
            this.btnrubric.Size = new System.Drawing.Size(154, 135);
            this.btnrubric.TabIndex = 2;
            this.btnrubric.Text = "Rubric";
            this.btnrubric.UseVisualStyleBackColor = true;
            // 
            // btnclo
            // 
            this.btnclo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclo.Location = new System.Drawing.Point(3, 143);
            this.btnclo.Name = "btnclo";
            this.btnclo.Size = new System.Drawing.Size(154, 134);
            this.btnclo.TabIndex = 1;
            this.btnclo.Text = "Clo";
            this.btnclo.UseVisualStyleBackColor = true;
            // 
            // btnstudent
            // 
            this.btnstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstudent.Location = new System.Drawing.Point(3, 3);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(154, 134);
            this.btnstudent.TabIndex = 0;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(1163, 68);
            this.panel1.TabIndex = 4;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 404);
            this.Controls.Add(this.tablelst);
            this.Controls.Add(this.tablelstudent);
            this.Controls.Add(this.panel1);
            this.Name = "Check";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcontact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorreg)).EndInit();
            this.tablelstudent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.ErrorProvider errorfirst;
        private System.Windows.Forms.TableLayoutPanel tablelst;
        private System.Windows.Forms.TableLayoutPanel tablelstudent;
        private System.Windows.Forms.Button btnrubric;
        private System.Windows.Forms.Button btnclo;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ErrorProvider errorlast;
        private System.Windows.Forms.ErrorProvider errorcontact;
        private System.Windows.Forms.ErrorProvider erroremail;
        private System.Windows.Forms.ErrorProvider errorreg;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}