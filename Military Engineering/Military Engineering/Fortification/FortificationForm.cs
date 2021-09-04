﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryConfiguration;
using Military_Engineering.Fortification.BuildingElementSelector;
using CalculationsCore.FortificationBuilding;

namespace Military_Engineering.Fortification
{
    public partial class FortificationForm : Form
    {
        public FortificationBoard Board { get; private set; } = new FortificationBoard();
        public int ElementsAmount { get; private set; } = 0;
        public double AllFirstTurns { get; private set; } = 0;
        public double AllSecondTurns { get; private set; } = 0;
        public double AllFutureTurns { get; private set; } = 0;
        public double AllAllTurns { get; private set; } = 0;
        public FortificationForm()
        {
            InitializeComponent();
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            var configurationManager = new ConfigurationManager();
            var configuration = configurationManager.LoadConfiguration();
            var buildingElements = configuration.BuildingElements;
            
            var form = new BuildingElementSelectorForm(this, buildingElements);
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
            var index = Board.AddElement(new BuildingCalculation(buildingElement));
            if (index == -1)
            {
                //oops..
            }
            var element = new BuildingElementPanel(Board, index);
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.Percent));
            MainTable.Controls.Add(element, 0, MainTable.RowCount - 1);
            element.Dock = DockStyle.Top;
        }

        //public void Update(

        private void FirstTurnLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
