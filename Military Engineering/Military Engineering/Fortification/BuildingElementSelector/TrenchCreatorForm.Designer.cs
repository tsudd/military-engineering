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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrenchCreatorForm));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TurnTypePanel = new System.Windows.Forms.Panel();
            this.FutureTurnsRadioBotton = new System.Windows.Forms.RadioButton();
            this.SecondTurnRadioBotton = new System.Windows.Forms.RadioButton();
            this.FirstTurnRadioBotton = new System.Windows.Forms.RadioButton();
            this.DefaultDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TrenchTypeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.TrenchTypeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.CurvFactorTextBox = new System.Windows.Forms.TextBox();
            this.CurvFactorLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.TurnTypePanel.SuspendLayout();
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
            this.InfoLabel.Size = new System.Drawing.Size(665, 74);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "СОЗДАТЬ/РЕДАКТИРОВАТЬ ТРАНШЕЮ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.MainPanel.Controls.Add(this.TurnTypePanel);
            this.MainPanel.Controls.Add(this.DefaultDescriptionCheckBox);
            this.MainPanel.Controls.Add(this.DescriptionBox);
            this.MainPanel.Controls.Add(this.DescriptionLabel);
            this.MainPanel.Controls.Add(this.TrenchTypeRadioButton2);
            this.MainPanel.Controls.Add(this.TrenchTypeRadioButton1);
            this.MainPanel.Controls.Add(this.CurvFactorTextBox);
            this.MainPanel.Controls.Add(this.CurvFactorLabel);
            this.MainPanel.Controls.Add(this.LengthTextBox);
            this.MainPanel.Controls.Add(this.LengthLabel);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 68);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(641, 562);
            this.MainPanel.TabIndex = 6;
            // 
            // TurnTypePanel
            // 
            this.TurnTypePanel.Controls.Add(this.FutureTurnsRadioBotton);
            this.TurnTypePanel.Controls.Add(this.SecondTurnRadioBotton);
            this.TurnTypePanel.Controls.Add(this.FirstTurnRadioBotton);
            this.TurnTypePanel.Location = new System.Drawing.Point(0, 278);
            this.TurnTypePanel.Margin = new System.Windows.Forms.Padding(2);
            this.TurnTypePanel.Name = "TurnTypePanel";
            this.TurnTypePanel.Size = new System.Drawing.Size(641, 72);
            this.TurnTypePanel.TabIndex = 23;
            // 
            // FutureTurnsRadioBotton
            // 
            this.FutureTurnsRadioBotton.AutoSize = true;
            this.FutureTurnsRadioBotton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnsRadioBotton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnsRadioBotton.Location = new System.Drawing.Point(428, 19);
            this.FutureTurnsRadioBotton.Margin = new System.Windows.Forms.Padding(2);
            this.FutureTurnsRadioBotton.Name = "FutureTurnsRadioBotton";
            this.FutureTurnsRadioBotton.Size = new System.Drawing.Size(202, 34);
            this.FutureTurnsRadioBotton.TabIndex = 16;
            this.FutureTurnsRadioBotton.Text = "В дальнейшем";
            this.FutureTurnsRadioBotton.UseVisualStyleBackColor = true;
            // 
            // SecondTurnRadioBotton
            // 
            this.SecondTurnRadioBotton.AutoSize = true;
            this.SecondTurnRadioBotton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SecondTurnRadioBotton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnRadioBotton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnRadioBotton.Location = new System.Drawing.Point(209, 19);
            this.SecondTurnRadioBotton.Margin = new System.Windows.Forms.Padding(2);
            this.SecondTurnRadioBotton.Name = "SecondTurnRadioBotton";
            this.SecondTurnRadioBotton.Size = new System.Drawing.Size(188, 34);
            this.SecondTurnRadioBotton.TabIndex = 15;
            this.SecondTurnRadioBotton.Text = "Во II очередь";
            this.SecondTurnRadioBotton.UseVisualStyleBackColor = true;
            // 
            // FirstTurnRadioBotton
            // 
            this.FirstTurnRadioBotton.AutoSize = true;
            this.FirstTurnRadioBotton.Checked = true;
            this.FirstTurnRadioBotton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnRadioBotton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnRadioBotton.Location = new System.Drawing.Point(11, 19);
            this.FirstTurnRadioBotton.Margin = new System.Windows.Forms.Padding(2);
            this.FirstTurnRadioBotton.Name = "FirstTurnRadioBotton";
            this.FirstTurnRadioBotton.Size = new System.Drawing.Size(167, 34);
            this.FirstTurnRadioBotton.TabIndex = 14;
            this.FirstTurnRadioBotton.TabStop = true;
            this.FirstTurnRadioBotton.Text = "В I очередь";
            this.FirstTurnRadioBotton.UseVisualStyleBackColor = true;
            // 
            // DefaultDescriptionCheckBox
            // 
            this.DefaultDescriptionCheckBox.AutoSize = true;
            this.DefaultDescriptionCheckBox.Checked = true;
            this.DefaultDescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDescriptionCheckBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DefaultDescriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DefaultDescriptionCheckBox.Location = new System.Drawing.Point(5, 514);
            this.DefaultDescriptionCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultDescriptionCheckBox.Name = "DefaultDescriptionCheckBox";
            this.DefaultDescriptionCheckBox.Size = new System.Drawing.Size(424, 34);
            this.DefaultDescriptionCheckBox.TabIndex = 22;
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
            this.DescriptionBox.Location = new System.Drawing.Point(8, 412);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(622, 96);
            this.DescriptionBox.TabIndex = 21;
            this.DescriptionBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(2, 338);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(312, 85);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrenchTypeRadioButton2
            // 
            this.TrenchTypeRadioButton2.AutoSize = true;
            this.TrenchTypeRadioButton2.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchTypeRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchTypeRadioButton2.Location = new System.Drawing.Point(326, 222);
            this.TrenchTypeRadioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.TrenchTypeRadioButton2.Name = "TrenchTypeRadioButton2";
            this.TrenchTypeRadioButton2.Size = new System.Drawing.Size(280, 34);
            this.TrenchTypeRadioButton2.TabIndex = 14;
            this.TrenchTypeRadioButton2.Text = "Ход сообщения(1.5 м)";
            this.TrenchTypeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // TrenchTypeRadioButton1
            // 
            this.TrenchTypeRadioButton1.AutoSize = true;
            this.TrenchTypeRadioButton1.Checked = true;
            this.TrenchTypeRadioButton1.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.TrenchTypeRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.TrenchTypeRadioButton1.Location = new System.Drawing.Point(326, 160);
            this.TrenchTypeRadioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.TrenchTypeRadioButton1.Name = "TrenchTypeRadioButton1";
            this.TrenchTypeRadioButton1.Size = new System.Drawing.Size(192, 34);
            this.TrenchTypeRadioButton1.TabIndex = 13;
            this.TrenchTypeRadioButton1.TabStop = true;
            this.TrenchTypeRadioButton1.Text = "Траншея(1.1 м)";
            this.TrenchTypeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // CurvFactorTextBox
            // 
            this.CurvFactorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CurvFactorTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CurvFactorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CurvFactorTextBox.Location = new System.Drawing.Point(8, 222);
            this.CurvFactorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CurvFactorTextBox.Name = "CurvFactorTextBox";
            this.CurvFactorTextBox.Size = new System.Drawing.Size(306, 38);
            this.CurvFactorTextBox.TabIndex = 12;
            this.CurvFactorTextBox.Text = "1.15";
            this.CurvFactorTextBox.TextChanged += new System.EventHandler(this.ValuesTextBox_TextChanged);
            // 
            // CurvFactorLabel
            // 
            this.CurvFactorLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CurvFactorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CurvFactorLabel.Location = new System.Drawing.Point(6, 135);
            this.CurvFactorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurvFactorLabel.Name = "CurvFactorLabel";
            this.CurvFactorLabel.Size = new System.Drawing.Size(309, 85);
            this.CurvFactorLabel.TabIndex = 11;
            this.CurvFactorLabel.Text = "Коэффициент кривизны";
            this.CurvFactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.LengthTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.LengthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.LengthTextBox.Location = new System.Drawing.Point(322, 94);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(306, 38);
            this.LengthTextBox.TabIndex = 10;
            this.LengthTextBox.Text = "0";
            this.LengthTextBox.TextChanged += new System.EventHandler(this.ValuesTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.LengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.LengthLabel.Location = new System.Drawing.Point(321, 6);
            this.LengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(309, 85);
            this.LengthLabel.TabIndex = 9;
            this.LengthLabel.Text = "Длина";
            this.LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NameTextBox.Location = new System.Drawing.Point(8, 94);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(306, 38);
            this.NameTextBox.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameLabel.Location = new System.Drawing.Point(2, 6);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(312, 85);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddElementButton
            // 
            this.AddElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddElementButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AddElementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AddElementButton.Location = new System.Drawing.Point(460, 636);
            this.AddElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(192, 66);
            this.AddElementButton.TabIndex = 7;
            this.AddElementButton.TabStop = false;
            this.AddElementButton.Text = "Сохранить";
            this.AddElementButton.UseVisualStyleBackColor = false;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // TrenchCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(665, 715);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TrenchCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать траншею";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TurnTypePanel.ResumeLayout(false);
            this.TurnTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        public System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox CurvFactorTextBox;
        public System.Windows.Forms.Label CurvFactorLabel;
        private System.Windows.Forms.RadioButton TrenchTypeRadioButton2;
        private System.Windows.Forms.RadioButton TrenchTypeRadioButton1;
        private System.Windows.Forms.CheckBox DefaultDescriptionCheckBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        public System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Panel TurnTypePanel;
        private System.Windows.Forms.RadioButton FutureTurnsRadioBotton;
        private System.Windows.Forms.RadioButton SecondTurnRadioBotton;
        private System.Windows.Forms.RadioButton FirstTurnRadioBotton;
    }
}