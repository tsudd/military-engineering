using CalculationsCore.FortificationBuilding.BuildingAbilities;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CalculationsCore.FortificationBuilding
{
    public class FortificationBoard
    {
        Dictionary<int, BuildingCalculation> elements;

        public FortificationBoard()
        {
            elements = new Dictionary<int, BuildingCalculation>();
        }
        public void AddElement(int id, BuildingCalculation calculation)
        {
            elements.Add(id, calculation);
        }

        public void DeleteElement(int id)
        {
            try
            {
                elements.Remove(id);
            }
            catch
            {
                throw new IndexOutOfRangeException("Wrong index");
            }
        }

        public List<Evaluations> GetBuildingTerms()
        {
            List<Evaluations> buildingTerms = new List<Evaluations>();
            foreach (var el in elements)
            {
                buildingTerms.Add(new Evaluations(
                    el.Value.EvaluateFirstTurn(), 
                    el.Value.EvaluateSecondTurn(),
                    el.Value.EvaluateFutureTurn(),
                    el.Value.Element.Name, 
                    el.Value.DaysToSettle));
            }
            return buildingTerms;
        }

        public void UpdateElementCondition(int id, DayTime value)
        {
            if (value is null)
            {
                throw new ArgumentNullException("Argument is null");
            }
            elements[id].DayTime = value;
        }

        public void UpdateElementCondition(int id, SoilType soil)
        {
            if (soil is null)
            {
                throw new ArgumentNullException("Argument is null");
            }
            elements[id].Soil = soil;
        }

        public void UpdateElementCondition(int id, FieldPollution pollution)
        {
            if (pollution is null)
            {
                throw new ArgumentNullException("Argument is null");
            }
            elements[id].Pollution = pollution;
        }

        public void UpdateElementCondition(int id, double daysToSattle)
        {
            elements[id].DaysToSettle = daysToSattle;
        }

        public void UpdateElementAbility(int id, object value, AbilityType abilityType)
        {
            var ability = GetElement(id).Ability;
            try
            {
                switch (abilityType)
                {
                    case AbilityType.PeopleAmount:
                        ability.PeopleAmount = (int)value;
                        break;
                    case AbilityType.AttritionRate:
                        ability.AttritionRate = (double)value;
                        break;
                    case AbilityType.ManPower:
                        ability.ManPower = (double)value;
                        break;
                    case AbilityType.Organization:
                        ability.Organization = (double)value;
                        break;
                    case AbilityType.BuildingGain:
                        ability.BuildingGain = (Gain)value;
                        break;
                    case AbilityType.WorkTime:
                        ability.WorkTime = (double)value;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException();
            }
        }

        public BuildingCalculation GetElement(int id)
        {
            return elements[id];
        }

        public int CalculationsNumber()
        {
            return elements.Count;              
        }
    }
}
