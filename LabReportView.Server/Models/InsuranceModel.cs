using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class InsuranceModel
    {
        [Key]
        public int? PatientInsuranceInfoId { get; set; }
        public int? PatientId { get; set; }
        public string? InsuranceNumber { get; set; }
        public string? InsuranceName { get; set; }
        public string? CardNumber { get; set; }
        public string? SubscriberFirstName { get; set; }
        public string? SubscriberLastName { get; set; }
        public string? SubscriberGender { get; set; }
        public DateTime? SubscriberDOB { get; set; }
        public string? SubscriberIDCardNumber { get; set; }
        public string? SubscriberIDCardType { get; set; }
        public string? IMISCode { get; set; }
        public double? InitialBalance { get; set; }
        public double? CurrentBalance { get; set; }
        public int? InsuranceProviderId { get; set; }

        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        [NotMapped]
        public string? InsuranceProviderName { get; set; }
        public virtual PatientModel? Patient { get; set; }
        public bool? Ins_HasInsurance { get; set; }
        public string? Ins_NshiNumber { get; set; }
        public double? Ins_InsuranceBalance { get; set; }
        public int? Ins_InsuranceProviderId { get; set; }
        public bool? Ins_IsFamilyHead { get; set; }
        public string? Ins_FamilyHeadNshi { get; set; }
        public string? Ins_FamilyHeadName { get; set; }
        public bool? Ins_IsFirstServicePoint { get; set; }
        [NotMapped]
        public int? PatientVisitId { get; set; }
        [NotMapped]
        public int? AdmittingDoctorId { get; set; }
    }
}
