
namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    partial class BuildingElementPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveButton = new MilitaryEngineering.Controls.Button();
            this.EditButton = new MilitaryEngineering.Controls.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.InfoLabel_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.RemoveButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Cross;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.HoverImage = global::MilitaryEngineering.Properties.Resources.CrossHover;
            this.RemoveButton.Image = global::MilitaryEngineering.Properties.Resources.Cross;
            this.RemoveButton.Location = new System.Drawing.Point(397, 23);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.EditButton.BackgroundImage = global::MilitaryEngineering.Properties.Resources.Edit;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.HoverImage = global::MilitaryEngineering.Properties.Resources.EditHover;
            this.EditButton.Image = global::MilitaryEngineering.Properties.Resources.Edit;
            this.EditButton.Location = new System.Drawing.Point(366, 23);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(25, 25);
            this.EditButton.TabIndex = 8;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(439, 70);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "No name";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            this.InfoLabel.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.InfoLabel.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // BuildingElementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Name = "BuildingElementPanel";
            this.Size = new System.Drawing.Size(475, 85);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label InfoLabel;
        public System.Windows.Forms.Panel panel1;
        private Controls.Button EditButton;
        private Controls.Button RemoveButton;
    }
}
