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

    public class DayAbility
    {
        public int PeopleAmount { get; set;  } = 0;
        public double ManPower { get; set; } = 0;
        public double AttritionRate { get; set; } = 0;
        public double Organization { get; set; } = 0;
        public List<KeyValuePair<Gain, int>> BuildingGains { get; set; } = new List<KeyValuePair<Gain, int>>();
        public double WorkTime { get; set; } = 0;
        public double Evaluate()
        {
            if (WorkTime <= 0 
                || PeopleAmount <= 0 
                || ManPower <= 0 
                || Organization <= 0 
                || AttritionRate <= 0)
            {
                throw new DivideByZeroException("Not able to evaluate, 'cause some fields are equeled zero");
            }
            return EvaluateGains() 
                + ( PeopleAmount 
                * ManPower 
                * AttritionRate 
                * Organization 
                * WorkTime );
        }

        private double EvaluateGains()
        {
            double ans = 0;
            foreach( var ga in BuildingGains)
            {
                ans += ga.Key.Evaluate(this, ga.Value);
            }
            return ans;
        }
    }
}
