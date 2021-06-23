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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
            //Data Source = DESKTOP-S7T830D; Initial Catalog =
            con.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = con; //command connectiona bağlanıyor

            //query kodu
            kmt.CommandText = "SELECT *FROM vatandas where TC='" + textBox1.Text + "'";
            SqlDataReader oku = kmt.ExecuteReader();
           

            if (oku.Read())  //okuma gerçekleşiyorsa
            {
                this.Hide();  //mevcut formu gizle
                KullaniciMenu k = new KullaniciMenu(); // k adında yeni bir anamenu formu türet
                k.ShowDialog(); // yeni formu aç
            }
            else
            {
                MessageBox.Show("TC Hatalıdır.");
            }
        }

       
    }
}