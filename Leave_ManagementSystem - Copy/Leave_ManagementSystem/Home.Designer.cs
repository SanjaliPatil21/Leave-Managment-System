namespace Leave_ManagementSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.picLeave = new System.Windows.Forms.PictureBox();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.lblEname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEmpList = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.datetimeDOB = new System.Windows.Forms.DateTimePicker();
            this.combGender = new System.Windows.Forms.ComboBox();
            this.combMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblManageEmployees = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTop.TabIndex = 0;
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(917, 9);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(38, 38);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Thistle;
            this.pnlSide.Controls.Add(this.picReport);
            this.pnlSide.Controls.Add(this.picLeave);
            this.pnlSide.Controls.Add(this.picEmp);
            this.pnlSide.Controls.Add(this.label2);
            this.pnlSide.Controls.Add(this.lblEmployee);
            this.pnlSide.Controls.Add(this.lblLeave);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 63);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(199, 497);
            this.pnlSide.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(60, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leave Reports";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEname.Location = new System.Drawing.Point(218, 154);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(51, 21);
            this.lblEname.TabIndex = 3;
            this.lblEname.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(218, 233);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 21);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNo.Location = new System.Drawing.Point(218, 195);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMobileNo.Size = new System.Drawing.Size(88, 21);
            this.lblMobileNo.TabIndex = 6;
            this.lblMobileNo.Text = "Mobile No.";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(518, 232);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(93, 21);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(323, 151);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(150, 22);
            this.txtEname.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(323, 231);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(638, 232);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(150, 22);
            this.txtDepartment.TabIndex = 11;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(323, 192);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(150, 22);
            this.txtMobileNo.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Thistle;
            this.btnInsert.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(858, 107);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 34);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Thistle;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(858, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(858, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Thistle;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(858, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Plum;
            this.dataGridView1.Location = new System.Drawing.Point(205, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 241);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblEmpList
            // 
            this.lblEmpList.AutoSize = true;
            this.lblEmpList.BackColor = System.Drawing.Color.DarkViolet;
            this.lblEmpList.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblEmpList.Location = new System.Drawing.Point(500, 292);
            this.lblEmpList.Name = "lblEmpList";
            this.lblEmpList.Size = new System.Drawing.Size(129, 24);
            this.lblEmpList.TabIndex = 8;
            this.lblEmpList.Text = "Employee List";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 560);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(967, 19);
            this.pnlBottom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Location = new System.Drawing.Point(197, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 11);
            this.panel1.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(218, 121);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(99, 21);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Employee ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(323, 120);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 22);
            this.txtId.TabIndex = 20;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(518, 120);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 21);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(518, 151);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(45, 21);
            this.lblDob.TabIndex = 22;
            this.lblDob.Text = "DOB";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(518, 195);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(111, 21);
            this.lblMaritalStatus.TabIndex = 23;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // datetimeDOB
            // 
            this.datetimeDOB.Location = new System.Drawing.Point(635, 149);
            this.datetimeDOB.Name = "datetimeDOB";
            this.datetimeDOB.Size = new System.Drawing.Size(150, 22);
            this.datetimeDOB.TabIndex = 24;
            // 
            // combGender
            // 
            this.combGender.FormattingEnabled = true;
            this.combGender.Location = new System.Drawing.Point(635, 109);
            this.combGender.Name = "combGender";
            this.combGender.Size = new System.Drawing.Size(150, 24);
            this.combGender.TabIndex = 25;
            // 
            // combMaritalStatus
            // 
            this.combMaritalStatus.FormattingEnabled = true;
            this.combMaritalStatus.Location = new System.Drawing.Point(635, 192);
            this.combMaritalStatus.Name = "combMaritalStatus";
            this.combMaritalStatus.Size = new System.Drawing.Size(150, 24);
            this.combMaritalStatus.TabIndex = 26;
            // 
            // lblManageEmployees
            // 
            this.lblManageEmployees.AutoSize = true;
            this.lblManageEmployees.BackColor = System.Drawing.Color.DarkViolet;
            this.lblManageEmployees.Font = new System.Drawing.Font("Palatino Linotype", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblManageEmployees.Location = new System.Drawing.Point(472, 66);
            this.lblManageEmployees.Name = "lblManageEmployees";
            this.lblManageEmployees.Size = new System.Drawing.Size(189, 27);
            this.lblManageEmployees.TabIndex = 27;
            this.lblManageEmployees.Text = "Manage Employees";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.lblManageEmployees);
            this.Controls.Add(this.combMaritalStatus);
            this.Controls.Add(this.combGender);
            this.Controls.Add(this.datetimeDOB);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmpList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEname);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLeave;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEmpList;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.DateTimePicker datetimeDOB;
        private System.Windows.Forms.ComboBox combGender;
        private System.Windows.Forms.ComboBox combMaritalStatus;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblManageEmployees;
    }
}

