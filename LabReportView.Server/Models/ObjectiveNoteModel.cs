﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class ObjectiveNoteModel
    {
        [Key]
        public int? ObjectiveNotesId { get; set; }
        public int? NotesId { get; set; }
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual PatientModel? Patients { get; set; }
        public int? PatientVisitId { get; set; }
        [ForeignKey("PatientVisitId")]
        public virtual VisitModel? Visits { get; set; }
        public string? HEENT { get; set; }
        public string? Chest { get; set; }
        public string? CVS { get; set; }
        public string? Abdomen { get; set; }
        public string? Extremity { get; set; }
        public string? Skin { get; set; }
        public string? Neurological { get; set; }

        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}