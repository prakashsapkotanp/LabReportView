using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class AddressModel
    {
        [Key]
        public int? PatientAddressId { get; set; }
        public int? PatientId { get; set; }
        public string? AddressType { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public int? CountryId { get; set; }
        public int? CountrySubDivisionId { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }

        [NotMapped]
        public string? CountryName { get; set; }
        [NotMapped]
        public string? CountrySubDivisionName { get; set; }

        public virtual PatientModel? Patient { get; set; }
    }


}
