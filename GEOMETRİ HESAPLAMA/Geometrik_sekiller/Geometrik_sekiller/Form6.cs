using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrik_sekiller
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int alttaban,üsttaban,yükseklik, alan;
                alttaban = Convert.ToInt32(textBox1.Text);
                üsttaban = Convert.ToInt32(textBox4.Text);
                yükseklik = Convert.ToInt32(textBox3.Text);
                alan = ((alttaban+üsttaban)*yükseklik)/2;
                textBox2.Text = alan.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞERLER GİRİNİZ");
            }

        }
    }
}
