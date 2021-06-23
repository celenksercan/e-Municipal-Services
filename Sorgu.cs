using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BELEDIYE
{
    public partial class Sorgu : Form
    {
        public Sorgu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string a = comboBox1.GetItemText(comboBox1.SelectedItem);
            //if (a=="Mevzuat")
            //{
            //    label3.Hide();
            //    label4.Hide();
            //    textBox2.Hide();
            //    textBox3.Hide();

            //}
            //else if(a == "Ihale")
            //{
            //    label3.Show();
            //    textBox2.Show();
            //    label4.Hide();
            //    textBox3.Hide();
            //}
            //else
            //{
            //    label3.Hide();
            //    textBox2.Hide();
            //    label4.Show();
            //    textBox3.Show();

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ihale q = new Ihale();
            q.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mevzuat q = new Mevzuat();
            q.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Evrak q = new Evrak();
            q.ShowDialog();
        }
    }
}
