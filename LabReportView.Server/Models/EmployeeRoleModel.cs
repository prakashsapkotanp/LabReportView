using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class EmployeeRoleModel
    {
        [Key]
        public int? EmployeeRoleId { get; set; }
        public string? EmployeeRoleName { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
