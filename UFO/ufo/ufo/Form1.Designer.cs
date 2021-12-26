
namespace ufo
{
    partial class UFO
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_müsteri = new System.Windows.Forms.Button();
            this.btn_kullanıcı = new System.Windows.Forms.Button();
            this.lbl_hosgeldiniz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_müsteri
            // 
            this.btn_müsteri.Location = new System.Drawing.Point(494, 77);
            this.btn_müsteri.Name = "btn_müsteri";
            this.btn_müsteri.Size = new System.Drawing.Size(127, 96);
            this.btn_müsteri.TabIndex = 0;
            this.btn_müsteri.Text = "MÜSTERİ GİRİSİ";
            this.btn_müsteri.UseVisualStyleBackColor = true;
            this.btn_müsteri.Click += new System.EventHandler(this.btn_müsteri_Click);
            // 
            // btn_kullanıcı
            // 
            this.btn_kullanıcı.Location = new System.Drawing.Point(494, 195);
            this.btn_kullanıcı.Name = "btn_kullanıcı";
            this.btn_kullanıcı.Size = new System.Drawing.Size(127, 106);
            this.btn_kullanıcı.TabIndex = 1;
            this.btn_kullanıcı.Text = "KULLANICI GİRİSİ";
            this.btn_kullanıcı.UseVisualStyleBackColor = true;
            this.btn_kullanıcı.Click += new System.EventHandler(this.btn_kullanıcı_Click);
            // 
            // lbl_hosgeldiniz
            // 
            this.lbl_hosgeldiniz.AutoSize = true;
            this.lbl_hosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hosgeldiniz.ForeColor = System.Drawing.Color.Red;
            this.lbl_hosgeldiniz.Location = new System.Drawing.Point(456, 23);
            this.lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            this.lbl_hosgeldiniz.Size = new System.Drawing.Size(156, 25);
            this.lbl_hosgeldiniz.TabIndex = 2;
            this.lbl_hosgeldiniz.Text = "HOSGELDİNİZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ufo.Properties.Resources.U_F_O__1_;
            this.pictureBox1.Location = new System.Drawing.Point(494, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.lbl_hosgeldiniz);
            this.Controls.Add(this.btn_kullanıcı);
            this.Controls.Add(this.btn_müsteri);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "UFO";
            this.Text = "UFO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_müsteri;
        private System.Windows.Forms.Button btn_kullanıcı;
        private System.Windows.Forms.Label lbl_hosgeldiniz;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

