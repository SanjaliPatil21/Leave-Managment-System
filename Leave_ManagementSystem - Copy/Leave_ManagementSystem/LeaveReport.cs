using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class LeaveReport : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string constr = ConfigurationManager.ConnectionStrings["conn"].ToString();
        DataSet ds;
        DataTable dt;
        DataRow dr;
        SqlDataAdapter da;
        public LeaveReport()
        {
            InitializeComponent();
            List<string> LeaveReportsOp = new List<string> {"All", "Approved", "Pending", "Rejected"};
            combSort.DataSource = LeaveReportsOp;
        }

        public void LoadLeaveAll()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_LeaveReports", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LeaveReports";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }
        public void LoadRejected()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_LeaveReportsRejected", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LeaveReportsRejected";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }
        public void LoadApproved()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_LeaveReportsApproved", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LeaveReportsApproved";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }
        public void LoadPending()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_LeaveReportsPending", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LeaveReportsPending";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void lblLeaveReport_Click(object sender, EventArgs e)
        {

        }

        private void lblLeave_Click(object sender, EventArgs e)
        {
            Leaves l = new Leaves();
            l.Show();
            this.Close();
        }

        private void lblLeaveReportsList_Click(object sender, EventArgs e)
        {
      
        }

        private void LeaveReport_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand("sp_LeaveReports", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LeaveReports";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }

        private void combSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = combSort.SelectedItem.ToString();
            if (selectedType == "All")
            {
               LoadLeaveAll(); 
            }
            else if (selectedType == "Approved")
            {
                LoadApproved();

            }
            else if (selectedType == "Pending")
            {
                LoadPending();
            }
            else if(selectedType == "Rejected")
            {
                LoadRejected();
            }
        }
    }
}
