using System;
using System.Collections.Generic;
using AFRMongoClassLibrary.DataAccess;
using AFRMongoClassLibrary.Models;
using MongoDB.Driver;

namespace AFRMongoClassLibrary
{
    public class AFRMongoClassLibrary
    {
           public AFRDBContext db;

        public AFRMongoClassLibrary()
        {
            db = new AFRDBContext();
        }

        public List<int> GetAllReportNumbers()
        {
            var reportNumList = new List<int>();
             var reports = db.AFRReportModelRecord.FindAsync(x => x.IsDeleted == false).Result.ToList();

             foreach (var item in reports)
             {
                 reportNumList.Add(item.RNumber);
             }

             return reportNumList;
        }

        public void AddAFRReportModelRecord(AFRReportModel reportModel)
        {
            try
            {
                db.AFRReportModelRecord.InsertOne(reportModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex: " + ex.Message);
                throw;
            }
        }

        public void UpdateReport(AFRReportModel reportModel)
        {
            try
            {
                reportModel._id = db.AFRReportModelRecord.Find(g => g.RNumber == reportModel.RNumber).First()._id;
                db.AFRReportModelRecord.FindOneAndDelete(g => g.RNumber == reportModel.RNumber);
                db.AFRReportModelRecord.InsertOne(reportModel);
            }
            catch(Exception ex)
            {
                
                throw;
            }
        }

        public bool CheckIfRNumberExists(int reportNumber)
        {
            try
            {
                var reports = db.ReportRecord.Find(x => x.RNumber == reportNumber);
                var reportsList = reports.ToList();
                if (reportsList.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public AFRReportModel GetAFRReportModelByRNumber(int rNumber)
        {
            try
            {
                var afrModel = db.AFRReportModelRecord.Find(x => x.RNumber == rNumber).FirstOrDefault();

                return afrModel;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void UpdateEntities(List<EntityVm> entities)
        {
            var afrReportModel = db.AFRReportModelRecord.Find(X => X.RNumber == entities[0].RNumber);

            db.AFRReportModelRecord.FindOneAndDelete(x => x.RNumber == entities[0].RNumber);
            
        }
    }
}