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
    public partial class Evrak : Form
    {
        public Evrak()
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
            da = new SqlDataAdapter("SELECT *from sorgu WHERE evrakNo='" + textBox1.Text + "'", con);
            ds = new DataSet();
            kmt.CommandText = "SELECT evrakNo from sorgu where evrakNo='" + textBox1.Text + "'";
            SqlDataReader oku = kmt.ExecuteReader();

            if (oku.Read())
            {
                string x = oku["evrakNo"].ToString();

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
                    dataGridView1.Columns["ihaleNo"].Visible = false;
                    dataGridView1.Columns["ihaleAdi"].Visible = false;
                    dataGridView1.Columns["ihaleKonusu"].Visible = false;
                    dataGridView1.Columns["ihaleBedel"].Visible = false;
                    dataGridView1.Columns["ihaleBitis"].Visible = false;
                    
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
    

