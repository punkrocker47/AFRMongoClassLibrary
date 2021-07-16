using AFRMongoClassLibrary.Models;
using MongoDB.Driver;

namespace AFRMongoClassLibrary.DataAccess
{
      public class AFRDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public AFRDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("AFRDB");
        }

        public IMongoCollection<AFRReportModel> AFRReportModelRecord
        {
            get { return _mongoDatabase.GetCollection<AFRReportModel>("AFRReportModels"); }
        }

        public IMongoCollection<ReportVm> ReportRecord
        {
            get { return _mongoDatabase.GetCollection<ReportVm>("ReportRecords"); }
        }
        
    }
}