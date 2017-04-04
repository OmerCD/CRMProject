namespace CRMKurs.CustomTools
{
    partial class PropertyGridMVCList
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
            this.panelPropArea = new System.Windows.Forms.Panel();
            this.lVTableValues = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // panelPropArea
            // 
            this.panelPropArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPropArea.AutoScroll = true;
            this.panelPropArea.BackColor = System.Drawing.Color.Brown;
            this.panelPropArea.Location = new System.Drawing.Point(3, 3);
            this.panelPropArea.Name = "panelPropArea";
            this.panelPropArea.Size = new System.Drawing.Size(349, 163);
            this.panelPropArea.TabIndex = 1;
            // 
            // lVTableValues
            // 
            this.lVTableValues.Location = new System.Drawing.Point(358, 3);
            this.lVTableValues.Name = "lVTableValues";
            this.lVTableValues.Size = new System.Drawing.Size(201, 163);
            this.lVTableValues.TabIndex = 2;
            this.lVTableValues.UseCompatibleStateImageBehavior = false;
            this.lVTableValues.View = System.Windows.Forms.View.Details;
            // 
            // PropertyGridMVCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.lVTableValues);
            this.Controls.Add(this.panelPropArea);
            this.Name = "PropertyGridMVCList";
            this.Size = new System.Drawing.Size(571, 169);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPropArea;
        private System.Windows.Forms.ListView lVTableValues;
    }
}
