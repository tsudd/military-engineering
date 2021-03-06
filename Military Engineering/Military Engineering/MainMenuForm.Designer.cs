
namespace MilitaryEngineering
{
    partial class MainMenuForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ThemesBox = new System.Windows.Forms.ComboBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Placeholder = new System.Windows.Forms.Button();
            this.FencingButton = new System.Windows.Forms.Button();
            this.FortificationButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.LeftPanel.Controls.Add(this.ThemesBox);
            this.LeftPanel.Controls.Add(this.ThemeLabel);
            this.LeftPanel.Controls.Add(this.button3);
            this.LeftPanel.Controls.Add(this.button2);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.Placeholder);
            this.LeftPanel.Controls.Add(this.FencingButton);
            this.LeftPanel.Controls.Add(this.FortificationButton);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(490, 699);
            this.LeftPanel.TabIndex = 0;
            // 
            // ThemesBox
            // 
            this.ThemesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemesBox.FormattingEnabled = true;
            this.ThemesBox.Location = new System.Drawing.Point(101, 606);
            this.ThemesBox.Name = "ThemesBox";
            this.ThemesBox.Size = new System.Drawing.Size(241, 25);
            this.ThemesBox.TabIndex = 7;
            this.ThemesBox.TabStop = false;
            this.ThemesBox.SelectedIndexChanged += new System.EventHandler(this.ThemesBox_SelectedIndexChanged);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.ThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.ThemeLabel.Location = new System.Drawing.Point(12, 598);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(83, 36);
            this.ThemeLabel.TabIndex = 6;
            this.ThemeLabel.Text = "Тема:";
            this.ThemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.button3.Location = new System.Drawing.Point(57, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 66);
            this.button3.TabIndex = 5;
            this.button3.TabStop = false;
            this.button3.Text = "PLACEHOLDER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            this.button3.MouseEnter += new System.EventHandler(this.Placeholder_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.DisplayMain);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.button2.Location = new System.Drawing.Point(57, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 66);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "PLACEHOLDER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Placeholder_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.DisplayMain);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.button1.Location = new System.Drawing.Point(57, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 66);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "PLACEHOLDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Placeholder_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.DisplayMain);
            // 
            // Placeholder
            // 
            this.Placeholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.Placeholder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Placeholder.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.Placeholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.Placeholder.Location = new System.Drawing.Point(57, 240);
            this.Placeholder.Name = "Placeholder";
            this.Placeholder.Size = new System.Drawing.Size(350, 66);
            this.Placeholder.TabIndex = 2;
            this.Placeholder.TabStop = false;
            this.Placeholder.Text = "PLACEHOLDER";
            this.Placeholder.UseVisualStyleBackColor = false;
            this.Placeholder.Click += new System.EventHandler(this.Button_Click);
            this.Placeholder.MouseEnter += new System.EventHandler(this.Placeholder_MouseEnter);
            this.Placeholder.MouseLeave += new System.EventHandler(this.DisplayMain);
            // 
            // FencingButton
            // 
            this.FencingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FencingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FencingButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FencingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.FencingButton.Location = new System.Drawing.Point(57, 155);
            this.FencingButton.Name = "FencingButton";
            this.FencingButton.Size = new System.Drawing.Size(350, 66);
            this.FencingButton.TabIndex = 1;
            this.FencingButton.TabStop = false;
            this.FencingButton.Text = "РСИЗ";
            this.FencingButton.UseVisualStyleBackColor = false;
            this.FencingButton.Click += new System.EventHandler(this.Button_Click);
            this.FencingButton.MouseEnter += new System.EventHandler(this.FencingButton_MouseEnter);
            this.FencingButton.MouseLeave += new System.EventHandler(this.DisplayMain);
            // 
            // FortificationButton
            // 
            this.FortificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FortificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FortificationButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FortificationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.FortificationButton.Location = new System.Drawing.Point(57, 70);
            this.FortificationButton.Name = "FortificationButton";
            this.FortificationButton.Size = new System.Drawing.Size(350, 66);
            this.FortificationButton.TabIndex = 0;
            this.FortificationButton.TabStop = false;
            this.FortificationButton.Text = "РФО";
            this.FortificationButton.UseVisualStyleBackColor = false;
            this.FortificationButton.Click += new System.EventHandler(this.Button_Click);
            this.FortificationButton.MouseEnter += new System.EventHandler(this.FortificationButton_MouseEnter);
            this.FortificationButton.MouseLeave += new System.EventHandler(this.DisplayMain);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Location = new System.Drawing.Point(496, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(771, 158);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "МЕТОДИКИ ИНЖЕНЕРНЫХ РАСЧЕТОВ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewPictureBox.Image = global::MilitaryEngineering.Properties.Resources.Main;
            this.PreviewPictureBox.Location = new System.Drawing.Point(580, 170);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(600, 360);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewPictureBox.TabIndex = 1;
            this.PreviewPictureBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1246, 643);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.PreviewPictureBox);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenuForm_KeyDown);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button FencingButton;
        private System.Windows.Forms.Button FortificationButton;
        private System.Windows.Forms.Button Placeholder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox PreviewPictureBox;
        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ComboBox ThemesBox;
        public System.Windows.Forms.Label ThemeLabel;
    }
}

