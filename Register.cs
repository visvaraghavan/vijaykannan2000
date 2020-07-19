using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\visva\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Login(Username,Password,Firstname,Lastname,Qualification,Experience,Address,Gender,DateOfBirth,Emailid,PhoneNumber,MaritalStatus) values(@Username,@Password,@Firstname,@Lastname,@Qualification,@Experience,@Address,@Gender,@DateOfBirth,@Emailid,@PhoneNumber,@MaritalStatus)", con);
            cmd.Parameters.AddWithValue("@Firstname", textBox1.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Username", textBox4.Text);
            cmd.Parameters.AddWithValue("@Password", textBox8.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Qualification", textBox3.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Experience", comboBox1.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBox6.Text);
            cmd.Parameters.AddWithValue("@Emailid", textBox7.Text);
            cmd.Parameters.AddWithValue("@MaritalStatus", comboBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("SUBMITTED");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lf = new Form1();
            lf.Show();
        }
    }
}
