using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_Front_End
{
    public partial class flight_schdule : Form
    {
        Flight_Schedule F1 = new Flight_Schedule(22, 22);
        public flight_schdule()
        {
            InitializeComponent();
        }

        private void textBoxflightarrival_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnflightsch_Click(object sender, EventArgs e)
        {
            F1.flight_name = F_name.Text;
            F1.Date_sch = dateTimePicker1.Text;
            F1.Flight_arrival = textBoxflightarrival.Text;
            F1.Flight_capacity = int.Parse(textBoxflightcapacity.Text);
            F1.Booked = int.Parse(textBoxbooked.Text);
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
             string insertquery = "Insert into oop.flight_schedule(	Name,Date,arrival,capacity,booked) VALUES('" + F1.flight_name + "','" + F1.Date_sch + "','" + F1.Flight_arrival + "','" + F1.Flight_capacity + "','" + F1.Booked + "') ;";
           
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from flight_schedule where name='" + this.F_name.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void F_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void flight_schdule_Load(object sender, EventArgs e)
        {

        }
    }
}
