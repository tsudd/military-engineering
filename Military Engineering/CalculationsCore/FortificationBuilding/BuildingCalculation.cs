using CalculationsCore.FortificationBuilding.BuildingAbilities;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding
{
    public class BuildingCalculation
    {
        public const int ACCURACY = 2;
        public BuildingElement Element { get; private set; }
        public DayTime DayTime { get; set; } = DayTime.Day;
        public FieldPollution Pollution { get; set; } = FieldPollution.Purely;
        public SoilType Soil { get; set; } = SoilType.Medium;
        public DayAbility Ability { get; set; }
        public double DaysToSettle { get; set; } = 0;
        public BuildingCalculation(BuildingElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Building element is null");
            }
            Element = element;
        }

        public double EvaluateFirstTurn()
        {
            var days = Element.FirstTurn 
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        public double EvaluateSecondTurn()
        {
            var days = Element.SecondTurn 
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        public double EvaluateFutureTurn()
        {
            var days = Element.FutureTurn 
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        public double EvaluateAllTurns()
        {
            var days = ( Element.FirstTurn + Element.SecondTurn + Element.FutureTurn ) 
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        private double EvaluateConditions()
        {
            return DayTime.Value 
                * Pollution.Value 
                * Soil.Value
                * Ability.Evaluate(Element);
        }
    }
}
