using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingConditions
{
    public class DayTime
    {
        public static DayTime Day { get; } = new DayTime(1, "Day");
        public static DayTime Night { get; } = new DayTime(0.7, "Night");
        public static DayTime DayNight { get; } = new DayTime(0.85, "DayNight");
        public string Name { get; private set; }
        public double Value { get; private set; }

        private DayTime(double val, string name)
        {
            Value = val;
            Name = name;
        }
    }
}
