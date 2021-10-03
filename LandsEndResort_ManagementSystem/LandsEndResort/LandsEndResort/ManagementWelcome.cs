using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ManagementWelcome : Form
    {
        public ManagementWelcome()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Com_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_order_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            viewOrders orders = new viewOrders();
            orders.ShowDialog();
        }

        private void radioButton_lreq_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            leavereq req = new leavereq();
            req.ShowDialog();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.Hide();
            checkComplaints comp = new checkComplaints();
            comp.ShowDialog();
        }
    }
}
