using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class AllergyModel
    {
        [Key]
        public int? PatientAllergyId { get; set; }
        public int? PatientId { get; set; }
        public int? AllergenAdvRecId { get; set; }
        public string? AllergenAdvRecName { get; set; }
        public string? AllergyType { get; set; }
        public string? Severity { get; set; }
        public bool? Verified { get; set; }
        public string? Reaction { get; set; }
        public string? Comments { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public virtual PatientModel? Patient { get; set; }
    }
}
