using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class LabTestJSONComponentModel
    {
        [Key]
        public int? ComponentId { get; set; }
        public string? ComponentName { get; set; }
        public string? Unit { get; set; }
        public string? ValueType { get; set; }
        public string? ControlType { get; set; }
        public string? Range { get; set; }
        public string? MaleRange { get; set; }
        public string? FemaleRange { get; set; }
        public string? ChildRange { get; set; }
        public string? RangeDescription { get; set; }
        public string? Method { get; set; }
        public string? ValueLookup { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string? DisplayName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        [NotMapped]
        public int? DisplaySequence { get; set; }
        [NotMapped]
        public bool? IndentationCount { get; set; }
        [NotMapped]
        public int? ComponentMapId { get; set; }
        public int? ValuePrecision { get; set; }
        public bool? ShowRangeDescriptionInLabReport { get; set; }
    }
}