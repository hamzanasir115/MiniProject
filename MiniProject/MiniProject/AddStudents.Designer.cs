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
            this.btnadd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(424, 343);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
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
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(239, 155);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 16;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(239, 107);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 20);
            this.txtcontact.TabIndex = 15;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(239, 54);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 20);
            this.txtlast.TabIndex = 14;
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(239, 3);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 20);
            this.txtfirst.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(239, 256);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 25;
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddStudents";
            this.Text = "Students";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtstatus;
    }
}