using CalculationsCore.FortificationBuilding;
using ColorThemeManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering.Fortification.CompositionSelector
{
    public partial class CompositionSelectorForm : Form
    {
        FortificationForm Sender { get; set; }
        List<BuildingElement> compositions { get; set; } = new List<BuildingElement>();
        List<BuildingElement> elements {  get; set; }
        const string ERROR = "Ошибка";
        const string ERROR_NO_ELEMENTS = "Невозможно создать композицию элементов построния, потому что нет ни одного элемента построения";
        public CompositionSelectorForm(FortificationForm sender, List<BuildingElement> elements)
        {
            InitializeComponent();
            SetColorTheme();
            Sender = sender;
            this.elements = elements.Where(e => e.BuildingType == BuildingTypes.Element).ToList();
            elements
                .Where(e => e.BuildingType == BuildingTypes.Composition)
                .ToList()
                .ForEach(e => AddNewElement(e));
        }

        private void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            ColorTheme selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainMainColor;
            MainTable.BackColor = selectedTheme.MainSecondaryColor;
            InfoLabel.ForeColor = selectedTheme.MainForeColor;

            CreateCompositionButton.BackColor = selectedTheme.SecondaryMainColor;
            CreateCompositionButton.ForeColor = selectedTheme.SecondaryForeColor;
        }
        private void CreateCompositionButton_Click(object sender, EventArgs e)
        {
            if(elements.Count == 0)
            {
                MessageBox.Show(ERROR_NO_ELEMENTS, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CompositionCreatorForm form = new CompositionCreatorForm(this, elements);
            form.FormClosed += (s, args) =>
            {
                Enabled = true;
            };
            Enabled = false;
            form.Show();
        }

        public void AddNewElement(BuildingElement composition)
        {
            if(composition.BuildingType == BuildingTypes.Element)
            {
                throw new ArgumentException("Building element can't be simple structure");
            }

            compositions.Add(composition);
            elements.Add(composition);
            CompositionViewPanel panel = new CompositionViewPanel(composition);
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            MainTable.Controls.Add(panel, 0, MainTable.RowCount - 1);
            panel.Dock = DockStyle.Top;
            panel.Clicked += (sender, e) =>
            {
                Sender.AddNewElement(((CompositionViewPanel)sender).BuildingElement);
                Close();
            };
            panel.Removed += Remove;
        }

        public void Remove(object sender, EventArgs e)
        {
            CompositionViewPanel panel = sender as CompositionViewPanel;
            BuildingElement composition = panel.BuildingElement;
            elements.Remove(composition);
            compositions.Remove(composition);
            MainTable.Controls.Remove(panel);
            MainTable.RowCount--;
        }

        private void CompositionSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sender.SaveCompositionsToConfig(compositions);
        }
    }
}
