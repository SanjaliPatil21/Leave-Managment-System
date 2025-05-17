namespace Leave_ManagementSystem
{
    partial class LeaveReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveReport));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.picLeave = new System.Windows.Forms.PictureBox();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.lblLeaveReport = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.lblLeaveReportsList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.combSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(58, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leave Management System";
            // 
            // picReport
            // 
            this.picReport.Image = ((System.Drawing.Image)(resources.GetObject("picReport.Image")));
            this.picReport.Location = new System.Drawing.Point(16, 153);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(38, 38);
            this.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReport.TabIndex = 7;
            this.picReport.TabStop = false;
            // 
            // picLeave
            // 
            this.picLeave.Image = ((System.Drawing.Image)(resources.GetObject("picLeave.Image")));
            this.picLeave.Location = new System.Drawing.Point(16, 88);
            this.picLeave.Name = "picLeave";
            this.picLeave.Size = new System.Drawing.Size(38, 38);
            this.picLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeave.TabIndex = 6;
            this.picLeave.TabStop = false;
            // 
            // picEmp
            // 
            this.picEmp.Image = ((System.Drawing.Image)(resources.GetObject("picEmp.Image")));
            this.picEmp.Location = new System.Drawing.Point(16, 32);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(38, 38);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmp.TabIndex = 2;
            this.picEmp.TabStop = false;
            // 
            // lblLeaveReport
            // 
            this.lblLeaveReport.AutoSize = true;
            this.lblLeaveReport.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblLeaveReport.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblLeaveReport.Location = new System.Drawing.Point(60, 153);
            this.lblLeaveReport.Name = "lblLeaveReport";
            this.lblLeaveReport.Size = new System.Drawing.Size(129, 24);
            this.lblLeaveReport.TabIndex = 5;
            this.lblLeaveReport.Text = "Leave Reports";
            this.lblLeaveReport.Click += new System.EventHandler(this.lblLeaveReport_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEmployee.Location = new System.Drawing.Point(60, 32);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(100, 24);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "Employees";
            this.lblEmployee.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblLeave.Location = new System.Drawing.Point(60, 88);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(66, 24);
            this.lblLeave.TabIndex = 3;
            this.lblLeave.Text = "Leaves";
            this.lblLeave.Click += new System.EventHandler(this.lblLeave_Click);
            // 
            // lblLeaveReportsList
            // 
            this.lblLeaveReportsList.AutoSize = true;
            this.lblLeaveReportsList.BackColor = System.Drawing.Color.DarkViolet;
            this.lblLeaveReportsList.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveReportsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblLeaveReportsList.Location = new System.Drawing.Point(516, 78);
            this.lblLeaveReportsList.Name = "lblLeaveReportsList";
            this.lblLeaveReportsList.Size = new System.Drawing.Size(158, 24);
            this.lblLeaveReportsList.TabIndex = 62;
            this.lblLeaveReportsList.Text = "Leave Report List";
            this.lblLeaveReportsList.Click += new System.EventHandler(this.lblLeaveReportsList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Plum;
            this.dataGridView1.Location = new System.Drawing.Point(206, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 452);
            this.dataGridView1.TabIndex = 63;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Thistle;
            this.pnlSide.Controls.Add(this.picReport);
            this.pnlSide.Controls.Add(this.picLeave);
            this.pnlSide.Controls.Add(this.picEmp);
            this.pnlSide.Controls.Add(this.lblLeaveReport);
            this.pnlSide.Controls.Add(this.lblEmployee);
            this.pnlSide.Controls.Add(this.lblLeave);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 63);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(199, 497);
            this.pnlSide.TabIndex = 61;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 560);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(967, 19);
            this.pnlBottom.TabIndex = 60;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlTop.Controls.Add(this.picClose);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(967, 63);
            this.pnlTop.TabIndex = 59;
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(917, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(38, 38);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // combSort
            // 
            this.combSort.FormattingEnabled = true;
            this.combSort.Location = new System.Drawing.Point(805, 75);
            this.combSort.Name = "combSort";
            this.combSort.Size = new System.Drawing.Size(150, 24);
            this.combSort.TabIndex = 65;
            this.combSort.SelectedIndexChanged += new System.EventHandler(this.combSort_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(744, 75);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(62, 21);
            this.lblSort.TabIndex = 64;
            this.lblSort.Text = "Sort By";
            // 
            // LeaveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.combSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblLeaveReportsList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveReport";
            this.Load += new System.EventHandler(this.LeaveReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.PictureBox picLeave;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.Label lblLeaveReport;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label lblLeaveReportsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.ComboBox combSort;
        private System.Windows.Forms.Label lblSort;
    }
}