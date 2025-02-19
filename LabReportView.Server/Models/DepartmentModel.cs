using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class DepartmentModel
    {
        [Key]
        public int? DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int? DepartmentHead { get; set; }
        public string NoticeText { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAppointmentApplicable { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ParentDepartmentId { get; set; }
        public string RoomNumber { get; set; }
        [NotMapped]
        public List<BillServiceItemModel> ServiceItemsList { get; set; }
        [NotMapped]
        public string ParentDepartmentName { get; set; }
        public int? OpdNewPatientServiceItemId { get; set; }
        public int? OpdOldPatientServiceItemId { get; set; }
        public int? FollowupServiceItemId { get; set; }
    }
}
