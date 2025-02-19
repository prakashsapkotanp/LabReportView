﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BedFeature
    {
        [Key]
        public int? BedFeatureId { get; set; }
        public string? BedFeatureCode { get; set; } // Sud:28Mar'23--for new billing structure.
        public string? BedFeatureName { get; set; }
        public string? BedFeatureFullName { get; set; }
        public double? BedPrice { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        [NotMapped]
        public bool? TaxApplicable { get; set; }

        [NotMapped]
        public int? ServiceDepartmentId { get; set; }

        public bool? IsPresentationGrouping { get; set; }
        public string? GroupCode { get; set; }
    }
}
