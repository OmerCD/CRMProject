﻿using System.Windows.Forms;

namespace CRMKurs.Kişi
{
    partial class frmKişi
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
            this.btnYeni = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBNotlar = new System.Windows.Forms.TextBox();
            this.txtBAdres = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblHitap = new System.Windows.Forms.Label();
            this.lblTür = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblOkul = new System.Windows.Forms.Label();
            this.lblSınıf = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblİl = new System.Windows.Forms.Label();
            this.lblBölge = new System.Windows.Forms.Label();
            this.lblÜlke = new System.Windows.Forms.Label();
            this.lblPostaKodu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.propGrid = new CRMKurs.CustomTools.PropertyGridMVC();
            this.lVKişiler = new CRMKurs.CustomTools.ListViewCompare();
            this.PersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(728, 327);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 8;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sınıf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Okul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ad Soyad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Notlar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Posta Kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ülke";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Bölge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "İl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Adres";
            // 
            // txtBNotlar
            // 
            this.txtBNotlar.Enabled = false;
            this.txtBNotlar.Location = new System.Drawing.Point(332, 261);
            this.txtBNotlar.Multiline = true;
            this.txtBNotlar.Name = "txtBNotlar";
            this.txtBNotlar.Size = new System.Drawing.Size(292, 61);
            this.txtBNotlar.TabIndex = 37;
            // 
            // txtBAdres
            // 
            this.txtBAdres.Enabled = false;
            this.txtBAdres.Location = new System.Drawing.Point(332, 44);
            this.txtBAdres.Multiline = true;
            this.txtBAdres.Name = "txtBAdres";
            this.txtBAdres.Size = new System.Drawing.Size(292, 61);
            this.txtBAdres.TabIndex = 36;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(91, 50);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(60, 13);
            this.lblAdSoyad.TabIndex = 38;
            this.lblAdSoyad.Text = "lblAdSoyad";
            // 
            // lblHitap
            // 
            this.lblHitap.AutoSize = true;
            this.lblHitap.Location = new System.Drawing.Point(91, 80);
            this.lblHitap.Name = "lblHitap";
            this.lblHitap.Size = new System.Drawing.Size(35, 13);
            this.lblHitap.TabIndex = 39;
            this.lblHitap.Text = "label1";
            // 
            // lblTür
            // 
            this.lblTür.AutoSize = true;
            this.lblTür.Location = new System.Drawing.Point(91, 110);
            this.lblTür.Name = "lblTür";
            this.lblTür.Size = new System.Drawing.Size(35, 13);
            this.lblTür.TabIndex = 40;
            this.lblTür.Text = "label1";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(91, 140);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(41, 13);
            this.lblEposta.TabIndex = 41;
            this.lblEposta.Text = "label15";
            // 
            // lblOkul
            // 
            this.lblOkul.AutoSize = true;
            this.lblOkul.Location = new System.Drawing.Point(91, 170);
            this.lblOkul.Name = "lblOkul";
            this.lblOkul.Size = new System.Drawing.Size(41, 13);
            this.lblOkul.TabIndex = 42;
            this.lblOkul.Text = "label16";
            // 
            // lblSınıf
            // 
            this.lblSınıf.AutoSize = true;
            this.lblSınıf.Location = new System.Drawing.Point(91, 200);
            this.lblSınıf.Name = "lblSınıf";
            this.lblSınıf.Size = new System.Drawing.Size(41, 13);
            this.lblSınıf.TabIndex = 43;
            this.lblSınıf.Text = "label17";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(91, 230);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(41, 13);
            this.lblTelefon.TabIndex = 44;
            this.lblTelefon.Text = "label18";
            // 
            // lblİl
            // 
            this.lblİl.AutoSize = true;
            this.lblİl.Location = new System.Drawing.Point(360, 125);
            this.lblİl.Name = "lblİl";
            this.lblİl.Size = new System.Drawing.Size(41, 13);
            this.lblİl.TabIndex = 45;
            this.lblİl.Text = "label19";
            // 
            // lblBölge
            // 
            this.lblBölge.AutoSize = true;
            this.lblBölge.Location = new System.Drawing.Point(360, 159);
            this.lblBölge.Name = "lblBölge";
            this.lblBölge.Size = new System.Drawing.Size(41, 13);
            this.lblBölge.TabIndex = 46;
            this.lblBölge.Text = "label20";
            // 
            // lblÜlke
            // 
            this.lblÜlke.AutoSize = true;
            this.lblÜlke.Location = new System.Drawing.Point(360, 193);
            this.lblÜlke.Name = "lblÜlke";
            this.lblÜlke.Size = new System.Drawing.Size(41, 13);
            this.lblÜlke.TabIndex = 47;
            this.lblÜlke.Text = "label21";
            // 
            // lblPostaKodu
            // 
            this.lblPostaKodu.AutoSize = true;
            this.lblPostaKodu.Location = new System.Drawing.Point(360, 227);
            this.lblPostaKodu.Name = "lblPostaKodu";
            this.lblPostaKodu.Size = new System.Drawing.Size(41, 13);
            this.lblPostaKodu.TabIndex = 48;
            this.lblPostaKodu.Text = "label22";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Kişiler";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(647, 328);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 52;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(566, 328);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 53;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // propGrid
            // 
            this.propGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propGrid.AutoScroll = true;
            this.propGrid.BackColor = System.Drawing.Color.Red;
            this.propGrid.Location = new System.Drawing.Point(12, 12);
            this.propGrid.Name = "propGrid";
            this.propGrid.Size = new System.Drawing.Size(356, 334);
            this.propGrid.TabIndex = 54;
            // 
            // lVKişiler
            // 
            this.lVKişiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonName,
            this.PhoneNumber});
            this.lVKişiler.FullRowSelect = true;
            this.lVKişiler.Location = new System.Drawing.Point(630, 44);
            this.lVKişiler.MultiSelect = false;
            this.lVKişiler.Name = "lVKişiler";
            this.lVKişiler.Size = new System.Drawing.Size(173, 277);
            this.lVKişiler.TabIndex = 51;
            this.lVKişiler.UseCompatibleStateImageBehavior = false;
            this.lVKişiler.View = System.Windows.Forms.View.Details;
            this.lVKişiler.SelectedIndexChanged += new System.EventHandler(this.lVÖğrenciler_SelectedIndexChanged);
            // 
            // PersonName
            // 
            this.PersonName.Text = "İsim";
            this.PersonName.Width = 88;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Telefon";
            this.PhoneNumber.Width = 79;
            // 
            // frmKişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 358);
            this.Controls.Add(this.propGrid);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.lVKişiler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPostaKodu);
            this.Controls.Add(this.lblÜlke);
            this.Controls.Add(this.lblBölge);
            this.Controls.Add(this.lblİl);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSınıf);
            this.Controls.Add(this.lblOkul);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblTür);
            this.Controls.Add(this.lblHitap);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYeni);
            this.Name = "frmKişi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kişiler";
            this.Load += new System.EventHandler(this.frmÖğrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBNotlar;
        private System.Windows.Forms.TextBox txtBAdres;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblHitap;
        private System.Windows.Forms.Label lblTür;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblOkul;
        private System.Windows.Forms.Label lblSınıf;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblİl;
        private System.Windows.Forms.Label lblBölge;
        private System.Windows.Forms.Label lblÜlke;
        private System.Windows.Forms.Label lblPostaKodu;
        private System.Windows.Forms.Label label1;
        private CustomTools.ListViewCompare lVKişiler;
        private System.Windows.Forms.ColumnHeader PersonName;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private CustomTools.PropertyGridMVC propGrid;
    }
}