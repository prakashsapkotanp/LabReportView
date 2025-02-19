using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class WardModel
    {
        [Key]
        public int? WardId { get; set; }
        public int? StoreId { get; set; }
        public string? WardCode { get; set; }
        public string? WardName { get; set; }
        public string? WardLocation { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}