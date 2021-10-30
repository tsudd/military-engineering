﻿namespace MilitaryEngineering.Fortification.CompositionSelector
{
    partial class CompositionSelectorForm
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.CreateCompositionButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(469, 73);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "КОМПОЗИЦИИ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MainPanel.Size = new System.Drawing.Size(470, 498);
            this.MainPanel.TabIndex = 5;
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
            this.MainTable.Size = new System.Drawing.Size(470, 498);
            this.MainTable.TabIndex = 0;
            // 
            // CreateCompositionButton
            // 
            this.CreateCompositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCompositionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CreateCompositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCompositionButton.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CreateCompositionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CreateCompositionButton.Location = new System.Drawing.Point(218, 590);
            this.CreateCompositionButton.Name = "CreateCompositionButton";
            this.CreateCompositionButton.Size = new System.Drawing.Size(264, 66);
            this.CreateCompositionButton.TabIndex = 6;
            this.CreateCompositionButton.TabStop = false;
            this.CreateCompositionButton.Text = "Создать новую";
            this.CreateCompositionButton.UseVisualStyleBackColor = false;
            // 
            // CompositionSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(494, 668);
            this.Controls.Add(this.CreateCompositionButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoLabel);
            this.Name = "CompositionSelectorForm";
            this.Text = "CompositionSelectorForm";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Button CreateCompositionButton;
    }
}