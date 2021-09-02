
namespace Military_Engineering.Fortification
{
    partial class BuildingElementPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.FirstTurnLabel = new System.Windows.Forms.Label();
            this.SecondTurnLabel = new System.Windows.Forms.Label();
            this.FutureTurnLabel = new System.Windows.Forms.Label();
            this.AllTurnsLabel = new System.Windows.Forms.Label();
            this.DayLightBox = new System.Windows.Forms.ComboBox();
            this.PollutionBox = new System.Windows.Forms.ComboBox();
            this.SoilTypeBox = new System.Windows.Forms.ComboBox();
            this.GainBox = new System.Windows.Forms.ComboBox();
            this.PeopleAmountBox = new System.Windows.Forms.TextBox();
            this.ManPowerBox = new System.Windows.Forms.TextBox();
            this.BackGroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NameLabel.Location = new System.Drawing.Point(46, 32);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(265, 91);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "No name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackGroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.BackGroundPanel.Controls.Add(this.ManPowerBox);
            this.BackGroundPanel.Controls.Add(this.PeopleAmountBox);
            this.BackGroundPanel.Controls.Add(this.GainBox);
            this.BackGroundPanel.Controls.Add(this.SoilTypeBox);
            this.BackGroundPanel.Controls.Add(this.PollutionBox);
            this.BackGroundPanel.Controls.Add(this.DayLightBox);
            this.BackGroundPanel.Controls.Add(this.AllTurnsLabel);
            this.BackGroundPanel.Controls.Add(this.FutureTurnLabel);
            this.BackGroundPanel.Controls.Add(this.SecondTurnLabel);
            this.BackGroundPanel.Controls.Add(this.FirstTurnLabel);
            this.BackGroundPanel.Controls.Add(this.NameLabel);
            this.BackGroundPanel.Location = new System.Drawing.Point(29, 14);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(2335, 295);
            this.BackGroundPanel.TabIndex = 6;
            // 
            // FirstTurnLabel
            // 
            this.FirstTurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstTurnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.FirstTurnLabel.Location = new System.Drawing.Point(386, 32);
            this.FirstTurnLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstTurnLabel.Name = "FirstTurnLabel";
            this.FirstTurnLabel.Size = new System.Drawing.Size(334, 91);
            this.FirstTurnLabel.TabIndex = 6;
            this.FirstTurnLabel.Text = "0";
            this.FirstTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondTurnLabel
            // 
            this.SecondTurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondTurnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.SecondTurnLabel.Location = new System.Drawing.Point(741, 32);
            this.SecondTurnLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SecondTurnLabel.Name = "SecondTurnLabel";
            this.SecondTurnLabel.Size = new System.Drawing.Size(307, 91);
            this.SecondTurnLabel.TabIndex = 7;
            this.SecondTurnLabel.Text = "0";
            this.SecondTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FutureTurnLabel
            // 
            this.FutureTurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FutureTurnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.FutureTurnLabel.Location = new System.Drawing.Point(1103, 32);
            this.FutureTurnLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FutureTurnLabel.Name = "FutureTurnLabel";
            this.FutureTurnLabel.Size = new System.Drawing.Size(316, 91);
            this.FutureTurnLabel.TabIndex = 8;
            this.FutureTurnLabel.Text = "0";
            this.FutureTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AllTurnsLabel
            // 
            this.AllTurnsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTurnsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AllTurnsLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AllTurnsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AllTurnsLabel.Location = new System.Drawing.Point(1516, 32);
            this.AllTurnsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AllTurnsLabel.Name = "AllTurnsLabel";
            this.AllTurnsLabel.Size = new System.Drawing.Size(394, 91);
            this.AllTurnsLabel.TabIndex = 9;
            this.AllTurnsLabel.Text = "0";
            this.AllTurnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DayLightBox
            // 
            this.DayLightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.DayLightBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayLightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DayLightBox.FormattingEnabled = true;
            this.DayLightBox.Location = new System.Drawing.Point(55, 148);
            this.DayLightBox.Name = "DayLightBox";
            this.DayLightBox.Size = new System.Drawing.Size(290, 62);
            this.DayLightBox.TabIndex = 10;
            // 
            // PollutionBox
            // 
            this.PollutionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.PollutionBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PollutionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PollutionBox.FormattingEnabled = true;
            this.PollutionBox.Location = new System.Drawing.Point(430, 148);
            this.PollutionBox.Name = "PollutionBox";
            this.PollutionBox.Size = new System.Drawing.Size(290, 62);
            this.PollutionBox.TabIndex = 11;
            // 
            // SoilTypeBox
            // 
            this.SoilTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.SoilTypeBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoilTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SoilTypeBox.FormattingEnabled = true;
            this.SoilTypeBox.Location = new System.Drawing.Point(814, 148);
            this.SoilTypeBox.Name = "SoilTypeBox";
            this.SoilTypeBox.Size = new System.Drawing.Size(290, 62);
            this.SoilTypeBox.TabIndex = 12;
            // 
            // GainBox
            // 
            this.GainBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.GainBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GainBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.GainBox.FormattingEnabled = true;
            this.GainBox.Location = new System.Drawing.Point(1200, 148);
            this.GainBox.Name = "GainBox";
            this.GainBox.Size = new System.Drawing.Size(290, 62);
            this.GainBox.TabIndex = 13;
            // 
            // PeopleAmountBox
            // 
            this.PeopleAmountBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.PeopleAmountBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.PeopleAmountBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PeopleAmountBox.Location = new System.Drawing.Point(1538, 148);
            this.PeopleAmountBox.Margin = new System.Windows.Forms.Padding(5);
            this.PeopleAmountBox.Name = "PeopleAmountBox";
            this.PeopleAmountBox.Size = new System.Drawing.Size(330, 62);
            this.PeopleAmountBox.TabIndex = 14;
            this.PeopleAmountBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ManPowerBox
            // 
            this.ManPowerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.ManPowerBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.ManPowerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.ManPowerBox.Location = new System.Drawing.Point(1955, 148);
            this.ManPowerBox.Margin = new System.Windows.Forms.Padding(5);
            this.ManPowerBox.Name = "ManPowerBox";
            this.ManPowerBox.Size = new System.Drawing.Size(330, 62);
            this.ManPowerBox.TabIndex = 15;
            // 
            // BuildingElementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.BackGroundPanel);
            this.Name = "BuildingElementPanel";
            this.Size = new System.Drawing.Size(2395, 333);
            this.BackGroundPanel.ResumeLayout(false);
            this.BackGroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.ComboBox DayLightBox;
        public System.Windows.Forms.Label AllTurnsLabel;
        public System.Windows.Forms.Label FutureTurnLabel;
        public System.Windows.Forms.Label SecondTurnLabel;
        public System.Windows.Forms.Label FirstTurnLabel;
        private System.Windows.Forms.ComboBox GainBox;
        private System.Windows.Forms.ComboBox SoilTypeBox;
        private System.Windows.Forms.ComboBox PollutionBox;
        private System.Windows.Forms.TextBox PeopleAmountBox;
        private System.Windows.Forms.TextBox ManPowerBox;
    }
}
