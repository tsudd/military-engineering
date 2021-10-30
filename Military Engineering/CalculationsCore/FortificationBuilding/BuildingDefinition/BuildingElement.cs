using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculationsCore.FortificationBuilding
{
    public enum ElementTypes
    {
        Trench,
        Pit
    }
    public enum BuildingTypes
    {
        Element,
        Composition
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
        public ElementTypes ElementType {  get; set; } = ElementTypes.Pit; //will be adjusted in future
        public BuildingTypes BuildingType { get; set; } = BuildingTypes.Element;

        public bool IsDefault { get; set; }

        public BuildingElement() { }
        public BuildingElement(string name = STANDART_NAME) => this.Name = name;
        public BuildingElement(
            string name, 
            double firstTurn, 
            double secondTurn, 
            double futurTurns, 
            bool isDefault, 
            ElementTypes elementType = ElementTypes.Pit,
            BuildingTypes buildingType = BuildingTypes.Element)
        {
            Name = name;
            FirstTurn = firstTurn;
            SecondTurn = secondTurn;
            FutureTurn = futurTurns;
            IsDefault = isDefault;
            ElementType = elementType;
            BuildingType = buildingType;
        }

        public static BuildingElement CreateComposition(List<(BuildingElement, int)> elements, string name, string description = null)
        {
            BuildingElement buildingElement = new BuildingElement(name);
            buildingElement.FirstTurn = elements.Sum(e => e.Item1.FirstTurn * e.Item2);
            buildingElement.SecondTurn = elements.Sum(e => e.Item1.SecondTurn * e.Item2);
            buildingElement.FutureTurn = elements.Sum(e => e.Item1.FutureTurn * e.Item2);

            buildingElement.BuildingType = BuildingTypes.Composition;
            buildingElement.ElementType = ElementTypes.Pit;

            if(description == null)
            {
                StringBuilder autoDescription = new StringBuilder();
                List<(BuildingElement, int)> compositions = elements.Where(e => e.Item1.BuildingType == BuildingTypes.Composition).ToList();
                List<(BuildingElement, int)> simples = elements.Where(e => e.Item1.BuildingType == BuildingTypes.Element).ToList();

                if(compositions.Count > 0)
                {
                    autoDescription.AppendLine("Композиции:");
                    compositions.ForEach(c => autoDescription.AppendLine($" - {c.Item2}x {c.Item1.Name};"));
                }

                if (simples.Count > 0)
                {
                    autoDescription.AppendLine("Элементы:");
                    simples.ForEach(s => autoDescription.AppendLine($" - {s.Item2}x {s.Item1.Name};"));
                }

                buildingElement.Description = autoDescription.ToString();
            }
            else
            {
                buildingElement.Description = description;
            }

            return buildingElement;
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
