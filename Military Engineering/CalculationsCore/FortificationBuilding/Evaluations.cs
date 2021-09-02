using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding
{
    public struct Evaluations
    {
        public double FirstTurn { get; set; }
        public double SecondTurn { get; set; }
        public double FutureTurn { get; set; }
        public string Name { get; set; }
        public double DaysToSettle { get; set; }
        public Evaluations(double FirstTurn,
                           double SecondTurn,
                           double FutureTurn,
                           string Name,
                           double DaysToSettle)
        {
            this.FirstTurn = FirstTurn;
            this.SecondTurn = SecondTurn;
            this.DaysToSettle = DaysToSettle;
            this.FutureTurn = FutureTurn;
            this.Name = Name;
        }
    }
}
