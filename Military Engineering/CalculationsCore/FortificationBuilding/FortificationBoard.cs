using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding
{
    class FortificationBoard : IBoard
    {
        Dictionary<int, BuildingElement> elements;
        public void AddElement(int id, string name)
        {
            elements.Add(id, new BuildingElement(name));
        }

        public bool DeleteElement(int id)
        {
            try
            {
                elements.Remove(id);
            }
            catch
            {
                throw new IndexOutOfRangeException("Wrong index");
            }
            return true;
        }

        public object GetBuildingTerms()
        {
            throw new NotImplementedException();
        }

        public bool UpdateElement(int id, double value, object property)
        {
            throw new NotImplementedException();
        }
    }
}
