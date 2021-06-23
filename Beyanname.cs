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
    public partial class Beyanname : Form
    {
        public Beyanname()
        {
            InitializeComponent();
        }

        private void Beyanname_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            label2.Text = "Beyanname" + Environment.NewLine + "Kategori";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (a == "IlanReklam")
            {
                label3.Show();
                textBox2.Show();
                label4.Hide();
                textBox3.Hide();
                textBox4.Hide();
                label5.Hide();
                textBox2.Text = "";
                dataGridView1.DataSource = null;

            }
            else if (a == "YanginPolice")
            {
                label3.Hide();
                textBox2.Hide();
                label4.Show();
                textBox3.Show();
                textBox4.Hide();
                label5.Hide();
                textBox3.Text = "";
                dataGridView1.DataSource = null;
            }
            else if (a == "DepremPolice")
            {
                label3.Hide();
                textBox2.Hide();
                label4.Hide();
                textBox3.Hide();
                textBox4.Show();
                label5.Show();
                textBox4.Text = "";
                dataGridView1.DataSource = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (a == "IlanReklam")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI; MultipleActiveResultSets = True");

                con.Open();
                SqlDataAdapter da;
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con;
                DataSet ds;
                da = new SqlDataAdapter("SELECT *from beyanname WHERE TC='" + textBox1.Text + "'  AND ilanNo = " + textBox2.Text, con);
                ds = new DataSet();
                kmt.CommandText = "SELECT ilanNo from beyanname where TC='" + textBox1.Text + "'  AND ilanNo='" + textBox2.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();

                if (oku.Read())
                {
                    string x = oku["ilanNo"].ToString();

                    if (x != "")
                    {
                        da.Fill(ds, "beyanname");
                        con.Close();
                        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DataSource = ds.Tables["beyanname"];
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.White;

                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.Columns["yanginPoliceNo"].Visible = false;
                        dataGridView1.Columns["yanginPoliceAdres"].Visible = false;
                        dataGridView1.Columns["depremPoliceNo"].Visible = false;
                        dataGridView1.Columns["depremPoliceAdres"].Visible = false;
                       
                        dataGridView1.Rows[0].Cells[0].Selected = false;
                    }


                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Kayit bulunamadi.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

            }
            else if (a == "YanginPolice")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI; MultipleActiveResultSets = True");

                con.Open();
                SqlDataAdapter da;
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con;
                DataSet ds;
                da = new SqlDataAdapter("SELECT *from beyanname WHERE TC='" + textBox1.Text + "'  AND yanginPoliceNo = " + textBox3.Text, con);
                ds = new DataSet();
                kmt.CommandText = "SELECT yanginPoliceNo from beyanname where TC='" + textBox1.Text + "'  AND yanginPoliceNo='" + textBox3.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();

                if (oku.Read())
                {
                    string x = oku["yanginPoliceNo"].ToString();

                    if (x != "")
                    {





                        da.Fill(ds, "beyanname");
                        con.Close();
                        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DataSource = ds.Tables["beyanname"];
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[0].Selected = false;
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.Columns["ilanNo"].Visible = false;
                        dataGridView1.Columns["ilanAdres"].Visible = false;
                        dataGridView1.Columns["depremPoliceNo"].Visible = false;
                        dataGridView1.Columns["depremPoliceAdres"].Visible = false;
                        
                    }

                    
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Kayit bulunamadi.");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
            }
            else if (a == "DepremPolice")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-S7T830D;Database=BELEDIYE;Integrated Security=SSPI; MultipleActiveResultSets = True");

                con.Open();
                SqlDataAdapter da;
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = con;
                DataSet ds;
                da = new SqlDataAdapter("SELECT *from beyanname WHERE TC='" + textBox1.Text + "'  AND depremPoliceNo = " + textBox4.Text, con);
                ds = new DataSet();
                kmt.CommandText = "SELECT depremPoliceNo from beyanname where TC='" + textBox1.Text + "'  AND depremPoliceNo='" + textBox4.Text + "'";
                SqlDataReader oku = kmt.ExecuteReader();

                if (oku.Read())
                {
                    string x = oku["depremPoliceNo"].ToString();

                    if (x != "")
                    {





                        da.Fill(ds, "beyanname");
                        con.Close();
                        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DataSource = ds.Tables["beyanname"];
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[0].Selected = false;
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.Columns["ilanNo"].Visible = false;
                        dataGridView1.Columns["ilanAdres"].Visible = false;
                        dataGridView1.Columns["yanginPoliceNo"].Visible = false;
                        dataGridView1.Columns["yanginPoliceAdres"].Visible = false;
                        textBox2.Text = "";
                    }

                   
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Kayit bulunamadi.");
                    textBox1.Text = "";
                    textBox4.Text = "";
                }

            }





        }
    }
}
