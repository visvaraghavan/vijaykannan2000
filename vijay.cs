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
    public partial class vijay : Form
    {
        string data1;
        public vijay(string data)
        {
            InitializeComponent();
            data1 = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main1 rf = new Main1(data1);
            rf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\visva\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into vijay(Name,Fathername,Dateofbirth,Address,Experience,Previouscompany,Qualification,Expectedsalary,Workinghours,Emailid,Maritalstatus,Gender,native,Hobby,Skills,Mobilenumber) values(@Name,@Fathername,@Dateofbirth,@Address,@Experience,@Previouscompany,@Qualification,@Expectedsalary,@Workinghours,@Emailid,@Maritalstatus,@Gender,@native,@Hobby,@Skills,@Mobilenumber)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Fathername", textBox2.Text);
            cmd.Parameters.AddWithValue("@Dateofbirth", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Experience", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Previouscompany", textBox4.Text);
            cmd.Parameters.AddWithValue("@Qualification", textBox5.Text);
            cmd.Parameters.AddWithValue("@Expectedsalary", textBox6.Text);
            cmd.Parameters.AddWithValue("@Workinghours", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Emailid", textBox7.Text);
            cmd.Parameters.AddWithValue("@Maritalstatus", comboBox4.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Native", textBox8.Text);
            cmd.Parameters.AddWithValue("@Hobby", textBox9.Text);
            cmd.Parameters.AddWithValue("@Skills", textBox11.Text);
            cmd.Parameters.AddWithValue("@Mobilenumber", textBox10.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("SUBMIT");
            con.Close();
        }
    }
}
