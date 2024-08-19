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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kısa,uzun, alan;
                kısa = Convert.ToInt32(textBox1.Text);
                uzun = Convert.ToInt32(textBox3.Text);
                alan = kısa*uzun;
                textBox2.Text = alan.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞERLER GİRİNİZ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
