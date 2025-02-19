using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class LabRequisitionModel
    {
        //[Key]
        //public Int64 RequisitionId { get; set; }
        //public int? PatientVisitId { get; set; }
        //public int? PatientId { get; set; }
        //public int? PrescriberId { get; set; }
        //public Int64? LabTestId { get; set; }
        //public string? ProcedureCode { get; set; }
        //public string? LOINC { get; set; }
        //public string? LabTestName { get; set; }
        //public string? LabTestSpecimen { get; set; }
        //public string? LabTestSpecimenSource { get; set; }
        //public string? PatientName { get; set; }
        //public string? Diagnosis { get; set; }
        //public string? Urgency { get; set; }
        //public DateTime? OrderDateTime { get; set; }
        //public string? PrescriberName { get; set; }
        //public string? BillingStatus { get; set; }
        //public string? OrderStatus { get; set; }
        //public int? SampleCode { get; set; }
        //public string? RequisitionRemarks { get; set; }
        //public DateTime? SampleCreatedOn { get; set; }
        //public DateTime? SampleCollectedOnDateTime { get; set; }
        //public int? SampleCreatedBy { get; set; }
        //public string? Comments { get; set; }
        //public string? RunNumberType { get; set; }
        //public string? ExternalLabSampleStatus { get; set; }
        //public bool? IsSmsSend { get; set; }
        //public List<LabTestComponentResult>? LabTestComponentResults { get; set; }
        //public virtual LabTestModel? LabTest { get; set; }
        //public virtual PatientModel? Patient { get; set; }
        //public int? ReportTemplateId { get; set; }
        //public int? DiagnosisId { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public int CreatedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public int? ModifiedBy { get; set; }
        //public bool? IsActive { get; set; }
        //public string? VisitType { get; set; }
        //public int? LabReportId { get; set; }
        //public Int64? BarCodeNumber { get; set; }
        //public string? WardName { get; set; }
        //public bool? IsVerified { get; set; }
        //public DateTime? VerifiedOn { get; set; }
        //public int? VerifiedBy { get; set; }
        //public int ResultingVendorId { get; set; }
        //public bool HasInsurance { get; set; }
        //public int? ResultAddedBy { get; set; }
        //public DateTime? ResultAddedOn { get; set; }
        //public int? PrintedBy { get; set; }
        //public int? PrintCount { get; set; }
        //public string? SampleCodeFormatted { get; set; }
        //public int? BillCancelledBy { get; set; }
        //public DateTime? BillCancelledOn { get; set; }
        //public string? LabTypeName { get; set; }
        //public string? GoogleFileId { get; set; }
        //public string? UploadedReportFileName { get; set; }
        //public bool? IsFileUploaded { get; set; }
        //public int? UploadedBy { get; set; }
        //public DateTime? UploadedOn { get; set; }
        //public bool? IsFileUploadedToTeleMedicine { get; set; }
        //public int? UploadedByToTeleMedicine { get; set; }
        //public DateTime? UploadedOnToTeleMedicine { get; set; }
        //public bool? IsUploadedToIMU { get; set; }
        //public DateTime? IMUUploadedOn { get; set; }
        //public int? IMUUploadedBy { get; set; }
        //public int? BillingTransactionItemId { get; set; }
        //public int? ServiceItemId { get; set; }
        //public DateTime? SampleReceivedOn { get; set; }
        //public bool? IsPreVerified { get; set; }
        //public int? PreVerifiedBy { get; set; }
        //public DateTime? PreVerifiedOn { get; set; }
        //public DateTime? CreatedDay { get; set; } = DateTime.Now.Date;



        [Key]
        public Int64 RequisitionId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public int? ProviderId { get; set; }
        public Int64? LabTestId { get; set; }
        public string? ProcedureCode { get; set; }
        public string? LOINC { get; set; }
        public string? LabTestName { get; set; }
        public string? LabTestSpecimen { get; set; }
        public string? LabTestSpecimenSource { get; set; }
        public string? PatientName { get; set; }
        public string? Diagnosis { get; set; }
        public string? Urgency { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public string? ProviderName { get; set; }
        public string? BillingStatus { get; set; }
        public string? OrderStatus { get; set; }
        public int? SampleCode { get; set; }
        public string? RequisitionRemarks { get; set; }
        public DateTime? SampleCreatedOn { get; set; }
        public DateTime? SampleCollectedOnDateTime { get; set; }
        public int? SampleCreatedBy { get; set; }
        public string? Comments { get; set; }
        public string? RunNumberType { get; set; }
        public bool? IsSmsSend { get; set; }
        public List<LabTestComponentResult>? LabTestComponentResults { get; set; }
        public virtual LabTestModel? LabTest { get; set; }
        public virtual PatientModel? Patient { get; set; }
        public int? ReportTemplateId { get; set; }
        public int? DiagnosisId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? CreatedDay { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? VisitType { get; set; }
        public int? LabReportId { get; set; }
        public Int64? BarCodeNumber { get; set; }
        public string? WardName { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public int? VerifiedBy { get; set; }
        public int ResultingVendorId { get; set; }
        public bool HasInsurance { get; set; }
        public int? ResultAddedBy { get; set; }
        public DateTime? ResultAddedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
        public string? SampleCodeFormatted { get; set; }
        public int? BillCancelledBy { get; set; }
        public DateTime? BillCancelledOn { get; set; }
        public string? LabTypeName { get; set; }
        public string? GoogleFileIdForCovid { get; set; }
        public string? CovidFileName { get; set; }
        public bool? IsFileUploaded { get; set; }
        public int? UploadedBy { get; set; }
        public DateTime? UploadedOn { get; set; }
        public bool? IsFileUploadedToTeleMedicine { get; set; }
        public int? UploadedByToTeleMedicine { get; set; }
        public DateTime? UploadedOnToTeleMedicine { get; set; }
        public bool? IsUploadedToIMU { get; set; }
        public DateTime? IMUUploadedOn { get; set; }
        public int? IMUUploadedBy { get; set; }
    }
}