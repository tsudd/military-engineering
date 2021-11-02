
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
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(691, 74);
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
            this.MainPanel.Location = new System.Drawing.Point(12, 83);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(667, 518);
            this.MainPanel.TabIndex = 6;
            // 
            // DefaultDescriptionCheckBox
            // 
            this.DefaultDescriptionCheckBox.AutoSize = true;
            this.DefaultDescriptionCheckBox.Checked = true;
            this.DefaultDescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDescriptionCheckBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DefaultDescriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DefaultDescriptionCheckBox.Location = new System.Drawing.Point(13, 467);
            this.DefaultDescriptionCheckBox.Name = "DefaultDescriptionCheckBox";
            this.DefaultDescriptionCheckBox.Size = new System.Drawing.Size(424, 34);
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
            this.DescriptionBox.Location = new System.Drawing.Point(13, 355);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(631, 96);
            this.DescriptionBox.TabIndex = 17;
            this.DescriptionBox.Text = "";
            // 
            // PitPerfomanceBox
            // 
            this.PitPerfomanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PitPerfomanceBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.PitPerfomanceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.PitPerfomanceBox.Location = new System.Drawing.Point(337, 245);
            this.PitPerfomanceBox.Name = "PitPerfomanceBox";
            this.PitPerfomanceBox.Size = new System.Drawing.Size(307, 38);
            this.PitPerfomanceBox.TabIndex = 12;
            this.PitPerfomanceBox.TextChanged += new System.EventHandler(this.PerfomanceBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(11, 286);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(305, 81);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PitPerfomanceLabel
            // 
            this.PitPerfomanceLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.PitPerfomanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PitPerfomanceLabel.Location = new System.Drawing.Point(332, 142);
            this.PitPerfomanceLabel.Name = "PitPerfomanceLabel";
            this.PitPerfomanceLabel.Size = new System.Drawing.Size(312, 85);
            this.PitPerfomanceLabel.TabIndex = 9;
            this.PitPerfomanceLabel.Text = "Производительность\r\nпри отрывке котлованов\r\nм^3/час";
            this.PitPerfomanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrenchPerfomanceBox
            // 
            this.TrenchPerfomanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchPerfomanceBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchPerfomanceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.TrenchPerfomanceBox.Location = new System.Drawing.Point(13, 245);
            this.TrenchPerfomanceBox.Name = "TrenchPerfomanceBox";
            this.TrenchPerfomanceBox.Size = new System.Drawing.Size(307, 38);
            this.TrenchPerfomanceBox.TabIndex = 8;
            this.TrenchPerfomanceBox.TextChanged += new System.EventHandler(this.PerfomanceBox_TextChanged);
            // 
            // TrenchPerfomanceLabel
            // 
            this.TrenchPerfomanceLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchPerfomanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchPerfomanceLabel.Location = new System.Drawing.Point(11, 142);
            this.TrenchPerfomanceLabel.Name = "TrenchPerfomanceLabel";
            this.TrenchPerfomanceLabel.Size = new System.Drawing.Size(309, 85);
            this.TrenchPerfomanceLabel.TabIndex = 7;
            this.TrenchPerfomanceLabel.Text = "Производительность\r\nпри отрывке траншей\r\nм^3/час";
            this.TrenchPerfomanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NameTextBox.Location = new System.Drawing.Point(13, 83);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(631, 38);
            this.NameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameLabel.Location = new System.Drawing.Point(8, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(312, 67);
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
            this.AddGainButton.Location = new System.Drawing.Point(486, 623);
            this.AddGainButton.Name = "AddGainButton";
            this.AddGainButton.Size = new System.Drawing.Size(193, 66);
            this.AddGainButton.TabIndex = 7;
            this.AddGainButton.TabStop = false;
            this.AddGainButton.Text = "Сохранить";
            this.AddGainButton.UseVisualStyleBackColor = false;
            this.AddGainButton.Click += new System.EventHandler(this.AddGainButton_Click);
            // 
            // GainCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(691, 701);
            this.Controls.Add(this.AddGainButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GainCreatorForm";
            this.ShowIcon = false;
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