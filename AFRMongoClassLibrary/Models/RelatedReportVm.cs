namespace AFRMongoClassLibrary.Models
{
    public class RelatedReportVm
    {
        public string ReportNumber { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return ReportNumber == null
                ? "Unknown Report" : ReportNumber.ToString();
        }
    }
}