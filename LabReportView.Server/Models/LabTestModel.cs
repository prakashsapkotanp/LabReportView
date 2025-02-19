using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class LabTestModel
    {
        [Key]
        public long? LabTestId { get; set; }
        public string? LabTestCode { get; set; }
        public int? LabSequence { get; set; }
        public string? ProcedureCode { get; set; }
        public string? LabTestName { get; set; }
        public string? LabTestShortName { get; set; }
        public string? LabTestSynonym { get; set; }
        public string? LabTestSpecimen { get; set; }
        public string? LabTestSpecimenSource { get; set; }
        public string? LOINC { get; set; }
        public int? ReportTemplateId { get; set; }
        public bool? IsValidForReporting { get; set; }
        public string? Description { get; set; }
        public int? DisplaySequence { get; set; }
        public string? RunNumberType { get; set; }

        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }

        public bool? HasNegativeResults { get; set; }
        public string? NegativeResultText { get; set; }
        public int? LabTestCategoryId { get; set; }
        public bool? SmsApplicable { get; set; }
        public virtual LabReportTemplateModel? LabReportTemplate { get; set; }
        public string? ReportingName { get; set; }

        public string? Interpretation { get; set; }

        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        [NotMapped]
        public bool? IsSelected { get; set; }
        [NotMapped]
        public bool? IsPreference { get; set; }

        [NotMapped]
        public bool? IsTaxApplicable { get; set; }
        [NotMapped]
        public List<LabTestJSONComponentModel>? LabTestComponentsJSON { get; set; }
        [NotMapped]
        public List<LabTestComponentMapModel>? LabTestComponentMap { get; set; }

        [NotMapped]
        public int? MyProperty { get; set; }

        [NotMapped]
        public int? ServiceDepartmentId { get; set; }

        [NotMapped]
        public string? TemplateType { get; set; }

        public bool? IsOutsourceTest { get; set; }

        public int? DefaultOutsourceVendorId { get; set; }
        public bool IsLISApplicable { get; set; }
    }
}