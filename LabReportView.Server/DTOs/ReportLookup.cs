namespace LabReportView.Server.DTOs
{
    public class ReportLookup
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientCode { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string MunicipalityName { get; set; }
        public string CountrySubDivisionName { get; set; }
        public int? ReferredById { get; set; }
        public string ReferredBy { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public DateTime? ReportingDate { get; set; }
        public DateTime? SampleDate { get; set; }
        public int? SampleCode { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public string SampleCodeFormatted { get; set; }
        public string VisitType { get; set; }
        public string RunNumberType { get; set; }
        public string Specimen { get; set; }
        public string LabTypeName { get; set; }
    }
}
