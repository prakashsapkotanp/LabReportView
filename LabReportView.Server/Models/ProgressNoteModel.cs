using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ProgressNoteModel
    {
        [Key]
        public int? ProgressNoteId { get; set; }
        public int? NotesId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? SubjectiveNotes { get; set; }
        public string? ObjectiveNotes { get; set; }
        public string? AssessmentPlan { get; set; }
        public string? Instructions { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}