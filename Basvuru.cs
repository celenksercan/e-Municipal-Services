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
    public partial class Basvuru : Form
    {
        public Basvuru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")  //GELEN TEXTİN BOŞ MU OLUP OLMADIGINI SORGULAMA
            {

                MessageBox.Show("TC boş geçilemez");

                return;

            }
            else
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
                //Data Source = DESKTOP-S7T830D; Initial Catalog =
                con.Open();
                SqlCommand kmt = new SqlCommand("INSERT INTO eBasvuru (TC, basvuruKategori, talep_mesaj) VALUES (@TC,@basvuruKategori,@talep_mesaj)");
                kmt.Connection = con; //command connectiona bağlanıyor


                
                kmt.Parameters.AddWithValue("@TC", textBox1.Text.Trim());
                kmt.Parameters.AddWithValue("@basvuruKategori", comboBox1.GetItemText(comboBox1.SelectedItem));
                kmt.Parameters.AddWithValue("@talep_mesaj", richTextBox1.Text.Trim());





                kmt.ExecuteNonQuery(); // COMMANDİ DERLEME
                con.Close();
                MessageBox.Show("Başarıyla başvuruldu.");

                textBox1.Text = "";
                comboBox1.Text = "";
                richTextBox1.Text = "";
               
            }
        }

        private void Basvuru_Load(object sender, EventArgs e)
        {
            label2.Text = ("Başvuru" + Environment.NewLine + "Kategori");
        }
    }
}
