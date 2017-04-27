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
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxVeriTürü = new CRMKurs.CustomTools.DataComboBox();
            this.cbAlan = new CRMKurs.CustomTools.DataComboBox();
            this.cbTür = new CRMKurs.CustomTools.DataComboBox();
            this.LVTypes = new CRMKurs.CustomTools.ListViewCompare();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(351, 68);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(121, 20);
            this.txtİsim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alan";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(295, 156);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Veri Türü";
            // 
            // cmbxVeriTürü
            // 
            this.cmbxVeriTürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVeriTürü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxVeriTürü.FormattingEnabled = true;
            this.cmbxVeriTürü.Location = new System.Drawing.Point(351, 41);
            this.cmbxVeriTürü.Name = "cmbxVeriTürü";
            this.cmbxVeriTürü.RealValues = null;
            this.cmbxVeriTürü.Size = new System.Drawing.Size(121, 21);
            this.cmbxVeriTürü.TabIndex = 9;
            // 
            // cbAlan
            // 
            this.cbAlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlan.FormattingEnabled = true;
            this.cbAlan.Items.AddRange(new object[] {
            "Yok"});
            this.cbAlan.Location = new System.Drawing.Point(351, 121);
            this.cbAlan.Name = "cbAlan";
            this.cbAlan.RealValues = null;
            this.cbAlan.Size = new System.Drawing.Size(121, 21);
            this.cbAlan.TabIndex = 6;
            // 
            // cbTür
            // 
            this.cbTür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTür.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTür.FormattingEnabled = true;
            this.cbTür.Items.AddRange(new object[] {
            "Kişi",
            "Okul"});
            this.cbTür.Location = new System.Drawing.Point(351, 94);
            this.cbTür.Name = "cbTür";
            this.cbTür.RealValues = null;
            this.cbTür.Size = new System.Drawing.Size(121, 21);
            this.cbTür.TabIndex = 3;
            this.cbTür.SelectedIndexChanged += new System.EventHandler(this.cbTür_SelectedIndexChanged);
            // 
            // LVTypes
            // 
            this.LVTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.LVTypes.FullRowSelect = true;
            this.LVTypes.Location = new System.Drawing.Point(12, 12);
            this.LVTypes.MultiSelect = false;
            this.LVTypes.Name = "LVTypes";
            this.LVTypes.Size = new System.Drawing.Size(277, 231);
            this.LVTypes.TabIndex = 0;
            this.LVTypes.UseCompatibleStateImageBehavior = false;
            this.LVTypes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Tür";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 1;
            this.columnHeader4.Text = "Alan";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VeriTürü";
            // 
            // frmExtraField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 332);
            this.Controls.Add(this.cmbxVeriTürü);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTür);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVTypes);
            this.Name = "frmExtraField";
            this.Text = "frmExtraField";
            this.Load += new System.EventHandler(this.frmExtraField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTools.ListViewCompare LVTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİsim;
        private CustomTools.DataComboBox cbTür;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomTools.DataComboBox cbAlan;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private CustomTools.DataComboBox cmbxVeriTürü;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}