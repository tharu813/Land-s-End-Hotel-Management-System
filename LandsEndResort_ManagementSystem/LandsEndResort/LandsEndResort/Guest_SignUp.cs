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
using loginformp;

namespace guestRegi
{
    public partial class Guest_SignUp : Form
    {
        int id = 0;
        public Guest_SignUp()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void firstlbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrivallbl_Click(object sender, EventArgs e)
        {

        }

        private void flight2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bookingdetailslbl_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            id = id + 1;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Guest(Id,lastName,firstName,dob,nationality,arrivalDate,flightNumber,aTime,depatureDate,dFlight,dTime,passport,dateofIssue,zipCode,country,telephone,email,fax) values('" + id + "','" + lnametxt.Text + "','" + Fnametxt.Text + "','" + dobtxt.Text + "','" + nationaltxt.Text + "','" + arrivaltxt.Text + "','" + flighttxt.Text + "','" + textBox1.Text + "','" + depaturetxt.Text + "','" + flight2txt.Text + "','" + time2txt.Text + "','" + useidtxt.Text + "','" + doitxt.Text + "','" + ziptxt.Text + "','" + countrytxt.Text + "','" + teletxt.Text + "','" + emailtxt.Text + "','" + faxtxt.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                MessageBox.Show("hello");
                cmd.ExecuteNonQuery();
                MessageBox.Show("records added");
                con.Close();
            }

            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }



        private void faxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bTNLOGIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest_Login gl = new Guest_Login();
            gl.ShowDialog();
        }
    }
}
