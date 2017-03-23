namespace CRMKurs
{
    partial class MainCRMWindow
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
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.öğretimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktiviteGörevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teklifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takvimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.DeepSkyBlueBox = new System.Windows.Forms.PictureBox();
            this.GreenYellowBox = new System.Windows.Forms.PictureBox();
            this.TomatoBox = new System.Windows.Forms.PictureBox();
            this.LimeBox = new System.Windows.Forms.PictureBox();
            this.MediumSeaGreenBox = new System.Windows.Forms.PictureBox();
            this.BlueBox = new System.Windows.Forms.PictureBox();
            this.YellowGreenBox = new System.Windows.Forms.PictureBox();
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.YellowBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelLogs = new System.Windows.Forms.FlowLayoutPanel();
            this.StripMenu.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeepSkyBlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenYellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomatoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumSeaGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.AutoSize = false;
            this.StripMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.öğretimToolStripMenuItem,
            this.öğretmenToolStripMenuItem,
            this.okulToolStripMenuItem,
            this.aktiviteGörevToolStripMenuItem,
            this.teklifToolStripMenuItem,
            this.takvimToolStripMenuItem,
            this.opsToolStripMenuItem,
            this.asdToolStripMenuItem,
            this.renkToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(727, 50);
            this.StripMenu.TabIndex = 0;
            this.StripMenu.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 46);
            // 
            // öğretimToolStripMenuItem
            // 
            this.öğretimToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.öğretimToolStripMenuItem.Name = "öğretimToolStripMenuItem";
            this.öğretimToolStripMenuItem.Size = new System.Drawing.Size(61, 46);
            this.öğretimToolStripMenuItem.Text = "Öğrenci";
            this.öğretimToolStripMenuItem.Click += new System.EventHandler(this.öğretimToolStripMenuItem_Click);
            this.öğretimToolStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeColorOfText);
            this.öğretimToolStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeColorOfText);
            // 
            // öğretmenToolStripMenuItem
            // 
            this.öğretmenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.öğretmenToolStripMenuItem.Name = "öğretmenToolStripMenuItem";
            this.öğretmenToolStripMenuItem.Size = new System.Drawing.Size(73, 46);
            this.öğretmenToolStripMenuItem.Text = "Öğretmen";
            this.öğretmenToolStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeColorOfText);
            this.öğretmenToolStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeColorOfText);
            // 
            // okulToolStripMenuItem
            // 
            this.okulToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.okulToolStripMenuItem.Name = "okulToolStripMenuItem";
            this.okulToolStripMenuItem.Size = new System.Drawing.Size(44, 46);
            this.okulToolStripMenuItem.Text = "Okul";
            this.okulToolStripMenuItem.Click += new System.EventHandler(this.okulToolStripMenuItem_Click);
            this.okulToolStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeColorOfText);
            this.okulToolStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeColorOfText);
            // 
            // aktiviteGörevToolStripMenuItem
            // 
            this.aktiviteGörevToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aktiviteGörevToolStripMenuItem.Name = "aktiviteGörevToolStripMenuItem";
            this.aktiviteGörevToolStripMenuItem.Size = new System.Drawing.Size(95, 46);
            this.aktiviteGörevToolStripMenuItem.Text = "Aktivite/Görev";
            this.aktiviteGörevToolStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeColorOfText);
            this.aktiviteGörevToolStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeColorOfText);
            // 
            // teklifToolStripMenuItem
            // 
            this.teklifToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.teklifToolStripMenuItem.Name = "teklifToolStripMenuItem";
            this.teklifToolStripMenuItem.Size = new System.Drawing.Size(48, 46);
            this.teklifToolStripMenuItem.Text = "Teklif";
            this.teklifToolStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeColorOfText);
            this.teklifToolStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeColorOfText);
            // 
            // takvimToolStripMenuItem
            // 
            this.takvimToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.takvimToolStripMenuItem.Name = "takvimToolStripMenuItem";
            this.takvimToolStripMenuItem.Size = new System.Drawing.Size(58, 46);
            this.takvimToolStripMenuItem.Text = "Takvim";
            this.takvimToolStripMenuItem.Click += new System.EventHandler(this.takvimToolStripMenuItem_Click);
            this.takvimToolStripMenuItem.MouseEnter += new System.EventHandler(this.ChangeColorOfText);
            this.takvimToolStripMenuItem.MouseLeave += new System.EventHandler(this.ChangeColorOfText);
            // 
            // opsToolStripMenuItem
            // 
            this.opsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.opsToolStripMenuItem.Image = global::CRMKurs.Properties.Resources.setting;
            this.opsToolStripMenuItem.Name = "opsToolStripMenuItem";
            this.opsToolStripMenuItem.Size = new System.Drawing.Size(28, 46);
            this.opsToolStripMenuItem.Click += new System.EventHandler(this.opsToolStripMenuItem_Click);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem1,
            this.asdaToolStripMenuItem,
            this.asdasfToolStripMenuItem});
            this.asdToolStripMenuItem.Image = global::CRMKurs.Properties.Resources.info;
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(28, 46);
            // 
            // asdToolStripMenuItem1
            // 
            this.asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            this.asdToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            // 
            // asdaToolStripMenuItem
            // 
            this.asdaToolStripMenuItem.Name = "asdaToolStripMenuItem";
            this.asdaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.asdaToolStripMenuItem.Text = "asda";
            // 
            // asdasfToolStripMenuItem
            // 
            this.asdasfToolStripMenuItem.Name = "asdasfToolStripMenuItem";
            this.asdasfToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.asdasfToolStripMenuItem.Text = "asdasf";
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.renkToolStripMenuItem.Image = global::CRMKurs.Properties.Resources.theme_brush;
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(28, 46);
            this.renkToolStripMenuItem.Click += new System.EventHandler(this.renkToolStripMenuItem_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ColorPanel.Controls.Add(this.DeepSkyBlueBox);
            this.ColorPanel.Controls.Add(this.GreenYellowBox);
            this.ColorPanel.Controls.Add(this.TomatoBox);
            this.ColorPanel.Controls.Add(this.LimeBox);
            this.ColorPanel.Controls.Add(this.MediumSeaGreenBox);
            this.ColorPanel.Controls.Add(this.BlueBox);
            this.ColorPanel.Controls.Add(this.YellowGreenBox);
            this.ColorPanel.Controls.Add(this.RedBox);
            this.ColorPanel.Controls.Add(this.YellowBox);
            this.ColorPanel.Location = new System.Drawing.Point(582, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(65, 77);
            this.ColorPanel.TabIndex = 5;
            this.ColorPanel.Visible = false;
            this.ColorPanel.LostFocus += new System.EventHandler(this.ColorPanel_LostFocus);
            // 
            // DeepSkyBlueBox
            // 
            this.DeepSkyBlueBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeepSkyBlueBox.Location = new System.Drawing.Point(45, 51);
            this.DeepSkyBlueBox.Name = "DeepSkyBlueBox";
            this.DeepSkyBlueBox.Size = new System.Drawing.Size(15, 15);
            this.DeepSkyBlueBox.TabIndex = 11;
            this.DeepSkyBlueBox.TabStop = false;
            this.DeepSkyBlueBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // GreenYellowBox
            // 
            this.GreenYellowBox.BackColor = System.Drawing.Color.GreenYellow;
            this.GreenYellowBox.Location = new System.Drawing.Point(24, 51);
            this.GreenYellowBox.Name = "GreenYellowBox";
            this.GreenYellowBox.Size = new System.Drawing.Size(15, 15);
            this.GreenYellowBox.TabIndex = 10;
            this.GreenYellowBox.TabStop = false;
            this.GreenYellowBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // TomatoBox
            // 
            this.TomatoBox.BackColor = System.Drawing.Color.Tomato;
            this.TomatoBox.Location = new System.Drawing.Point(3, 51);
            this.TomatoBox.Name = "TomatoBox";
            this.TomatoBox.Size = new System.Drawing.Size(15, 15);
            this.TomatoBox.TabIndex = 9;
            this.TomatoBox.TabStop = false;
            this.TomatoBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // LimeBox
            // 
            this.LimeBox.BackColor = System.Drawing.Color.Lime;
            this.LimeBox.Location = new System.Drawing.Point(45, 33);
            this.LimeBox.Name = "LimeBox";
            this.LimeBox.Size = new System.Drawing.Size(15, 15);
            this.LimeBox.TabIndex = 8;
            this.LimeBox.TabStop = false;
            this.LimeBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // MediumSeaGreenBox
            // 
            this.MediumSeaGreenBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MediumSeaGreenBox.Location = new System.Drawing.Point(24, 33);
            this.MediumSeaGreenBox.Name = "MediumSeaGreenBox";
            this.MediumSeaGreenBox.Size = new System.Drawing.Size(15, 15);
            this.MediumSeaGreenBox.TabIndex = 7;
            this.MediumSeaGreenBox.TabStop = false;
            this.MediumSeaGreenBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // BlueBox
            // 
            this.BlueBox.BackColor = System.Drawing.Color.Blue;
            this.BlueBox.Location = new System.Drawing.Point(3, 33);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(15, 15);
            this.BlueBox.TabIndex = 6;
            this.BlueBox.TabStop = false;
            this.BlueBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // YellowGreenBox
            // 
            this.YellowGreenBox.BackColor = System.Drawing.Color.YellowGreen;
            this.YellowGreenBox.Location = new System.Drawing.Point(45, 13);
            this.YellowGreenBox.Name = "YellowGreenBox";
            this.YellowGreenBox.Size = new System.Drawing.Size(15, 15);
            this.YellowGreenBox.TabIndex = 5;
            this.YellowGreenBox.TabStop = false;
            this.YellowGreenBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Red;
            this.RedBox.Location = new System.Drawing.Point(3, 13);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(15, 15);
            this.RedBox.TabIndex = 3;
            this.RedBox.TabStop = false;
            this.RedBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // YellowBox
            // 
            this.YellowBox.BackColor = System.Drawing.Color.Yellow;
            this.YellowBox.Location = new System.Drawing.Point(24, 13);
            this.YellowBox.Name = "YellowBox";
            this.YellowBox.Size = new System.Drawing.Size(15, 15);
            this.YellowBox.TabIndex = 4;
            this.YellowBox.TabStop = false;
            this.YellowBox.Click += new System.EventHandler(this.ChangeThemeColor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.BackgroundImage = global::CRMKurs.Properties.Resources.logo_dark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::CRMKurs.Properties.Resources.logo_dark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(0, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(727, 5);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // PanelLogs
            // 
            this.PanelLogs.Location = new System.Drawing.Point(12, 64);
            this.PanelLogs.Name = "PanelLogs";
            this.PanelLogs.Size = new System.Drawing.Size(703, 263);
            this.PanelLogs.TabIndex = 7;
            // 
            // MainCRMWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 339);
            this.Controls.Add(this.PanelLogs);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StripMenu);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.StripMenu;
            this.Name = "MainCRMWindow";
            this.Text = "DeleteCRM";
            this.Load += new System.EventHandler(this.MainCRMWindow_Load);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeepSkyBlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenYellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomatoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumSeaGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem öğretimToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem öğretmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktiviteGörevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teklifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takvimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.PictureBox YellowBox;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.PictureBox YellowGreenBox;
        private System.Windows.Forms.PictureBox MediumSeaGreenBox;
        private System.Windows.Forms.PictureBox BlueBox;
        private System.Windows.Forms.PictureBox DeepSkyBlueBox;
        private System.Windows.Forms.PictureBox GreenYellowBox;
        private System.Windows.Forms.PictureBox TomatoBox;
        private System.Windows.Forms.PictureBox LimeBox;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdasfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel PanelLogs;
    }
}

