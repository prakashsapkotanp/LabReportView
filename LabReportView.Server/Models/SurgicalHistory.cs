using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class SurgicalHistory
    {

        [Key]
        public int? SurgicalHistoryId { get; set; }
        public string? SurgeryType { get; set; }
        public string? Note { get; set; }
        public DateTime? SurgeryDate { get; set; }
        public virtual PatientModel? Patient { get; set; }
    }
}
