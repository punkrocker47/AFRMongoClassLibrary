using System;

namespace AFRMongoClassLibrary.Models
{
    public class ReportLocationVm
    {
        public bool LocationKnown { get; set; } = true;
        public Decimal? Latitude { get; set; }
        public Decimal? Longitude { get; set; }

        public string SelectedTroopZoneParentValue { get; set; }
        public string SelectedTroopZone { get; set; }
        public AddressVm Address { get; set; } = new AddressVm();
        public string SelectedCounty { get; set; }
    }
}