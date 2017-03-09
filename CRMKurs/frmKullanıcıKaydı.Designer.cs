namespace CRMKurs
{
    partial class frmKullanıcıKaydı
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.cBStatü = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtŞifret = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new CRMKurs.CustomTools.EmailTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Statü";
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(91, 12);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcı.TabIndex = 3;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(91, 44);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtŞifre.TabIndex = 4;
            this.txtŞifre.UseSystemPasswordChar = true;
            // 
            // cBStatü
            // 
            this.cBStatü.FormattingEnabled = true;
            this.cBStatü.Location = new System.Drawing.Point(91, 140);
            this.cBStatü.Name = "cBStatü";
            this.cBStatü.Size = new System.Drawing.Size(121, 21);
            this.cBStatü.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre (Tekrar) ";
            // 
            // txtŞifret
            // 
            this.txtŞifret.Location = new System.Drawing.Point(91, 76);
            this.txtŞifret.Name = "txtŞifret";
            this.txtŞifret.Size = new System.Drawing.Size(100, 20);
            this.txtŞifret.TabIndex = 8;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.Location = new System.Drawing.Point(91, 108);
            this.emailTextBox1.MaxLength = 30;
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-Posta";
            // 
            // frmKullanıcıKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 233);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(this.txtŞifret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBStatü);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKullanıcıKaydı";
            this.Text = "frmKullanıcıKaydı";
            this.Load += new System.EventHandler(this.frmKullanıcıKaydı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.ComboBox cBStatü;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtŞifret;
        private CustomTools.EmailTextBox emailTextBox1;
        private System.Windows.Forms.Label label5;
    }
}