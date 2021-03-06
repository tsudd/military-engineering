using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculationsCore.FortificationBuilding.BuildingAbilities
{
    public class Gain : ISearchable
    {
        public const string DEFAULT_NAME = "UNKNOWN_GAIN";
        public const int MAX_ID = 10000;
        public string Name { get; set; } = DEFAULT_NAME;
        public string Description { get; set; } = "";
        public double TrenchPerformance {  get; set; } = 0;
        public double PitPerformance { get; set;  } = 0;
        public int Id { get; set; } = 0;
        public bool IsDefault { get; set; } = false;
        public Gain() { }
        public Gain(Gain gain) 
        {
            Name = gain.Name;
            Description = gain.Description;
            TrenchPerformance = gain.TrenchPerformance;
            PitPerformance = gain.PitPerformance;
            IsDefault = gain.IsDefault;
            Id = gain.Id;
        }
        public Gain(double trenchPerfomance, double pitPerfomance, string name = DEFAULT_NAME, int id = 0, string description = null)
        {         
            TrenchPerformance = trenchPerfomance;
            PitPerformance = pitPerfomance;

            if (string.IsNullOrEmpty(description))
            {
                Description = CreateDefaultDescription(TrenchPerformance.ToString(), PitPerformance.ToString());
            }
            else
            {
                Description = description;
            }

            Name = name;
            if (id == 0)
            {
                Id = (new System.Random()).Next(MAX_ID);
            }
            else
            {
                Id = id;
            }
        }

        public static string CreateDefaultDescription(string trenchPerformance, string pitPerformance)
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine("Производительность:");
            description.AppendLine($"для траншей - {trenchPerformance}");
            description.AppendLine($"для котлованов - {pitPerformance}");
            return description.ToString();
        }
        public double Evaluate(DayAbility ability, GainAbility gainAbility, ElementTypes elementType)
        {
            if (ability is null)
            {
                return 0;
            }
            return gainAbility.Amount
                * DeterminePerformance(elementType)
                * ability.Organization
                * ((gainAbility.WorkTime > 10) ? 1.5 : 1)
                * gainAbility.WorkTime;
        }

        private double DeterminePerformance(ElementTypes type)
        {
            switch (type)
            {
                case ElementTypes.Pit: return PitPerformance;
                case ElementTypes.Trench: return TrenchPerformance;
                case ElementTypes.Mixed: return (PitPerformance + TrenchPerformance) / 2;
            }

            return 0;
        }

        public IEnumerable<string> GetFeatures()
        {
            return Name.Split().Where(s => !string.IsNullOrWhiteSpace(s));
        }
    }
}
