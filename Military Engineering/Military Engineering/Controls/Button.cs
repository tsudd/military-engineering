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
#pragma warning disable CS0108
        public event EventHandler Click;
#pragma warning restore CS0108
        public Button()
        {
            InitializeComponent();
            DoubleClick += (sender, e) => Click?.Invoke(sender, e);
            base.Click += (sender, e) => Click?.Invoke(sender, e);
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
            };
        }
    }
}
