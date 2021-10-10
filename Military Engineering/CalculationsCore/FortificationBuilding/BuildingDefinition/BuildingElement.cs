using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingDefinition;
using System;

namespace CalculationsCore.FortificationBuilding
{
    public enum ElementType
    {
        Trench,
        Pit
    }

    public class BuildingElement : IBuilding
    {
        public const string STANDART_NAME = "Unknown building";
        public double FirstTurn { get; set; } = 0;
        public double SecondTurn { get; set; } = 0;
        public double FutureTurn { get; set; } = 0;
        public double AllTurns { get => FirstTurn + SecondTurn + FutureTurn; }
        public string Name { get; set; }
        public string Description { get; set; } = "Single object";
        public int Id { get; set; } = 0;
        public ElementType ElementType {  get; set; } = ElementType.Pit; //will be adjusted in future

        public bool IsDefault { get; set; }

        public BuildingElement() { }
        public BuildingElement(string name = STANDART_NAME) => this.Name = name;
        public BuildingElement(
            string name, 
            double firstTurn, 
            double secondTurn, 
            double futurTurns, 
            bool isDefault, 
            ElementType elementType = ElementType.Pit)
        {
            Name = name;
            FirstTurn = firstTurn;
            SecondTurn = secondTurn;
            FutureTurn = futurTurns;
            IsDefault = isDefault;
            ElementType = elementType;
        }

        public double GetFirstTurn()
        {
            return FirstTurn;
        }

        public double GetSecondTurn()
        {
            return SecondTurn;
        }

        public double GetFutureTurn()
        {
            return FutureTurn;
        }

        public double GetAllTurns()
        {
            return AllTurns;
        }

        public int GetId()
        {
            return Id;
        }
    }
}
