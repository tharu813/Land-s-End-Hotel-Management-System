using HotelManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration
{
    public partial class Staff_LoginForm : Form
    {
        public Staff_LoginForm()
        {
            InitializeComponent();
        }

        private void Staff_LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtUid_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //exit
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //minimize
        private void minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THARUSHI\Documents\LandsEndResortDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Staff WHERE Id = '" +TxtUid.Text+ "' and Password = '" + TxtPw.Text+ "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query,constring);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Staff_Welcome swel = new Staff_Welcome();
                swel.ShowDialog();

            }
            else
            {
                MessageBox.Show("Check user id and password");
            }
        }

        //moveable borderless window
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);

            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) 
        {
            this.pictureBox1.BackColor = Color.Red;
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.DimGray;
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Staff_SignUpForm f1 = new Staff_SignUpForm();
            f1.ShowDialog();
            
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
