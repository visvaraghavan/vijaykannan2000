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
    public partial class Main2 : Form
    {
        String data1;
        public Main2(String data)
        {
            InitializeComponent();
            data1 = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main1 mf = new Main1(data1);
            mf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            visva vs = new visva();
            vs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ganesh mg = new ganesh();
            mg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
