using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakkalamca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void urun_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun;
            double alis, kdv = 0, satis, maliyet, kazanc;
            urun = Convert.ToString(textBox1.Text);
            alis = Convert.ToDouble(textBox2.Text);
            satis = Convert.ToDouble(textBox3.Text);

            if (radioButton1.Checked)
            {
                kdv = alis * 0.01;
            }
            if (radioButton2.Checked)
            {
                kdv = alis * 0.08;
            }
            if (radioButton3.Checked)
            {
                kdv = alis * 0.18;
            }
            maliyet = kdv + alis;
            textBox4.Text = maliyet.ToString();
            kazanc = satis - maliyet;
            textBox5.Text = kazanc.ToString();
            if (kazanc>0)
            {
                MessageBox.Show("Afferim köftor cebe indirdin");
            }
            else
            {
                MessageBox.Show("Aq gerizekalisi zarar ettin");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
