using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class VisitModel
    {
        [Key]
        public int? PatientVisitId { get; set; }
        public string? VisitCode { get; set; }
        public int? PatientId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string? QueueStatus { get; set; }
        public int? PerformerId { get; set; }
        public string? PerformerName { get; set; }
        public string? Comments { get; set; }
        public string? ReferredBy { get; set; }
        public string? VisitType { get; set; }
        public string? VisitStatus { get; set; }
        public TimeSpan? VisitTime { get; set; }
        public int? VisitDuration { get; set; }
        public int? AppointmentId { get; set; }
        public string? BillingStatus { get; set; }
        public int? ReferredById { get; set; }
        public string? AppointmentType { get; set; }
        public int? ParentVisitId { get; set; }
        public bool? IsVisitContinued { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTriaged { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string? Remarks { get; set; }
        public Int64? ClaimCode { get; set; }
        public bool? IsSignedVisitSummary { get; set; }
        public int? PrescriberId { get; set; }
        public DateTime? ConcludeDate { get; set; }
        [NotMapped]
        public int? CurrentCounterId { get; set; }
        public int? DepartmentId { get; set; }

        [NotMapped]
        public string? DepartmentName { get; set; }

        public virtual PatientModel? Patient { get; set; }
        public virtual AdmissionModel? Admission { get; set; }
        public List<VitalsModel>? Vitals { get; set; }
        public List<InputOutputModel>? InputOutput { get; set; }
        public List<NotesModel>? Notes { get; set; }
        public List<ImagingRequisitionModel>? ImagingRequisitions { get; set; }
        public List<ImagingReportModel>? ImagingReports { get; set; }

        public int? QueueNo { get; set; }
        public bool? Ins_HasInsurance { get; set; }

        [NotMapped]
        public bool? IsLastClaimCodeUsed { get; set; }
        public int? PriceCategoryId { get; set; }
        public int? SchemeId { get; set; }

        public decimal? TicketCharge { get; set; }
        public int? SubSchemeId { get; set; }
        public bool? IsFreeVisit { get; set; }
        [NotMapped]
        public bool? IsManualFreeFollowup { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string? FollowUpRemarks { get; set; }
        public int? FollowUpDays { get; set; }
        public string? OtherInfo { get; set; }
    }
}