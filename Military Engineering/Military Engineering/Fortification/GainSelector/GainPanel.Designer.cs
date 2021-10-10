
namespace MilitaryEngineering.Fortification.GainSelector
{
    partial class GainPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubstractButton = new MilitaryEngineering.Controls.Button();
            this.AddButton = new MilitaryEngineering.Controls.Button();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.EditButton = new MilitaryEngineering.Controls.Button();
            this.RemoveButton = new MilitaryEngineering.Controls.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CoeffInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WorkTimeBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.WorkTimeBox);
            this.panel1.Controls.Add(this.SubstractButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.CounterLabel);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Location = new System.Drawing.Point(30, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.InfoLabel_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // SubstractButton
            // 
            this.SubstractButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SubstractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SubstractButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Substract;
            this.SubstractButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubstractButton.HoverImage = global::MilitaryEngineering.Properties.Resources.SubstractHover;
            this.SubstractButton.Image = global::MilitaryEngineering.Properties.Resources.Substract;
            this.SubstractButton.Location = new System.Drawing.Point(515, 42);
            this.SubstractButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(44, 45);
            this.SubstractButton.TabIndex = 14;
            this.SubstractButton.Click += new System.EventHandler(this.DecrementButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Add;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.HoverImage = global::MilitaryEngineering.Properties.Resources.AddHover;
            this.AddButton.Image = global::MilitaryEngineering.Properties.Resources.Add;
            this.AddButton.Location = new System.Drawing.Point(666, 42);
            this.AddButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(44, 45);
            this.AddButton.TabIndex = 13;
            this.AddButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // CounterLabel
            // 
            this.CounterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CounterLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.CounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CounterLabel.Location = new System.Drawing.Point(570, 0);
            this.CounterLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(86, 127);
            this.CounterLabel.TabIndex = 12;
            this.CounterLabel.Text = "0";
            this.CounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CounterLabel.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.CounterLabel.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.EditButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Edit;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.HoverImage = global::MilitaryEngineering.Properties.Resources.EditHover;
            this.EditButton.Image = global::MilitaryEngineering.Properties.Resources.Edit;
            this.EditButton.Location = new System.Drawing.Point(892, 42);
            this.EditButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(44, 45);
            this.EditButton.TabIndex = 11;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.RemoveButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Cross;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.HoverImage = global::MilitaryEngineering.Properties.Resources.CrossHover;
            this.RemoveButton.Image = global::MilitaryEngineering.Properties.Resources.Cross;
            this.RemoveButton.Location = new System.Drawing.Point(946, 42);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(44, 45);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(1021, 127);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "No name";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoLabel.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.InfoLabel.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // CoeffInfoToolTip
            // 
            this.CoeffInfoToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffInfoToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            // 
            // WorkTimeBox
            // 
            this.WorkTimeBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WorkTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.WorkTimeBox.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.WorkTimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.WorkTimeBox.Location = new System.Drawing.Point(724, 33);
            this.WorkTimeBox.Margin = new System.Windows.Forms.Padding(5);
            this.WorkTimeBox.Name = "WorkTimeBox";
            this.WorkTimeBox.Size = new System.Drawing.Size(160, 62);
            this.WorkTimeBox.TabIndex = 16;
            this.WorkTimeBox.TextChanged += new System.EventHandler(this.WorkTimeBox_TextChanged);
            // 
            // GainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GainPanel";
            this.Size = new System.Drawing.Size(1084, 154);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip CoeffInfoToolTip;
        public System.Windows.Forms.Label InfoLabel;
        private Controls.Button AddButton;
        public System.Windows.Forms.Label CounterLabel;
        private Controls.Button SubstractButton;
        public Controls.Button RemoveButton;
        public Controls.Button EditButton;
        private System.Windows.Forms.TextBox WorkTimeBox;
    }
}
