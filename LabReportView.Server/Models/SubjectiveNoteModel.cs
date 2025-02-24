﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class SubjectiveNoteModel
    {
        [Key]
        public int? SubjectiveNoteId { get; set; }
        public int? NotesId { get; set; }

        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual PatientModel? Patients { get; set; }
        public int? PatientVisitId { get; set; }
        [ForeignKey("PatientVisitId")]
        public virtual VisitModel? Visits { get; set; }

        public string? ChiefComplaint { get; set; }
        public string? HistoryOfPresentingIllness { get; set; }
        public string? ReviewOfSystems { get; set; }

        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}