﻿using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class SocialHistory
    {
        [Key]
        public int? SocialHistoryId { get; set; }
        public int? PatientId { get; set; }
        public string? SmokingHistory { get; set; }
        public string? AlcoholHistory { get; set; }
        public string? DrugHistory { get; set; }
        public string? Occupation { get; set; }
        public string? FamilySupport { get; set; }
        public string? Note { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public virtual PatientModel? Patient { get; set; }
    }
}