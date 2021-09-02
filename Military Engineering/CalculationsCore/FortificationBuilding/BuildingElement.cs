using CalculationsCore.FortificationBuilding.BuildingConditions;
using System;

namespace CalculationsCore.FortificationBuilding
{
    public class BuildingElement
    {
        public const string STANDART_NAME = "Unknown building";
        public double FirstTurn { get; set; } = 0;
        public double SecondTurn { get; set; } = 0;
        public double FutureTurn { get; set; } = 0;
        public double AllTurns { get => FirstTurn + SecondTurn + FutureTurn; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public BuildingElement(string name = STANDART_NAME) => this.Name = name;
        public BuildingElement(string name, double firstTurn, double secondTurn, double futurTurns, bool isDefault)
        {
            Name = name;
            FirstTurn = firstTurn;
            SecondTurn = secondTurn;    
            FutureTurn = futurTurns;
            IsDefault = isDefault;
        }  
    }
}
