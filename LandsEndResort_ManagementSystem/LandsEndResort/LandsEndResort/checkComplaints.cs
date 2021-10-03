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
using LandsEndResort;

namespace HotelManagementSystem
{
    public partial class checkComplaints : Form
    {
        public checkComplaints()
        {
            InitializeComponent();
        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            /*String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Donotdelete\insert.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT Complain  FROM insertTable";
            //String query = "SELECT Comments FROM Housekeeping";
            

            SqlDataAdapter adaptor = new SqlDataAdapter(query, constring);
            DataSet set = new DataSet();
            adaptor.Fill(set, "insertTable");
            dataGridView_com.DataSource = set.Tables["insertTable"];*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();

        }
    }
}
