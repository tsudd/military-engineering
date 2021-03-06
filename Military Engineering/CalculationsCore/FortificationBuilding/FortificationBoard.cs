using CalculationsCore.FortificationBuilding.BuildingAbilities;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculationsCore.FortificationBuilding
{
    public class FortificationBoard
    {
        public const int ACCURACY = 2;
        Dictionary<int, BuildingCalculation> elements;
        public List<Gain> gainFacilities;
        int lastNumber = 0;

        public static IEnumerable<DayTime> DayTimes { get; private set;  } = DayTime.GetTimeConditions();
        public static IEnumerable<FieldPollution> Pollutions { get; private set; } = FieldPollution.GetPollutionConditions();
        public static IEnumerable<SoilType> SoilTypes { get; private set; } = SoilType.GetSoilConditions();

        public FortificationBoard()
        {
            elements = new Dictionary<int, BuildingCalculation>();
            gainFacilities = new List<Gain>();
        }
        public int AddElement(BuildingCalculation calculation)
        {
            lastNumber++;
            elements.Add(lastNumber, calculation);
            return lastNumber;
        }

        public void AddGainFacility(Gain gain)
        {
            gainFacilities.Add(gain);
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
                buildingTerms.Add(el.Value.GetBuildingTerms());
            }
            return buildingTerms;
        }

        public void UpdateElementCondition(int id, object value)
        {
            if (value == null)
                throw new ArgumentNullException("Value can't be null");
            if (value is DayTime dayTime)
            {
                elements[id].DayTime = dayTime;
            }
            else if (value is SoilType soilType)
            {
                elements[id].Soil = soilType;
            }
            else if (value is FieldPollution pollution)
            {
                elements[id].Pollution = pollution;
            }
            else
            {
                throw new ArgumentException("Wrong element condition type");
            }
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

        public void UpdateElementAbility(int id, object value, AbilityType abilityType)
        {
            var ability = GetElement(id).Ability;
            try
            {
                switch (abilityType)
                {
                    case AbilityType.PeopleAmount:
                        ability.PeopleAmount = Convert.ToInt32(value);
                        break;
                    case AbilityType.AttritionRate:
                        ability.AttritionRate = Convert.ToDouble(value);
                        break;
                    case AbilityType.ManPower:
                        ability.ManPower = Convert.ToDouble(value);
                        break;
                    case AbilityType.Organization:
                        ability.Organization = Convert.ToDouble(value);
                        break;
                    case AbilityType.BuildingGain:
                        ability.BuildingGains = (List<KeyValuePair<Gain, GainAbility>>)value;
                        break;
                    case AbilityType.WorkTime:
                        ability.WorkTime = Convert.ToDouble(value);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }

        }

        public BuildingCalculation GetElement(int id)
        {
            return elements[id];
        }

        public Gain GetGainFacility(int id)
        {
            return gainFacilities[id];
        }

        public int GetCalculationsNumber()
        {
            return elements.Count;              
        }

        public double EvaluateAllFirstTurns()
        {
            double ans = 0;
            foreach (var element in elements.Values)
            {
                ans += element.Building.GetFirstTurn();
            }

            return Math.Round(ans, ACCURACY);
        }

        public double EvaluateAllSecondTurns()
        {
            double ans = 0;
            foreach (var element in elements.Values)
            {
                ans += element.Building.GetSecondTurn();
            }

            return Math.Round(ans, ACCURACY);
        }

        public double EvaluateAllFutureTurns()
        {
            double ans = 0;
            foreach (var element in elements.Values)
            {
                ans += element.Building.GetFutureTurn();
            }

            return Math.Round(ans, ACCURACY);
        }

        public double EvaluateAllAllTurns()
        {
            double ans = 0;
            foreach (var element in elements.Values)
            {
                ans += element.Building.GetAllTurns();
            }
            return Math.Round(ans, ACCURACY);
        }

        public void RemoveGainFromElements(int gainId)
        {
            foreach(var element in elements.Values)
            {
                foreach(var gain in element.Ability.BuildingGains)
                {
                    if (gain.Key.Id == gainId)
                    {
                        element.Ability.BuildingGains.Remove(gain);
                        break;
                    }
                }
            }
        }

        public void UpdateGainInElements(Gain gain)
        {
            foreach (var element in elements.Values)
            {
                foreach (var g in element.Ability.BuildingGains)
                {
                    if (g.Key.Id == gain.Id)
                    {
                        var newGain = new KeyValuePair<Gain, GainAbility>(gain, g.Value);
                        element.Ability.BuildingGains.Remove(g);
                        element.Ability.BuildingGains.Add(newGain);
                        break;
                    }
                }
            }
        }

        public double GetNewChartInterval()
        {
            double interval = 0;
            foreach(var element in elements.Values)
            {
                try
                {
                    if (interval < element.EvaluateAllTurns())
                        interval = element.EvaluateAllTurns();
                }
                catch (DivideByZeroException)
                {

                }
                
            }
            return interval;
        }
    }
}
