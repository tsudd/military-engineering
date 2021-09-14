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
    public partial class Button : UserControl
    {
        public Image Image {  get; set; }
        public Image HoverImage {  get; set; }
        public Button()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
            MouseEnter += (sender, e) =>
            {
                BackgroundImage = HoverImage;
            };
            MouseLeave += (sender, e) =>
            {
                BackgroundImage = Image;
            };
            
            Load += (sender, e) => Setup();
        }

        private void Setup()
        {
            BackColor = Parent.BackColor;
            BackgroundImage = Image;
            Parent.BackColorChanged += (sender, e) =>
            {
                BackColor = Parent.BackColor;
                //MessageBox.Show("q");

            };
        }
    }
}
