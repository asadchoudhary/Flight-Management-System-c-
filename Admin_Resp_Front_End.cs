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
    public partial class Admin_Res : Form
    {
        public Admin_Res()
        {
            InitializeComponent();
        }

        private void labelflightdate_Click(object sender, EventArgs e)
        {
                  
        }

        private void Admin_Res_Load(object sender, EventArgs e)
        {

        } 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Pilot ans = new Pilot("4 years");
            Admin ad = new Admin(ans);
            Console.WriteLine(ad.pl.id);
        }

        private void Submitbtnadmin_Click(object sender, EventArgs e)
        {

           // Route mnobj = new Route();
          //  Admin robject = new Admin(mnobj);
            
        }

        private void comboBoxCA_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabin_Attendent cabat = new Cabin_Attendent("Evening");
            Admin caa = new Admin(cabat);
            Console.WriteLine(caa.ca.name);

        }

        private void textBoxrtidadmin_TextChanged(object sender, EventArgs e)
        {
            Route mnobj = new Route();
            Admin robject = new Admin(mnobj);
            Route_Front_End an = new Route_Front_End();
           // an.ridfun();
            Console.WriteLine(robject.r.Route_id);
            
        }

        private void textBoxairportcodeadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxairportlocationadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxairportcountryadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flightSchdleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            flight_schdule fl = new flight_schdule();
            fl.Show();
            
        }
    }
}
