using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Leave_ManagementSystem
{
    public partial class Home : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string constr= ConfigurationManager.ConnectionStrings["conn"].ToString();
        DataSet ds;
        DataTable dt;
        DataRow dr;
        SqlDataAdapter da;

        public Home()
        {
            InitializeComponent();
            txtEname.TabIndex = 0;
            txtMobileNo.TabIndex = 1;
            txtAddress.TabIndex = 2;
            combGender.TabIndex = 3;
            datetimeDOB.TabIndex = 4;
            combMaritalStatus.TabIndex = 5;
            combDept.TabIndex = 6;
            List<string> options = new List<string> { "Male", "Female", "Others" };
            combGender.DataSource = options;
            List<string> optionsMS = new List<string> { "Married", "Single" };
            combMaritalStatus.DataSource = optionsMS;
            List<string> optionsDept = new List<string> { "IT", "Accounts","Finance","HR" };
            combDept.DataSource = optionsDept;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        public void LoadEmpData()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_Show", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Show";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_Insert",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Insert";
            cmd.CommandText = "sp_Insert";
            cmd.CommandText = "sp_Insert";
            cmd.CommandText = "sp_Insert";
            con.Open();
            
            cmd.Parameters.AddWithValue("@Name",txtEname.Text);
            cmd.Parameters.AddWithValue("@MobileNo", Convert.ToInt64(txtMobileNo.Text));
            cmd.Parameters.AddWithValue("@Address",txtAddress.Text);
            cmd.Parameters.AddWithValue("@Department",combDept.Text);
            cmd.Parameters.AddWithValue("@Gender",combGender.Text);
            cmd.Parameters.AddWithValue("@Dob", datetimeDOB.Value);
            cmd.Parameters.AddWithValue("@Marital_Status", combMaritalStatus.Text);
            Int64 result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                MessageBox.Show("Record Inserted");
                LoadEmpData();
            }
            else
            {
                MessageBox.Show("Record not inserted");
            }



        }

        
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            LoadEmpData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_Updates", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Updates";
            con.Open();

            cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtId.Text));
            cmd.Parameters.AddWithValue("@Name", txtEname.Text);
            cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Department", combDept.Text);
            cmd.Parameters.AddWithValue("@Gender", combGender.Text);
            cmd.Parameters.AddWithValue("@Dob", datetimeDOB.Value);
            cmd.Parameters.AddWithValue("@Marital_Status", combMaritalStatus.Text);

            int result = cmd.ExecuteNonQuery();

            if (result != 0)
            {
                MessageBox.Show("Record Updated Successfully");
                LoadEmpData();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Delete";
            con.Open();

            cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtId.Text));
            

            int result = cmd.ExecuteNonQuery();

            if (result != 0)
            {
                MessageBox.Show("Record Deleted Successfully");
                LoadEmpData();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void lblLeave_Click(object sender, EventArgs e)
        {
            Leaves l = new Leaves();
            l.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LeaveReport l = new LeaveReport();
            l.Show();
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtEname.Text = row.Cells[1].Value.ToString();
            txtMobileNo.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            combDept.Text = row.Cells[4].Value.ToString();
            combGender.Text = row.Cells[5].Value.ToString();
            datetimeDOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
            combMaritalStatus.Text = row.Cells[7].Value.ToString();

        }
    }
}
