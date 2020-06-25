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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

          
            string dbconnect = Receptionist.dbconn();
            MySqlConnection con = new MySqlConnection(dbconnect);
            con.Open();
           // if (con.State==ConnectionState.Open)
            //{
             // MessageBox.Show("Database Connected");
            //}
            //else
            //{
             // MessageBox.Show("Not Connected");
            //}
            if (textBox1usernameres.Text=="" || textBox1passwordres.Text=="" )
            {
                MessageBox.Show("Please Enter Something User Name or Password is Empty","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (textBox1usernameres.Text != "asad" || textBox1passwordres.Text != "asad")
            {
                MessageBox.Show("Enter Valid User Name and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           this.Hide();
           Resecpnist rs = new Resecpnist();
           rs.Show();
          //  Customer_Front_end an = new Customer_Front_end();
           // an.Show();
         //   label1username.Text = textBox1username.Text;
           // label1password.Text = textBox2password.Text;
        }
      
        

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox1usernameres.Clear();
            textBox1passwordres.Clear();
        }

        private void label1username_Click(object sender, EventArgs e)
        {

        }
       
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonloginadmin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Route_Front_End rt = new Route_Front_End();
            //rt.Show();
            
         
            Pilot ans = new Pilot("4 years");
            Admin ad = new Admin(ans);
            string dbconnect = Admin.dbconn();
            MySqlConnection con = new MySqlConnection(dbconnect);
            con.Open();
          //   if (con.State==ConnectionState.Open)
           // {
            // MessageBox.Show("Database Connected");
            //}
            //else
            //{
             // MessageBox.Show("Not Connected");
            //}
            if (textBoxadminusername.Text == "" || textBoxpassadmin.Text=="")
            {
                MessageBox.Show("Please Enter Something User Name or Password is Empty", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxadminusername.Text != "admin" || textBoxpassadmin.Text != "admin")
            {
               MessageBox.Show("Enter Valid User Name and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
            }
            this.Hide();
            AdminRes an = new AdminRes();
            an.Show();
        }

       private void buttonresetadmin_Click(object sender, EventArgs e)
        {
            textBoxadminusername.Clear();
            textBoxpassadmin.Clear();
        }

       private void pictureBox2_Click(object sender, EventArgs e)
       {

       }
       
       private void textBoxadminusername_TextChanged(object sender, EventArgs e)
       {
           Pilot ans = new Pilot("4 years");
           Admin ad = new Admin(ans);
           ad.name = textBoxadminusername.Text;
       }

      private void textBoxpassadmin_TextChanged(object sender, EventArgs e)
       {
           Pilot ans = new Pilot("6 years");
           Admin ad = new Admin(ans);
         
           ad.Admin_Pass = textBoxpassadmin.Text;
       }
    }
}
