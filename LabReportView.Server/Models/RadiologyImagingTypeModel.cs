using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class RadiologyImagingTypeModel
    {
        [Key]
        public int? ImagingTypeId { get; set; }
        public string? ImagingTypeName { get; set; }
        public string? ProcedureCoding { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public virtual List<RadiologyImagingItemModel>? ImagingItems { get; set; }
    }
}