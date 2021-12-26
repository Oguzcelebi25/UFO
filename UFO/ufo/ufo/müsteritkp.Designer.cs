
namespace ufo
{
    partial class müsteritkp
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sipariss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.müsteriadıı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "verilen siparişler ayrıntılarıyla beraber aşşağıda gösterilmektedir";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.adress,
            this.sipariss,
            this.fiyat,
            this.müsteriadıı});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 207);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 197);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // adress
            // 
            this.adress.DisplayIndex = 1;
            this.adress.Text = "müşteri adresi";
            this.adress.Width = 250;
            // 
            // sipariss
            // 
            this.sipariss.DisplayIndex = 2;
            this.sipariss.Text = "sipariş";
            // 
            // fiyat
            // 
            this.fiyat.DisplayIndex = 3;
            this.fiyat.Text = "fiyatt";
            // 
            // müsteriadıı
            // 
            this.müsteriadıı.DisplayIndex = 0;
            this.müsteriadıı.Text = "müşteri adı";
            this.müsteriadıı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.müsteriadıı.Width = 172;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // müsteritkp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "müsteritkp";
            this.Text = "müsteritkp";
            this.Load += new System.EventHandler(this.müsteritkp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader adress;
        private System.Windows.Forms.ColumnHeader sipariss;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader müsteriadıı;
        private System.Windows.Forms.Button button2;
    }
}