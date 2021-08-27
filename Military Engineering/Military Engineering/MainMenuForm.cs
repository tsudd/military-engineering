using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationsCore;

namespace Military_Engineering
{
    public partial class MainMenuForm : Form
    {
        const string mainInfo = "МЕТОДИКИ ИНЖЕНЕРНЫХ РАСЧЕТОВ";
        const string fortificationInfo = "МЕТОДИКА РАСЧЕТА ФОРТИФИКАЦИОННОГО \nОБОРУДОВАНИЯ ПОЗИЦИЙ И РАЙОНОВ \nРАСПОЛОЖЕНИЯ ВОЙСК";
        const string fencingInfo = "МЕТОДИКА РАСЧЕТА СИСТЕМЫ ИНЖЕНЕРНЫХ ЗАГРАЖДЕНИЙ";
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void DisplayButtonInfo(string displayInfo, Image displayImage)
        {
            InfoLabel.Text = displayInfo;
            PreviewPictureBox.Image = displayImage;
        }

        private void FencingButton_MouseEnter(object sender, EventArgs e)
        {
            DisplayButtonInfo(fencingInfo, Properties.Resources.Fencing);
        }

        private void FortificationButton_MouseEnter(object sender, EventArgs e)
        {
            DisplayButtonInfo(fortificationInfo, Properties.Resources.Fortification);
        }

        private void DisplayMain(object sender, EventArgs e)
        {
            DisplayButtonInfo(mainInfo, Properties.Resources.Main);
        }

        private void Placeholder_MouseEnter(object sender, EventArgs e)
        {
            DisplayButtonInfo("ПРИЛОЖЕНИЕ ИМЕНИ КИСЕЛЯ А.Г.", Properties.Resources.Placeholder);
        }
    }
}
