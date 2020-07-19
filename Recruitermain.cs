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
    public partial class Recruitermain : Form
    {
        private SqlConnection connection;

        public Recruitermain(string data)
        {
            InitializeComponent();
            label1.Text = data;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\db\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From "+data+"", con);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            sda.Fill(dt);
            con.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.close();
        }

        private void close()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }
    }
}
