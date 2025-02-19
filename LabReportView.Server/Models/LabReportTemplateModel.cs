using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class LabReportTemplateModel
    {
        [Key]
        public int ReportTemplateID { get; set; }
        public string? ReportTemplateShortName { get; set; }
        public string? ReportTemplateName { get; set; }
        public string? TemplateFileName { get; set; }
        public string? NegativeTemplateFileName { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? HeaderText { get; set; }
        public string? ColSettingsJSON { get; set; }
        public string? TemplateType { get; set; }
        public string? TemplateHTML { get; set; }
        public string? FooterText { get; set; }
        public string? Description { get; set; }
        public int? DisplaySequence { get; set; }
    }
}