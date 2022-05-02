using System;
using System.Collections.Generic;

namespace CalculationsCore.FortificationBuilding.BuildingAbilities
{
    public enum AbilityType
    {
        PeopleAmount,
        ManPower,
        AttritionRate,
        Organization,
        BuildingGain,
        WorkTime
    }

    public struct GainAbility
    {
        public int Amount { get; set; }
        public double WorkTime { get; set; }
        public GainAbility(int Amount, double WorkTime)
        {
            this.Amount = Amount;
            this.WorkTime = WorkTime;
        }
    }

    public class DayAbility
    {
        public int PeopleAmount { get; set;  } = 0;
        public double ManPower { get; set; } = 0;
        public double AttritionRate { get; set; } = 0;
        public double Organization { get; set; } = 0;
        public List<KeyValuePair<Gain, GainAbility>> BuildingGains { get; set; } = new List<KeyValuePair<Gain, GainAbility>>();
        public double WorkTime { get; set; } = 0;
        public double Evaluate(ElementTypes elementType)
        {
            var result = EvaluateGains(elementType) 
                + ( PeopleAmount 
                * ManPower 
                * AttritionRate 
                * Organization 
                * WorkTime );
            if (result <= 0)
            {
                throw new DivideByZeroException("Not able to evaluate, 'cause some fields are equeled zero or zero gain");
            }
            return result;
        }

        private double EvaluateGains(ElementTypes elementType)
        {
            double ans = 0;
            foreach( var ga in BuildingGains)
            {
                ans += ga.Key.Evaluate(this, ga.Value, elementType);
            }
            return ans;
        }
    }
}
