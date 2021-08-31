﻿using CalculationsCore.FortificationBuilding.BuildingConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding
{
    public class BuildingElement
    {
        public const string STANDART_NAME = "Unknown building";
        public BuildingElement(string name = STANDART_NAME) => this.Name = name;

        public double FirstTurn { get; set; } = 0;
        public double SecondTurn { get; set; } = 0;
        public double FutureTurn { get; set; } = 0;
        public string Name { get; set; }
    }
}
