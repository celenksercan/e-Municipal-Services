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
    public partial class Ihale : Form
    {
        public Ihale()
        {
            InitializeComponent();
        }

               

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI; MultipleActiveResultSets = True");

            con.Open();
            SqlDataAdapter da;
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = con;
            DataSet ds;
            da = new SqlDataAdapter("SELECT *from sorgu WHERE ihaleNo='" + textBox1.Text + "'", con);
            ds = new DataSet();
            kmt.CommandText = "SELECT ihaleNo from sorgu where ihaleNo='" + textBox1.Text + "'";
            SqlDataReader oku = kmt.ExecuteReader();

            if (oku.Read())
            {
                string x = oku["ihaleNo"].ToString();

                if (x != "")
                {
                    da.Fill(ds, "sorgu");
                    con.Close();
                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = ds.Tables["sorgu"];
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.Rows[0].Cells[0].Selected = false;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Columns["TC"].Visible = false;
                    dataGridView1.Columns["evrakNo"].Visible = false;
                    dataGridView1.Columns["evrakKayitYil"].Visible = false;
                    dataGridView1.Columns["evrakKonusu"].Visible = false;
                    textBox1.Text = "";
                }

                
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Kayit bulunamadi.");
                textBox1.Text = "";
            }
        }
    }
}
    

