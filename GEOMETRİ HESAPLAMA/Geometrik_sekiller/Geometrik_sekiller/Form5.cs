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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int taban, yükseklik, alan;
                taban = Convert.ToInt32(textBox1.Text);
                yükseklik = Convert.ToInt32(textBox3.Text);
                alan = (taban * yükseklik);
                textBox2.Text = alan.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞERLER GİRİNİZ");
            }
        }
    }
}
