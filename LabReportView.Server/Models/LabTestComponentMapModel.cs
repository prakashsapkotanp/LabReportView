﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class LabTestComponentMapModel
    {

        [Key]
        public int? ComponentMapId { get; set; }
        public Int64? LabTestId { get; set; }
        public int? ComponentId { get; set; }
        public int? DisplaySequence { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool? IsActive { get; set; }

        public string? GroupName { get; set; }

        public int? IndentationCount { get; set; }
        public bool? ShowInSheet { get; set; }

        public bool? IsAutoCalculate { get; set; }

        public string? CalculationFormula { get; set; }

        public string? FormulaDescription { get; set; }
    }
}
