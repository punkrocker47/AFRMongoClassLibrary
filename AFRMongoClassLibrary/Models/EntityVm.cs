using System;
using System.Collections.Generic;
using System.Linq;

namespace AFRMongoClassLibrary.Models
{
    public class EntityVm
    {
           public IReadOnlyDictionary<int, string> _navItems = new Dictionary<int, string>()
        {
            {0, "Overview"},
            {1, "Additional Details"},
            {2, "Alias, Clothes, SMTP"}
        };

        public int CurrentNavIndex { get; set; }
        
        public int RNumber { get; set; }
        
        //PERSON DETAILS//
        public string SelectedType { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public int? HeightFeet { get; set; }
        public int? HeightInches { get; set; }
        public int? Weight { get; set; }
        public string OLN { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool DobUnknown { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool Photo { get; set; }
        public bool IdentityKnown { get; set; } = true;
        public bool Fingerprinted { get; set; }
        public bool ProvidedFirstAid { get; set; }
        public string SelectedGenSuffix { get; set; }
        public string SelectedAgeUnit { get; set; }
        public string SelectedRace { get; set; }
        public string SelectedEthnicity { get; set; }
        public string SelectedSex { get; set; }
        public string SelectedStateParentValue { get; set; }
        public string SelectedState { get; set; }
        public string SelectedEyeColor { get; set; }
        public string SelectedHairColor { get; set; }
        public string SelectedSecondHairColor { get; set; }
        
        //LICENSE INFO//
        public string SelectedLicenseStatus { get; set; }
        public string SelectedLicenseType { get; set; }
        public IList<string> SelectedRestrictions { get; set; }
        public IList<string> SelectedEndorsements { get; set; }
        public bool CDL { get; set; }
        public string SelectedClass { get; set; }
        public bool BoaterEducationCard { get; set; }
        
        //BUSINESS INFO//
        public string SelectedTypeOfBusiness { get; set; }
        public string BusinessName { get; set; }
        
        //CONTACT INFO//
        public string EmailAddress { get; set; }
        public string WebsiteURL { get; set; }
        public int? CurrentPhoneNumberIndex { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; } = new();
        public int? CurrentAddressIndex { get; set; }
        public List<EntityAddressVm> Addresses { get; set; } = new();
        public ReportEntityDetailsVm EntityDetailsVm { get; set; } = new();
            
        
        public bool IsPerson => SelectedType.ToLower().Contains("person");
        public string FullName =>  SetFullName();
        public string DisplayName => $"{LastName} , {FirstName} {MiddleName} {SelectedGenSuffix}";

        private string SetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName} {SelectedGenSuffix}"
                .Trim();
        }

        public override string ToString()
        {
            if(string.IsNullOrWhiteSpace(SelectedType))
                return "Unknown Entity";

            if (IsPerson == false)
            {
                return !string.IsNullOrWhiteSpace(BusinessName) ? BusinessName.Trim() : "Unknown Business";
            }
            
            //check if any of the pieces of a full name are empty or whitespace
            var namesToCheck = new List<string> {LastName, FirstName, MiddleName, SelectedGenSuffix};
            return namesToCheck.Any(x => !string.IsNullOrWhiteSpace(x)) ? FullName : "Unknown Person";
        }
        
        public class PhoneNumber
        {
            public string Type { get; set; }
            public string Number { get; set; }

            public override string ToString()
            {
                return string.IsNullOrWhiteSpace(Type) ? "Unknown Number" : Type;
            }
        }
    }
}