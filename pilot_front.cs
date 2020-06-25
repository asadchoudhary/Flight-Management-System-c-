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
    public partial class pilot_front : Form
    {
        Pilot p1 = new Pilot("2 years");
        public pilot_front()
        {
            InitializeComponent();
        }

        private void pilot_front_Load(object sender, EventArgs e)
        {

        }

        private void textBoxcaname_TextChanged(object sender, EventArgs e)
        {
            p1.name = textBoxcaname.Text;
            
        }

        private void Submitbtncainfo_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from pilot where name='" + this.textBoxcaname.Text + "';";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBoxcaaddress_TextChanged(object sender, EventArgs e)
        {
            p1.address = textBoxcaaddress.Text;
        }

        private void textBoxcaage_TextChanged(object sender, EventArgs e)
        {
            p1.age = int.Parse(textBoxcaage.Text);
        }

        private void textBoxcacnic_TextChanged(object sender, EventArgs e)
        {
            p1.Cnic = (textBoxcacnic.Text);
        }

        private void textBoxcacionfo_TextChanged(object sender, EventArgs e)
        {
            p1.Contact_info = int.Parse(textBoxcacionfo.Text);
        }

        private void comboboxcamalefemale_SelectedIndexChanged(object sender, EventArgs e)
        {
            p1.gender = comboboxcamalefemale.Text;
        }

        private void textBoxexperience_TextChanged(object sender, EventArgs e)
        {
            p1.p_experience = textBoxexperience.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.pilot(name,address,	CNIC,	Age,Gender,pilot_experience) VALUES('" + p1.name + "','" + p1.address + "','" + p1.Cnic + "','" + p1.age + "','"  + p1.gender + "','" + p1.p_experience + "') ;";
            con.Open();
            MySqlCommand comm = new MySqlCommand(insertquery, con);
            if (comm.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }
    }
}
