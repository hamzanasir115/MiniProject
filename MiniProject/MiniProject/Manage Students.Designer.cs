namespace MiniProject
{
    partial class Manage_Students
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
            this.addstudents = new System.Windows.Forms.Button();
            this.viewstudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addstudents
            // 
            this.addstudents.Location = new System.Drawing.Point(76, 49);
            this.addstudents.Name = "addstudents";
            this.addstudents.Size = new System.Drawing.Size(119, 23);
            this.addstudents.TabIndex = 0;
            this.addstudents.Text = "Add Students";
            this.addstudents.UseVisualStyleBackColor = true;
            // 
            // viewstudents
            // 
            this.viewstudents.Location = new System.Drawing.Point(76, 131);
            this.viewstudents.Name = "viewstudents";
            this.viewstudents.Size = new System.Drawing.Size(119, 23);
            this.viewstudents.TabIndex = 1;
            this.viewstudents.Text = "View Students";
            this.viewstudents.UseVisualStyleBackColor = true;
            // 
            // Manage_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 264);
            this.Controls.Add(this.viewstudents);
            this.Controls.Add(this.addstudents);
            this.Name = "Manage_Students";
            this.Text = "Manage_Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addstudents;
        private System.Windows.Forms.Button viewstudents;
    }
}