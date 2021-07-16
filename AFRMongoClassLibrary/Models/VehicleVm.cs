namespace AFRMongoClassLibrary.Models
{
    public class VehicleVm
    {
        public bool SelectedIdentifier { get; set; }
        public string Required => SelectedIdentifier ? "required" : "";
        public ChosenVehicleTypeEnum? ChosenType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int? Year { get; set; }
        public decimal? EstimatedValue { get; set; }
        
        public bool ShouldShowVehicleYear => string.IsNullOrEmpty(SelectedVehicleYearUnkNA) || (!SelectedVehicleYearUnkNA.Contains("Unknown") && !SelectedVehicleYearUnkNA.Contains("N/A"));
        
        public string SelectedVehicleYearUnkNA { get; set; }

        public AutomobileDetailsVm AutomobileDetails { get; set; }
        public WatercraftDetailsVm WatercraftDetails { get; set; }
        public AircraftDetailsVm AircraftDetails { get; set; }

        public string DisplayName => $"{Make} {Model}".Trim();

        public override string ToString()
        {
            if(!string.IsNullOrEmpty(Make) || !string.IsNullOrEmpty(Model))
                return DisplayName;

            if(ChosenType != null)
            {
                switch (ChosenType)
                {
                    case ChosenVehicleTypeEnum.Automobile:
                        return "Unknown Vehicle";
                    case ChosenVehicleTypeEnum.Aircraft:
                        return "Unknown Aircraft";
                    case ChosenVehicleTypeEnum.Watercraft:
                        return "Unknown Watercraft";                     
                }
            }
               
            return "Unknown Vehicle";          
        }
    }

    public enum ChosenVehicleTypeEnum
    {
        Automobile,
        Aircraft,
        Watercraft
    }
}