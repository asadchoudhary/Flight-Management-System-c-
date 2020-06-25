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
    public partial class AdminRes : Form
    {
        public AdminRes()
        {
            InitializeComponent();
        }

        private void flightSchdleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Res ad = new Admin_Res();
            ad.Show();
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Route_Front_End rt = new Route_Front_End();
            rt.Show();
            return;
        }

        private void cabinAttendentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Queries_Front_End qr = new Queries_Front_End();
            qr.Show();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addFlightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            int a=42;
            int b=10;
            Flight_Schedule fl = new Flight_Schedule(a,b);
            this.Show();
        }

        private void addRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Route_Front_End rt = new Route_Front_End();
            rt.Show();
        }

        private void addCabinAttendentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CA_Front_End cf = new CA_Front_End();
            cf.Show();
        }

        private void addAirportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airport_Front_End ar = new Airport_Front_End();
            ar.Show();
        }

        private void addPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resecpnist rt = new Resecpnist();
            rt.Show();
        }

        private void addPilotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pilot_front pl = new pilot_front();
            pl.Show();
        }

        private void AdminRes_Load(object sender, EventArgs e)
        {

        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void performActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_Res a1 = new Admin_Res();
            a1.Show();
        }
    }
}
