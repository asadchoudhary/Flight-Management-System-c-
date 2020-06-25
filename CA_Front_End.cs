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
using System.Data.SqlClient;

namespace OOP_Front_End
{
    public partial class CA_Front_End : Form
    {

        Cabin_Attendent ca2 = new Cabin_Attendent("evening");
        public CA_Front_End()
        {
            InitializeComponent();
        }

        private void labelcnic_Click(object sender, EventArgs e)
        {

        }

        private void labelcaaddress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcaname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submitbtncainfo_Click(object sender, EventArgs e)
        {
            ca2.name = textBoxcaname.Text;
            ca2.address = textBoxcaaddress.Text;
            ca2.gender = comboboxcamalefemale.Text;
            ca2.Contact_info = long.Parse(textBoxcacionfo.Text);
            ca2.Cnic = textBoxcacnic.Text;
            ca2.shift_ca = comboBoxcashift.Text;
            ca2.age = int.Parse(textBoxcaage.Text);
            // ca2.add_ca();
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.Cabin_attendent(name,address,	CNIC,	Age,	Contact_No,Gender, shift) VALUES('" + ca2.name + "','" + ca2.address + "','" + ca2.Cnic + "','" + ca2.age + "','" + ca2.Contact_info + "','" + ca2.gender + "','" + ca2.shift_ca + "') ;";
            
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

        private void labelgender_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcacionfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelcinfo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcacnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcaage_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelage_Click(object sender, EventArgs e)
        {

        }

        private void comboboxcamalefemale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxcashift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcaaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelcashift_Click(object sender, EventArgs e)
        {

        }

        private void labelcaname_Click(object sender, EventArgs e)
        {

        }

        private void seach_Click(object sender, EventArgs e)
        {


            bool temp = false;
            SqlConnection con = new SqlConnection("datasource=localhost; username=root; password=; database = oop");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from cabin_attendent where CNIC='" + this.textBoxcacnic.Text.Trim() + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.textBoxcaname.Text = dr.GetString(1);
                this.textBoxcacnic.Text = dr.GetString(2);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();



        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from cabin_attendent where name='" + this.textBoxcaname.Text + "';";
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
            try
            {

                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "update oop.Cabin_attendent set name='" + ca2.name + "',address='" + ca2.address + "',CNIC='" + ca2.Cnic + "',Age='" + ca2.age + "',Contact_No='" + ca2.Contact_info + "',Gender='" + ca2.gender + "', shift='" + ca2.shift_ca + "' where CNIC='" + this.textBoxcacnic + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
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