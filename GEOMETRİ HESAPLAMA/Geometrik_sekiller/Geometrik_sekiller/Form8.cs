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
    public partial class Form8 : Form
    {
        public Form8()
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

                alan = ((kenar*kenar) *(3*(Math.Sqrt(3))))/2;
                textBox2.Text = alan.ToString("F2");
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞERLER GİRİNİZ");
            }
        }
    }
    
}
