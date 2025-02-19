using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class EmployeeTypeModel
    {
        [Key]
        public int? EmployeeTypeId { get; set; }
        public string? EmployeeTypeName { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
