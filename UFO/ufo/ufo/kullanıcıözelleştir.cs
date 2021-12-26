using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace ufo
{
    public partial class kullanıcıözelleştir : Form
    {
        public kullanıcıözelleştir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kullanıcıurun kurn = new kullanıcıurun();
            kurn.MdiParent = this;
            kurn.FormBorderStyle = FormBorderStyle.None;
            kurn.Show();
            kullanıcıözelleştir k = new kullanıcıözelleştir();
        }

        private void kullanıcıözelleştir_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            müsteritkp must = new müsteritkp();
            must.MdiParent = this;
            must.FormBorderStyle = FormBorderStyle.None;
            must.Show();
        }
    }
}
    
    
    

