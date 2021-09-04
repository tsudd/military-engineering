using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingConditions
{
    public class DayTime
    {
        public static DayTime Day { get; } = new DayTime(1, "День");
        public static DayTime Night { get; } = new DayTime(0.7, "Ночь");
        public static DayTime DayNight { get; } = new DayTime(0.85, "День-Ночь");
        public string Name { get; private set; }
        public double Value { get; private set; }

        private DayTime(double val, string name)
        {
            Value = val;
            Name = name;
        }
        public static IEnumerable<DayTime> GetTimeConditions()
        {
            return new[] { Day, Night, DayNight };
        }
    }
}
