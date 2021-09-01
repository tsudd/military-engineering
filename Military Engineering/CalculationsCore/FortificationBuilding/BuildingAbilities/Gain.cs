using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingAbilities
{
    public class Gain
    {
        public const string DEFAULT_NAME = "UKNOWN_GAIN";
        public string Name { get; set; } = DEFAULT_NAME;
        public string Description { get; set; } = "";
        public double HumanEquivalent { get; set; } = 0;
    }
}
