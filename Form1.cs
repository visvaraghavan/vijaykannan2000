using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\visva\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main1 ss = new Main1(textBox1.Text);
                    ss.Show();
                }
                else 
                {
                    SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\visva\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlDataAdapter ssda = new SqlDataAdapter("Select Count(*) From Recruiterspeciallogin where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", scon);
                    DataTable sdt = new DataTable();
                    ssda.Fill(sdt);
                    if (sdt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        RecruiterLogin mm = new RecruiterLogin();
                        mm.Show();
                    }

                    else
                    {
                        MessageBox.Show("please check inputs");
                    }
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rrf = new Register();
            rrf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
