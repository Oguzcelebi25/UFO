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
    public partial class kullanıcıurun : Form
    {
        public kullanıcıurun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void kullanıcıurun_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.AllowColumnReorder = true;
            listView1.CheckBoxes = true;
            listView1.Columns.Add("adı", 100);
            listView1.Columns.Add("ürün fiyatı", 100);
            listView1.Columns.Add("ürün adeti", 100);
            listView1.CheckBoxes = true;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)

            {
                ListViewItem item = listView1.SelectedItems[0];

                urnadd.Text = item.SubItems[0].Text;
                urnfytt.Text = item.SubItems[1].Text;
                textBox2urnagrr.Text = item.SubItems[2].Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sira = listView1.Items.Count;
            listView1.Items.Add(urnadd.Text);
            listView1.Items[sira].SubItems.Add(urnfytt.Text);
            listView1.Items[sira].SubItems.Add(textBox2urnagrr.Text);
            textBox2urnagrr.Clear();
            urnadd.Clear();
            urnfytt.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("lütfen bir seçim yapın");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
                int sira = listView1.Items.Count;
                listView1.Items.Add(urnadd.Text);
                listView1.Items[sira].SubItems.Add(urnfytt.Text);
                listView1.Items[sira].SubItems.Add(textBox2urnagrr.Text);
                textBox2urnagrr.Clear();
                urnadd.Clear();
                urnfytt.Clear();
            }

            else
            {
                MessageBox.Show("lütfen bir seçim yapın");
            }
        }
    }
}
