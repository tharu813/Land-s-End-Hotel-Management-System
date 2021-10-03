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

namespace HotelManagementSystem
{
    public partial class leavereq : Form
    {
        public leavereq()
        {
            InitializeComponent();
        }

        private void btn_lreq_Click(object sender, EventArgs e)
        {
            String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM LeaveRequests";

            SqlDataAdapter adaptor = new SqlDataAdapter(query, constring);
            DataSet set = new DataSet();
            adaptor.Fill(set, "LeaveRequests");
            dataGridView_lreq.DataSource = set.Tables["LeaveRequests"];
        }
    }
}
