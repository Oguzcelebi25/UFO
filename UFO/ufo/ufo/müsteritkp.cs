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
    public partial class müsteritkp : Form
    {
        public müsteritkp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Musteritakip.mdb");
        private void veriler()
        {
            bag.Open();
            OleDbCommand komu = new OleDbCommand();
            komu.Connection = bag;
            komu.CommandText = ("select * from Takip");
            OleDbDataReader oku = komu.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MüsteriAdresi"].ToString();
                ekle.SubItems.Add(oku["Sipariş"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["MusteriAdı"].ToString());
               
               


                listView1.Items.Add(ekle);

            }
            bag.Close();
        }

        private void müsteritkp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
