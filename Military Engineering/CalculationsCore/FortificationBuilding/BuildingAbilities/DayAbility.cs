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
        public double Evaluate(BuildingElement element)
        {
            if (WorkTime <= 0 
                || PeopleAmount <= 0 
                || ManPower <= 0 
                || Organization <= 0 
                || AttritionRate <= 0)
            {
                throw new DivideByZeroException("Not able to evaluate, 'cause some fields are equeled zero");
            }
            return EvaluateGains(element) 
                + ( PeopleAmount 
                * ManPower 
                * AttritionRate 
                * Organization 
                * WorkTime );
        }

        private double EvaluateGains(BuildingElement element)
        {
            double ans = 0;
            foreach( var ga in BuildingGains)
            {
                ans += ga.Key.Evaluate(element, this, ga.Value);
            }
            return ans;
        }
    }
}
