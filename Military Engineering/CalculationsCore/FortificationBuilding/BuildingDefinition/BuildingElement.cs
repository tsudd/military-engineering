using CalculationsCore.FortificationBuilding.BuildingAbilities;
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
        Pit,
        Mixed
    }
    public enum BuildingTypes
    {
        Element,
        Composition
    }

    public class BuildingElement : IBuilding, ISearchable
    {
        public const string DEFAULT_BUILDING_NAME = "Неизвестное построение";
        public const string DEFAULT_COMPOSITION_NAME = "Неизвестная композиция";
        public double FirstTurn { get; set; } = 0;
        public double SecondTurn { get; set; } = 0;
        public double FutureTurn { get; set; } = 0;
        public double AllTurns { get => FirstTurn + SecondTurn + FutureTurn; }
        public string Name { get; set; }
        public string Description { get; set; } = "Одиночный объект";
        public int Id { get; set; } = 0;
        public ElementTypes ElementType {  get; set; } = ElementTypes.Pit; //will be adjusted in future
        public BuildingTypes BuildingType { get; set; } = BuildingTypes.Element;
        public bool IsDefault { get; set; }
        public bool CanBeEdited 
        {
            get
            {
                return !IsDefault && ElementType == ElementTypes.Pit;
            }
        }

        private const float TRENCH_SMALL = 0.8f;
        private const float TRENCH_DEEP = 1.1f;

        public BuildingElement() { }
        public BuildingElement(string name = DEFAULT_BUILDING_NAME) => this.Name = name;
        public BuildingElement(
            string name, 
            double firstTurn, 
            double secondTurn, 
            double futurTurns, 
            bool isDefault, 
            ElementTypes elementType = ElementTypes.Pit,
            BuildingTypes buildingType = BuildingTypes.Element)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = DEFAULT_BUILDING_NAME;
            }
            else
            {
                Name = name;
            }

            FirstTurn = firstTurn;
            SecondTurn = secondTurn;
            FutureTurn = futurTurns;
            IsDefault = isDefault;
            ElementType = elementType;
            BuildingType = buildingType;
        }

        public static BuildingElement CompositionFactory(List<(BuildingElement, int)> elements, string name, string description = null)
        {
            BuildingElement buildingElement = new BuildingElement();
            buildingElement.FirstTurn = elements.Sum(e => e.Item1.FirstTurn * e.Item2);
            buildingElement.SecondTurn = elements.Sum(e => e.Item1.SecondTurn * e.Item2);
            buildingElement.FutureTurn = elements.Sum(e => e.Item1.FutureTurn * e.Item2);

            buildingElement.BuildingType = BuildingTypes.Composition;
            buildingElement.ElementType = elements.TrueForAll(b => b.Item1.ElementType == elements[0].Item1.ElementType) ? elements[0].Item1.ElementType : ElementTypes.Mixed;
            buildingElement.Id = new Random().Next(10000);

            if (name == null)
            {
                buildingElement.Name = DEFAULT_COMPOSITION_NAME;
            }
            else
            {
                buildingElement.Name = name;
            }

            if(description == null)
            {
                StringBuilder autoDescription = new StringBuilder();
                List<(BuildingElement, int)> compositions = elements.Where(e => e.Item1.BuildingType == BuildingTypes.Composition).ToList();
                List<(BuildingElement, int)> simples = elements.Where(e => e.Item1.BuildingType == BuildingTypes.Element).ToList();

                if(compositions.Count > 0)
                {
                    autoDescription.AppendLine("Композиции:");
                    compositions.ForEach(c => autoDescription.AppendLine($" - {c.Item2}x {c.Item1.Name}({Math.Round(c.Item1.FirstTurn, 2)}|{Math.Round(c.Item1.SecondTurn, 2)}|{Math.Round(c.Item1.FutureTurn, 2)});"));
                }

                if (simples.Count > 0)
                {
                    autoDescription.AppendLine("Элементы:");
                    simples.ForEach(s => autoDescription.AppendLine($" - {s.Item2}x {s.Item1.Name}({Math.Round(s.Item1.FirstTurn, 2)}|{Math.Round(s.Item1.SecondTurn, 2)}|{Math.Round(s.Item1.FutureTurn, 2)});"));
                }
                autoDescription.AppendLine();
                autoDescription.Append(CreateDefaultDescription(buildingElement, 2));

                buildingElement.Description = autoDescription.ToString();
            }
            else
            {
                buildingElement.Description = description;
            }

            return buildingElement;
        }

        public static BuildingElement TrenchFactory(string name, bool isDeep, float length, float kCoeff)
        {
            BuildingElement trench = new BuildingElement(name);
            float manPower = length * kCoeff * (isDeep ? TRENCH_DEEP : TRENCH_SMALL);
            trench.FirstTurn = manPower;
            trench.ElementType = ElementTypes.Trench;
            trench.BuildingType = BuildingTypes.Element;

            return trench;
        }

        public static string CreateDefaultDescriptionForTrench(BuildingElement buildingElement, float length, float curvFact, bool isDeep, int precision)
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine($"Длина - {Math.Round(length, precision)} м.");
            description.AppendLine($"Коэфициент кривизны - {Math.Round(curvFact, precision)}");
            description.AppendLine($"Глубина - {Math.Round(isDeep ? 1.5f : 1.1f, precision)} м.");
            description.Append(CreateDefaultDescription(buildingElement, precision));

            return description.ToString();
        }
        public static string CreateDefaultDescription(BuildingElement buildingElement, int precision)
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine($"В первую очередь - {Math.Round(buildingElement.FirstTurn, precision)} чел./час.");
            description.AppendLine($"Во вторую очередь - {Math.Round(buildingElement.SecondTurn, precision)} чел./час.");
            description.AppendLine($"В дальнейшем - {Math.Round(buildingElement.FutureTurn, precision)} чел./час.");
            description.AppendLine($"Всего - {Math.Round(buildingElement.AllTurns, precision)} чел./час.");
            switch (buildingElement.ElementType) 
            {
                case ElementTypes.Trench:
                    description.Append("Траншея");
                    break;
                case ElementTypes.Pit:
                    description.Append("Котлован");
                    break;
                case ElementTypes.Mixed:
                    description.Append("Смешанное построение");
                    break;
            }

            return description.ToString();
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

        public IEnumerable<string> GetFeatures()
        {
            return Name.Split().Where(s => !string.IsNullOrWhiteSpace(s));
        }
    }
}
