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

namespace Staff_Registration
{
    public partial class Staff_SignUpForm : Form
    {
        int id = 0;
        public Staff_SignUpForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtFname_TextChanged(object sender, EventArgs e)
        {
        }
       
        private void btnstaffRegister_Click(object sender, EventArgs e)
        {


            //MessageBox.Show("Button Clicked");
            id = id + 1;
            string name = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            
            SqlConnection con = new SqlConnection(name);
            string query = "insert into Staff(Id, FirstName, LastName, Email, Password, ContactNumber, Address, Department, Post) values('"+id+"' , '"+TxtFname.Text+"' , '"+TxtLname.Text+"', '"+TxtEmail.Text+"', '"+TxtPW.Text+"','"+TxtContact.Text+"', '"+TxtAddress.Text+"','"+TxtDept.Text+"' , '"+TxtPost.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                MessageBox.Show("Hello connection was successful");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added to staff member file sucessfully");
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

            if ((TxtFname.Text == "" || TxtLname.Text == "" || TxtEmail.Text == "" || TxtPW.Text == "" || TxtContact.Text == "" || TxtAddress.Text == "" || TxtDept.Text == "" || TxtPost.Text == ""))
            {
                MessageBox.Show("Registration Failed. \nYou have to enter your data into all the fields given ");
            }

            else
            {
                MessageBox.Show("Hi " + TxtFname.Text + "\nYou have registered successfully");
            }

        }

        private void Staff_SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_LoginForm lform = new Staff_LoginForm();
            lform.ShowDialog();
        }
    }
}
