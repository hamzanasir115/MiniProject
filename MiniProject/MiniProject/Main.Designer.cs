namespace MiniProject
{
    partial class Main
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
            this.managestudent = new System.Windows.Forms.Button();
            this.manageclos = new System.Windows.Forms.Button();
            this.managerubrics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managestudent
            // 
            this.managestudent.Location = new System.Drawing.Point(81, 45);
            this.managestudent.Name = "managestudent";
            this.managestudent.Size = new System.Drawing.Size(119, 23);
            this.managestudent.TabIndex = 0;
            this.managestudent.Text = "Manage Students";
            this.managestudent.UseVisualStyleBackColor = true;
            this.managestudent.Click += new System.EventHandler(this.managestudent_Click);
            // 
            // manageclos
            // 
            this.manageclos.Location = new System.Drawing.Point(81, 114);
            this.manageclos.Name = "manageclos";
            this.manageclos.Size = new System.Drawing.Size(119, 23);
            this.manageclos.TabIndex = 1;
            this.manageclos.Text = "Manage CLOs";
            this.manageclos.UseVisualStyleBackColor = true;
            this.manageclos.Click += new System.EventHandler(this.manageclos_Click);
            // 
            // managerubrics
            // 
            this.managerubrics.Location = new System.Drawing.Point(81, 187);
            this.managerubrics.Name = "managerubrics";
            this.managerubrics.Size = new System.Drawing.Size(119, 23);
            this.managerubrics.TabIndex = 2;
            this.managerubrics.Text = "Manage Rubrics";
            this.managerubrics.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.managerubrics);
            this.Controls.Add(this.manageclos);
            this.Controls.Add(this.managestudent);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managestudent;
        private System.Windows.Forms.Button manageclos;
        private System.Windows.Forms.Button managerubrics;
    }
}

