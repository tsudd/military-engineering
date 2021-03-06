using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding;
using ColorThemeManager;

namespace MilitaryEngineering.Fortification.CompositionSelector
{
    public partial class CompositionCreatorForm : Form
    {
        List<BuildingElement> elements;
        List<BuildingElement> compositions;
        CompositionSelectorForm Sender;
        const string ERROR = "Ошибка";
        const string ERROR_NO_ELEMENTS = "Не было выбрано ни одного элемента построения или композиции";

        public CompositionCreatorForm(CompositionSelectorForm sender, List<BuildingElement> buildingElements)
        {
            InitializeComponent();
            SetColorTheme();
            Sender = sender;
            elements = buildingElements.Where(b => b.BuildingType == BuildingTypes.Element).ToList();
            compositions = buildingElements.Where(b => b.BuildingType == BuildingTypes.Composition).ToList();

            ElementsPanel.Size = new Size(ElementsPanel.Size.Width, 0);
            ElementsTable.Size = new Size(ElementsTable.Size.Width, 0);

            CompositionsPanel.Size = new Size(CompositionsPanel.Size.Width, 0);
            CompositionsTable.Size = new Size(CompositionsTable.Size.Width, 0);

            elements.ForEach(b => AddElement(b, ElementsTable, ElementsPanel));
            compositions.ForEach(b => AddElement(b, CompositionsTable, CompositionsPanel));

            if(elements.Count == 0)
            {
                ElementsLabel.Visible = false;
                ElementsPanel.Visible = false;

                CompositionsLabel.Location = new Point(CompositionsLabel.Location.X,
                                                       InfoSecondLabel.Location.Y + InfoSecondLabel.Size.Height);
                CompositionsPanel.Location = new Point(CompositionsPanel.Location.X,
                                                        CompositionsLabel.Location.Y + CompositionsLabel.Height + 10);
                SaveCompositionButton.Location = new Point(SaveCompositionButton.Location.X,
                                                            CompositionsPanel.Location.Y + CompositionsPanel.Size.Height + 10);
            }
            else if(compositions.Count == 0)
            {
                CompositionsLabel.Visible = false;
                CompositionsPanel.Visible = false;
                SaveCompositionButton.Location = new Point(SaveCompositionButton.Location.X,
                                                            ElementsPanel.Location.Y + ElementsPanel.Size.Height + 10);
            }
            else
            {
                CompositionsLabel.Location = new Point(CompositionsLabel.Location.X,
                                                        ElementsPanel.Location.Y + ElementsPanel.Size.Height + 10);
                CompositionsPanel.Location = new Point(CompositionsPanel.Location.X,
                                                        CompositionsLabel.Location.Y + CompositionsLabel.Height + 10);
                SaveCompositionButton.Location = new Point(SaveCompositionButton.Location.X,
                                                            CompositionsPanel.Location.Y + CompositionsPanel.Size.Height + 10);
            }

            if(SaveCompositionButton.Location.Y + SaveCompositionButton.Size.Height < Size.Height)
            {
                Height = SaveCompositionButton.Location.Y + SaveCompositionButton.Size.Height + 50;
            }
        }

        public void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            ColorTheme selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainMainColor;

            ElementsTable.BackColor = selectedTheme.MainSecondaryColor;
            CompositionsTable.BackColor = selectedTheme.MainSecondaryColor;

            InfoLabel.ForeColor = selectedTheme.MainForeColor;
            InfoSecondLabel.ForeColor = selectedTheme.MainForeColor;
            ElementsLabel.ForeColor = selectedTheme.MainForeColor;
            CompositionsLabel.ForeColor = selectedTheme.MainForeColor;

            MainPanel.BackColor = selectedTheme.MainSecondaryColor;
            NameLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            DescriptionLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            DefaultDescriptionCheckBox.ForeColor = selectedTheme.SecondarySecondaryColor;

            NameTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            NameTextBox.ForeColor = selectedTheme.SecondaryForeColorAlternative;
            DescriptionBox.BackColor = selectedTheme.SecondarySecondaryColor;
            DescriptionBox.ForeColor = selectedTheme.SecondaryForeColorAlternative;

            SaveCompositionButton.BackColor = selectedTheme.SecondaryMainColor;
            SaveCompositionButton.ForeColor = selectedTheme.SecondaryForeColor;
        }

        void AddElement(BuildingElement building, TableLayoutPanel table, Panel parentPanel)
        {
            CompositionAddPanel panel = new CompositionAddPanel(building);
            parentPanel.Size = new Size(parentPanel.Size.Width, parentPanel.Size.Height + panel.Height);
            table.Size = new Size(table.Size.Width, table.Size.Height + panel.Height);
            table.RowCount++;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, panel.Height));
            table.Controls.Add(panel, 0, table.RowCount - 1);
            panel.Dock = DockStyle.Top;
        }

        private void SaveCompositionButton_Click(object sender, EventArgs e)
        {
            List<(BuildingElement, int)> elements = new List<(BuildingElement, int)>();

            ElementsTable.Controls
                .OfType<CompositionAddPanel>()
                .Where(b => b.Count > 0)
                .ToList()
                .ForEach(b => elements.Add((b.BuildingElement, b.Count)));

            CompositionsTable.Controls
                .OfType<CompositionAddPanel>()
                .Where(b => b.Count > 0)
                .ToList()
                .ForEach(b => elements.Add((b.BuildingElement, b.Count)));

            if(elements.Count == 0)
            {
                MessageBox.Show(ERROR_NO_ELEMENTS, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name;
            if(NameTextBox.Text == "")
            {
                name = null;
            }
            else
            {
                name = NameTextBox.Text;
            }

            string description;
            if (DefaultDescriptionCheckBox.Checked)
            {
                description = null;
            }
            else
            {
                description = DescriptionBox.Text;
            }


            BuildingElement composition = BuildingElement
                .CompositionFactory(elements, name, description);
            
            Sender.AddNewElement(composition);
            Close();
        }

        private void DefaultDescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DescriptionBox.Enabled = !DefaultDescriptionCheckBox.Checked;
        }
    }
}
