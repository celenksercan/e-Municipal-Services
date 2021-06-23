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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            label2.Text = "Borç" + Environment.NewLine + "Kategori";
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (a == "BelediyeBorcOdeme")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
                //Data Source = DESKTOP-S7T830D; Initial Catalog =
                con.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con; //command connectiona bağlanıyor

                //query kodu
                kmt.CommandText = "SELECT belediyeBorc from borc where TC='" + textBox1.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();
                kmt.Parameters.AddWithValue("belediyeBorc", textBox2.Text);

                if (oku.Read())  //okuma gerçekleşiyorsa
                {
                    textBox2.Text = oku["belediyeBorc"].ToString();
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Borcunuz bulunmamaktadır.");
                    }
                    else if (textBox2.Text != "0" && textBox2.Text != "")
                    {
                        MessageBox.Show(textBox2.Text + " TL borcunuz bulunmaktadır.!");
                    }
                }
                else
                {
                    MessageBox.Show("Borcunuz bulunmamaktadır.");
                }

            }
            else if(a=="SuBorcOdeme")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
                //Data Source = DESKTOP-S7T830D; Initial Catalog =
                con.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con; //command connectiona bağlanıyor

                //query kodu
                kmt.CommandText = "SELECT suBorc from borc where TC='" + textBox1.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();
                kmt.Parameters.AddWithValue("suBorc", textBox2.Text);

                if (oku.Read())  //okuma gerçekleşiyorsa
                {
                    textBox2.Text = oku["suBorc"].ToString();
                    if (textBox2.Text=="")
                    {
                        MessageBox.Show("Borcunuz bulunmamaktadır.");
                    }
                    else if (textBox2.Text != "0"&&textBox2.Text!="")
                    {
                        MessageBox.Show(textBox2.Text + " TL borcunuz bulunmaktadır.!");
                    }
                }
                else
                {
                    MessageBox.Show("Borcunuz bulunmamaktadır");
                }
            }
            else if(a=="DogalgazBorcOdeme")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
                //Data Source = DESKTOP-S7T830D; Initial Catalog =
                con.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con; //command connectiona bağlanıyor

                //query kodu
                kmt.CommandText = "SELECT dogalgazBorc from borc where TC='" + textBox1.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();
                kmt.Parameters.AddWithValue("dogalgazBorc", textBox2.Text);

                if (oku.Read())  //okuma gerçekleşiyorsa
                {
                    textBox2.Text = oku["dogalgazBorc"].ToString();
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Borcunuz bulunmamaktadır.");
                    }
                    else if (textBox2.Text != "0" && textBox2.Text != "")
                    {
                        MessageBox.Show(textBox2.Text + " TL borcunuz bulunmaktadır.!");
                    }
                }
                else
                {
                    MessageBox.Show("Borcunuz bulunmamaktadır.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (x == "BelediyeBorcOdeme")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
                //Data Source = DESKTOP-S7T830D; Initial Catalog =
                con.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con; //command connectiona bağlanıyor

                //query kodu
                kmt.CommandText = "SELECT belediyeBorc from borc where TC='" + textBox1.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();
                kmt.Parameters.AddWithValue("belediyeBorc", textBox2.Text);
                //textBox2.Text = oku["borcTutari"].ToString();
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox4.Text);
                con.Close();
                if (a >= b)
                {
                    int c = a - b;
                    SqlCommand q = new SqlCommand("UPDATE borc SET belediyeBorc = '" + c + "'  WHERE TC = " + textBox1.Text);
                    q.Connection = con;
                    con.Open();



                    int sayi = q.ExecuteNonQuery(); //derleme sonucunu değişkene atama
                    con.Close();
                    if (sayi == 1)
                    {
                        MessageBox.Show("Ödeme başarılı, Güncel belediye borcunuz" + c + " TL'dir");
                        textBox2.Text = "";

                        textBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ödeme başarısız, borçlu bulunamadı");
                    }

                }
                else if (a < b)
                {
                    textBox4.Text = "";
                    MessageBox.Show("Ödenecek Tutar, Borç Tutarından Fazla Olamaz!");
                }
                else if (b == 0)
                {
                    MessageBox.Show("Ödenecek Tutar 0 Olamaz!");
                }
                else
                {
                    MessageBox.Show("Hatalı tuşlama");

                }
            }
            else if (x == "SuBorcOdeme")
            {
                            
            SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
            //Data Source = DESKTOP-S7T830D; Initial Catalog =
            con.Open();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = con; //command connectiona bağlanıyor

            //query kodu
            kmt.CommandText = "SELECT suBorc from borc where TC='" + textBox1.Text + "'";
            SqlDataReader oku = kmt.ExecuteReader();
            kmt.Parameters.AddWithValue("suBorc", textBox2.Text);
            
            //textBox2.Text = oku["borcTutari"].ToString();
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox4.Text);
            con.Close();
            if (a >= b)
            {
                int c = a - b;
                SqlCommand q = new SqlCommand("UPDATE borc SET suBorc = '" + c + "'  WHERE TC = " + textBox1.Text);
                q.Connection = con;
                con.Open();



                int sayi = q.ExecuteNonQuery(); //derleme sonucunu değişkene atama
                con.Close();
                if (sayi == 1)
                {
                    MessageBox.Show("Ödeme başarılı, Güncel su borcunuz" + c + " TL'dir");
                    textBox2.Text = "";

                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Ödeme başarısız, borçlu bulunamadı");
                }

            }
            else if (a < b)
                {
                    textBox4.Text = "";
                    MessageBox.Show("Ödenecek Tutar, Borç Tutarından Fazla Olamaz!");
            }
            else if (b == 0)
            {
                MessageBox.Show("Ödenecek Tutar 0 Olamaz!");
            }
            else
            {
                MessageBox.Show("Hatalı tuşlama");

            }
        }
            else if (x == "DogalgazBorcOdeme")
            {

                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI");
                //Data Source = DESKTOP-S7T830D; Initial Catalog =
                con.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con; //command connectiona bağlanıyor

                //query kodu
                kmt.CommandText = "SELECT dogalgazBorc from borc where TC='" + textBox1.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();
                kmt.Parameters.AddWithValue("dogalgazBorc", textBox2.Text);
                //textBox2.Text = oku["borcTutari"].ToString();
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox4.Text);
                con.Close();
                if (a >= b)
                {
                    int c = a - b;
                    SqlCommand q = new SqlCommand("UPDATE borc SET dogalgazBorc = '" + c + "'  WHERE TC = " + textBox1.Text);
                    q.Connection = con;
                    con.Open();



                    int sayi = q.ExecuteNonQuery(); //derleme sonucunu değişkene atama
                    con.Close();
                    if (sayi == 1)
                    {
                        MessageBox.Show("Ödeme başarılı, Güncel doğalgaz borcunuz" + c + " TL'dir");
                        textBox2.Text = "";

                        textBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ödeme başarısız, borçlu bulunamadı");
                    }

                }
                else if (a < b)
                {
                    textBox4.Text = "";
                    MessageBox.Show("Ödenecek Tutar, Borç Tutarından Fazla Olamaz!");
                }
                else if (b == 0)
                {
                    MessageBox.Show("Ödenecek Tutar 0 Olamaz!");
                }
                else
                {
                    MessageBox.Show("Hatalı tuşlama");

                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
