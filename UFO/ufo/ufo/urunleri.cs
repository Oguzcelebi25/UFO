using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ufo
{
    public partial class urunleri : Form
    {
        public urunleri()
        {
            InitializeComponent();
        }
        
        private void urunleri_Load(object sender, EventArgs e)
        {
            
           
        }
       
        private void btn_satınal_Click(object sender, EventArgs e)
        {

             odemeekran oekran = new odemeekran();
             oekran.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public static string veri;

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int a1;
                int b1;
                int çarpım1;
                a1 = Convert.ToInt32(ekrkart.Text);
                b1 = 15000;
                çarpım1 = a1 * b1;
                tutar1.Text = çarpım1.ToString();
            }
            else
            {
                int abc1 = 0;
                tutar1.Text = abc1.ToString();

            }
            if (checkBox2.Checked)
            {
                int a2;
                int b2;
                int çarpım2;
                a2 = Convert.ToInt32(işl.Text);
                b2 = 5000;
                çarpım2 = a2 * b2;
                tutar2.Text = çarpım2.ToString();

            }
            else
            {
                int abc2 = 0;
                tutar2.Text = abc2.ToString();

            }
            if (checkBox3.Checked)
            {
                int a3;
                int b3;
                int çarpım3;
                a3 = Convert.ToInt32(klav.Text);
                b3 = 500;
                çarpım3 = a3 * b3;
                tutar3.Text = çarpım3.ToString();
            }
            else
            {
                int abc3 = 0;
                tutar3.Text = abc3.ToString();

            }
            if (checkBox4.Checked)
            {
                int a4;
                int b4;
                int çarpım4;
                a4 = Convert.ToInt32(mou.Text);
                b4 = 300;
                çarpım4 = a4 * b4;
                tutar4.Text = çarpım4.ToString();
            }
            else
            {
                int abc4 = 0;
                tutar4.Text = abc4.ToString();

            }
            if (checkBox5.Checked)
            {
                int a5;
                int b5;
                int çarpım5;
                a5 = Convert.ToInt32(mon.Text);
                b5 = 300;
                çarpım5 = a5 * b5;
                tutar5.Text = çarpım5.ToString();
            }
            else
            {
                int abc5 = 0;
                tutar5.Text = abc5.ToString();

            }
            int d = Convert.ToInt32(tutar1.Text) +
            Convert.ToInt32(tutar2.Text) +
            Convert.ToInt32(tutar3.Text) +
            Convert.ToInt32(tutar4.Text) +
            Convert.ToInt32(tutar5.Text);
            tutar.Text = d.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            veri = tutar.Text;
            odemeekran form = new odemeekran();
            form.Show();
            this.Hide();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tutar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutar3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutar4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutar5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tutar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
