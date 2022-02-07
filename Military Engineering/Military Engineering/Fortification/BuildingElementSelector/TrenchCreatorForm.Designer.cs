namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    partial class TrenchCreatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SecondTurnTextBox = new System.Windows.Forms.TextBox();
            this.kCoeffLabel = new System.Windows.Forms.Label();
            this.TrenchTypeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.TrenchTypeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.DefaultDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(665, 74);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "СОЗДАТЬ/РЕДАКТИРОВАТЬ ТРАНШЕЮ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.DefaultDescriptionCheckBox);
            this.panel1.Controls.Add(this.DescriptionBox);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.TrenchTypeRadioButton2);
            this.panel1.Controls.Add(this.TrenchTypeRadioButton1);
            this.panel1.Controls.Add(this.SecondTurnTextBox);
            this.panel1.Controls.Add(this.kCoeffLabel);
            this.panel1.Controls.Add(this.LengthTextBox);
            this.panel1.Controls.Add(this.LengthLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 478);
            this.panel1.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NameTextBox.Location = new System.Drawing.Point(8, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(307, 38);
            this.NameTextBox.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameLabel.Location = new System.Drawing.Point(3, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(312, 85);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.LengthTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.LengthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.LengthTextBox.Location = new System.Drawing.Point(323, 94);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(307, 38);
            this.LengthTextBox.TabIndex = 10;
            // 
            // LengthLabel
            // 
            this.LengthLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.LengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.LengthLabel.Location = new System.Drawing.Point(321, 6);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(309, 85);
            this.LengthLabel.TabIndex = 9;
            this.LengthLabel.Text = "Длина";
            this.LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondTurnTextBox
            // 
            this.SecondTurnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.SecondTurnTextBox.Location = new System.Drawing.Point(8, 223);
            this.SecondTurnTextBox.Name = "SecondTurnTextBox";
            this.SecondTurnTextBox.Size = new System.Drawing.Size(307, 38);
            this.SecondTurnTextBox.TabIndex = 12;
            this.SecondTurnTextBox.Text = "1,15";
            // 
            // kCoeffLabel
            // 
            this.kCoeffLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.kCoeffLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.kCoeffLabel.Location = new System.Drawing.Point(6, 135);
            this.kCoeffLabel.Name = "kCoeffLabel";
            this.kCoeffLabel.Size = new System.Drawing.Size(309, 85);
            this.kCoeffLabel.TabIndex = 11;
            this.kCoeffLabel.Text = "Коэффициент кривизны";
            this.kCoeffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrenchTypeRadioButton1
            // 
            this.TrenchTypeRadioButton1.AutoSize = true;
            this.TrenchTypeRadioButton1.Checked = true;
            this.TrenchTypeRadioButton1.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchTypeRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchTypeRadioButton1.Location = new System.Drawing.Point(326, 160);
            this.TrenchTypeRadioButton1.Name = "TrenchTypeRadioButton1";
            this.TrenchTypeRadioButton1.Size = new System.Drawing.Size(192, 34);
            this.TrenchTypeRadioButton1.TabIndex = 13;
            this.TrenchTypeRadioButton1.TabStop = true;
            this.TrenchTypeRadioButton1.Text = "Траншея(1.1 м)";
            this.TrenchTypeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // TrenchTypeRadioButton2
            // 
            this.TrenchTypeRadioButton2.AutoSize = true;
            this.TrenchTypeRadioButton2.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchTypeRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchTypeRadioButton2.Location = new System.Drawing.Point(326, 223);
            this.TrenchTypeRadioButton2.Name = "TrenchTypeRadioButton2";
            this.TrenchTypeRadioButton2.Size = new System.Drawing.Size(280, 34);
            this.TrenchTypeRadioButton2.TabIndex = 14;
            this.TrenchTypeRadioButton2.Text = "Ход сообщения(1.5 м)";
            this.TrenchTypeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // DefaultDescriptionCheckBox
            // 
            this.DefaultDescriptionCheckBox.AutoSize = true;
            this.DefaultDescriptionCheckBox.Checked = true;
            this.DefaultDescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDescriptionCheckBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DefaultDescriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DefaultDescriptionCheckBox.Location = new System.Drawing.Point(5, 440);
            this.DefaultDescriptionCheckBox.Name = "DefaultDescriptionCheckBox";
            this.DefaultDescriptionCheckBox.Size = new System.Drawing.Size(424, 34);
            this.DefaultDescriptionCheckBox.TabIndex = 22;
            this.DefaultDescriptionCheckBox.Text = "Создать описание автоматически";
            this.DefaultDescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.DescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.DescriptionBox.Location = new System.Drawing.Point(8, 338);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(622, 96);
            this.DescriptionBox.TabIndex = 21;
            this.DescriptionBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 264);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(312, 85);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddElementButton
            // 
            this.AddElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddElementButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AddElementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AddElementButton.Location = new System.Drawing.Point(460, 551);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(193, 66);
            this.AddElementButton.TabIndex = 7;
            this.AddElementButton.TabStop = false;
            this.AddElementButton.Text = "Сохранить";
            this.AddElementButton.UseVisualStyleBackColor = false;
            // 
            // TrenchCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(665, 621);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TrenchCreatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать траншею";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        public System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox SecondTurnTextBox;
        public System.Windows.Forms.Label kCoeffLabel;
        private System.Windows.Forms.RadioButton TrenchTypeRadioButton2;
        private System.Windows.Forms.RadioButton TrenchTypeRadioButton1;
        private System.Windows.Forms.CheckBox DefaultDescriptionCheckBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        public System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button AddElementButton;
    }
}