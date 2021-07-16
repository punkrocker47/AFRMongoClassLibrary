namespace AFRMongoClassLibrary.Models
{
    public class AircraftDetailsVm
    {
        public string SelectedAircraftOriginalColorOne { get; set; }
        public string SelectedAircraftOriginalColorTwo { get; set; }
        public string SelectedAircraftRepaintedColorOne { get; set; }
        public string SelectedAircraftRepaintedColorTwo { get; set; }
        public string SelectedAircraftType { get; set; }
        public string AircraftSerialNumber { get; set; }
        public string AircraftRecordNumber { get; set; }
        public string AircraftOwnerAppliedNumber { get; set; }
        public string AircraftYear { get; set; }
        public string TailNumberRegistrion { get; set; }
        public string EstimatedValue { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsDamaged { get; set; }
    }
}