using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BedModel
    {
        [Key]
        public int? BedId { get; set; }
        public string? BedCode { get; set; }
        public string? BedNumber { get; set; }
        public int? WardId { get; set; }
        public bool? IsOccupied { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? HoldedOn { get; set; }
        public bool? IsActive { get; set; }
        public WardModel? Ward { get; set; }
        public bool? IsReserved { get; set; }
        public bool? OnHold { get; set; }
        [NotMapped]
        public string? BedNumFrm { get; set; }
        [NotMapped]
        public int? BedNumTo { get; set; }
    }
}
