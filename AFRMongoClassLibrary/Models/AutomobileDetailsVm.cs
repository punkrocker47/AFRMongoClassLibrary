using System;

namespace AFRMongoClassLibrary.Models
{
    public class AutomobileDetailsVm
    {
        public string SelectedBodyType { get; set; }
        public DateTime? PlateExpiration { get; set; }
        
        public bool PlateExpirationNa { get; set; }
        public string SelectedStateParent { get; set; }
        public bool StateParentHasChildren { get; set; }
        public string SelectedState { get; set; }
        public string SelectedDamage { get; set; }
        public string RegistrationNumber { get; set; }
        public string SelectedStyleParent { get; set; }
        public bool StyleParentHasChildren { get; set; }
        public string SelectedStyle { get; set; }
        public string SelectedOriginalColorOne { get; set; }
        public string SelectedOriginalColorTwo { get; set; }
        public string SelectedRepaintedColorOne { get; set; }
        public string SelectedRepaintedColorTwo { get; set; }
        public int? Expires { get; set; }
        public string OwnerAppliedNumber { get; set; }
        public string RegisteredWeight { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsCommercialVehicle { get; set; }
        public bool IsHazmat { get; set; }
        public bool IsIgnitionInterlock { get; set; }
    }
}