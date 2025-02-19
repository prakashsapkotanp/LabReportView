using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class LabReport
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientCode { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? PrescriberId { get; set; }
        public string PrescriberName { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public DateTime? ReportingDate { get; set; }
        public DateTime? SampleDate { get; set; }
        public int? SampleCode { get; set; }
        public string SampleCodeFormatted { get; set; }
        public string RunNumberType { get; set; }
        public string CountrySubDivisionName { get; set; }
        public string MunicipalityName { get; set; }
        public string CountryName { get; set; }

        public string PassPortNumber { get; set; }
        public string WardName { get; set; }
        public string WardNumber { get; set; }

        //Lab Report
        public int? LabReportId { get; set; }
        public int? TemplateId { get; set; }
        public bool? IsPrinted { get; set; }
        public string Signatories { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ReportCreatedOn { get; set; }
        public int? ReportCreatedBy { get; set; }
        public bool? IsActive_Test { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ReferredByDr { get; set; }
        public string LabReportComments { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
        public string PrintedByName { get; set; }

        //Requisition + LabTests
        public int? PatientVisitId { get; set; }
        public int? ProviderId { get; set; }
        public Int64 LabTestId { get; set; }
        public string LabTestName { get; set; }
        public string LabTestSpecimen { get; set; }
        public string LabTestSpecimenSource { get; set; }
        public string Urgency { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public string ProviderName { get; set; }
        public string BillingStatus { get; set; }
        public string Specimen { get; set; }
        public string OrderStatus { get; set; }
        public string RequisitionRemarks { get; set; }
        public DateTime? SampleCreatedOn { get; set; }
        public int? SampleCreatedBy { get; set; }
        public string Comments { get; set; }
        public int ReportTemplateId { get; set; }
        public int? DiagnosisId { get; set; }
        public object LabTestComponentsJSON { get; set; }
        public string Description { get; set; }
        public int? TestDisplaySequence { get; set; }
        public bool? HasNegativeResults { get; set; }
        public string NegativeResultText { get; set; }
        public string ReportingName { get; set; }
        public string Interpretation { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public string CovidFileUrl { get; set; }

        //Test Component Result
        public Int64? TestComponentResultId { get; set; }
        public Int64 RequisitionId { get; set; }
        public int ResultingVendorId { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public string Range { get; set; }
        public string ComponentName { get; set; }
        public string Method { get; set; }
        public string Remarks { get; set; }
        public string RangeDescription { get; set; }
        public bool IsNegativeResult { get; set; }
        public bool IsAbnormal { get; set; }
        public bool? IsActive_Component { get; set; }
        public int? ResultGroup { get; set; }


        //LabReportTemplateModel
        public string ReportTemplateShortName { get; set; }
        public string ReportTemplateName { get; set; }
        public bool? IsDefault { get; set; }
        public string HeaderText { get; set; }
        public string ColSettingsJSON { get; set; }
        public string TemplateType { get; set; }
        public string TemplateHTML { get; set; }
        public string FooterText { get; set; }
        public int? TemplateDisplaySequence { get; set; }

        public string VisitType { get; set; }

        public bool HasInsurance { get; set; }
        public string AbnormalType { get; set; }
        public string LabTypeName { get; set; }

        public string Email { get; set; }
        public bool? IsFileUploadedToTeleMedicine { get; set; }
        public bool IsLISApplicable { get; set; }
        public int? ReferredById { get; set; }
        [NotMapped]
        public string ReferredByName { get; set; }
    }
}
