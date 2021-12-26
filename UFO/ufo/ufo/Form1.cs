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
    public partial class UFO : Form
    {
        public UFO()
        {
            InitializeComponent();
        }

        private void btn_müsteri_Click(object sender, EventArgs e)
        {
          
            musterigirisekranı musterigiris= new musterigirisekranı();
            musterigiris.MdiParent = this;
            musterigiris.FormBorderStyle = FormBorderStyle.None;
            musterigiris.Show();
        }

        private void btn_kullanıcı_Click(object sender, EventArgs e)
        {
           
            kullanıcıgirsi kulgir = new kullanıcıgirsi();
            kulgir.MdiParent = this;
            kulgir.FormBorderStyle = FormBorderStyle.None;
            kulgir.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
