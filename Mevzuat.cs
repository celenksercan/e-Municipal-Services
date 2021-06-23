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
    public partial class Mevzuat : Form
    {
        public Mevzuat()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (a == "OtoparkYonetmeligi")
            {
                string myPath = Application.StartupPath + "\\otopark-yonetmeligi.pdf";
                System.Diagnostics.Process islem = new System.Diagnostics.Process();
                islem.StartInfo.FileName = myPath;
                islem.Start();

            }
            else if (a == "ReklamTanitim")
            {
                string myPath = Application.StartupPath + "\\reklam-tanitim.pdf";
                System.Diagnostics.Process islem = new System.Diagnostics.Process();
                islem.StartInfo.FileName = myPath;
                islem.Start();

            }
            else if (a == "IhaleIsleri")
            {
                string myPath = Application.StartupPath + "\\ihale-isleri.pdf";
                System.Diagnostics.Process islem = new System.Diagnostics.Process();
                islem.StartInfo.FileName = myPath;
                islem.Start();
            }
            else
            {
               
            }
        }

        private void Mevzuat_Load(object sender, EventArgs e)
        {

        }
    }
}
