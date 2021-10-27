using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering.Controls
{
    public partial class CheckBox : UserControl
    {
        private bool _checked;

        private Image imgDefault;
        public Image ImgDefault 
        {
            get
            {
                return imgDefault;
            }
            set
            {
                imgDefault = value;
                BackgroundImage = imgDefault;
            }
        }
        public Image ImgDefaultHower { get; set; }
        public Image ImgChecked { get; set; }
        public Image ImgCheckedHower { get; set; }


        public bool Checked 
        {  
            get 
            {
                return _checked;
            } 
            set 
            {
                _checked = value;
                if(_checked)
                {
                    BackgroundImage = ImgChecked;
                }
                else
                {
                    BackgroundImage = ImgDefault;
                }
            } 
        }
        Image PrevImage {  get; set; }
        public event EventHandler CheckBox_Checked;
        public CheckBox()
        {
            InitializeComponent();
            Setup();
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            if(Checked)
            {
                BackgroundImage = ImgDefaultHower;
                PrevImage = ImgDefault;
            }
            else
            {
                BackgroundImage = ImgCheckedHower;
                PrevImage = ImgChecked;
            }
            _checked = !_checked;
            
            CheckBox_Checked?.Invoke(this, EventArgs.Empty);
        }

        private void CheckBox_MouseEnter(object sender, EventArgs e)
        {
            PrevImage = BackgroundImage;
            if(Checked)
            {
                BackgroundImage = ImgCheckedHower;
            }
            else
            {
                BackgroundImage = ImgDefaultHower;
            }
        }

        private void CheckBox_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = PrevImage;
        }

        private void Setup()
        {
            //button.BackColor = Parent.BackColor;
            //Parent.BackColorChanged += (sender, e) =>
            //{
            //    button.BackColor = Parent.BackColor;
            //};
        }

        private void CheckBox_Load(object sender, EventArgs e)
        {
            if (_checked)
            {
                BackgroundImage = ImgChecked;
            }
            else
            {
                BackgroundImage = ImgDefault;
            }
        }
    }
}
