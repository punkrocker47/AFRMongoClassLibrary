using System;
using System.Collections.Generic;

namespace AFRMongoClassLibrary.Models
{
    public class ReportVm
    {
        public bool IsSaved { get; set; }

        //Overview Information
        public int RNumber { get; set; }
        public bool IsStarted { get; set; }
        public bool IsSynced { get; set; }
        public string IncidentNumber { get; set; }
        public string OccurredOnOrBetween { get; set; }
        public DateTime? OccurredBeginDate { get; set; }
        public string BeginTime { get; set; }
        public DateTime? OccurredEndDate { get; set; }
        public string EndTime { get; set; }

        public ReportLocationVm ReportLocation { get; set; } = new ();
        
        public int? CurrentRelatedReportIndex { get; set; }
        public List<RelatedReportVm> RelatedReports { get; set; } = new ();

        public int? CurrentAdditionalAgencyIndex { get; set; }
        public List<AdditionalAgencyVm> AdditionalAgencies { get; set; } = new ();

        public int? CurrentEntityIndex { get; set; }
        public List<EntityVm> Entities { get; set; } = new();

        public int? CurrentVehicleIndex { get; set; }
        public List<VehicleVm> Vehicles { get; set; } = new();
    }
}