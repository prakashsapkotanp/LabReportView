using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BillMapPriceCategoryServiceItemModel
    {
        [Key]
        public int? PriceCategoryServiceItemMapId { get; set; }
        public int? PriceCategoryId { get; set; }
        public int? ServiceItemId { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public int? IntegrationItemId { get; set; }
        public decimal? Price { get; set; }
        public bool? IsDiscountApplicable { get; set; }
        public string ItemLegalCode { get; set; }
        public string ItemLegalName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPriceChangeAllowed { get; set; }
        public bool? IsZeroPriceAllowed { get; set; }
        public bool? HasAdditionalBillingItems { get; set; }
        public bool? IsCappingEnabled { get; set; }
        public int? CappingLimitDays { get; set; }
        public int? CappingQuantity { get; set; }

        public BillMapPriceCategoryServiceItemModel()
        {
            IsActive = true;
        }
    }
}
