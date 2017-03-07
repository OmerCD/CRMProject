namespace CRMKurs.Öğrenci
{
    partial class frmÖğrenciDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÖğrenciDüzenle));
            this.rbKurum = new System.Windows.Forms.RadioButton();
            this.rbKişi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBHitap = new System.Windows.Forms.ComboBox();
            this.txtBAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBTür = new System.Windows.Forms.TextBox();
            this.txtBEposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBSınıf = new System.Windows.Forms.ComboBox();
            this.txtBTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBAdres = new System.Windows.Forms.TextBox();
            this.cBİl = new System.Windows.Forms.ComboBox();
            this.txtBBölge = new System.Windows.Forms.TextBox();
            this.txtBÜlke = new System.Windows.Forms.TextBox();
            this.txtBPostaKodu = new System.Windows.Forms.TextBox();
            this.txtBNotlar = new System.Windows.Forms.TextBox();
            this.btnEpostaMA = new System.Windows.Forms.Button();
            this.btnTelefonMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cBOkul = new CRMKurs.CustomTools.DataComboBox();
            this.SuspendLayout();
            // 
            // rbKurum
            // 
            this.rbKurum.AutoSize = true;
            this.rbKurum.Location = new System.Drawing.Point(141, 27);
            this.rbKurum.Name = "rbKurum";
            this.rbKurum.Size = new System.Drawing.Size(55, 17);
            this.rbKurum.TabIndex = 8;
            this.rbKurum.TabStop = true;
            this.rbKurum.Text = "Kurum";
            this.rbKurum.UseVisualStyleBackColor = true;
            // 
            // rbKişi
            // 
            this.rbKişi.AutoSize = true;
            this.rbKişi.Location = new System.Drawing.Point(84, 27);
            this.rbKişi.Name = "rbKişi";
            this.rbKişi.Size = new System.Drawing.Size(41, 17);
            this.rbKişi.TabIndex = 7;
            this.rbKişi.TabStop = true;
            this.rbKişi.Text = "Kişi";
            this.rbKişi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tür";
            // 
            // cBHitap
            // 
            this.cBHitap.FormattingEnabled = true;
            this.cBHitap.Items.AddRange(new object[] {
            "Bay",
            "Bayan",
            "Doktor",
            "Profesör",
            "Pr. Dtr."});
            this.cBHitap.Location = new System.Drawing.Point(84, 92);
            this.cBHitap.Name = "cBHitap";
            this.cBHitap.Size = new System.Drawing.Size(100, 21);
            this.cBHitap.TabIndex = 12;
            // 
            // txtBAdSoyad
            // 
            this.txtBAdSoyad.Location = new System.Drawing.Point(84, 63);
            this.txtBAdSoyad.Name = "txtBAdSoyad";
            this.txtBAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtBAdSoyad.TabIndex = 11;
            this.txtBAdSoyad.Text = "Ömer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ad Soyad";
            // 
            // txtBTür
            // 
            this.txtBTür.Location = new System.Drawing.Point(84, 122);
            this.txtBTür.Name = "txtBTür";
            this.txtBTür.Size = new System.Drawing.Size(100, 20);
            this.txtBTür.TabIndex = 14;
            this.txtBTür.Text = "Sol";
            // 
            // txtBEposta
            // 
            this.txtBEposta.Location = new System.Drawing.Point(84, 151);
            this.txtBEposta.Name = "txtBEposta";
            this.txtBEposta.Size = new System.Drawing.Size(100, 20);
            this.txtBEposta.TabIndex = 15;
            this.txtBEposta.Text = "asd@hotmail.com.tr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Okul";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sınıf";
            // 
            // cBSınıf
            // 
            this.cBSınıf.FormattingEnabled = true;
            this.cBSınıf.Location = new System.Drawing.Point(84, 210);
            this.cBSınıf.Name = "cBSınıf";
            this.cBSınıf.Size = new System.Drawing.Size(100, 21);
            this.cBSınıf.TabIndex = 20;
            // 
            // txtBTelefon
            // 
            this.txtBTelefon.Location = new System.Drawing.Point(83, 240);
            this.txtBTelefon.Name = "txtBTelefon";
            this.txtBTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtBTelefon.TabIndex = 21;
            this.txtBTelefon.Text = "543605128";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "İl";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bölge";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ülke";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Posta Kodu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Notlar";
            // 
            // txtBAdres
            // 
            this.txtBAdres.Location = new System.Drawing.Point(312, 18);
            this.txtBAdres.Multiline = true;
            this.txtBAdres.Name = "txtBAdres";
            this.txtBAdres.Size = new System.Drawing.Size(292, 61);
            this.txtBAdres.TabIndex = 29;
            this.txtBAdres.Text = "asdasdasd";
            // 
            // cBİl
            // 
            this.cBİl.FormattingEnabled = true;
            this.cBİl.Items.AddRange(new object[] {
            "Adana ",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne ",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van ",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cBİl.Location = new System.Drawing.Point(350, 94);
            this.cBİl.Name = "cBİl";
            this.cBİl.Size = new System.Drawing.Size(121, 21);
            this.cBİl.TabIndex = 30;
            // 
            // txtBBölge
            // 
            this.txtBBölge.Location = new System.Drawing.Point(350, 130);
            this.txtBBölge.Name = "txtBBölge";
            this.txtBBölge.Size = new System.Drawing.Size(100, 20);
            this.txtBBölge.TabIndex = 31;
            this.txtBBölge.Text = "SSağ";
            // 
            // txtBÜlke
            // 
            this.txtBÜlke.Location = new System.Drawing.Point(350, 165);
            this.txtBÜlke.Name = "txtBÜlke";
            this.txtBÜlke.Size = new System.Drawing.Size(100, 20);
            this.txtBÜlke.TabIndex = 32;
            this.txtBÜlke.Text = "Zimbabwe";
            // 
            // txtBPostaKodu
            // 
            this.txtBPostaKodu.Location = new System.Drawing.Point(350, 200);
            this.txtBPostaKodu.Name = "txtBPostaKodu";
            this.txtBPostaKodu.Size = new System.Drawing.Size(100, 20);
            this.txtBPostaKodu.TabIndex = 33;
            this.txtBPostaKodu.Text = "34303";
            // 
            // txtBNotlar
            // 
            this.txtBNotlar.Location = new System.Drawing.Point(312, 235);
            this.txtBNotlar.Multiline = true;
            this.txtBNotlar.Name = "txtBNotlar";
            this.txtBNotlar.Size = new System.Drawing.Size(292, 61);
            this.txtBNotlar.TabIndex = 34;
            this.txtBNotlar.Text = "Yok";
            // 
            // btnEpostaMA
            // 
            this.btnEpostaMA.Location = new System.Drawing.Point(190, 149);
            this.btnEpostaMA.Name = "btnEpostaMA";
            this.btnEpostaMA.Size = new System.Drawing.Size(27, 23);
            this.btnEpostaMA.TabIndex = 35;
            this.btnEpostaMA.Text = "+";
            this.btnEpostaMA.UseVisualStyleBackColor = true;
            this.btnEpostaMA.Click += new System.EventHandler(this.btnEpostaMA_Click);
            // 
            // btnTelefonMA
            // 
            this.btnTelefonMA.Location = new System.Drawing.Point(190, 237);
            this.btnTelefonMA.Name = "btnTelefonMA";
            this.btnTelefonMA.Size = new System.Drawing.Size(27, 23);
            this.btnTelefonMA.TabIndex = 36;
            this.btnTelefonMA.Text = "+";
            this.btnTelefonMA.UseVisualStyleBackColor = true;
            this.btnTelefonMA.Click += new System.EventHandler(this.btnTelefonMA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBOkul
            // 
            this.cBOkul.FormattingEnabled = true;
            this.cBOkul.Location = new System.Drawing.Point(83, 178);
            this.cBOkul.Name = "cBOkul";
            this.cBOkul.RealValues = ((System.Collections.Generic.List<string>)(resources.GetObject("cBOkul.RealValues")));
            this.cBOkul.Size = new System.Drawing.Size(101, 21);
            this.cBOkul.TabIndex = 38;
            // 
            // frmÖğrenciDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 364);
            this.Controls.Add(this.cBOkul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTelefonMA);
            this.Controls.Add(this.btnEpostaMA);
            this.Controls.Add(this.txtBNotlar);
            this.Controls.Add(this.txtBPostaKodu);
            this.Controls.Add(this.txtBÜlke);
            this.Controls.Add(this.txtBBölge);
            this.Controls.Add(this.cBİl);
            this.Controls.Add(this.txtBAdres);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBTelefon);
            this.Controls.Add(this.cBSınıf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBEposta);
            this.Controls.Add(this.txtBTür);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBHitap);
            this.Controls.Add(this.txtBAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbKurum);
            this.Controls.Add(this.rbKişi);
            this.Controls.Add(this.label1);
            this.Name = "frmÖğrenciDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmÖğrenciDüzenle";
            this.Load += new System.EventHandler(this.frmÖğrenciDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKurum;
        private System.Windows.Forms.RadioButton rbKişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBHitap;
        private System.Windows.Forms.TextBox txtBAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBTür;
        private System.Windows.Forms.TextBox txtBEposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBSınıf;
        private System.Windows.Forms.TextBox txtBTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBAdres;
        private System.Windows.Forms.ComboBox cBİl;
        private System.Windows.Forms.TextBox txtBBölge;
        private System.Windows.Forms.TextBox txtBÜlke;
        private System.Windows.Forms.TextBox txtBPostaKodu;
        private System.Windows.Forms.TextBox txtBNotlar;
        private System.Windows.Forms.Button btnEpostaMA;
        private System.Windows.Forms.Button btnTelefonMA;
        private System.Windows.Forms.Button button1;
        private CustomTools.DataComboBox cBOkul;
    }
}