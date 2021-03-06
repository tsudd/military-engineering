
namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    partial class BuildingElementSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingElementSelectorForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CreateElementButton = new System.Windows.Forms.Button();
            this.CreateTrenchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.MainPanel.Controls.Add(this.MainTable);
            this.MainPanel.Location = new System.Drawing.Point(12, 127);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(470, 460);
            this.MainPanel.TabIndex = 0;
            // 
            // MainTable
            // 
            this.MainTable.AutoScroll = true;
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.Size = new System.Drawing.Size(470, 460);
            this.MainTable.TabIndex = 0;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Location = new System.Drawing.Point(15, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(469, 73);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "ЭЛЕМЕНТЫ ПОСТРОЕНИЯ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateElementButton
            // 
            this.CreateElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CreateElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateElementButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CreateElementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CreateElementButton.Location = new System.Drawing.Point(308, 593);
            this.CreateElementButton.Name = "CreateElementButton";
            this.CreateElementButton.Size = new System.Drawing.Size(174, 77);
            this.CreateElementButton.TabIndex = 4;
            this.CreateElementButton.TabStop = false;
            this.CreateElementButton.Text = "Создать\r\nэлемент";
            this.CreateElementButton.UseVisualStyleBackColor = false;
            this.CreateElementButton.Click += new System.EventHandler(this.CreateElementButton_Click);
            // 
            // CreateTrenchButton
            // 
            this.CreateTrenchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTrenchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CreateTrenchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTrenchButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CreateTrenchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CreateTrenchButton.Location = new System.Drawing.Point(128, 593);
            this.CreateTrenchButton.Name = "CreateTrenchButton";
            this.CreateTrenchButton.Size = new System.Drawing.Size(174, 77);
            this.CreateTrenchButton.TabIndex = 5;
            this.CreateTrenchButton.TabStop = false;
            this.CreateTrenchButton.Text = "Создать\r\nтраншею";
            this.CreateTrenchButton.UseVisualStyleBackColor = false;
            this.CreateTrenchButton.Click += new System.EventHandler(this.CreateTrenchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 84);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(470, 38);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // BuildingElementSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(494, 679);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CreateTrenchButton);
            this.Controls.Add(this.CreateElementButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 715);
            this.Name = "BuildingElementSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор элемента построения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuildingElementSelectorForm_FormClosed);
            this.Load += new System.EventHandler(this.BuildingElementSelectorForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CreateElementButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Button CreateTrenchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}