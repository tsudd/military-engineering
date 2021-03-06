using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryConfiguration;
using MilitaryEngineering.Fortification.BuildingElementSelector;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using MilitaryEngineering.Fortification;
using MilitaryConfiguration.Configurations;
using CalculationsCore.FortificationBuilding.BuildingDefinition;
using ColorThemeManager;
using MilitaryEngineering.Fortification.CompositionSelector;
using System.Linq;

namespace MilitaryEngineering.Fortification
{
    public partial class FortificationForm : Form
    {
        public const string CONFIG_PATH = "fortification.json";
        public FortificationBoard Board { get; private set; } = new FortificationBoard();
        public int ElementsAmount { get; private set; } = 0;
        public double AllFirstTurns { get; private set; } = 0;
        public double AllSecondTurns { get; private set; } = 0;
        public double AllFutureTurns { get; private set; } = 0;
        public double AllAllTurns { get; private set; } = 0;
        public FortificationConfiguration Config { get; private set; }
        bool isInProgress = false;
        public FortificationForm()
        {
            InitializeComponent();
            MainPanel.Visible = false;
            Config = (new ConfigurationManager()).LoadConfiguration<FortificationConfiguration>(CONFIG_PATH);

            SoilTypeBox.DataSource = FortificationBoard.SoilTypes;
            SoilTypeBox.DisplayMember = "Name";
            //SoilTypeBox.SelectedItem = null;

            DayTimeBox.DataSource = FortificationBoard.DayTimes;
            DayTimeBox.DisplayMember = "Name";
            //DayTimeBox.SelectedItem = null;

            PollutionsBox.DataSource = FortificationBoard.Pollutions;
            PollutionsBox.DisplayMember = "Name";
            //PollutionsBox.SelectedItem = null;

            MainTable.RowStyles[0] = new RowStyle(SizeType.Absolute, 120);
            SetColorTheme();
        }

        private void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            ColorTheme selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainMainColor;
            MainTable.BackColor = selectedTheme.MainMainColor;
            ForeColor = selectedTheme.MainForeColor;

            //header labels
            HeaderPanel.BackColor = selectedTheme.MainSecondaryColor;

            DayTimeLabel.BackColor = selectedTheme.MainSecondaryColor;
            DayTimeLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            PollutionLabel.BackColor = selectedTheme.MainSecondaryColor;
            PollutionLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            SoilTypeLabel.BackColor = selectedTheme.MainSecondaryColor;
            SoilTypeLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            CoeffNpersonnelLabel.BackColor = selectedTheme.MainSecondaryColor;
            CoeffNpersonnelLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            CoeffKcallingLabel.BackColor = selectedTheme.MainSecondaryColor;
            CoeffKcallingLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            CoeffKorganizationLabel.BackColor = selectedTheme.MainSecondaryColor;
            CoeffKorganizationLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            CoeffKstaffingLabel.BackColor = selectedTheme.MainSecondaryColor;
            CoeffKstaffingLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            CoeffThoursLabel.BackColor = selectedTheme.MainSecondaryColor;
            CoeffThoursLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            DayTimeBox.BackColor = selectedTheme.SecondarySecondaryColor;
            DayTimeBox.ForeColor = selectedTheme.SecondaryForeColorAlternative;

            PollutionsBox.BackColor = selectedTheme.SecondarySecondaryColor;
            PollutionsBox.ForeColor = selectedTheme.SecondaryForeColorAlternative;

            SoilTypeBox.BackColor = selectedTheme.SecondarySecondaryColor;
            SoilTypeBox.ForeColor = selectedTheme.SecondaryForeColorAlternative;

            PeopleAmountInput.BackColor = selectedTheme.SecondarySecondaryColor;
            OrganizationInput.BackColor = selectedTheme.SecondarySecondaryColor;
            AttritionRateInput.BackColor = selectedTheme.SecondarySecondaryColor;
            ManPowerInput.BackColor = selectedTheme.SecondarySecondaryColor;
            WorkTimeInput.BackColor = selectedTheme.SecondarySecondaryColor;

            RemoveSelectedButton.BackColor = selectedTheme.SecondaryMainColor;
            RemoveSelectedButton.ForeColor = selectedTheme.SecondaryForeColor;
            
            FooterPanel.BackColor = selectedTheme.MainSecondaryColor;

            AddElementButton.BackColor = selectedTheme.SecondaryMainColor;
            AddElementButton.ForeColor = selectedTheme.SecondaryForeColor;

            AddCompositionButton.BackColor = selectedTheme.SecondaryMainColor;
            AddCompositionButton.ForeColor = selectedTheme.SecondaryForeColor;

            AllLabel.BackColor = selectedTheme.MainSecondaryColor;
            AllLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            AllAllTurnsLabel.BackColor = selectedTheme.MainSecondaryColor;
            AllAllTurnsLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            AllFirstTurnsLabel.BackColor = selectedTheme.MainSecondaryColor;
            AllFirstTurnsLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            AllSecondTurnsLabel.BackColor = selectedTheme.MainSecondaryColor;
            AllSecondTurnsLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            AllFutureTurnsLabel.BackColor = selectedTheme.MainSecondaryColor;
            AllFutureTurnsLabel.ForeColor = selectedTheme.SecondarySecondaryColor;

            ChangeTableLabels(selectedTheme, MainTable);

            if (selectedTheme.IconType == ColorTheme.IconTypes.Alternative)
            {
                CheckBox.ImgDefault = Properties.Resources.CheckBoxUncheckedAlternative;
                CheckBox.ImgDefaultHower = Properties.Resources.CheckBoxUncheckedHoverAlternative;
            }
        }

        private void ChangeTableLabels(ColorTheme theme, object obj)
        {
            if(obj is TableLayoutPanel panel)
            {
                foreach (object obj1 in panel.Controls)
                {
                    ChangeTableLabels(theme, obj1);
                }
            }
            else if(obj is Label label)
            {
                label.ForeColor = theme.MainForeColor;
            }
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            var form = new BuildingElementSelectorForm(this, 
                Config.BuildingElements.Where(b => b.BuildingType == BuildingTypes.Element).ToList());

            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show(this);
            Enabled = false;
        }

        public void AddNewElement(IBuilding buildingElement)
        {
            MainPanel.Visible = true;
            var index = Board.AddElement(new BuildingCalculation(buildingElement));
            if (index == -1)
            {
                //oops..
            }
            var element = new BuildingElementPanel(this, index);
            element.ElementChanged += ResetGlobalSetting;
            SetGlobalSettings(element);
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.Percent));
            MainTable.Controls.Add(element, 0, MainTable.RowCount - 1);
            element.Dock = DockStyle.Top;
            EvaluateAllTurns();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            List<BuildingElementPanel> rowsToRemove = new List<BuildingElementPanel>();
            foreach (object panel in MainTable.Controls)
            {
                if (panel is BuildingElementPanel buildingElement && buildingElement.Checked)
                {
                    rowsToRemove.Add(buildingElement);
                }
            }
            foreach (BuildingElementPanel buildingElement in rowsToRemove)
            {
                MainTable.Controls.Remove(buildingElement);
                MainTable.RowCount--;
                Board.DeleteElement(buildingElement.ElementIndex);
            }
            if (MainTable.RowCount == 1)
            {
                MainPanel.Visible = false;
            }
            UpdateChartsInterval();
            EvaluateAllTurns();
        }

        private void FortificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var configManager = new ConfigurationManager();
            configManager.SaveConfiguration(CONFIG_PATH, Config);
        }

        private void GlobalFilter_Changed(object sender, EventArgs e)
        {
            if (isInProgress)
            {
                return;
            }
            isInProgress = true;
            foreach (Control control in MainTable.Controls)
            {
                Control globalControl = sender as Control;
                if (control is BuildingElementPanel buildingElement)
                {
                    foreach (Control childControl in GetAllChildren(buildingElement))
                    {
                        if (childControl.Name == globalControl.Name)
                        {
                            SetControl(globalControl, childControl, buildingElement);
                            break;
                        }
                    }
                    //SetGlobalSettings(buildingElement);
                }
            }
            isInProgress = false;
        }

        private void SetControl(Control globalControl, Control control, BuildingElementPanel element)
        {
            if (control is ComboBox comboBox)
            {
                ComboBox globalComboBox = (ComboBox)globalControl;
                if(globalComboBox.SelectedItem != null)
                {
                    comboBox.SelectedItem = globalComboBox.SelectedItem;
                }
            }
            else if (control is TextBox textBox)
            {
                textBox.Text = (globalControl as TextBox).Text;
            }
            else if (control is Controls.CheckBox checkBox)
            {
                checkBox.Checked = (globalControl as Controls.CheckBox).Checked;
                element.Checked = checkBox.Checked;
            }
        }
        public void SetGlobalSettings(BuildingElementPanel element)
        {
            isInProgress = true;
            List<Control> globalControls = GetAllChildren(HeaderPanel);
            List<Control> childControls = GetAllChildren(element);
            foreach(Control childControl in childControls)
            {
                foreach(Control globalControl in globalControls)
                {
                    if(globalControl.Name == childControl.Name)
                    {
                        SetControl(globalControl, childControl, element);
                    }
                }
            }
            isInProgress = false;
        }

        private void ResetGlobalSetting(object sender, EventArgs e)
        {
            if(isInProgress)
            {
                return;
            }
            isInProgress = true;
            Control senderControl = sender as Control;
            foreach(Control control in HeaderPanel.Controls)
            {
                foreach(Control globalChild in GetAllChildren(control))
                {
                    if(senderControl.Name == globalChild.Name)
                    {
                        if(globalChild is ComboBox globalComboBox)
                        {
                            ComboBox senderComboBox = senderControl as ComboBox;
                            if(senderComboBox.SelectedItem != globalComboBox.SelectedItem)
                            {
                                globalComboBox.SelectedItem = null;
                            }        
                        }
                        else if (globalChild is TextBox globalTextBox)
                        {
                            globalTextBox.Text = "";
                        }
                        else if(globalChild is Controls.CheckBox globalCheckBox)
                        {
                            globalCheckBox.Checked = false;
                        }
                        isInProgress = false;
                        return;
                    }
                }
            }
            isInProgress = false;
        }

        private List<Control> GetAllChildren(Control control)
        {
            List<Control> result = new List<Control>();
            foreach (Control child in control.Controls)
            {
                result.Add(child);
                result.AddRange(GetAllChildren(child));
            }
            return result;
        }

        public void EvaluateAllTurns()
        {
            AllFirstTurnsLabel.Text = Board.EvaluateAllFirstTurns().ToString("0.##");
            AllSecondTurnsLabel.Text = Board.EvaluateAllSecondTurns().ToString("0.##");
            AllFutureTurnsLabel.Text = Board.EvaluateAllFutureTurns().ToString("0.##");
            AllAllTurnsLabel.Text = Board.EvaluateAllAllTurns().ToString("0.##");
        }

        public void RemoveGains(List<int> gainsToRemove)
        {
            if (gainsToRemove is null || gainsToRemove.Count == 0)
            {
                return;
            }
            foreach(var gainId in gainsToRemove)
            {
                Board.RemoveGainFromElements(gainId);
                foreach (var gain in Config.Gains)
                {
                    if (gain.Id == gainId)
                    {
                        Config.Gains.Remove(gain);
                        break;
                    }
                }
            }
        }

        public void UpdateGains(List<Gain> gainsToUpdate)
        {
            if (gainsToUpdate is null || gainsToUpdate.Count == 0)
                return;
            foreach (var ga in gainsToUpdate)
            {
                foreach (var gain in Config.Gains)
                {
                    if (gain.Id == ga.Id)
                    {
                        Config.Gains.Remove(gain);
                        Config.Gains.Add(ga);
                        break;
                    }
                }
                if (Config.Gains[Config.Gains.Count - 1].Id != ga.Id)
                {
                    Config.Gains.Add(ga);
                    break;
                }
                Board.UpdateGainInElements(ga);
            }
        }

        public void UpdateAndRemoveGains(List<Gain> gainsToUpdate, List<int> gainsToRemove)
        {
            if (gainsToUpdate is null || gainsToRemove is null)
            {
                return;
            }
            UpdateGains(gainsToUpdate);
            RemoveGains(gainsToRemove);
            EvaluateElements();
        }

        public void EvaluateElements()
        {
            foreach(var panel in MainTable.Controls)
            {
                if (panel is BuildingElementPanel panel1)
                {
                    panel1.Evaluate(this, EventArgs.Empty);
                }
            }
        }

        public Gain GetGainById(int gainId)
        {
            foreach (var ga in Config.Gains)
            {
                if (ga.Id == gainId)
                {
                    return ga;
                }
            }
            return null;
        }

        public void UpdateChartsInterval()
        {
            double interval = Board.GetNewChartInterval();
            foreach (var control in MainTable.Controls)
            {
                if (control is BuildingElementPanel buildingElement)
                {
                    buildingElement.ChangeChartInterval(interval);
                }
            }
        }

        private void AddCompositionButton_Click(object sender, EventArgs e)
        {
            CompositionSelectorForm form = new CompositionSelectorForm(this, Config.BuildingElements);
            form.FormClosed += (s, args) =>
            {
                Enabled = true;
            };
            Enabled = false;
            form.Show();
        }

        public void SaveBuildingElementsToConfig(List<BuildingElement> buildingElements)
        {
            Config.BuildingElements.RemoveAll(b => b.BuildingType == BuildingTypes.Element);
            Config.BuildingElements.AddRange(buildingElements);
        }

        public void SaveCompositionsToConfig(List<BuildingElement> compositions)
        {
            Config.BuildingElements.RemoveAll(b => b.BuildingType == BuildingTypes.Composition);
            Config.BuildingElements.AddRange(compositions);
        }
    }
}
