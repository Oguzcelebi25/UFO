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
    public partial class kullanıcıgirsi : Form
    {
        public kullanıcıgirsi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection bag = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=kullanıcı.mdb");
                bag.Open();
                OleDbCommand sor = new OleDbCommand("select  kullanıcıadı,sifre from kullanıcıbilgi where kullanıcıadı=@kullanıcıadı and sifre=@sifre", bag);
                sor.Parameters.AddWithValue("@kullanıcıadı", textBox1.Text);
                sor.Parameters.AddWithValue("@sifre", textBox2.Text);
                OleDbDataReader drr;
                drr = sor.ExecuteReader();

                if (drr.Read())
                {
                    kullanıcıözelleştir köz = new kullanıcıözelleştir();
                    köz.Show();
                    this.Visible = false;
                }
                else
                {
                    bag.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıcıgirsi_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

