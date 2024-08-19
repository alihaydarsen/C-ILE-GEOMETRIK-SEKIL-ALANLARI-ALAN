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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int yarıçap;
                double alan;
                double pi = 3.14;

                yarıçap = Convert.ToInt32(textBox1.Text);

                alan = pi * (yarıçap * yarıçap);
                textBox2.Text = alan.ToString("F2");
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞERLER GİRİNİZ");
            }
        }
    }
    
}
