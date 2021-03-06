
namespace MilitaryEngineering.Fortification
{
    partial class GainCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GainCreatorForm));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DefaultDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.PitPerfomanceBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PitPerfomanceLabel = new System.Windows.Forms.Label();
            this.TrenchPerfomanceBox = new System.Windows.Forms.TextBox();
            this.TrenchPerfomanceLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddGainButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(518, 60);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "СОЗДАТЬ/РЕДАКТИРОВАТЬ УСИЛЕНИЕ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.MainPanel.Controls.Add(this.DefaultDescriptionCheckBox);
            this.MainPanel.Controls.Add(this.DescriptionBox);
            this.MainPanel.Controls.Add(this.PitPerfomanceBox);
            this.MainPanel.Controls.Add(this.DescriptionLabel);
            this.MainPanel.Controls.Add(this.PitPerfomanceLabel);
            this.MainPanel.Controls.Add(this.TrenchPerfomanceBox);
            this.MainPanel.Controls.Add(this.TrenchPerfomanceLabel);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Location = new System.Drawing.Point(9, 67);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 421);
            this.MainPanel.TabIndex = 6;
            // 
            // DefaultDescriptionCheckBox
            // 
            this.DefaultDescriptionCheckBox.AutoSize = true;
            this.DefaultDescriptionCheckBox.Checked = true;
            this.DefaultDescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDescriptionCheckBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DefaultDescriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DefaultDescriptionCheckBox.Location = new System.Drawing.Point(10, 379);
            this.DefaultDescriptionCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DefaultDescriptionCheckBox.Name = "DefaultDescriptionCheckBox";
            this.DefaultDescriptionCheckBox.Size = new System.Drawing.Size(343, 28);
            this.DefaultDescriptionCheckBox.TabIndex = 18;
            this.DefaultDescriptionCheckBox.Text = "Создать описание автоматически";
            this.DefaultDescriptionCheckBox.UseVisualStyleBackColor = true;
            this.DefaultDescriptionCheckBox.CheckedChanged += new System.EventHandler(this.DefaultDescriptionCheckBox_CheckedChanged);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.DescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.DescriptionBox.Location = new System.Drawing.Point(10, 288);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(474, 79);
            this.DescriptionBox.TabIndex = 17;
            this.DescriptionBox.Text = "";
            // 
            // PitPerfomanceBox
            // 
            this.PitPerfomanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PitPerfomanceBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.PitPerfomanceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.PitPerfomanceBox.Location = new System.Drawing.Point(253, 199);
            this.PitPerfomanceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PitPerfomanceBox.Name = "PitPerfomanceBox";
            this.PitPerfomanceBox.Size = new System.Drawing.Size(231, 32);
            this.PitPerfomanceBox.TabIndex = 12;
            this.PitPerfomanceBox.Text = "0";
            this.PitPerfomanceBox.TextChanged += new System.EventHandler(this.PerfomanceBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(8, 232);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(229, 66);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PitPerfomanceLabel
            // 
            this.PitPerfomanceLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.PitPerfomanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PitPerfomanceLabel.Location = new System.Drawing.Point(249, 115);
            this.PitPerfomanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PitPerfomanceLabel.Name = "PitPerfomanceLabel";
            this.PitPerfomanceLabel.Size = new System.Drawing.Size(234, 69);
            this.PitPerfomanceLabel.TabIndex = 9;
            this.PitPerfomanceLabel.Text = "Производительность \r\nпри отр. котлованов\r\nм^3/час";
            this.PitPerfomanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrenchPerfomanceBox
            // 
            this.TrenchPerfomanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchPerfomanceBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchPerfomanceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.TrenchPerfomanceBox.Location = new System.Drawing.Point(10, 199);
            this.TrenchPerfomanceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrenchPerfomanceBox.Name = "TrenchPerfomanceBox";
            this.TrenchPerfomanceBox.Size = new System.Drawing.Size(231, 32);
            this.TrenchPerfomanceBox.TabIndex = 8;
            this.TrenchPerfomanceBox.Text = "0";
            this.TrenchPerfomanceBox.TextChanged += new System.EventHandler(this.PerfomanceBox_TextChanged);
            // 
            // TrenchPerfomanceLabel
            // 
            this.TrenchPerfomanceLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchPerfomanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchPerfomanceLabel.Location = new System.Drawing.Point(8, 115);
            this.TrenchPerfomanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrenchPerfomanceLabel.Name = "TrenchPerfomanceLabel";
            this.TrenchPerfomanceLabel.Size = new System.Drawing.Size(232, 69);
            this.TrenchPerfomanceLabel.TabIndex = 7;
            this.TrenchPerfomanceLabel.Text = "Производительность\r\nпри отрывке траншей\r\nм^3/час";
            this.TrenchPerfomanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NameTextBox.Location = new System.Drawing.Point(10, 67);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(474, 32);
            this.NameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameLabel.Location = new System.Drawing.Point(6, 11);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(234, 54);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddGainButton
            // 
            this.AddGainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddGainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGainButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AddGainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AddGainButton.Location = new System.Drawing.Point(364, 506);
            this.AddGainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddGainButton.Name = "AddGainButton";
            this.AddGainButton.Size = new System.Drawing.Size(145, 54);
            this.AddGainButton.TabIndex = 7;
            this.AddGainButton.TabStop = false;
            this.AddGainButton.Text = "Сохранить";
            this.AddGainButton.UseVisualStyleBackColor = false;
            this.AddGainButton.Click += new System.EventHandler(this.AddGainButton_Click);
            // 
            // GainCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(518, 570);
            this.Controls.Add(this.AddGainButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GainCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание усиления";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox PitPerfomanceBox;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Label PitPerfomanceLabel;
        private System.Windows.Forms.TextBox TrenchPerfomanceBox;
        public System.Windows.Forms.Label TrenchPerfomanceLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddGainButton;
        private System.Windows.Forms.CheckBox DefaultDescriptionCheckBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
    }
}