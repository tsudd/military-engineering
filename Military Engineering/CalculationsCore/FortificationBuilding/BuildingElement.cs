using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding
{
    class DayTime
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

    class FieldPollution
    {
        public static FieldPollution Radioation { get; } = new FieldPollution(0.75, "Radioation");
        public static FieldPollution Chemical { get; } = new FieldPollution(0.75, "Chemical");
        public static FieldPollution Bacteriological { get; } = new FieldPollution(0.75, "Bacteriological");
        public static FieldPollution Purely { get; } = new FieldPollution(1, "Purely");
        public string Name { get; private set; }
        public double Value { get; private set; }

        private FieldPollution(double val, string name)
        {
            Value = val;
            Name = name;
        }
    }

    class SoilType
    {
        public static SoilType Weak { get; } = new SoilType(1.25, "Weak");
        public static SoilType Medium { get; } = new SoilType(1, "Medium");
        public static SoilType Solid { get; } = new SoilType(0.6, "Solid");
        public static SoilType Rocky { get; } = new SoilType(0.2, "Rocky");
        public static SoilType FrozenShallow { get; } = new SoilType(0.3, "FrozenShallow");
        public static SoilType FrozenDeep { get; } = new SoilType(0.15, "FrozenDeep");
        public string Name { get; private set; }
        public double Value { get; private set; }

        private SoilType(double val, string name)
        {
            Value = val;
            Name = name;
        }
    }
    class BuildingElement
    {

        public BuildingElement(string name) => this.name = name;


        double firstTurn;
        double secondTurn;
        double futureTurn;
        string name;
        DayTime dayTime;
        FieldPollution fieldPollution;
        SoilType soilType;
        FortReinforcement fortReinforcement;

        double EvaluateDayPossibility()
        {
            throw new NotImplementedException();
        }

        double EvaluateFirstTurn()
        {
            double days;
            double dayPossibility = EvaluateDayPossibility();
            days = firstTurn / dayTime.Value / fieldPollution.Value/ soilType.Value / dayPossibility;
            return days;
        }

        double EvaluateSecondTurn()
        {
            double days;
            double dayPossibility = EvaluateDayPossibility();
            days = secondTurn / dayTime.Value / fieldPollution.Value / soilType.Value / dayPossibility;
            return days;
        }

        double EvaluateFutureTurn()
        {

            double days;
            double dayPossibility = EvaluateDayPossibility();
            days = secondTurn / dayTime.Value / fieldPollution.Value / soilType.Value / dayPossibility;
            return days;
        }
    }
}
