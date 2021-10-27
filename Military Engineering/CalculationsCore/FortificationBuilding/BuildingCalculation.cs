using CalculationsCore.FortificationBuilding.BuildingAbilities;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingDefinition;
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
        public IBuilding Building { get; private set; }
        public DayTime DayTime { get; set; } = DayTime.Day;
        public FieldPollution Pollution { get; set; } = FieldPollution.Purely;
        public SoilType Soil { get; set; } = SoilType.Medium;
        public DayAbility Ability { get; set; } = new DayAbility();
        public double DaysToSettle { get; set; } = 0;
        public BuildingCalculation(IBuilding element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Building element is null");
            }
            Building = element;
        }

        public double EvaluateFirstTurn()
        {
            var days = Building.GetFirstTurn() 
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        public double EvaluateSecondTurn()
        {
            var days = Building.GetSecondTurn()
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        public double EvaluateFutureTurn()
        {
            var days = Building.GetFutureTurn()
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        public double EvaluateAllTurns()
        {
            var days = ( Building.GetFirstTurn() + Building.GetSecondTurn() + Building.GetFutureTurn() ) 
                / EvaluateConditions();
            return Math.Round(days, ACCURACY);
        }

        private double EvaluateConditions()
        {
            return DayTime.Value 
                * Pollution.Value 
                * Soil.Value
                * Ability.Evaluate();
        }

        public Evaluations GetBuildingTerms()
        {
            return new Evaluations(EvaluateFirstTurn(),
                EvaluateSecondTurn(),
                EvaluateFutureTurn(),
                Building.Name,
                DaysToSettle);
        }

        public int GetGainsAmount()
        {
            int amount = 0;
            foreach(var gains in Ability.BuildingGains)
            {
                amount += gains.Value.Amount;
            }
            return amount;
        }
    }
}
