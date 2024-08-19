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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }

        private void btndikd_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void btnpk_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.Show();
            this.Hide();
        }

        private void btnyamuk_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6();
            fr.Show();
            this.Hide();
        }

        private void btnbeşgen_Click(object sender, EventArgs e)
        {
            Form7 fr = new Form7();
            fr.Show();
            this.Hide();
        }

        private void btnaltıgen_Click(object sender, EventArgs e)
        {
            Form8 fr = new Form8();
            fr.Show();
            this.Hide();
        }

        private void btnçember_Click(object sender, EventArgs e)
        {
            Form9 fr = new Form9();
            fr.Show();
            this.Hide();
        }
    }
}


        
          
    

