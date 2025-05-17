using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_ManagementSystem
{
    public partial class Leaves : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string constr = ConfigurationManager.ConnectionStrings["conn"].ToString();
        DataSet ds;
        DataTable dt;
        DataRow dr;
        SqlDataAdapter da;
        public Leaves()
        {
            InitializeComponent();
            List<string> options = new List<string> { "Leaves", "Employee" };
            combTables.DataSource = options;
            List<string> optionsStatus = new List<string> { "Pending", "Approved","Rejected" };
            combStatus.DataSource = optionsStatus;
            List<string> optionsLeaveT = new List<string> { "Casual", "Sick","Paid","Unpaid","Marriage" };
            combLeaveType.DataSource = optionsLeaveT;
        }

        public void LoadLeavesData()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_ShowLeave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ShowLeave";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
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
        private void lblEmpList_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_InsertLeave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertLeave";
            con.Open();
            cmd.Parameters.AddWithValue("@EmpID", txtId.Text);
            cmd.Parameters.AddWithValue("@Name", txtEname.Text);
            cmd.Parameters.AddWithValue("@LeaveReason", richtxtLeaveReson.Text);
            cmd.Parameters.AddWithValue("@LeaveType", combLeaveType.Text);
            cmd.Parameters.AddWithValue("@LeaveSD", datetimeLSD.Text);
            cmd.Parameters.AddWithValue("@LeaveED", dateTimeLED.Text);
            cmd.Parameters.AddWithValue("@Status", combStatus.Text);
            Int64 result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                MessageBox.Show("Record Inserted");
                LoadLeavesData();
            }
            else
            {
                MessageBox.Show("Record not inserted");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Leaves_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTables_Click(object sender, EventArgs e)
        {

        }

        private void combTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedType = combTables.SelectedItem.ToString();
            if (selectedType == "Leaves" )
            {
                LoadLeavesData();
            }
            else if (selectedType == "Employee")
            {

                LoadEmpData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedType = combTables.SelectedItem.ToString();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (selectedType == "Employee")
            {

                txtId.Text = row.Cells[0].Value.ToString();
                txtEname.Text = row.Cells[1].Value.ToString();
            }

            else if (selectedType == "Leaves")
            {

                txtId.Text = row.Cells[0].Value.ToString();
                txtEname.Text = row.Cells[1].Value.ToString();
                richtxtLeaveReson.Text = row.Cells[2].Value.ToString();
                combLeaveType.Text = row.Cells[3].Value.ToString();
                datetimeLSD.Value = Convert.ToDateTime(row.Cells["LeaveSD"].Value);
                dateTimeLED.Value = Convert.ToDateTime(row.Cells["LeaveED"].Value);
                combStatus.Text = row.Cells[6].Value.ToString();
            }
        }

        private void lblLeaveReports_Click(object sender, EventArgs e)
        {
            LeaveReport l = new LeaveReport();
            l.Show();
            this.Close();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_UpdateLeave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateLeave";
            con.Open();

            cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtId.Text));
            cmd.Parameters.AddWithValue("@Name", txtEname.Text);
            cmd.Parameters.AddWithValue("@LeaveReason", richtxtLeaveReson.Text);
            cmd.Parameters.AddWithValue("@Leave_type", combLeaveType.Text);
            cmd.Parameters.AddWithValue("@LeaveSD", datetimeLSD.Value);
            cmd.Parameters.AddWithValue("@LeaveED", dateTimeLED.Value);
            cmd.Parameters.AddWithValue("@Status", combStatus.Text);


            int result = cmd.ExecuteNonQuery();

            if (result != 0)
            {
                MessageBox.Show("Record Updated Successfully");
                LoadLeavesData();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_DeleteLeave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DeleteLeave";
            con.Open();

            cmd.Parameters.AddWithValue("@EmpID", Convert.ToInt32(txtId.Text));


            int result = cmd.ExecuteNonQuery();

            if (result != 0)
            {
                MessageBox.Show("Record Deleted Successfully");
                LoadLeavesData();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
