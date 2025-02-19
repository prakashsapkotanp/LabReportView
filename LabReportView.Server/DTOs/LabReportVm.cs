using static LabReportView.Server.Models.ReportLookUp;

namespace LabReportView.Server.DTOs
{
    public class LabReportVm
    {
        public string Header { get; set; }
        public ReportLookup Lookups { get; set; }
        public string Columns { get; set; }
        public int? ReportId { get; set; }
        public string Signatories { get; set; }
        public int TemplateId { get; set; }
        public string TemplateType { get; set; }
        public string TemplateHTML { get; set; }
        public string TemplateName { get; set; }
        public string FooterText { get; set; }
        public string Comments { get; set; }
        public bool? IsPrinted { get; set; }
        public bool ValidToPrint { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ReportCreatedOn { get; set; }
        public int? ReportCreatedBy { get; set; }
        public Int64? BarCodeNumber { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
        public string PrintedByName { get; set; }
        public bool HasInsurance { get; set; }
        public List<LabReportTemplateVM> Templates { get; set; }
        public string CovidFileUrl { get; set; }

        public string Email { get; set; }
        public bool? IsFileUploadedToTeleMedicine { get; set; }
        public int? ResultAddedBy { get; set; }
    }
}
