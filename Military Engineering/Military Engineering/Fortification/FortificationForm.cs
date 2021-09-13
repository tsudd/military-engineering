using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryConfiguration;
using MilitaryEngineering.Fortification.BuildingElementSelector;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using MilitaryEngineering.Fortification;
using MilitaryConfiguration.Configurations;

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
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            var form = new BuildingElementSelectorForm(this, Config.BuildingElements);
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show(this);
            Enabled = false;
        }

        private void RemoveElement(object sender, EventArgs e)
        {
            var childPanel = (Panel)((Button)sender).Parent;
            var parent = (BuildingElementPanel)(childPanel.Parent);
            Board.DeleteElement(parent.ElementIndex);
            parent.Dispose();
        }

        public void AddNewElement(BuildingElement buildingElement)
        {
            MainPanel.Visible = true;
            var index = Board.AddElement(new BuildingCalculation(buildingElement));
            if (index == -1)
            {
                //oops..
            }
            var element = new BuildingElementPanel(Board, index);
            element.ElementChanged += ResetGlobalSetting;
            SetGlobalSettings(element);
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.Percent));
            MainTable.Controls.Add(element, 0, MainTable.RowCount - 1);
            element.Dock = DockStyle.Top;
        }

        //public void Update(

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
        }

        private void AddGainButton_Click(object sender, EventArgs e)
        {
            var form = new GainCreatorForm(this);
            Enabled = false;
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show(this);
        }

        public void UpdateAllElementsGain()
        {
            foreach (object panel in MainTable.Controls)
            {
                if (panel is BuildingElementPanel buildingElement)
                {
                    buildingElement.UpdateGainBox();
                }
            }
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
            else if (control is Fortification.CheckBox checkBox)
            {
                checkBox.Checked = (globalControl as Fortification.CheckBox).Checked;
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
                        else if(globalChild is Fortification.CheckBox globalCheckBox)
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
    }
}
