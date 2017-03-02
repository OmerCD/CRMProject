namespace CRMKurs.Okul
{
    partial class frmOkul
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
            this.lVOkullar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostaKodu = new System.Windows.Forms.Label();
            this.lblÜlke = new System.Windows.Forms.Label();
            this.lblBölge = new System.Windows.Forms.Label();
            this.lblİl = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTür = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtBNotlar = new System.Windows.Forms.TextBox();
            this.txtBAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lVOkullar
            // 
            this.lVOkullar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lVOkullar.FullRowSelect = true;
            this.lVOkullar.Location = new System.Drawing.Point(609, 28);
            this.lVOkullar.MultiSelect = false;
            this.lVOkullar.Name = "lVOkullar";
            this.lVOkullar.Size = new System.Drawing.Size(173, 272);
            this.lVOkullar.TabIndex = 80;
            this.lVOkullar.UseCompatibleStateImageBehavior = false;
            this.lVOkullar.View = System.Windows.Forms.View.Details;
            this.lVOkullar.SelectedIndexChanged += new System.EventHandler(this.lVOkullar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Okullar";
            // 
            // lblPostaKodu
            // 
            this.lblPostaKodu.AutoSize = true;
            this.lblPostaKodu.Location = new System.Drawing.Point(339, 205);
            this.lblPostaKodu.Name = "lblPostaKodu";
            this.lblPostaKodu.Size = new System.Drawing.Size(41, 13);
            this.lblPostaKodu.TabIndex = 78;
            this.lblPostaKodu.Text = "label22";
            // 
            // lblÜlke
            // 
            this.lblÜlke.AutoSize = true;
            this.lblÜlke.Location = new System.Drawing.Point(339, 171);
            this.lblÜlke.Name = "lblÜlke";
            this.lblÜlke.Size = new System.Drawing.Size(41, 13);
            this.lblÜlke.TabIndex = 77;
            this.lblÜlke.Text = "label21";
            // 
            // lblBölge
            // 
            this.lblBölge.AutoSize = true;
            this.lblBölge.Location = new System.Drawing.Point(339, 137);
            this.lblBölge.Name = "lblBölge";
            this.lblBölge.Size = new System.Drawing.Size(41, 13);
            this.lblBölge.TabIndex = 76;
            this.lblBölge.Text = "label20";
            // 
            // lblİl
            // 
            this.lblİl.AutoSize = true;
            this.lblİl.Location = new System.Drawing.Point(339, 103);
            this.lblİl.Name = "lblİl";
            this.lblİl.Size = new System.Drawing.Size(41, 13);
            this.lblİl.TabIndex = 75;
            this.lblİl.Text = "label19";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(70, 208);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(41, 13);
            this.lblTelefon.TabIndex = 74;
            this.lblTelefon.Text = "label18";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(70, 118);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(41, 13);
            this.lblEposta.TabIndex = 71;
            this.lblEposta.Text = "label15";
            // 
            // lblTür
            // 
            this.lblTür.AutoSize = true;
            this.lblTür.Location = new System.Drawing.Point(70, 88);
            this.lblTür.Name = "lblTür";
            this.lblTür.Size = new System.Drawing.Size(35, 13);
            this.lblTür.TabIndex = 70;
            this.lblTür.Text = "label1";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(70, 28);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(60, 13);
            this.lblAdSoyad.TabIndex = 68;
            this.lblAdSoyad.Text = "lblAdSoyad";
            // 
            // txtBNotlar
            // 
            this.txtBNotlar.Enabled = false;
            this.txtBNotlar.Location = new System.Drawing.Point(311, 239);
            this.txtBNotlar.Multiline = true;
            this.txtBNotlar.Name = "txtBNotlar";
            this.txtBNotlar.Size = new System.Drawing.Size(292, 61);
            this.txtBNotlar.TabIndex = 67;
            // 
            // txtBAdres
            // 
            this.txtBAdres.Enabled = false;
            this.txtBAdres.Location = new System.Drawing.Point(311, 22);
            this.txtBAdres.Multiline = true;
            this.txtBAdres.Name = "txtBAdres";
            this.txtBAdres.Size = new System.Drawing.Size(292, 61);
            this.txtBAdres.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Notlar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Posta Kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Ülke";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Bölge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "İl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Okul Adı";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(663, 305);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 52;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmOkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 350);
            this.Controls.Add(this.lVOkullar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPostaKodu);
            this.Controls.Add(this.lblÜlke);
            this.Controls.Add(this.lblBölge);
            this.Controls.Add(this.lblİl);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblTür);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtBNotlar);
            this.Controls.Add(this.txtBAdres);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYeni);
            this.Name = "frmOkul";
            this.Text = "frmOkul";
            this.Load += new System.EventHandler(this.frmOkul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lVOkullar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPostaKodu;
        private System.Windows.Forms.Label lblÜlke;
        private System.Windows.Forms.Label lblBölge;
        private System.Windows.Forms.Label lblİl;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTür;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtBNotlar;
        private System.Windows.Forms.TextBox txtBAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYeni;
    }
}