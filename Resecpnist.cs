using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Front_End
{
    public partial class Resecpnist : Form
    {
        public Resecpnist()
        {
            InitializeComponent();
        }

        private void addPlaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plane_Front_end pl = new Plane_Front_end();
            pl.Show();
        }

        private void addPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Front_end cf = new Customer_Front_end();
            cf.Show();
        }

        private void addTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_Front_End tk = new Ticket_Front_End();
            tk.Show();
        }

        private void passengerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
