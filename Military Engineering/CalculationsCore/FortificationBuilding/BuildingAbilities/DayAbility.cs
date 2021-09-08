﻿using System.Collections.Generic;

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
        public List<Gain> BuildingGains { get; set; } = new List<Gain>();
        public double WorkTime { get; set; } = 0;
        public double Evaluate(BuildingElement element)
        {
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
                ans += ga.Evaluate(element, this);
            }
            return ans;
        }
    }
}
