using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering.Fortification
{
    public partial class CheckBox : UserControl
    {
        private bool _checked;
        public bool Checked 
        {  
            get 
            {
                return _checked;
            } 
            set 
            {
                _checked = value;
                if (_checked)
                {
                    button.BackgroundImage = Properties.Resources.CheckBoxChecked;
                }
                else
                {
                    button.BackgroundImage = Properties.Resources.CheckBoxUnchecked;
                }
            } 
        }
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
