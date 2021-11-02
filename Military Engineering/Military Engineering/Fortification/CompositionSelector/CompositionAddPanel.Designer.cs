namespace MilitaryEngineering.Fortification.CompositionSelector
{
    partial class CompositionAddPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.DescriptionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SubstractButton = new MilitaryEngineering.Controls.Button();
            this.AddButton = new MilitaryEngineering.Controls.Button();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.BackPanel.Controls.Add(this.SubstractButton);
            this.BackPanel.Controls.Add(this.AddButton);
            this.BackPanel.Controls.Add(this.CounterLabel);
            this.BackPanel.Controls.Add(this.InfoLabel);
            this.BackPanel.Location = new System.Drawing.Point(17, 8);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(638, 70);
            this.BackPanel.TabIndex = 1;
            // 
            // CounterLabel
            // 
            this.CounterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CounterLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CounterLabel.Location = new System.Drawing.Point(540, 0);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(49, 70);
            this.CounterLabel.TabIndex = 12;
            this.CounterLabel.Text = "0";
            this.CounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CounterLabel.MouseEnter += new System.EventHandler(this.InfoLabel_MouseEnter);
            this.CounterLabel.MouseLeave += new System.EventHandler(this.CounterLabel_MouseLeave);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(638, 70);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "No name";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoLabel.MouseEnter += new System.EventHandler(this.InfoLabel_MouseEnter);
            this.InfoLabel.MouseLeave += new System.EventHandler(this.InfoLabel_MouseLeave);
            // 
            // SubstractButton
            // 
            this.SubstractButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SubstractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SubstractButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Substract;
            this.SubstractButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubstractButton.HoverImage = global::MilitaryEngineering.Properties.Resources.SubstractHover;
            this.SubstractButton.Image = global::MilitaryEngineering.Properties.Resources.Substract;
            this.SubstractButton.Location = new System.Drawing.Point(509, 23);
            this.SubstractButton.Margin = new System.Windows.Forms.Padding(5);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(25, 25);
            this.SubstractButton.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Add;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.HoverImage = global::MilitaryEngineering.Properties.Resources.AddHover;
            this.AddButton.Image = global::MilitaryEngineering.Properties.Resources.Add;
            this.AddButton.Location = new System.Drawing.Point(595, 23);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(25, 25);
            this.AddButton.TabIndex = 13;
            // 
            // CompositionAddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.BackPanel);
            this.Name = "CompositionAddPanel";
            this.Size = new System.Drawing.Size(674, 85);
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel BackPanel;
        private Controls.Button SubstractButton;
        private Controls.Button AddButton;
        public System.Windows.Forms.Label CounterLabel;
        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ToolTip DescriptionToolTip;
    }
}
