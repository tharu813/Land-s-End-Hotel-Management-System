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
using System.Linq.Expressions;
using hotel;

namespace LandsEndResort
{
    public partial class maintain : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Donotdelete\insert.mdf;Integrated Security=True;Connect Timeout=30");
        public maintain()
        {
            InitializeComponent();
            combobox();
        }

        private void maintain_Load(object sender, EventArgs e)
        {

        }
        private void combobox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Donotdelete\ineventory3.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "select * from maintaintable";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    comboBox1.Items.Add(sname);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Donotdelete\ineventory3.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "select * from maintaintable  where Maintannance='" + comboBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Id = myreader.GetInt32(0).ToString();
                    string Maintannance = myreader.GetString(1);
                    textBox1.Text = Id;
                    textBox2.Text = Maintannance;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                {
                    SqlCommand sqlCmd = new SqlCommand("maintaintedit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("Id", 0);
                    sqlCmd.Parameters.AddWithValue("@Maintain", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Complian", textBox3.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodnBeverages f1 = new FoodnBeverages();
            f1.ShowDialog();

        }
    }
}
    

