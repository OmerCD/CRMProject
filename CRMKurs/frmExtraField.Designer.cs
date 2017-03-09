namespace CRMKurs
{
    partial class frmExtraField
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
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTür = new CRMKurs.CustomTools.DataComboBox();
            this.listViewCompare1 = new CRMKurs.CustomTools.ListViewCompare();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAlan = new CRMKurs.CustomTools.DataComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(43, 26);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tür";
            // 
            // cbTür
            // 
            this.cbTür.FormattingEnabled = true;
            this.cbTür.Location = new System.Drawing.Point(209, 26);
            this.cbTür.Name = "cbTür";
            this.cbTür.RealValues = null;
            this.cbTür.Size = new System.Drawing.Size(121, 21);
            this.cbTür.TabIndex = 3;
            // 
            // listViewCompare1
            // 
            this.listViewCompare1.Location = new System.Drawing.Point(12, 89);
            this.listViewCompare1.Name = "listViewCompare1";
            this.listViewCompare1.Size = new System.Drawing.Size(497, 231);
            this.listViewCompare1.TabIndex = 0;
            this.listViewCompare1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alan";
            // 
            // cbAlan
            // 
            this.cbAlan.FormattingEnabled = true;
            this.cbAlan.Location = new System.Drawing.Point(370, 26);
            this.cbAlan.Name = "cbAlan";
            this.cbAlan.RealValues = null;
            this.cbAlan.Size = new System.Drawing.Size(121, 21);
            this.cbAlan.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(516, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmExtraField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 332);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTür);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewCompare1);
            this.Name = "frmExtraField";
            this.Text = "frmExtraField";
            this.Load += new System.EventHandler(this.frmExtraField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTools.ListViewCompare listViewCompare1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİsim;
        private CustomTools.DataComboBox cbTür;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomTools.DataComboBox cbAlan;
        private System.Windows.Forms.Button btnEkle;
    }
}