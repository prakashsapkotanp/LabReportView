using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ImagingReportModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int? ImagingReportId { get; set; }
        [Key, ForeignKey("ImagingRequisition")]
        public int? ImagingRequisitionId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public string? PrescriberName { get; set; }
        public int? ImagingTypeId { get; set; }
        public string? ImagingTypeName { get; set; }
        public int? ImagingItemId { get; set; }
        public string? ImagingItemName { get; set; }
        public string? ImageFullPath { get; set; }
        public string? ImageName { get; set; }
        public string? ReportText { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Signatories { get; set; }
        public string? OrderStatus { get; set; }
        public int? PrescriberId { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ReportTemplateId { get; set; }
        public string? PatientStudyId { get; set; }
        public virtual VisitModel? Visit { get; set; }
        public virtual PatientModel? Patient { get; set; }

        public string? Indication { get; set; }
        public string? RadiologyNo { get; set; }
        public int? PerformerId { get; set; }
        public long? PatientFileId { get; set; }
        public string? PerformerName { get; set; }

        public virtual ImagingRequisitionModel? ImagingRequisition { get; set; }

        [NotMapped]
        public string? PerformerNameInBilling { get; set; }
        [NotMapped]
        public int? PerformerIdInBilling { get; set; }
        public int? PrintCount { get; set; }
        public int? ReferredById { get; set; }
        public string? ReferredByName { get; set; }
        public string? ReportTemplateIdsCSV { get; set; }
        [NotMapped]
        public List<FooterText>? FooterTextsList { get; set; }
        public int? SelectedFooterTemplateId { get; set; }
    }
}
