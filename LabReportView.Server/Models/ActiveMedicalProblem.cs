using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ActiveMedicalProblem
    {
        [Key]
        public int? PatientProblemId { get; set; }
        public string? CurrentStatus { get; set; }
        public string? Note { get; set; }
        public DateTime? OnSetDate { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public bool? IsResolved { get; set; }
        public bool? PrincipleProblem { get; set; }
        public virtual PatientModel? Patient { get; set; }
    }
}
