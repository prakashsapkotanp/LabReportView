using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class ReportLookUp
    {
        public class ReportLookup
        {
            public int? PatientId { get; set; }
            public string? PatientName { get; set; }
            public string? PatientCode { get; set; }
            public string? Gender { get; set; }
            public DateTime? DOB { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Address { get; set; }
            public string? MunicipalityName { get; set; }
            public string? CountrySubDivisionName { get; set; }
            public string? CountryName { get; set; }
            public string? WardNumber { get; set; }
            public int? PrescriberId { get; set; }
            public string? PrescriberName { get; set; }
            public DateTime? ReceivingDate { get; set; }
            public DateTime? ReportingDate { get; set; }
            public DateTime? SampleDate { get; set; }
            public int? SampleCode { get; set; }
            public DateTime? VerifiedOn { get; set; }
            public string? SampleCodeFormatted { get; set; }
            public string? VisitType { get; set; }
            public string? RunNumberType { get; set; }
            public string? Specimen { get; set; }
            public string? LabTypeName { get; set; }
            public string? ProfilePictureName { get; set; }
            public string? PassPortNumber { get; set; }
            public string? WardName { get; set; }
            public string? PolicyNumber { get; set; }
            public int? ReferredById { get; set; }
            [NotMapped]
            public string? ReferredByName { get; set; }
        }
    }
}