using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingDefinition
{
    public interface IBuilding
    {
        bool IsDefault { get; }
        string Name { get; }
        string Description {  get; }
        ElementTypes ElementType { get; }
        double GetFirstTurn();
        double GetSecondTurn();
        double GetFutureTurn();
        double GetAllTurns();
        int GetId();
    }
}
