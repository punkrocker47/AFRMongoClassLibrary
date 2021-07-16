using System.Collections.Generic;

namespace AFRMongoClassLibrary.Models
{
    public class WatercraftDetailsVm
    {
        public string SelectedVesselStyle { get; set; }

        public string SelectedVesselColor { get; set; }
        public string SelectedVesselRegistrationStateParent { get; set; }
        public bool RegistrationStateParentHasChildren { get; set; }
        public string SelectedVesselRegistrationState { get; set; }

        public string SelectedVesselInspectionCertificate { get; set; }

        public string SelectedVesselInspectedVentilation { get; set; }

        public string SelectedVesselRegistrationDecal { get; set; }

        public IList<string> SelectedVesselInspectionFireExtinguishers { get; set; }

        public IList<string> SelectedVesselInspectionNavigationLights { get; set; }

        public IList<string> SelectedVesselInspectionRegistrations { get; set; }

        public IList<string> SelectedVesselInspectionLifeSavingDevices { get; set; }

        public IList<string> SelectedVesselInspectionSoundDevices { get; set; }

        public IList<string> SelectedVesselInspectionNumberings { get; set; }
        public string VesselRegistration { get; set; }
        public string VesselExpiration { get; set; }
        public bool VesselInspectionRequested { get; set; }
        public bool VesselInspectionApproved { get; set; }
        public int? VesselLength { get; set; }
        public bool SoundLevelExceedsLegalLimits { get; set; }
    }
}