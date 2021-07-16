namespace AFRMongoClassLibrary.Models
{
    public class AdditionalOfficerVm
    {
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName)
                ? "Unknown Assisting Officer" : $"{FirstName} {LastName}".Trim();
        }
    }
}