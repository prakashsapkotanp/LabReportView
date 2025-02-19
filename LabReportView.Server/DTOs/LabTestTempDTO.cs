using LabReportView.Server.Models;

namespace LabReportView.Server.DTOs
{
    public class LabTestTempDTO
    {
        public string? TestName { get; set; }
        public string? ReportingName { get; set; }
        public long? RequisitionId { get; set; }
        public long? LabTestId { get; set; }
        public List <ComponentJSONDTO> ComponentJSON { get; set; }
        public bool? HasNegativeResults { get; set; }
        public string? NegativeResultText { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Comments { get; set; }
        public int? DisplaySequence { get; set; }
        public string? Interpretation { get; set; }
        public List<LabTestComponentResult>? Components { get; set; }
        public string? Specimen { get; set; }
        public string? SampleCollectedBy { get; set; }
        public DateTime? SampleCollectedOn { get; set; }
        public LabVendorsModel? VendorDetail { get; set; }
        public bool? HasInsurance { get; set; }
        public string? BillingStatus { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public int? ResultingVendorId { get; set; }
        public int? MaxResultGroup { get; set; }
        public bool? IsLISApplicable { get; set; }
    }
}
