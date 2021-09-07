using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Gain BuildingGain { get; set; }
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
            return (BuildingGain is null ? 0 : BuildingGain.HumanEquivalent) 
                + ( PeopleAmount 
                * ManPower 
                * AttritionRate 
                * Organization 
                * WorkTime );
        }
    }
}
