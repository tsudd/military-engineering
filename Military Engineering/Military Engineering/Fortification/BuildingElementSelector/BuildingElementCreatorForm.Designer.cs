
namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    partial class BuildingElementCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingElementCreatorForm));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.DefaultDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FutureTurnsTextBox = new System.Windows.Forms.TextBox();
            this.FutureTurnsLabel = new System.Windows.Forms.Label();
            this.SecondTurnTextBox = new System.Windows.Forms.TextBox();
            this.SecondTurnLabel = new System.Windows.Forms.Label();
            this.FirstTurnTextBox = new System.Windows.Forms.TextBox();
            this.FirstTurnLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.HeaderPanel.SuspendLayout();
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
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "СОЗДАТЬ/РЕДАКТИРОВАТЬ ЭЛЕМЕНТ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.HeaderPanel.Controls.Add(this.DefaultDescriptionCheckBox);
            this.HeaderPanel.Controls.Add(this.DescriptionBox);
            this.HeaderPanel.Controls.Add(this.DescriptionLabel);
            this.HeaderPanel.Controls.Add(this.FutureTurnsTextBox);
            this.HeaderPanel.Controls.Add(this.FutureTurnsLabel);
            this.HeaderPanel.Controls.Add(this.SecondTurnTextBox);
            this.HeaderPanel.Controls.Add(this.SecondTurnLabel);
            this.HeaderPanel.Controls.Add(this.FirstTurnTextBox);
            this.HeaderPanel.Controls.Add(this.FirstTurnLabel);
            this.HeaderPanel.Controls.Add(this.NameTextBox);
            this.HeaderPanel.Controls.Add(this.NameLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(9, 63);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(500, 404);
            this.HeaderPanel.TabIndex = 5;
            // 
            // DefaultDescriptionCheckBox
            // 
            this.DefaultDescriptionCheckBox.AutoSize = true;
            this.DefaultDescriptionCheckBox.Checked = true;
            this.DefaultDescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDescriptionCheckBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DefaultDescriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DefaultDescriptionCheckBox.Location = new System.Drawing.Point(8, 363);
            this.DefaultDescriptionCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DefaultDescriptionCheckBox.Name = "DefaultDescriptionCheckBox";
            this.DefaultDescriptionCheckBox.Size = new System.Drawing.Size(343, 28);
            this.DefaultDescriptionCheckBox.TabIndex = 19;
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
            this.DescriptionBox.Location = new System.Drawing.Point(8, 280);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(474, 79);
            this.DescriptionBox.TabIndex = 16;
            this.DescriptionBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 220);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(234, 69);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FutureTurnsTextBox
            // 
            this.FutureTurnsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnsTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.FutureTurnsTextBox.Location = new System.Drawing.Point(253, 187);
            this.FutureTurnsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FutureTurnsTextBox.Name = "FutureTurnsTextBox";
            this.FutureTurnsTextBox.Size = new System.Drawing.Size(231, 32);
            this.FutureTurnsTextBox.TabIndex = 12;
            this.FutureTurnsTextBox.Text = "0";
            this.FutureTurnsTextBox.TextChanged += new System.EventHandler(this.TurnTextBox_TextChanged);
            // 
            // FutureTurnsLabel
            // 
            this.FutureTurnsLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnsLabel.Location = new System.Drawing.Point(251, 115);
            this.FutureTurnsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FutureTurnsLabel.Name = "FutureTurnsLabel";
            this.FutureTurnsLabel.Size = new System.Drawing.Size(232, 69);
            this.FutureTurnsLabel.TabIndex = 11;
            this.FutureTurnsLabel.Text = "В дальнейшем VIII\r\nприв.чел./час";
            this.FutureTurnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondTurnTextBox
            // 
            this.SecondTurnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.SecondTurnTextBox.Location = new System.Drawing.Point(8, 187);
            this.SecondTurnTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecondTurnTextBox.Name = "SecondTurnTextBox";
            this.SecondTurnTextBox.Size = new System.Drawing.Size(231, 32);
            this.SecondTurnTextBox.TabIndex = 10;
            this.SecondTurnTextBox.Text = "0";
            this.SecondTurnTextBox.TextChanged += new System.EventHandler(this.TurnTextBox_TextChanged);
            // 
            // SecondTurnLabel
            // 
            this.SecondTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnLabel.Location = new System.Drawing.Point(6, 115);
            this.SecondTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondTurnLabel.Name = "SecondTurnLabel";
            this.SecondTurnLabel.Size = new System.Drawing.Size(232, 69);
            this.SecondTurnLabel.TabIndex = 9;
            this.SecondTurnLabel.Text = "II очереди VII\r\nприв.чел./час";
            this.SecondTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstTurnTextBox
            // 
            this.FirstTurnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.FirstTurnTextBox.Location = new System.Drawing.Point(253, 82);
            this.FirstTurnTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstTurnTextBox.Name = "FirstTurnTextBox";
            this.FirstTurnTextBox.Size = new System.Drawing.Size(231, 32);
            this.FirstTurnTextBox.TabIndex = 8;
            this.FirstTurnTextBox.Text = "0";
            this.FirstTurnTextBox.TextChanged += new System.EventHandler(this.TurnTextBox_TextChanged);
            // 
            // FirstTurnLabel
            // 
            this.FirstTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnLabel.Location = new System.Drawing.Point(251, 11);
            this.FirstTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstTurnLabel.Name = "FirstTurnLabel";
            this.FirstTurnLabel.Size = new System.Drawing.Size(232, 69);
            this.FirstTurnLabel.TabIndex = 7;
            this.FirstTurnLabel.Text = "I очереди VI\r\nприв.чел./час";
            this.FirstTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NameTextBox.Location = new System.Drawing.Point(10, 82);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(231, 32);
            this.NameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameLabel.Location = new System.Drawing.Point(6, 11);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(234, 69);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddElementButton
            // 
            this.AddElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddElementButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AddElementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AddElementButton.Location = new System.Drawing.Point(364, 479);
            this.AddElementButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(145, 54);
            this.AddElementButton.TabIndex = 6;
            this.AddElementButton.TabStop = false;
            this.AddElementButton.Text = "Сохранить";
            this.AddElementButton.UseVisualStyleBackColor = false;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(5, 502);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Сделать стандартным";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BuildingElementCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(518, 540);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "BuildingElementCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание элемента построения";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox FirstTurnTextBox;
        public System.Windows.Forms.Label FirstTurnLabel;
        private System.Windows.Forms.TextBox FutureTurnsTextBox;
        public System.Windows.Forms.Label FutureTurnsLabel;
        private System.Windows.Forms.TextBox SecondTurnTextBox;
        public System.Windows.Forms.Label SecondTurnLabel;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        public System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.CheckBox DefaultDescriptionCheckBox;
    }
}