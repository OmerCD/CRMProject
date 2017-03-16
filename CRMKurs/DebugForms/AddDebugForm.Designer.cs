namespace CRMKurs.DebugForms
{
    partial class AddDebugForm
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
            this.PropertyGridDebugClass = new System.Windows.Forms.PropertyGrid();
            this.cBDebugList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PropertyGridDebugClass
            // 
            this.PropertyGridDebugClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyGridDebugClass.Location = new System.Drawing.Point(12, 12);
            this.PropertyGridDebugClass.Name = "PropertyGridDebugClass";
            this.PropertyGridDebugClass.Size = new System.Drawing.Size(460, 269);
            this.PropertyGridDebugClass.TabIndex = 0;
            // 
            // cBDebugList
            // 
            this.cBDebugList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBDebugList.FormattingEnabled = true;
            this.cBDebugList.Location = new System.Drawing.Point(478, 12);
            this.cBDebugList.Name = "cBDebugList";
            this.cBDebugList.Size = new System.Drawing.Size(121, 21);
            this.cBDebugList.TabIndex = 1;
            this.cBDebugList.SelectedIndexChanged += new System.EventHandler(this.cBDebugList_SelectedIndexChanged);
            // 
            // AddDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 293);
            this.Controls.Add(this.cBDebugList);
            this.Controls.Add(this.PropertyGridDebugClass);
            this.Name = "AddDebugForm";
            this.Text = "AddDebugForm";
            this.Load += new System.EventHandler(this.AddDebugForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid PropertyGridDebugClass;
        private System.Windows.Forms.ComboBox cBDebugList;
    }
}