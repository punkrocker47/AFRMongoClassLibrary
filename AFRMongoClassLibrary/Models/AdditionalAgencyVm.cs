using System.Collections.Generic;

namespace AFRMongoClassLibrary.Models
{
    public class AdditionalAgencyVm
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }

        public string OtherAddress { get; set; }

        public string OtherPhone { get; set; }

        public int? CurrentOfficerIndex  { get; set; }
        public List<AdditionalOfficerVm> Officers { get; set; } = new();

        public bool IsOther => !string.IsNullOrEmpty(Name) && Name.ToLower().StartsWith("other");

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name)) 
                return "Unknown Assisting Officer";
            if (IsOther) 
                return string.IsNullOrEmpty(OtherName) ? "Other Agency" : OtherName;
            
            return Name;
        }
    }
}