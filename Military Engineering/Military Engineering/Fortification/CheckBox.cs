﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Engineering.Fortification
{
    public partial class CheckBox : UserControl
    {
        public bool Checked {  get; set; }
        Image PrevImage {  get; set; }
        public event EventHandler CheckBox_Checked;
        public CheckBox()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Checked)
            {
                button.BackgroundImage = Properties.Resources.CheckBoxUncheckedHower;
                PrevImage = Properties.Resources.CheckBoxUnchecked;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.CheckBoxCheckedHower;
                PrevImage = Properties.Resources.CheckBoxChecked;
            }
            Checked = !Checked;
            
            CheckBox_Checked?.Invoke(this, EventArgs.Empty);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            PrevImage = button.BackgroundImage;
            if (Checked)
            {
                button.BackgroundImage = Properties.Resources.CheckBoxCheckedHower;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.CheckBoxUncheckedHower;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            button.BackgroundImage = PrevImage;
        }
    }
}