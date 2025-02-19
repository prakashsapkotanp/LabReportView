using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class DischargeSummaryMedication
    {
        [Key]
        public int? DischargeSummaryMedicationId { get; set; }
        public int? DischargeSummaryId { get; set; }
        public int? OldNewMedicineType { get; set; }
        public string? Medicine { get; set; }
        public int? FrequencyId { get; set; }
        public string? Notes { get; set; }
        public bool? IsActive { get; set; }
    }
}
