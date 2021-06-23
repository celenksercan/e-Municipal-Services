using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELEDIYE
{
    public partial class KullaniciMenu : Form
    {
        public KullaniciMenu()
        {
            InitializeComponent();
        }

        private void KullaniciMenu_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Basvuru q = new Basvuru();
            q.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorgu x = new Sorgu();
            x.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Beyanname y = new Beyanname();
            y.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odeme z = new Odeme();
            z.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KullaniciGiris f = new KullaniciGiris();
            this.Hide();
            f.ShowDialog();
            
        }
    }

    }

