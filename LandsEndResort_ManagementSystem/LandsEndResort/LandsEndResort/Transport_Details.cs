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
    public partial class Transport_Details : Form
    {
        public Transport_Details()
        {
            InitializeComponent();
        }


        private void btn_showtransport_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            String queryy = "insert into Transport(Id, Destination, ArrivalTime, DepatureTime, DriverName, PhoneNumber) values (1,'Colombo','7am','6am','ABC','0711238904')";
            SqlCommand cmd = new SqlCommand(queryy, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("records added successfully");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM  Transport";

            SqlDataAdapter adaptor = new SqlDataAdapter(query, conString);
            DataSet Set = new DataSet();
            adaptor.Fill(Set, "Transport");

            dataGridView_transport.DataSource = Set.Tables["Transport"];

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Welcome sw = new Staff_Welcome();
            sw.ShowDialog();
        }
    }
}
