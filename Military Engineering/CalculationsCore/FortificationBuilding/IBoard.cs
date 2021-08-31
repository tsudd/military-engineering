using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding
{
    interface IBoard
    {
        object GetBuildingTerms();
        void AddElement(int id, string name);
        bool DeleteElement(int id);
        bool UpdateElement(int id, double value, object property);
    }
}
