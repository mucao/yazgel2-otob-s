﻿namespace yazgel2_otobus
{
    partial class anasayfa
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iptalPanel = new System.Windows.Forms.Panel();
            this.tcBox = new System.Windows.Forms.TextBox();
            this.araBtn = new System.Windows.Forms.Button();
            this.iptalEtBtn = new System.Windows.Forms.Button();
            this.sfrBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blt = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.biletFiyat = new System.Windows.Forms.Label();
            this.adSoyad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ylcLbl = new System.Windows.Forms.Label();
            this.sfrLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toplamBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.iptalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iptalPanel);
            this.panel1.Controls.Add(this.toplamBtn);
            this.panel1.Controls.Add(this.iptalBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ylcLbl);
            this.panel1.Controls.Add(this.sfrLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 395);
            this.panel1.TabIndex = 0;
            // 
            // iptalPanel
            // 
            this.iptalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iptalPanel.Controls.Add(this.tcBox);
            this.iptalPanel.Controls.Add(this.araBtn);
            this.iptalPanel.Controls.Add(this.iptalEtBtn);
            this.iptalPanel.Controls.Add(this.sfrBox);
            this.iptalPanel.Controls.Add(this.label4);
            this.iptalPanel.Controls.Add(this.blt);
            this.iptalPanel.Controls.Add(this.ad);
            this.iptalPanel.Controls.Add(this.biletFiyat);
            this.iptalPanel.Controls.Add(this.adSoyad);
            this.iptalPanel.Controls.Add(this.label6);
            this.iptalPanel.Location = new System.Drawing.Point(520, 42);
            this.iptalPanel.Name = "iptalPanel";
            this.iptalPanel.Size = new System.Drawing.Size(342, 310);
            this.iptalPanel.TabIndex = 2;
            // 
            // tcBox
            // 
            this.tcBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcBox.Location = new System.Drawing.Point(180, 66);
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(117, 26);
            this.tcBox.TabIndex = 1;
            // 
            // araBtn
            // 
            this.araBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.araBtn.Location = new System.Drawing.Point(227, 104);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(70, 36);
            this.araBtn.TabIndex = 1;
            this.araBtn.Text = "Ara";
            this.araBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // iptalEtBtn
            // 
            this.iptalEtBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalEtBtn.Image = ((System.Drawing.Image)(resources.GetObject("iptalEtBtn.Image")));
            this.iptalEtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iptalEtBtn.Location = new System.Drawing.Point(96, 232);
            this.iptalEtBtn.Name = "iptalEtBtn";
            this.iptalEtBtn.Size = new System.Drawing.Size(160, 62);
            this.iptalEtBtn.TabIndex = 1;
            this.iptalEtBtn.Text = "İptal Et";
            this.iptalEtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iptalEtBtn.UseVisualStyleBackColor = true;
            this.iptalEtBtn.Click += new System.EventHandler(this.iptalEtBtn_Click);
            // 
            // sfrBox
            // 
            this.sfrBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrBox.Location = new System.Drawing.Point(180, 28);
            this.sfrBox.Name = "sfrBox";
            this.sfrBox.Size = new System.Drawing.Size(117, 26);
            this.sfrBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC Kimlik Numarası:";
            // 
            // blt
            // 
            this.blt.AutoSize = true;
            this.blt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blt.Location = new System.Drawing.Point(183, 188);
            this.blt.Name = "blt";
            this.blt.Size = new System.Drawing.Size(89, 20);
            this.blt.TabIndex = 0;
            this.blt.Text = "Adı Soyadı:";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(183, 144);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(89, 20);
            this.ad.TabIndex = 0;
            this.ad.Text = "Adı Soyadı:";
            // 
            // biletFiyat
            // 
            this.biletFiyat.AutoSize = true;
            this.biletFiyat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletFiyat.Location = new System.Drawing.Point(79, 188);
            this.biletFiyat.Name = "biletFiyat";
            this.biletFiyat.Size = new System.Drawing.Size(83, 20);
            this.biletFiyat.TabIndex = 0;
            this.biletFiyat.Text = "Bilet Fiyatı:";
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.Location = new System.Drawing.Point(73, 144);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(89, 20);
            this.adSoyad.TabIndex = 0;
            this.adSoyad.Text = "Adı Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sefer Numarası:";
            // 
            // iptalBtn
            // 
            this.iptalBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalBtn.Image = ((System.Drawing.Image)(resources.GetObject("iptalBtn.Image")));
            this.iptalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iptalBtn.Location = new System.Drawing.Point(99, 209);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(165, 62);
            this.iptalBtn.TabIndex = 1;
            this.iptalBtn.Text = "Satış İptal";
            this.iptalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yolcu Sayısı:";
            // 
            // ylcLbl
            // 
            this.ylcLbl.AutoSize = true;
            this.ylcLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ylcLbl.Location = new System.Drawing.Point(241, 152);
            this.ylcLbl.Name = "ylcLbl";
            this.ylcLbl.Size = new System.Drawing.Size(34, 24);
            this.ylcLbl.TabIndex = 0;
            this.ylcLbl.Text = "18";
            // 
            // sfrLbl
            // 
            this.sfrLbl.AutoSize = true;
            this.sfrLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrLbl.Location = new System.Drawing.Point(241, 83);
            this.sfrLbl.Name = "sfrLbl";
            this.sfrLbl.Size = new System.Drawing.Size(34, 24);
            this.sfrLbl.TabIndex = 0;
            this.sfrLbl.Text = "18";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(28, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "  Anasayfa   ";
            // 
            // toplamBtn
            // 
            this.toplamBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamBtn.Image = ((System.Drawing.Image)(resources.GetObject("toplamBtn.Image")));
            this.toplamBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toplamBtn.Location = new System.Drawing.Point(99, 290);
            this.toplamBtn.Name = "toplamBtn";
            this.toplamBtn.Size = new System.Drawing.Size(165, 62);
            this.toplamBtn.TabIndex = 1;
            this.toplamBtn.Text = "Toplam Gelir";
            this.toplamBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toplamBtn.UseVisualStyleBackColor = true;
            this.toplamBtn.Click += new System.EventHandler(this.toplamBtn_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "anasayfa";
            this.Size = new System.Drawing.Size(962, 429);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.iptalPanel.ResumeLayout(false);
            this.iptalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel iptalPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ylcLbl;
        private System.Windows.Forms.Label sfrLbl;
        private System.Windows.Forms.TextBox tcBox;
        private System.Windows.Forms.TextBox sfrBox;
        private System.Windows.Forms.Label blt;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label biletFiyat;
        private System.Windows.Forms.Label adSoyad;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Button iptalEtBtn;
        private System.Windows.Forms.Button toplamBtn;
    }
}
