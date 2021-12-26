
namespace ufo
{
    partial class kullanıcıurun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.urnfytt = new System.Windows.Forms.TextBox();
            this.textBox2urnagrr = new System.Windows.Forms.TextBox();
            this.urnadd = new System.Windows.Forms.TextBox();
            this.urnagrrfdgfd = new System.Windows.Forms.Label();
            this.urnfyttgggfd = new System.Windows.Forms.Label();
            this.fgf = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.urnad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnfyt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnagr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // urnfytt
            // 
            this.urnfytt.Location = new System.Drawing.Point(179, 103);
            this.urnfytt.Name = "urnfytt";
            this.urnfytt.Size = new System.Drawing.Size(131, 22);
            this.urnfytt.TabIndex = 19;
            // 
            // textBox2urnagrr
            // 
            this.textBox2urnagrr.Location = new System.Drawing.Point(179, 174);
            this.textBox2urnagrr.Name = "textBox2urnagrr";
            this.textBox2urnagrr.Size = new System.Drawing.Size(131, 22);
            this.textBox2urnagrr.TabIndex = 18;
            // 
            // urnadd
            // 
            this.urnadd.Location = new System.Drawing.Point(179, 36);
            this.urnadd.Name = "urnadd";
            this.urnadd.Size = new System.Drawing.Size(131, 22);
            this.urnadd.TabIndex = 17;
            // 
            // urnagrrfdgfd
            // 
            this.urnagrrfdgfd.AutoSize = true;
            this.urnagrrfdgfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urnagrrfdgfd.Location = new System.Drawing.Point(43, 174);
            this.urnagrrfdgfd.Name = "urnagrrfdgfd";
            this.urnagrrfdgfd.Size = new System.Drawing.Size(100, 22);
            this.urnagrrfdgfd.TabIndex = 16;
            this.urnagrrfdgfd.Text = "ürün adeti";
            // 
            // urnfyttgggfd
            // 
            this.urnfyttgggfd.AutoSize = true;
            this.urnfyttgggfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urnfyttgggfd.Location = new System.Drawing.Point(43, 101);
            this.urnfyttgggfd.Name = "urnfyttgggfd";
            this.urnfyttgggfd.Size = new System.Drawing.Size(99, 22);
            this.urnfyttgggfd.TabIndex = 15;
            this.urnfyttgggfd.Text = "ürün fiyatı";
            // 
            // fgf
            // 
            this.fgf.AutoSize = true;
            this.fgf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fgf.Location = new System.Drawing.Point(43, 36);
            this.fgf.Name = "fgf";
            this.fgf.Size = new System.Drawing.Size(83, 22);
            this.fgf.TabIndex = 14;
            this.fgf.Text = "ürün adı";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urnad,
            this.urnfyt,
            this.urnagr});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 233);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(706, 194);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // urnad
            // 
            this.urnad.Text = "adı";
            this.urnad.Width = 249;
            // 
            // urnfyt
            // 
            this.urnfyt.Text = "ürün fiyatı";
            this.urnfyt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urnfyt.Width = 223;
            // 
            // urnagr
            // 
            this.urnagr.Text = "ürün adeti";
            this.urnagr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urnagr.Width = 220;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 82);
            this.button3.TabIndex = 12;
            this.button3.Text = "ürünü değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 88);
            this.button2.TabIndex = 11;
            this.button2.Text = "ürün çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 106);
            this.button1.TabIndex = 10;
            this.button1.Text = "ürün ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ufo.Properties.Resources.U_F_O__1_;
            this.pictureBox1.Location = new System.Drawing.Point(192, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // kullanıcıurun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.urnfytt);
            this.Controls.Add(this.textBox2urnagrr);
            this.Controls.Add(this.urnadd);
            this.Controls.Add(this.urnagrrfdgfd);
            this.Controls.Add(this.urnfyttgggfd);
            this.Controls.Add(this.fgf);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kullanıcıurun";
            this.Text = "kullanıcıurun";
            this.Load += new System.EventHandler(this.kullanıcıurun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urnfytt;
        private System.Windows.Forms.TextBox textBox2urnagrr;
        private System.Windows.Forms.TextBox urnadd;
        private System.Windows.Forms.Label urnagrrfdgfd;
        private System.Windows.Forms.Label urnfyttgggfd;
        private System.Windows.Forms.Label fgf;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader urnad;
        private System.Windows.Forms.ColumnHeader urnfyt;
        private System.Windows.Forms.ColumnHeader urnagr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}