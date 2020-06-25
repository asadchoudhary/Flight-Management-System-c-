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
    public partial class Airport_Front_End : Form
    {
        public Airport_Front_End()
        {
            InitializeComponent();
        }

        private void textBoxairportname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // string dbconnect = Airport.dbconn();
            //MySqlConnection con = new MySqlConnection(dbconnect);
            //con.Open();
             // if (con.State==ConnectionState.Open)
             //{
             //MessageBox.Show("Database Connected");
            //}
            //else
            //{
             //MessageBox.Show("Not Connected");
            //}
            Airport ar1 = new Airport();
           //MySqlConnection con = new MySqlConnection(dbconnect);
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
           string insertquery = "Insert into oop.airport(Airport_Name,Airport_Location,Airport_Code,Airport_Country) VALUES('" +ar1.A_name + "','" + ar1.A_location + "','" + ar1.A_code + "','" + ar1.A_country+ "') ;";
          // string insertquery = ("Insert into oop.info() VALUES(" +textBoxpname.Text + "," + textBoxaddress+ ","+textBoxcnic.Text+","+textBoxage.Text+","+textBoxcionfo.Text+","+comboboxmalefemale.Text+","+textBoxticketno.Text+","+textBoxnoofpassengers.Text+","+textBoxpaymebt.Text+","+textBoxpassport.Text+","+textBoxemail.Text+")");
            con.Open();
            MySqlCommand comm = new MySqlCommand(insertquery, con);
            if (comm.ExecuteNonQuery() == 1)
           {
             MessageBox.Show("Data Inserted");
           }
            //else
            //{
             //   MessageBox.Show("Not Inserted");
            //}
          //  con.Close();
        }

        private void textBoxairname_TextChanged(object sender, EventArgs e)
        {
            Airport ar1 = new Airport();
            ar1.A_name = textBoxairname.Text;
        }

        private void comboBoxairportcountery_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airport ar = new Airport();
            ar.A_country = comboBoxairportcountery.Text;
        }

        private void textBoxaircode_TextChanged(object sender, EventArgs e)
        {
            Airport ar = new Airport();
            ar.A_code = textBoxaircode.Text;
        }

        private void comboBoxairportlocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airport ar = new Airport();
            ar.A_location = comboBoxairportlocation.Text;
        }
    }
}
