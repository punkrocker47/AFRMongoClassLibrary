using System;
using System.Collections.Generic;
using System.Linq;

namespace AFRMongoClassLibrary.Models
{
    public class ReportEntityDetailsVm
    {
           //Additional Details
        public string SelectedGlasses { get; set; }
        public string SelectedComplexion { get; set; }
        public string SelectedBuild { get; set; }
        public string SelectedRightLeftHanded { get; set; }
        public string SelectedHairDescriptorOne { get; set; }
        public string SelectedHairDescriptorTwo { get; set; }
        public string SelectedFacialHairColor { get; set; }
        public string SelectedFacialHairDescriptorOne { get; set; }
        public string HairDescriptorOneOther { get; set; }
        public string SelectedFacialHairDescriptorTwo { get; set; }
        public string SelectedDental { get; set; }
        public string SelectedDentalRecords { get; set; }
        public string SelectedSpeech { get; set; }
        public string SpeechOther { get; set; }
        public string SelectedUnusualBodyOdor { get; set; }
        public string DescribeUnusualBodyOdor { get; set; }
        public string PassportNumber { get; set; }
        public string SSN { get; set; }
        public string UCNFBINumber { get; set; }
        public string SIDNumber { get; set; }
        public string SelectedDNAAvailable { get; set; }
        public string SelectedSexOffender { get; set; }
        public string SelectedCountryOfResidency { get; set; }
        public string PermanentResidentInsNo { get; set; }
        public string ImmigrantVisaNumber { get; set; }
        public string SelectedCountryOfBirth { get; set; }
        public string PlaceOfBirthCityState { get; set; }
        public string SelectedMaritalStatus { get; set; }
        public string SelectedIceCode { get; set; }
        
        
        //GANG AFFILIATIONS//
        public int CurrentGangAffiliationIndex {get ; set;} = 0;
        public List<GangAffiliationVm> GangAffiliations { get; set; } = new();

        public class GangAffiliationVm
        {
            public string SelectedGroupType { get; set; }
            public string SelectedStatus { get; set; }
            public string SelectedPosition { get; set; }
            public string GroupName { get; set; }

            public override string ToString()
            {
                return !string.IsNullOrEmpty(SelectedGroupType) ? SelectedGroupType : "Unknown Gang Affiliation";
            }
        }
        
        //EMPLOYER / SCHOOL//
        public int CurrentEmployerSchoolIndex {get ; set;} = 0;
        public List<EmployerSchoolVm> EmployerSchools { get; set; } = new();
        public class EmployerSchoolVm
        {
            public string SelectedEmployerSchool { get; set; }
            public DateTime? EmployerCurrentAsOf { get; set; }
            public string SelectedOccupation { get; set; }
            public string EmployerSchoolNo2 { get; set; }

            public override string ToString()
            {
                return !string.IsNullOrEmpty(SelectedEmployerSchool) ? SelectedEmployerSchool : "Unknown Occupation";
            }
        }
        
        //ADULT RELATIVES//
        public int CurrentAdultRelativeIndex {get ; set;} = 0;
        public List<NearestAdultRelativesVm> NearestAdultRelatives { get; set; } = new();
        public class NearestAdultRelativesVm
        {
            public string SelectedNearestAdultRelative { get; set; }
            public bool UnknownNearestAdultRelative { get; set; } = true;
            public string SelectedRelationship { get; set; }

            public override string ToString()
            {
                return !string.IsNullOrEmpty(SelectedNearestAdultRelative) ? SelectedNearestAdultRelative : "Unknown Relative";
            }
        }

        //ALIASES//
        public int CurrentAliasIndex {get ; set;} = 0;
        public List<AliasVm> Aliases { get; set; } = new();
        
        public class AliasVm
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string SelectedGenSuffix { get; set; }
            public string DisplayName => $"{LastName} {FirstName} {MiddleName} {SelectedGenSuffix}";
            public DateTime? DOB { get; set; }
            public string SSN { get; set; }
            public string MonikerNickname { get; set; }

            public override string ToString()
            {
                var namesToCheck = new List<string> {LastName, FirstName, MiddleName, SelectedGenSuffix};
                return namesToCheck.Any(x => !string.IsNullOrWhiteSpace(x)) ? DisplayName : "Unknown Alias";
            }
        }
        
        //CLOTHING//
        public int CurrentClothingIndex {get ; set;} = 0;
        public List<ClothingVm> Clothing { get; set; } = new();
        public class ClothingVm
        {
            public string SelectedType { get; set; }
            public string SelectedColorOne { get; set; }
            public string SelectedColorTwo { get; set; }
            public string SelectedMaterial { get; set; }
            public string Make { get; set; }
            public string DescriptionRemarks { get; set; }
            public override string ToString()
            {
                return !string.IsNullOrEmpty(SelectedType) ? SelectedType : "Unknown Clothing";
            }
        }
        
        //SMTP//
        public int CurrentSMTPIndex {get ; set;} = 0;
        public List<SMTPVm> SMTPList { get; set; } = new();
        public class SMTPVm
        {
            public string SelectedType { get; set; }
            public string SelectedLocation { get; set; }
            public string SelectedClassification { get; set; }
            public string Size { get; set; }
            public string Description { get; set; }
            public override string ToString()
            {
                return !string.IsNullOrEmpty(SelectedType) ? SelectedType : "Unknown SMTP";
            }
        }
    }
}