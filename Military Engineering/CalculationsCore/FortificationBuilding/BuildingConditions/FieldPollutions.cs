using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingConditions
{
    public class FieldPollution
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
}
