﻿
namespace MilitaryEngineering.Controls
{
    partial class CheckBox
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
            this.SuspendLayout();
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name = "CheckBox";
            this.Load += new System.EventHandler(this.CheckBox_Load);
            this.Click += new System.EventHandler(this.CheckBox_Click);
            this.DoubleClick += new System.EventHandler(this.CheckBox_Click);
            this.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
