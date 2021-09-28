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

namespace loginformp
{
    public partial class updateForm : Form
    {

        //string userID = userIDtxt.Text;//
       // string pword = nwpwordtxt.Text;//

        public updateForm()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update Guest set zipCode='" + nwpwordtxt.Text + "' where Id ='" + userIDtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records were updated succesfully");

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void nwpwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
