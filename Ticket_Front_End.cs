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
    public partial class Ticket_Front_End : Form
    {
        Ticket t1 = new Ticket();
        public Ticket_Front_End()
        {
            InitializeComponent();
        }

        private void buttonticketadd_Click(object sender, EventArgs e)
        {
            this.Hide();
          t1.ticket_no = textBoxticketno.Text;
          t1.ticket_type = tickettype.Text;
          t1.payment = textBoxpaymebt.Text;
       //   t1.no_of_passengers = int.Parse(textBoxnoofpassengers.Text);
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.customer_details(	Ticket_No,No_of_Passenger,Payment,Ticket_type) VALUES('" + t1.ticket_no + "','" + t1.no_of_passengers + "','" + t1.payment + "','" + t1.ticket_type + "') ;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from customer_details where Ticket_No='" + this.textBoxticketno.Text + "';";
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

        private void textBoxticketno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
