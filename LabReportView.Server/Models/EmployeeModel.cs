using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class EmployeeModel
    {
        [Key]
        public int? EmployeeId { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? ImageFullPath { get; set; } = string.Empty;
        public string? ImageName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? ContactNumber { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? ContactAddress { get; set; } = string.Empty;
        public bool? IsActive { get; set; }
        public string? Salutation { get; set; } = string.Empty;
        public int? DepartmentId { get; set; }
        public int? EmployeeRoleId { get; set; }
        public int? EmployeeTypeId { get; set; }

        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Gender { get; set; } = string.Empty;

        public string? FullName { get; set; } = string.Empty;
        public Int16? Extension { get; set; }
        public Int16? SpeedDial { get; set; }
        public string? OfficeHour { get; set; } = string.Empty;
        public string? RoomNo { get; set; } = string.Empty;
        public string? MedCertificationNo { get; set; } = string.Empty;
        public string? Signature { get; set; } = string.Empty;
        public string? LongSignature { get; set; } = string.Empty;

        public virtual DepartmentModel? Department { get; set; }
        public virtual EmployeeRoleModel? EmployeeRole { get; set; }
        public virtual EmployeeTypeModel? EmployeeType { get; set; }

        public bool? IsAppointmentApplicable { get; set; }
        public string? LabSignature { get; set; } = string.Empty;

        public string? RadiologySignature { get; set; } = string.Empty;

        public string? BloodGroup { get; set; } = string.Empty;
        public string? DriverLicenseNo { get; set; } = string.Empty;
        public string? NursingCertificationNo { get; set; } = string.Empty;
        public string? HealthProfessionalCertificationNo { get; set; } = string.Empty;
        public int? DisplaySequence { get; set; }

        public string? SignatoryImageName { get; set; } = string.Empty;

        [NotMapped]
        public string? SignatoryImageBase64 { get; set; }
        public bool? IsExternal { get; set; }
        [NotMapped]
        public List<BillServiceItemModel>? ServiceItemsList { get; set; }

        [NotMapped]
        public int? LedgerId { get; set; }
        [NotMapped]
        public string? LedgerType { get; set; }

        public double? TDSPercent { get; set; }
        public bool? IsIncentiveApplicable { get; set; }
        public string? PANNumber { get; set; } = string.Empty;
        //public int? OpdNewPatientServiceItemId { get; set; }
        //public int? OpdOldPatientServiceItemId { get; set; }
        //public int? FollowupServiceItemId { get; set; }
        //public int? InternalReferralServiceItemId { get; set; }

    }
}