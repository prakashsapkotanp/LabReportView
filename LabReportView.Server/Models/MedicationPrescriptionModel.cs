using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class MedicationPrescriptionModel
    {
        [Key]
        public int? MedicationPrescriptionId { get; set; }
        public int? PatientId { get; set; }
        public int? MedicationId { get; set; }
        [NotMapped]
        public string? MedicationName { get; set; }
        public int? PerformerId { get; set; }
        [NotMapped]
        public string? PerformerName { get; set; }
        public string? Route { get; set; }
        public int? Duration { get; set; }
        public string? DurationType { get; set; }
        public string? Dose { get; set; }
        public string? Frequency { get; set; }
        public int? Refill { get; set; }
        public string? TypeofMedication { get; set; }
        [NotMapped]
        public bool? IsSelected { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public virtual PatientModel? Patient { get; set; }
    }
}