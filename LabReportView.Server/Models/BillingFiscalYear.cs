using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BillingFiscalYear
    {
        [Key]
        public int? FiscalYearId { get; set; }
        public string? FiscalYearName { get; set; }
        public string? FiscalYearFormatted { get; set; }
        public DateTime? StartYear { get; set; }
        public DateTime? EndYear { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
