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
    public partial class musterigirisekranı : Form
        
    {
        public musterigirisekranı()
        {
            InitializeComponent();
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Müsteri müsteri = new Müsteri();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Müsteri müsteri = new Müsteri();
                müsteri.Ad = textBox1.Text;
                müsteri.Sifre = Convert.ToInt32(textBox2.Text);

                OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=ufolarr.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select  kullanıcıadı,sifre from kullanıciislem where kullanıcıadı=@kullanıcıadı and sifre=@sifre", baglanti);
                sorgu.Parameters.AddWithValue("@kullanıcıadı", textBox1.Text);
                sorgu.Parameters.AddWithValue("@sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                    urunleri urunumuz = new urunleri();
                    urunumuz.Show();
                    this.Visible = false;
                }
                else
                {
                    baglanti.Close();
                    MessageBox.Show("hatalı");
                }
            }
            catch
            {
                MessageBox.Show("yanlıs");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Clear();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void musterigirisekranı_Load(object sender, EventArgs e)
        {

        }
    }
}
