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
    public partial class Customer_Front_end : Form
    {
        Passenger p1 = new Passenger("DX3291","Haider@gmail.com","3 large size bags");
        Ticket t = new Ticket();
      
        public Customer_Front_end()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if (textBoxpname.Text == "")
            {
               // textBoxpname.BackColor = Color.Red;
                MessageBox.Show("Name Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
               // textBoxpname.Focus();
            }
            if (textBoxaddress.Text == "")
            {
               // textBoxaddress.BackColor = Color.Red;
                MessageBox.Show("Address Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                //textBoxpname.Focus();
            }


            if (textBoxcnic.Text == "")
            {
                textBoxcnic.BackColor = Color.Red;
                MessageBox.Show("CNIC Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                //textBoxage.Focus();
            }
            else
            {
                int outcnic;
                if (!int.TryParse(textBoxcnic.Text, out outcnic))
                {
                    MessageBox.Show("CNIC Only in Digits ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                  //  textBoxage.Focus();
                }
                if (textBoxage.Text == "")
                {
                    textBoxpname.BackColor = Color.Red;
                    MessageBox.Show("Age Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    //textBoxage.Focus();
                }
                else
                {
                    int outage;
                    if (!int.TryParse(textBoxage.Text, out outage))
                    {
                        MessageBox.Show("Age can not be in texts ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                      //  textBoxage.Focus();
                    }
                    if (textBoxcionfo.Text == "")
                    {
                        textBoxcionfo.BackColor = Color.Red;
                        MessageBox.Show("Contact Info Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        //textBoxage.Focus();
                    }
                    else
                    {
                        int outcinfo;
                        if (!int.TryParse(textBoxcionfo.Text, out outcinfo))
                        {
                            MessageBox.Show("Contact Info only in Numbers ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                          //  textBoxage.Focus();
                        }


                    }
                    if (textBoxticketno.Text == "")
                    {
                        textBoxpname.BackColor = Color.Red;
                        MessageBox.Show("Ticket No Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        //textBoxpname.Focus();
                    }
                    if (textBoxnoofpassengers.Text == "")
                    {
                        textBoxpname.BackColor = Color.Red;
                        MessageBox.Show("No of Passengers Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    //    textBoxnoofpassengers.Focus();
                    }
                    else
                    {
                        int outnoofpass;
                        if (!int.TryParse(textBoxnoofpassengers.Text, out outnoofpass))
                        {
                            MessageBox.Show("No of Passengers only in Numbers  ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                      //      textBoxnoofpassengers.Focus();
                        }
                        if (textBoxpaymebt.Text == "")
                        {
                            textBoxpname.BackColor = Color.Red;
                            MessageBox.Show("Payment Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        //    textBoxpaymebt.Focus();
                        }
                        else
                        {
                            int outpayment;
                            if (!int.TryParse(textBoxpaymebt.Text, out outpayment))
                            {
                                MessageBox.Show("Payment can in Numbers  ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                          //      textBoxage.Focus();
                            }
                        }
                        if (textBoxpassport.Text == "")
                        {
                            textBoxcionfo.BackColor = Color.Red;
                            MessageBox.Show("Passport No Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            //textBoxpassport.Focus();
                        }
                      //  MessageBox.Show("Done", "Ceated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // this.Hide();
                        //CustomerReport cr = new CustomerReport();
                        //cr.Show();
                    }

                }

            }

            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = oop");
            string insertquery = "Insert into oop.customer_details(c_name,Address,	CNIC,	Age,	Contact_Nos,Gender, Ticket_No,No_of_Passenger,payment,Passport_No, Email,Class) VALUES('" + p1.name + "','" + p1.address + "','" + p1.Cnic + "','" + p1.age + "','" + p1.Contact_info + "','" + p1.gender + "','" + p1.t1.ticket_no + "','" + p1.t1.no_of_passengers + "','" + p1.t1.payment + "','" + p1.passport_no + "','" + p1.email_address + "') ;";
            //  string insertquery = ("Insert into umt.info() VALUES(" +textBoxpname.Text + "," + textBoxaddress+ ","+textBoxcnic.Text+","+textBoxage.Text+","+textBoxcionfo.Text+","+comboboxmalefemale.Text+","+textBoxticketno.Text+","+textBoxnoofpassengers.Text+","+textBoxpaymebt.Text+","+textBoxpassport.Text+","+textBoxemail.Text+")");
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
    
        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBoxpname_TextChanged(object sender, EventArgs e)
        {
           // textBoxpname.BackColor = Color.Green;
          //  p1.name = textBoxpname.Text;
        }

        private void labeladdress_Click(object sender, EventArgs e)
        {

        }

        private void labelpassport_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxticketno_TextChanged(object sender, EventArgs e)
        {

            t.ticket_no = textBoxticketno.Text;
        }

        private void textBoxaddress_TextChanged(object sender, EventArgs e)
        {
            p1.address = textBoxaddress.Text;
        }

        private void textBoxcnic_TextChanged(object sender, EventArgs e)
        {
           p1.Cnic =textBoxcnic.Text;
        }

        private void textBoxage_TextChanged(object sender, EventArgs e)
        {
            p1.age = Convert.ToInt32( textBoxage.Text);
        }

        private void textBoxcionfo_TextChanged(object sender, EventArgs e)
        {
            p1.Contact_info = Convert.ToInt64(textBoxcionfo.Text);
        }

        private void comboboxmalefemale_SelectedIndexChanged(object sender, EventArgs e)
        {
            p1.gender = comboboxmalefemale.Text;
        }

        private void textBoxnoofpassengers_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(p1.t1.no_of_passengers);  
            t.no_of_passengers = Convert.ToInt32(textBoxnoofpassengers.Text);
        }

        private void textBoxpaymebt_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(p1.t1.payment);
            t.payment = textBoxpaymebt.Text;
        }

        private void textBoxpassport_TextChanged(object sender, EventArgs e)
        {

            p1.passport_no = textBoxpassport.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(p1.t1.ticket_type);
            t.ticket_type = comboBoxticketclass.Text;
        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "delete from customer_details where CNIC='" + this.textBoxcnic + "';";
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

        private void planeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labelpayment_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "update oop.customer_details set name='" + p1.name + "',address='" + p1.address + "',CNIC='" + p1.Cnic + "',Age='" + p1.age + "',Contact_No='" + p1.Contact_info + "',Gender='" + p1.gender + "', passport='" + p1.passport_no + "' where CNIC='" + this.textBoxcnic + "';";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        bool temp = false;
        SqlConnection con = new SqlConnection("datasource=localhost; username=root; password=; database = oop");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from customer_detail where CNIC='" + this.textBoxcnic.Text.Trim() + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
        this.textBoxpname.Text = dr.GetString(1);
        this.textBoxaddress.Text = dr.GetString(2);
        temp = true;
        }
        if (temp == false)
        MessageBox.Show("not found");
        con.Close();
            }
        }
    }
