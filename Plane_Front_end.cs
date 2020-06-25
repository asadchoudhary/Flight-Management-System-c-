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
    public partial class Plane_Front_end : Form
    {
        Plane p1 = new Plane();
        public Plane_Front_end()
        {
            InitializeComponent();
        }

        private void textBoxplanename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.Name = textBoxplanename.Text;
            p1.Code = textBoxplancecode.Text;
            p1.Capacity =int.Parse( textBoxplancecapacity.Text);
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.plane(name,code,capacity) VALUES('" + p1.Name + "','" + p1.Code + "','" + p1.Capacity + "') ;";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from plane where code='" + this.textBoxplancecode.Text + "';";
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
