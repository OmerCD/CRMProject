namespace CRMKurs.Okul
{
    partial class frmKurumDüzenle
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnTelefonMA = new System.Windows.Forms.Button();
            this.btnEpostaMA = new System.Windows.Forms.Button();
            this.txtBNotlar = new System.Windows.Forms.TextBox();
            this.txtBPostaKodu = new System.Windows.Forms.TextBox();
            this.txtBÜlke = new System.Windows.Forms.TextBox();
            this.txtBBölge = new System.Windows.Forms.TextBox();
            this.cBİl = new System.Windows.Forms.ComboBox();
            this.txtBAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBEposta = new System.Windows.Forms.TextBox();
            this.txtBTür = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbKurum = new System.Windows.Forms.RadioButton();
            this.rbKişi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(21, 325);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 69;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnTelefonMA
            // 
            this.btnTelefonMA.Location = new System.Drawing.Point(183, 233);
            this.btnTelefonMA.Name = "btnTelefonMA";
            this.btnTelefonMA.Size = new System.Drawing.Size(27, 23);
            this.btnTelefonMA.TabIndex = 68;
            this.btnTelefonMA.Text = "+";
            this.btnTelefonMA.UseVisualStyleBackColor = true;
            // 
            // btnEpostaMA
            // 
            this.btnEpostaMA.Location = new System.Drawing.Point(183, 145);
            this.btnEpostaMA.Name = "btnEpostaMA";
            this.btnEpostaMA.Size = new System.Drawing.Size(27, 23);
            this.btnEpostaMA.TabIndex = 67;
            this.btnEpostaMA.Text = "+";
            this.btnEpostaMA.UseVisualStyleBackColor = true;
            // 
            // txtBNotlar
            // 
            this.txtBNotlar.Location = new System.Drawing.Point(305, 231);
            this.txtBNotlar.Multiline = true;
            this.txtBNotlar.Name = "txtBNotlar";
            this.txtBNotlar.Size = new System.Drawing.Size(292, 61);
            this.txtBNotlar.TabIndex = 66;
            // 
            // txtBPostaKodu
            // 
            this.txtBPostaKodu.Location = new System.Drawing.Point(343, 196);
            this.txtBPostaKodu.Name = "txtBPostaKodu";
            this.txtBPostaKodu.Size = new System.Drawing.Size(100, 20);
            this.txtBPostaKodu.TabIndex = 65;
            // 
            // txtBÜlke
            // 
            this.txtBÜlke.Location = new System.Drawing.Point(343, 161);
            this.txtBÜlke.Name = "txtBÜlke";
            this.txtBÜlke.Size = new System.Drawing.Size(100, 20);
            this.txtBÜlke.TabIndex = 64;
            // 
            // txtBBölge
            // 
            this.txtBBölge.Location = new System.Drawing.Point(343, 126);
            this.txtBBölge.Name = "txtBBölge";
            this.txtBBölge.Size = new System.Drawing.Size(100, 20);
            this.txtBBölge.TabIndex = 63;
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
            this.cBİl.Location = new System.Drawing.Point(343, 90);
            this.cBİl.Name = "cBİl";
            this.cBİl.Size = new System.Drawing.Size(121, 21);
            this.cBİl.TabIndex = 62;
            // 
            // txtBAdres
            // 
            this.txtBAdres.Location = new System.Drawing.Point(305, 14);
            this.txtBAdres.Multiline = true;
            this.txtBAdres.Name = "txtBAdres";
            this.txtBAdres.Size = new System.Drawing.Size(292, 61);
            this.txtBAdres.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(264, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Notlar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Posta Kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Ülke";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Bölge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "İl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Telefon";
            // 
            // txtBTelefon
            // 
            this.txtBTelefon.Location = new System.Drawing.Point(76, 236);
            this.txtBTelefon.Name = "txtBTelefon";
            this.txtBTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtBTelefon.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "E-Posta";
            // 
            // txtBEposta
            // 
            this.txtBEposta.Location = new System.Drawing.Point(77, 147);
            this.txtBEposta.Name = "txtBEposta";
            this.txtBEposta.Size = new System.Drawing.Size(100, 20);
            this.txtBEposta.TabIndex = 47;
            // 
            // txtBTür
            // 
            this.txtBTür.Location = new System.Drawing.Point(77, 118);
            this.txtBTür.Name = "txtBTür";
            this.txtBTür.Size = new System.Drawing.Size(100, 20);
            this.txtBTür.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tür";
            // 
            // txtBAdSoyad
            // 
            this.txtBAdSoyad.Location = new System.Drawing.Point(77, 59);
            this.txtBAdSoyad.Name = "txtBAdSoyad";
            this.txtBAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtBAdSoyad.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "İsim";
            // 
            // rbKurum
            // 
            this.rbKurum.AutoSize = true;
            this.rbKurum.Location = new System.Drawing.Point(134, 23);
            this.rbKurum.Name = "rbKurum";
            this.rbKurum.Size = new System.Drawing.Size(55, 17);
            this.rbKurum.TabIndex = 40;
            this.rbKurum.TabStop = true;
            this.rbKurum.Text = "Kurum";
            this.rbKurum.UseVisualStyleBackColor = true;
            // 
            // rbKişi
            // 
            this.rbKişi.AutoSize = true;
            this.rbKişi.Location = new System.Drawing.Point(77, 23);
            this.rbKişi.Name = "rbKişi";
            this.rbKişi.Size = new System.Drawing.Size(41, 17);
            this.rbKişi.TabIndex = 39;
            this.rbKişi.TabStop = true;
            this.rbKişi.Text = "Kişi";
            this.rbKişi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tipi";
            // 
            // frmKurumDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 373);
            this.Controls.Add(this.btnOnayla);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBEposta);
            this.Controls.Add(this.txtBTür);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbKurum);
            this.Controls.Add(this.rbKişi);
            this.Controls.Add(this.label1);
            this.Name = "frmKurumDüzenle";
            this.Text = "frmKurumDüzenle";
            this.Load += new System.EventHandler(this.frmKurumDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnTelefonMA;
        private System.Windows.Forms.Button btnEpostaMA;
        private System.Windows.Forms.TextBox txtBNotlar;
        private System.Windows.Forms.TextBox txtBPostaKodu;
        private System.Windows.Forms.TextBox txtBÜlke;
        private System.Windows.Forms.TextBox txtBBölge;
        private System.Windows.Forms.ComboBox cBİl;
        private System.Windows.Forms.TextBox txtBAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBEposta;
        private System.Windows.Forms.TextBox txtBTür;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbKurum;
        private System.Windows.Forms.RadioButton rbKişi;
        private System.Windows.Forms.Label label1;
    }
}