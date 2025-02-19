using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LabReportView.Server.DTOs;

namespace LabReportView.Server.Models
{
    public class AdmissionModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? PatientAdmissionId { get; set; }

        [Key, ForeignKey("Visit")]
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public int? AdmittingDoctorId { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string? AdmissionNotes { get; set; }
        public string? AdmissionOrders { get; set; }
        public string? AdmissionStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public virtual VisitModel? Visit { get; set; }
        public string? BillStatusOnDischarge { get; set; }
        public string? DischargeRemarks { get; set; }
        public int? DischargedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CareOfPersonName { get; set; }
        public string? CareOfPersonPhoneNo { get; set; }
        public string? CareOfPersonRelation { get; set; }
        public virtual List<PatientBedInfo>? PatientBedInfos { get; set; }
        [NotMapped]
        public virtual BillingDepositModel? BilDeposit { get; set; }
        [NotMapped]
        public BillingTransactionModel? BillingTransaction { get; set; }

        [NotMapped]
        public int? RequestingDeptId { get; set; }
        public DateTime? CancelledOn { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledRemark { get; set; }

        public string? ProcedureType { get; set; }

        public bool? IsPoliceCase { get; set; }
        [NotMapped]
        public bool? Ins_HasInsurance { get; set; }
        [NotMapped]
        public Int64? ClaimCode { get; set; }
        [NotMapped]
        public string? Ins_NshiNumber { get; set; }
        public bool? IsInsurancePatient { get; set; }
        [NotMapped]
        public double? Ins_InsuranceBalance { get; set; }
        public int? DiscountSchemeId { get; set; }
        public string? AdmissionCase { get; set; }
        [NotMapped]
        public bool? IsBillingEnabled { get; set; }

        [NotMapped]
        public bool? IsLastClaimCodeUsed { get; set; }

        public double? ProvisionalDiscPercent { get; set; }
        public bool? IsItemDiscountEnabled { get; set; }
        [NotMapped]
        public int? PriceCategoryId { get; set; }
        [NotMapped]
        public virtual PatientSchemeMapModel? PatientSchemesMap { get; set; }
        [NotMapped]
        public CareofPersonDTO? CareTaker { get; set; }
        public bool? IsProvisionalDischarge { get; set; }
        public bool? IsProvisionalDischargeCleared { get; set; }
        [NotMapped]
        public required List<AddPatientVisitConsultantsDTO>? AddPatientVisitConsultants { get; set; }
    }
}
