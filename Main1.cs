using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class Main1 : Form
    {
        string data1;
        public Main1(string data)
        {
            InitializeComponent();
            label1.Text = data;
            data1 = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 ss = new Main2(data1);
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vijay vj = new vijay(data1);
            vj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            vishnu vb = new vishnu(data1);
            vb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main1_Load(object sender, EventArgs e)
        {

        }
    }
}
