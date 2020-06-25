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
    public partial class Queries_Front_End : Form
    {
        Inqueries in1 = new Inqueries();
        public Queries_Front_End()
        {
            InitializeComponent();
        }

        private void Addbtninq_Click(object sender, EventArgs e)
        {
            string dbconn = Person.dbconn();
           // MySqlConnection con = new MySqlConnection(dbconn);
             in1.inq_date = textBoxenqid.Text;
             in1.inq_type = comboboxinqtype.Text;
            in1.inq_id = textBoxenqid.Text;
            in1.inq_title=textBoxinqtitle.Text;
            in1.inq_description = textBoxinqdet.Text;
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.enquiries	(inq_id,inq_type,inq_title,inq_description) VALUES('" + in1.inq_id + "','" + in1.inq_type + "','" + in1.inq_id + "','" + in1.inq_title + "','" + in1.inq_description + "') ;";
            
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from enquiries where inq_id ='" + this.textBoxenqid.Text + "';";
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

        private void textBoxenqid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
