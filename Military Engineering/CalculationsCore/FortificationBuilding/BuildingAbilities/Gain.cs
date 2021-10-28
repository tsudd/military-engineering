﻿namespace CalculationsCore.FortificationBuilding.BuildingAbilities
{
    public class Gain
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
        public Gain(string description, double trenchPerfomance, double pitPerfomance, string name = DEFAULT_NAME, int id = 0)
        {
            Description = description;
            TrenchPerformance = trenchPerfomance;
            PitPerformance = pitPerfomance;
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
        public double Evaluate(DayAbility ability, GainAbility gainAbility)
        {
            //TODO: implement performance evaluation according to building type (keep in mind, that we have new hierarchy)
            if (ability is null)
            {
                return 0;
            }
            return gainAbility.Amount
                * DeterminePerformance(0)
                * ability.Organization
                * ((gainAbility.WorkTime > 24) ? 1.5 : 1)
                * gainAbility.WorkTime;
        }

        private double DeterminePerformance(ElementTypes type)
        {
            return (type == ElementTypes.Pit) ? PitPerformance : TrenchPerformance;
        }
    }
}
