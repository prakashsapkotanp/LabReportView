﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class RadiologyImagingItemModel
    {
        [Key]
        public int? ImagingItemId { get; set; }
        public int? ImagingTypeId { get; set; }
        public string? ImagingItemName { get; set; }
        public string? ProcedureCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsValidForReporting { get; set; }
        public int? TemplateId { get; set; }

        public virtual RadiologyImagingTypeModel? ImagingTypes { get; set; }
    }
}