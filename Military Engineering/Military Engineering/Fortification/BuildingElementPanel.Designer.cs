
namespace Military_Engineering.Fortification
{
    partial class BuildingElementPanel
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label SecondTurnLabel;
        public System.Windows.Forms.Label FutureTurnLabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label FirstTurnLabel;
        public System.Windows.Forms.Label AllTurnsLabel;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstTurnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FutureTurnLabel = new System.Windows.Forms.Label();
            this.SecondTurnLabel = new System.Windows.Forms.Label();
            this.AllTurnsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.18391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.81609F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.SecondTurnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FutureTurnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FirstTurnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AllTurnsLabel, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1020, 193);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FirstTurnLabel
            // 
            this.FirstTurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnLabel.Location = new System.Drawing.Point(207, 0);
            this.FirstTurnLabel.Name = "FirstTurnLabel";
            this.FirstTurnLabel.Size = new System.Drawing.Size(198, 96);
            this.FirstTurnLabel.TabIndex = 4;
            this.FirstTurnLabel.Text = "FirstTurnLabel";
            this.FirstTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 96);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FutureTurnLabel
            // 
            this.FutureTurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnLabel.Location = new System.Drawing.Point(615, 0);
            this.FutureTurnLabel.Name = "FutureTurnLabel";
            this.FutureTurnLabel.Size = new System.Drawing.Size(198, 96);
            this.FutureTurnLabel.TabIndex = 6;
            this.FutureTurnLabel.Text = "FutureTurnLabel";
            this.FutureTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondTurnLabel
            // 
            this.SecondTurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnLabel.Location = new System.Drawing.Point(411, 0);
            this.SecondTurnLabel.Name = "SecondTurnLabel";
            this.SecondTurnLabel.Size = new System.Drawing.Size(198, 96);
            this.SecondTurnLabel.TabIndex = 7;
            this.SecondTurnLabel.Text = "SecondTurnLabel";
            this.SecondTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AllTurnsLabel
            // 
            this.AllTurnsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTurnsLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AllTurnsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AllTurnsLabel.Location = new System.Drawing.Point(819, 0);
            this.AllTurnsLabel.Name = "AllTurnsLabel";
            this.AllTurnsLabel.Size = new System.Drawing.Size(198, 96);
            this.AllTurnsLabel.TabIndex = 8;
            this.AllTurnsLabel.Text = "AllTurnsLabel";
            this.AllTurnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BuildingElementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuildingElementPanel";
            this.Size = new System.Drawing.Size(1046, 371);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
