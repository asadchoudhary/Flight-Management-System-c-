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
    public partial class Route_Front_End : Form
    {
        Route rt = new Route();
        public Route_Front_End()
        {
            InitializeComponent();
        }

        private void Route_Front_End_Load(object sender, EventArgs e)
        {

        }

        private void textBoxrtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxrid_TextChanged(object sender, EventArgs e)
        {
          
            rt.Route_id = textBoxrid.Text;
    }
        public void ridfun()
        {
            string rid = textBoxrid.Text;
            Console.WriteLine(rid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.route(r_id,stay_time,Des_rt_dis) VALUES('" + rt.Route_id + "','" + rt.Stay_time + "','" + rt.Distance + "') ;";
          
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
            con.Close();
           // ridfun();
           // Admin_Res ads = new Admin_Res();
            //ads.Show();
           
        }

        private void textBoxstaytime_TextChanged(object sender, EventArgs e)
        {
            rt.Stay_time = textBoxstaytime.Text;
        }

        private void textBoxdistance_TextChanged(object sender, EventArgs e)
        {
            rt.Distance = textBoxdistance.Text;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from route where r_id='" + this.textBoxrid.Text + "';";
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
     
    }
}
