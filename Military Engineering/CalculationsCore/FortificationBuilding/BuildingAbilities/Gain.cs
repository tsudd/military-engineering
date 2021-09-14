namespace CalculationsCore.FortificationBuilding.BuildingAbilities
{
    public class Gain
    {
        public const string DEFAULT_NAME = "UNKNOWN_GAIN";
        public const int MAX_ID = 10000;
        public string Name { get; set; } = DEFAULT_NAME;
        public string Description { get; set; } = "";
        public int Amount { get; set; } = 0;
        public double TrenchPerformance {  get; set; } = 0;
        public double PitPerformance { get; set;  } = 0;
        public bool IsDefault { get; set; } = false;
        public int Id { get; set; } = 0;
        public Gain() { }
        public Gain(Gain gain) 
        {
            Name = gain.Name;
            Description = gain.Description;    
            Amount = gain.Amount;   
            TrenchPerformance = gain.TrenchPerformance;
            PitPerformance = gain.PitPerformance;
            IsDefault = gain.IsDefault;
            Id = gain.Id;
        }
        public Gain(string name = DEFAULT_NAME) => this.Name = name;
        public Gain(string description, double trenchPerfomance, double pitPerfomance, string name = DEFAULT_NAME, int id = 0, int amount = 0)
        {
            Description = description;
            TrenchPerformance = trenchPerfomance;
            PitPerformance = pitPerfomance;
            Amount = amount;
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
        public double Evaluate(BuildingElement element, DayAbility ability)
        {
            if (element is null || ability is null)
            {
                return 0;
            }
            return Amount
                * DeterminePerformance(element.ElementType)
                * ability.Organization
                * ((ability.WorkTime > 24) ? 1.5 : 1)
                * ability.WorkTime;
        }

        private double DeterminePerformance(ElementType type)
        {
            return (type == ElementType.Pit) ? PitPerformance : TrenchPerformance;
        }
    }
}
