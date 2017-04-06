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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.panelPropArea.Size = new System.Drawing.Size(349, 220);
            this.panelPropArea.TabIndex = 1;
            // 
            // lVTableValues
            // 
            this.lVTableValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lVTableValues.FullRowSelect = true;
            this.lVTableValues.Location = new System.Drawing.Point(358, 3);
            this.lVTableValues.MultiSelect = false;
            this.lVTableValues.Name = "lVTableValues";
            this.lVTableValues.Size = new System.Drawing.Size(201, 192);
            this.lVTableValues.TabIndex = 2;
            this.lVTableValues.UseCompatibleStateImageBehavior = false;
            this.lVTableValues.View = System.Windows.Forms.View.Details;
            this.lVTableValues.SelectedIndexChanged += new System.EventHandler(this.lVTableValues_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(430, 201);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // PropertyGridMVCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lVTableValues);
            this.Controls.Add(this.panelPropArea);
            this.MinimumSize = new System.Drawing.Size(571, 226);
            this.Name = "PropertyGridMVCList";
            this.Size = new System.Drawing.Size(571, 226);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPropArea;
        private System.Windows.Forms.ListView lVTableValues;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
