using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryConfiguration.Configurations
{
    public class FortificationConfiguration
    {
        public List<CalculationsCore.FortificationBuilding.BuildingElement> BuildingElements {  get; set; }
        public List<CalculationsCore.FortificationBuilding.BuildingAbilities.Gain> Gains {  get; set; }
        public FortificationConfiguration() { }
    }
}
