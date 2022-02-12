using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingDefinition
{
    public class BuildingComposition : IBuilding
    {
        public const int MAX_ID = 10000;

        List<IBuilding> buildings;
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Unknown composition";
        public string Description { get; set; } = "";
        public bool IsDefault { get; set; } = false;

        public ElementTypes ElementType { get; set; }

        public BuildingComposition()
        {
            buildings = new List<IBuilding>();
        }

        public BuildingComposition(string name, string description, int id = 0, List<IBuilding> buildings = null)
        {
            if (buildings == null)
            {
                this.buildings = new List<IBuilding>();
            }
            else
            {
                this.buildings = buildings;
            }
            Name = name;
            Description = description;
            if (id == 0)
            {
                Id = GenerateIndex(); //there is a probability of collisions
            }
            else
            {
                Id = id;
            }
        }

        public void AddBuilding(IBuilding building) { }

        public double GetFirstTurn()
        {
            double ans = 0;
            foreach(var b in buildings) 
            {
                ans += b.GetFirstTurn();
            }
            return ans;
        }

        public double GetSecondTurn()
        {
            double ans = 0;
            foreach (var b in buildings)
            {
                ans += b.GetSecondTurn();
            }
            return ans;
        }

        public double GetFutureTurn()
        {
            double ans = 0;
            foreach (var b in buildings)
            {
                ans += b.GetFutureTurn();
            }
            return ans;
        }

        public double GetAllTurns()
        {
            double ans = 0;
            foreach (var b in buildings)
            {
                ans += b.GetAllTurns();
            }
            return ans;
        }

        private int GenerateIndex()
        {
            return (new Random()).Next(MAX_ID);
        }

        public int GetId()
        {
            return Id;
        }
    }
}
