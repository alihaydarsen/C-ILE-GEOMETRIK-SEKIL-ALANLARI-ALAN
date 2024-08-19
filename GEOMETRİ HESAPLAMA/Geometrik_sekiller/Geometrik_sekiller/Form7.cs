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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kenar;
                double alan;
               
                kenar = Convert.ToInt32(textBox1.Text);

                 alan = (1.0 / 4.0) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * kenar * kenar;
                textBox2.Text = alan.ToString("F2");
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞERLER GİRİNİZ");
            }
        }
    }
}
