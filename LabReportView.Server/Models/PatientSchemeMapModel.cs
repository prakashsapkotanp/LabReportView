﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class PatientSchemeMapModel
    {
        [Key]
        public int? PatientSchemeId { get; set; }
        public int? PatientId { get; set; }
        public string? PatientCode { get; set; }
        public int? LatestPatientVisitId { get; set; }
        public int? SchemeId { get; set; }
        public string? PolicyNo { get; set; }
        public decimal? OpCreditLimit { get; set; }
        public decimal? IpCreditLimit { get; set; }
        public decimal? GeneralCreditLimit { get; set; }
        public string? PolicyHolderEmployerName { get; set; }
        public string? RegistrationCase { get; set; }
        public string? RegistrationSubCase { get; set; }
        public long? LatestClaimCode { get; set; }
        public string? OtherInfo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? PolicyHolderEmployerID { get; set; }
        public string? PolicyHolderUID { get; set; }
        public int? SubSchemeId { get; set; }
        public string? Ins_FirstServicePoint { get; set; }
        public int? PriceCategoryId { get; set; }
    }
}