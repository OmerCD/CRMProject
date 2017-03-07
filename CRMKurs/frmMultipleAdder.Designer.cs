namespace CRMKurs
{
    partial class frmMultipleAdder
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
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.btnAlanEkle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOnayla.Location = new System.Drawing.Point(218, 276);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AutoScroll = true;
            this.GeneralPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(200, 287);
            this.GeneralPanel.TabIndex = 2;
            // 
            // btnAlanEkle
            // 
            this.btnAlanEkle.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAlanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlanEkle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAlanEkle.Location = new System.Drawing.Point(218, 233);
            this.btnAlanEkle.Name = "btnAlanEkle";
            this.btnAlanEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAlanEkle.TabIndex = 3;
            this.btnAlanEkle.Text = "Alan Ekle";
            this.btnAlanEkle.UseVisualStyleBackColor = false;
            this.btnAlanEkle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(290, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMultipleAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(337, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAlanEkle);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.btnOnayla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMultipleAdder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMultipleAdder";
            this.Load += new System.EventHandler(this.frmMultipleAdder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Button btnAlanEkle;
        private System.Windows.Forms.Button btnClose;
    }
}