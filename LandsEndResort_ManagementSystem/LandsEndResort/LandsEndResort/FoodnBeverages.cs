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

namespace hotel
{
    public partial class FoodnBeverages : Form
    {
        int id = 0;
        public FoodnBeverages()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = id + 1;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            String Spicyrice = "";
            String Nasigoreng = "";
            String Chikenbiriyani = "";
            String Lasangna = "";
            String Coffee = "";
            String Tea = "";
            String PlainTea = "";
            String Other = "";


            if (checkBox1.Checked)
            {
                Spicyrice = "Spicy rice";
            }
            else
            {
                Spicyrice = "";
            }
            if (checkBox2.Checked)
            {
                Nasigoreng = "Nasi goreng";
            }
            else
            {
                Nasigoreng = "";
            }
            if (checkBox3.Checked)
            {
                Chikenbiriyani = "Chiken biriyani";
            }
            else
            {
                Chikenbiriyani = "";
            }
            if (checkBox4.Checked)
            {
                Lasangna = "Lasangna";
            }
            else
            {
                Lasangna = "";
            }
            if (checkBox5.Checked)
            {
                Coffee = "Coffee";
            }
            else
            {
                Coffee = "";
            }
            if (checkBox6.Checked)
            {
                Tea = "Tea";
            }
            else
            {
                Tea = "";
            }
            if (checkBox7.Checked)
            {
                PlainTea = "Plain Tea";
            }
            else
            {
                PlainTea = "";
            }
            if (checkBox8.Checked)
            {
                Other = "Other";
            }
            else
            {
                Other = "";
            }

            string query = "insert into Order(Id,Spicyrice,Nasigoreng,Chikenbiriyani,Lasangna,Coffee,Tea,PlainTea,Other,Comments)values ('" + id + "', '" + Spicyrice + "','" + Nasigoreng + "','" + Chikenbiriyani + "','" + Lasangna + "','" + Coffee + "','" + Tea + "', '" + PlainTea + "', '" + Other + "', '" + this.textBox1.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Fail");
            }
            con.Close();
        

        }

        private void FoodnBeverages_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();
        }
    }
}
