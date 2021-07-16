using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AFRMongoClassLibrary.Models
{
    public class AFRReportModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IsSaved { get; set; }
        
        public int RNumber { get; set; }
        public ReportVm Report { get; set; } = new();
    }
}