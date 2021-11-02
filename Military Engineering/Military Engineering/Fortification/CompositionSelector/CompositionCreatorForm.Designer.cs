namespace MilitaryEngineering.Fortification.CompositionSelector
{
    partial class CompositionCreatorForm
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ElementsLabel = new System.Windows.Forms.Label();
            this.ElementsPanel = new System.Windows.Forms.Panel();
            this.ElementsTable = new System.Windows.Forms.TableLayoutPanel();
            this.CompositionsPanel = new System.Windows.Forms.Panel();
            this.CompositionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.CompositionsLabel = new System.Windows.Forms.Label();
            this.SaveCompositionButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.ElementsPanel.SuspendLayout();
            this.CompositionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(717, 74);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "СОЗДАТЬ КОМПОЗИЦИЮ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.MainPanel.Controls.Add(this.DefaultDescriptionCheckBox);
            this.MainPanel.Controls.Add(this.DescriptionBox);
            this.MainPanel.Controls.Add(this.DescriptionLabel);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Location = new System.Drawing.Point(16, 77);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(667, 347);
            this.MainPanel.TabIndex = 7;
            // 
            // DefaultDescriptionCheckBox
            // 
            this.DefaultDescriptionCheckBox.AutoSize = true;
            this.DefaultDescriptionCheckBox.Checked = true;
            this.DefaultDescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDescriptionCheckBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DefaultDescriptionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DefaultDescriptionCheckBox.Location = new System.Drawing.Point(13, 304);
            this.DefaultDescriptionCheckBox.Name = "DefaultDescriptionCheckBox";
            this.DefaultDescriptionCheckBox.Size = new System.Drawing.Size(424, 34);
            this.DefaultDescriptionCheckBox.TabIndex = 18;
            this.DefaultDescriptionCheckBox.Text = "Создать описание автоматически";
            this.DefaultDescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.DescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.DescriptionBox.Location = new System.Drawing.Point(13, 192);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(631, 96);
            this.DescriptionBox.TabIndex = 17;
            this.DescriptionBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Enabled = false;
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(11, 123);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(305, 81);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.NameLabel.Location = new System.Drawing.Point(11, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(312, 67);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(0, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "ДОБАВИТЬ ЭЛЕМЕНТЫ И КОМПОЗИЦИИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementsLabel
            // 
            this.ElementsLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.ElementsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.ElementsLabel.Location = new System.Drawing.Point(12, 501);
            this.ElementsLabel.Name = "ElementsLabel";
            this.ElementsLabel.Size = new System.Drawing.Size(187, 42);
            this.ElementsLabel.TabIndex = 9;
            this.ElementsLabel.Text = "Элементы:";
            this.ElementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.ElementsPanel.Controls.Add(this.ElementsTable);
            this.ElementsPanel.Location = new System.Drawing.Point(16, 564);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(667, 140);
            this.ElementsPanel.TabIndex = 10;
            // 
            // ElementsTable
            // 
            this.ElementsTable.ColumnCount = 1;
            this.ElementsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ElementsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElementsTable.Location = new System.Drawing.Point(0, 0);
            this.ElementsTable.Name = "ElementsTable";
            this.ElementsTable.RowCount = 1;
            this.ElementsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ElementsTable.Size = new System.Drawing.Size(667, 140);
            this.ElementsTable.TabIndex = 0;
            // 
            // CompositionsPanel
            // 
            this.CompositionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.CompositionsPanel.Controls.Add(this.CompositionsTable);
            this.CompositionsPanel.Location = new System.Drawing.Point(16, 784);
            this.CompositionsPanel.Name = "CompositionsPanel";
            this.CompositionsPanel.Size = new System.Drawing.Size(667, 140);
            this.CompositionsPanel.TabIndex = 12;
            // 
            // CompositionsTable
            // 
            this.CompositionsTable.ColumnCount = 1;
            this.CompositionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CompositionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompositionsTable.Location = new System.Drawing.Point(0, 0);
            this.CompositionsTable.Name = "CompositionsTable";
            this.CompositionsTable.RowCount = 1;
            this.CompositionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CompositionsTable.Size = new System.Drawing.Size(667, 140);
            this.CompositionsTable.TabIndex = 1;
            // 
            // CompositionsLabel
            // 
            this.CompositionsLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.CompositionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CompositionsLabel.Location = new System.Drawing.Point(12, 721);
            this.CompositionsLabel.Name = "CompositionsLabel";
            this.CompositionsLabel.Size = new System.Drawing.Size(233, 42);
            this.CompositionsLabel.TabIndex = 11;
            this.CompositionsLabel.Text = "Композиции:";
            this.CompositionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveCompositionButton
            // 
            this.SaveCompositionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SaveCompositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCompositionButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SaveCompositionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.SaveCompositionButton.Location = new System.Drawing.Point(490, 930);
            this.SaveCompositionButton.Name = "SaveCompositionButton";
            this.SaveCompositionButton.Size = new System.Drawing.Size(193, 66);
            this.SaveCompositionButton.TabIndex = 13;
            this.SaveCompositionButton.TabStop = false;
            this.SaveCompositionButton.Text = "Сохранить";
            this.SaveCompositionButton.UseVisualStyleBackColor = false;
            this.SaveCompositionButton.Click += new System.EventHandler(this.SaveCompositionButton_Click);
            // 
            // CompositionCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(717, 1042);
            this.Controls.Add(this.SaveCompositionButton);
            this.Controls.Add(this.CompositionsPanel);
            this.Controls.Add(this.CompositionsLabel);
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.ElementsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CompositionCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание композиции";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ElementsPanel.ResumeLayout(false);
            this.CompositionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox DefaultDescriptionCheckBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        public System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ElementsLabel;
        private System.Windows.Forms.Panel ElementsPanel;
        private System.Windows.Forms.Panel CompositionsPanel;
        public System.Windows.Forms.Label CompositionsLabel;
        private System.Windows.Forms.Button SaveCompositionButton;
        private System.Windows.Forms.TableLayoutPanel ElementsTable;
        private System.Windows.Forms.TableLayoutPanel CompositionsTable;
    }
}