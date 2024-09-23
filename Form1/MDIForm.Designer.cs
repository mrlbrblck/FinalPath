using System;

namespace Form1
{
    partial class MDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiprofile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmdiclose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.itsm_info = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiprofile,
            this.tsmicalculator,
            this.itsm_info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiprofile
            // 
            this.tsmiprofile.ForeColor = System.Drawing.Color.White;
            this.tsmiprofile.Name = "tsmiprofile";
            this.tsmiprofile.Size = new System.Drawing.Size(66, 26);
            this.tsmiprofile.Text = "Profile";
            this.tsmiprofile.Click += new System.EventHandler(this.tsmiprofile_Click);
            // 
            // tsmicalculator
            // 
            this.tsmicalculator.ForeColor = System.Drawing.Color.White;
            this.tsmicalculator.Name = "tsmicalculator";
            this.tsmicalculator.Size = new System.Drawing.Size(90, 26);
            this.tsmicalculator.Text = "Calculator";
            this.tsmicalculator.Click += new System.EventHandler(this.tsmicalculator_Click);
            // 
            // btnmdiclose
            // 
            this.btnmdiclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.btnmdiclose.FlatAppearance.BorderSize = 0;
            this.btnmdiclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnmdiclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnmdiclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmdiclose.ForeColor = System.Drawing.Color.White;
            this.btnmdiclose.Location = new System.Drawing.Point(1071, 1);
            this.btnmdiclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnmdiclose.Name = "btnmdiclose";
            this.btnmdiclose.Size = new System.Drawing.Size(45, 28);
            this.btnmdiclose.TabIndex = 2;
            this.btnmdiclose.Text = "X";
            this.btnmdiclose.UseVisualStyleBackColor = false;
            this.btnmdiclose.Click += new System.EventHandler(this.btnmdiclose_Click);
            // 
            // itsm_info
            // 
            this.itsm_info.ForeColor = System.Drawing.Color.White;
            this.itsm_info.Name = "itsm_info";
            this.itsm_info.Size = new System.Drawing.Size(156, 24);
            this.itsm_info.Text = "Student Information";
            this.itsm_info.Click += new System.EventHandler(this.itsm_info_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 708);
            this.Controls.Add(this.btnmdiclose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIForm";
            this.Text = "MDIForm";
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MDIForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void itsmstudentinfo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiprofile;
        private System.Windows.Forms.ToolStripMenuItem tsmicalculator;
        private System.Windows.Forms.Button btnmdiclose;
        private System.Windows.Forms.ToolStripMenuItem itsm_info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}