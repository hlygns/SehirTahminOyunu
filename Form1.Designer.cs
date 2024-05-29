namespace Şehir_Tahmin_Oyunu1
{
    partial class Form1
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
            this.GrpOyunAlani = new System.Windows.Forms.GroupBox();
            this.GrpCevapAlani = new System.Windows.Forms.GroupBox();
            this.LblKalanHak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGirilenHarfler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKelime = new System.Windows.Forms.TextBox();
            this.BtnTahminEt = new System.Windows.Forms.Button();
            this.BtnHarfGir = new System.Windows.Forms.Button();
            this.TxtHarf = new System.Windows.Forms.TextBox();
            this.BtnYeniOyunBaslat = new System.Windows.Forms.Button();
            this.GrpCevapAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpOyunAlani
            // 
            this.GrpOyunAlani.Location = new System.Drawing.Point(55, 83);
            this.GrpOyunAlani.Name = "GrpOyunAlani";
            this.GrpOyunAlani.Size = new System.Drawing.Size(427, 119);
            this.GrpOyunAlani.TabIndex = 0;
            this.GrpOyunAlani.TabStop = false;
            this.GrpOyunAlani.Text = "Soru Alanı";
            // 
            // GrpCevapAlani
            // 
            this.GrpCevapAlani.Controls.Add(this.LblKalanHak);
            this.GrpCevapAlani.Controls.Add(this.label2);
            this.GrpCevapAlani.Controls.Add(this.LblGirilenHarfler);
            this.GrpCevapAlani.Controls.Add(this.label1);
            this.GrpCevapAlani.Controls.Add(this.TxtKelime);
            this.GrpCevapAlani.Controls.Add(this.BtnTahminEt);
            this.GrpCevapAlani.Controls.Add(this.BtnHarfGir);
            this.GrpCevapAlani.Controls.Add(this.TxtHarf);
            this.GrpCevapAlani.Location = new System.Drawing.Point(55, 227);
            this.GrpCevapAlani.Name = "GrpCevapAlani";
            this.GrpCevapAlani.Size = new System.Drawing.Size(427, 119);
            this.GrpCevapAlani.TabIndex = 1;
            this.GrpCevapAlani.TabStop = false;
            this.GrpCevapAlani.Text = "Cevap Alanı";
            // 
            // LblKalanHak
            // 
            this.LblKalanHak.AutoSize = true;
            this.LblKalanHak.Location = new System.Drawing.Point(84, 100);
            this.LblKalanHak.Name = "LblKalanHak";
            this.LblKalanHak.Size = new System.Drawing.Size(14, 16);
            this.LblKalanHak.TabIndex = 7;
            this.LblKalanHak.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Hak:";
            // 
            // LblGirilenHarfler
            // 
            this.LblGirilenHarfler.AutoSize = true;
            this.LblGirilenHarfler.Location = new System.Drawing.Point(102, 69);
            this.LblGirilenHarfler.Name = "LblGirilenHarfler";
            this.LblGirilenHarfler.Size = new System.Drawing.Size(0, 16);
            this.LblGirilenHarfler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler";
            // 
            // TxtKelime
            // 
            this.TxtKelime.Location = new System.Drawing.Point(235, 32);
            this.TxtKelime.Name = "TxtKelime";
            this.TxtKelime.Size = new System.Drawing.Size(100, 22);
            this.TxtKelime.TabIndex = 3;
            // 
            // BtnTahminEt
            // 
            this.BtnTahminEt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnTahminEt.Location = new System.Drawing.Point(341, 31);
            this.BtnTahminEt.Name = "BtnTahminEt";
            this.BtnTahminEt.Size = new System.Drawing.Size(80, 25);
            this.BtnTahminEt.TabIndex = 2;
            this.BtnTahminEt.Text = "Tahmin Et";
            this.BtnTahminEt.UseVisualStyleBackColor = false;
            this.BtnTahminEt.Click += new System.EventHandler(this.BtnTahminEt_Click);
            // 
            // BtnHarfGir
            // 
            this.BtnHarfGir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnHarfGir.Location = new System.Drawing.Point(112, 30);
            this.BtnHarfGir.Name = "BtnHarfGir";
            this.BtnHarfGir.Size = new System.Drawing.Size(78, 25);
            this.BtnHarfGir.TabIndex = 1;
            this.BtnHarfGir.Text = "Harf Gir";
            this.BtnHarfGir.UseVisualStyleBackColor = false;
            this.BtnHarfGir.Click += new System.EventHandler(this.BtnHarfGir_Click);
            // 
            // TxtHarf
            // 
            this.TxtHarf.Location = new System.Drawing.Point(6, 31);
            this.TxtHarf.Name = "TxtHarf";
            this.TxtHarf.Size = new System.Drawing.Size(100, 22);
            this.TxtHarf.TabIndex = 0;
            this.TxtHarf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnYeniOyunBaslat
            // 
            this.BtnYeniOyunBaslat.Location = new System.Drawing.Point(55, 27);
            this.BtnYeniOyunBaslat.Name = "BtnYeniOyunBaslat";
            this.BtnYeniOyunBaslat.Size = new System.Drawing.Size(427, 26);
            this.BtnYeniOyunBaslat.TabIndex = 2;
            this.BtnYeniOyunBaslat.Text = "Yeni Oyun Başlat";
            this.BtnYeniOyunBaslat.UseVisualStyleBackColor = true;
            this.BtnYeniOyunBaslat.Click += new System.EventHandler(this.BtnYeniOyunBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnYeniOyunBaslat);
            this.Controls.Add(this.GrpCevapAlani);
            this.Controls.Add(this.GrpOyunAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpCevapAlani.ResumeLayout(false);
            this.GrpCevapAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpOyunAlani;
        private System.Windows.Forms.GroupBox GrpCevapAlani;
        private System.Windows.Forms.TextBox TxtHarf;
        private System.Windows.Forms.Button BtnYeniOyunBaslat;
        private System.Windows.Forms.TextBox TxtKelime;
        private System.Windows.Forms.Button BtnTahminEt;
        private System.Windows.Forms.Button BtnHarfGir;
        private System.Windows.Forms.Label LblKalanHak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGirilenHarfler;
        private System.Windows.Forms.Label label1;
    }
}

