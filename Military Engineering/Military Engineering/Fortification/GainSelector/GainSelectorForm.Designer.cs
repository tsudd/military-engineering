
namespace MilitaryEngineering.Fortification.GainSelector
{
    partial class GainSelectorForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CreateGainButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.NoChangesButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
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
            this.MainPanel.Location = new System.Drawing.Point(12, 85);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(542, 498);
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
            this.MainTable.Size = new System.Drawing.Size(542, 498);
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
            this.InfoLabel.Size = new System.Drawing.Size(541, 73);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "УСИЛЕНИЯ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateGainButton
            // 
            this.CreateGainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateGainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CreateGainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateGainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateGainButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CreateGainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CreateGainButton.Location = new System.Drawing.Point(481, 9);
            this.CreateGainButton.MinimumSize = new System.Drawing.Size(75, 67);
            this.CreateGainButton.Name = "CreateGainButton";
            this.CreateGainButton.Size = new System.Drawing.Size(75, 67);
            this.CreateGainButton.TabIndex = 4;
            this.CreateGainButton.TabStop = false;
            this.CreateGainButton.UseVisualStyleBackColor = false;
            this.CreateGainButton.Click += new System.EventHandler(this.CreateGainButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.DoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.DoneButton.Location = new System.Drawing.Point(240, 589);
            this.DoneButton.MinimumSize = new System.Drawing.Size(75, 67);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(154, 67);
            this.DoneButton.TabIndex = 5;
            this.DoneButton.TabStop = false;
            this.DoneButton.Text = "Готово";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // NoChangesButton
            // 
            this.NoChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NoChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.NoChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoChangesButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.NoChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.NoChangesButton.Location = new System.Drawing.Point(400, 589);
            this.NoChangesButton.MinimumSize = new System.Drawing.Size(75, 67);
            this.NoChangesButton.Name = "NoChangesButton";
            this.NoChangesButton.Size = new System.Drawing.Size(154, 67);
            this.NoChangesButton.TabIndex = 6;
            this.NoChangesButton.TabStop = false;
            this.NoChangesButton.Text = "Отмена";
            this.NoChangesButton.UseVisualStyleBackColor = false;
            this.NoChangesButton.Click += new System.EventHandler(this.NoChangesButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountLabel.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AmountLabel.Location = new System.Drawing.Point(12, 589);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(150, 67);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Всего";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GainSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(566, 668);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NoChangesButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CreateGainButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(512, 715);
            this.Name = "GainSelectorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор усиления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GainSelectorForm_FormClosed);
            this.Load += new System.EventHandler(this.GainSelectorForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CreateGainButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button NoChangesButton;
        public System.Windows.Forms.Label AmountLabel;
    }
}