using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BillServiceItemModel
    {
        [Key]
        public int? ServiceItemId { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public int? IntegrationItemId { get; set; }
        public string IntegrationName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public bool? IsTaxApplicable { get; set; }
        public string Description { get; set; }
        public int? DisplaySeq { get; set; }
        public bool? IsDoctorMandatory { get; set; }
        public bool? IsOT { get; set; }
        public bool? IsProc { get; set; }
        public int? ServiceCategoryId { get; set; }
        public bool? AllowMultipleQty { get; set; }
        public string DefaultDoctorList { get; set; }
        public bool? IsValidForReporting { get; set; }
        public bool? IsErLabApplicable { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsIncentiveApplicable { get; set; }
        [NotMapped]
        public string ServiceDepartmentName { get; set; }
        [NotMapped]
        public List<BillMapPriceCategoryServiceItemModel> BilCfgItemsVsPriceCategoryMap { get; set; }
        public bool? IsInsurancePackage { get; set; }
        public string OTCategory { get; set; }
        public int? DynamicReportGroupId { get; set; }
    }
}
