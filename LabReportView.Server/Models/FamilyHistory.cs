using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class FamilyHistory
    {
        [Key]
        public int? FamilyProblemId { get; set; }

        public string? Relationship { get; set; }
        public string? Note { get; set; }
        public virtual PatientModel? Patient { get; set; }
    }
}
