using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ADTDischargeSummaryConsultantModel
    {
        [Key]
        public int? id { get; set; }
        public int? DischargeSummaryId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public int? ConsultantId { get; set; }
    }
}
