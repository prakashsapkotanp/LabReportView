using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class PrescriptionNotesModel
    {
        [Key]
        public int? PrescriptionNoteId { get; set; }
        public int? NotesId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? PrescriptionNoteText { get; set; }
        public string? OldMedicationStopped { get; set; }
        public string? NewMedicationStarted { get; set; }
        public string? ICDRemarks { get; set; }
        public string? ICDSelected { get; set; }
        public string? OrdersSelected { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}