using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ClinicalDiagnosisModel
    {
        [Key]
        public int? DiagnosisId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }

        [NotMapped]
        public int? ICD10ID { get; set; }
        public int? NotesId { get; set; }

        [NotMapped]
        public string ICD10Description { get; set; }
        public string DiagnosisCodeDescription { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisType { get; set; }

        [NotMapped]
        public string ICD10Code { get; set; }
        public bool? IsCauseOfDeath { get; set; }
        public string Remarks { get; set; }
        public string ModificationHistory { get; set; }

        [NotMapped]
        public List<LabRequisitionModel> AllIcdLabOrders { get; set; } = new List<LabRequisitionModel>();
        [NotMapped]
        public List<ImagingRequisitionModel> AllIcdImagingOrders { get; set; } = new List<ImagingRequisitionModel>();
        [NotMapped]
        public List<PHRMPrescriptionItemModel> AllIcdPrescriptionOrders { get; set; } = new List<PHRMPrescriptionItemModel>();

        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
