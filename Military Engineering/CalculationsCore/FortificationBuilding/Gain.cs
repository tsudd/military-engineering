using CalculationsCore.FortificationBuilding.BuildingConditions;
using System;

namespace CalculationsCore.FortificationBuilding
{
<<<<<<< Updated upstream:Military Engineering/CalculationsCore/FortificationBuilding/BuildingDefinition/BuildingElement.cs
    public enum ElementType
    {
        Trench,
        Pit
    }

    public class BuildingElement
=======
    public class Gain
>>>>>>> Stashed changes:Military Engineering/CalculationsCore/FortificationBuilding/Gain.cs
    {
        public const string STANDART_NAME = "Unknown building";
        public double FirstTurn { get; set; } = 0;
        public double SecondTurn { get; set; } = 0;
        public double FutureTurn { get; set; } = 0;
        public double AllTurns { get => FirstTurn + SecondTurn + FutureTurn; }
        public string Name { get; set; }
	public ElementType ElementType {  get; set; } = ElementType.Pit;
        public bool IsDefault { get; set; }

        public Gain() { }
        public Gain(string name = STANDART_NAME) => this.Name = name;
        public Gain(string name, double firstTurn, double secondTurn, double futurTurns, bool isDefault)
        {
            Name = name;
            FirstTurn = firstTurn;
            SecondTurn = secondTurn;    
            FutureTurn = futurTurns;
            IsDefault = isDefault;
        }  
    }
}
