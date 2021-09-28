using LandsEndResort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication16;

namespace HotelManagementSystem
{
    public partial class Staff_Welcome : Form
    {
        public Staff_Welcome()
        {
            InitializeComponent();
        }

        private void radbtn_salary_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radbtn_leaves_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Leaves ld = new Leaves();
            ld.ShowDialog();
        }

        private void radbtn_transport_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Details td = new Transport_Details();
            td.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w1 = new Welcome();
            w1.ShowDialog();
        }
    }
}
