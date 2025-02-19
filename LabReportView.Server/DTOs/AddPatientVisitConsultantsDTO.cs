namespace LabReportView.Server.DTOs
{
    public class AddPatientVisitConsultantsDTO
    {
        public string VisitType { get; set; }
        public int ConsultantId { get; set; }
        public bool IsPrimaryConsultant { get; set; }
    }
}
