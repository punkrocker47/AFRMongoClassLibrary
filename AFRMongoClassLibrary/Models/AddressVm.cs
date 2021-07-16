using System;

namespace AFRMongoClassLibrary.Models
{
    public class AddressVm
    {
        public int Id { get; set; }

        //If this is coming from a picklist, it will break if they ever change it.
        //Would be better for types to come
        public string SelectedTypeValue { get; set; }

        //StreetAddress
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string UnitNumber { get; set; }

        //Roadway      
        public string SelectedHighway { get; set; }
        public string Description { get; set; }
        public string HighwayRoadwayName { get; set; }

        //Waterway
        public string SelectedBodyOfWater { get; set; }
        public string WaterDescription { get; set; }

         
        //Common
        public DateTime? CurrentAsOf { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string SelectedCityType { get; set; } = "MO";
        public string City { get; set; }
        public string SelectedStateParentValue { get; set; } = "MO";
        public string SelectedState { get; set; }
        public string Zip { get; set; }
        public string Zip4 { get; set; }

        //PO Box
        public string POBox { get; set; }

        public string SelectedTroopLocation { get; set; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(SelectedTypeValue) ? "Unknown Address" : SelectedTypeValue;
        }
    }
}