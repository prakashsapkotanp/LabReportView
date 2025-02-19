﻿using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class CountryModel
    {
        [Key]
        public int? CountryId { get; set; }
        public string CountryShortName { get; set; }
        public string CountryName { get; set; }
        public string ISDCode { get; set; }
        public string CountrySubDivisionType { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
