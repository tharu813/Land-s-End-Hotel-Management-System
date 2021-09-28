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
    public partial class Leaves : Form
    {
        
        public Leaves()
        {
            InitializeComponent();
        }

        private void btn_sendreq_Click(object sender, EventArgs e)
        {
            
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            string Query = "insert into LeaveRequests (Date, Reason, UserID)" +
                "values('" + this.dateTimePicker_leaves.Text + "','" + this.txt_reason.Text + "','" + this.txt_id.Text + "')";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Request has been sent successfully");
                while (myReader.Read())
                { }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbl_reqleave_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Welcome sw1 = new Staff_Welcome();
            sw1.ShowDialog();
        }
    }
}
