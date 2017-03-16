using System.Windows.Forms;

namespace CRMKurs.CustomTools
{
    partial class LogLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.txtBAction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(3, 23);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.PersonName_Click);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(363, 23);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(30, 13);
            this.LabelDate.TabIndex = 1;
            this.LabelDate.Text = "Date";
            this.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBAction
            // 
            this.txtBAction.Location = new System.Drawing.Point(70, 11);
            this.txtBAction.Multiline = true;
            this.txtBAction.Name = "txtBAction";
            this.txtBAction.Size = new System.Drawing.Size(253, 38);
            this.txtBAction.TabIndex = 2;
            // 
            // LogLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBAction);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelName);
            this.Name = "LogLabel";
            this.Size = new System.Drawing.Size(396, 61);
            this.Load += new System.EventHandler(this.LogLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelName;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.TextBox txtBAction;
    }
}
