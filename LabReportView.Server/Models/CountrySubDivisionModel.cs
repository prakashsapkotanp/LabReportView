﻿using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class CountrySubDivisionModel
    {
        [Key]
        public int? CountrySubDivisionId { get; set; }
        public int? CountryId { get; set; }
        public string CountrySubDivisionName { get; set; }
        public string CountrySubDivisionCode { get; set; }
        public string MapAreaCode { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IMU_CountrySubDivisonId { get; set; }
        public int? IMU_ProvinceId { get; set; }
    }
}
