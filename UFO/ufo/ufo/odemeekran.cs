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
    public partial class odemeekran : Form
    {
        public odemeekran()
        {
            InitializeComponent();
        }
        private void odemeekran_Load(object sender, EventArgs e)
        {
            label3.Text = urunleri.veri;
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                odemeson ode = new odemeson();
                ode.Show();
            }
            else if(radioButton2.Checked==true)
            {
                MessageBox.Show("odemeyi kuryeye teslim ediniz!!");
                Application.Exit();
            }
            else if (radioButton3.Checked==true)
            {
                çekekranı çek = new çekekranı();
                çek.Show();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
