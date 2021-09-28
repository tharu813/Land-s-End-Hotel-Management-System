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
using HotelManagementSystem;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Salary, Discount, Total,Profit;
            Salary = float.Parse(textBox3.Text);
            Discount = float.Parse(textBox4.Text);
            Total = Salary + Salary * (Discount / 100);
            Profit = Salary * (Discount / 100);
            textBox5.Text = "" + Total;
            textBox6.Text = "" + Profit;

        }
        private void combobox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Donotdelete\salary.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "select * from Salarytable";
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
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Donotdelete\salary.mdf;Integrated Security=True;Connect Timeout=30");
                string sql = "select * from salarytable where Department='" + comboBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        string Id = myreader.GetInt32(0).ToString();
                        string Department = myreader.GetString(1);
                        string Job = myreader.GetString(2);
                        string Salary = myreader.GetInt32(3).ToString();
                        string Discount = myreader.GetInt32(4).ToString();


                        textBox1.Text = Job;
                        textBox2.Text = Id;
                        textBox3.Text = Salary;
                        textBox4.Text = Discount;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["Department", row].Value = comboBox1.Text;
            dataGridView1["Job", row].Value = textBox1.Text;
            dataGridView1["Total", row].Value = textBox5.Text;


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Welcome sw2 = new Staff_Welcome();
            sw2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}