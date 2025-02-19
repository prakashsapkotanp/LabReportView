using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabReportView.Server.Models
{
    public class PatientFilesModel
    {
        [Key]
        public long? PatientFileId { get; set; }
        public int? PatientId { get; set; }
        public Guid? ROWGUID { get; set; }
        public string? FileType { get; set; }
        public string? Title { get; set; }
        public DateTime? UploadedOn { get; set; }
        public int? UploadedBy { get; set; }
        public string? Description { get; set; }
        public int? FileNo { get; set; }
        public string? FileName { get; set; }
        public string? FileExtention { get; set; }

        public bool? IsActive { get; set; }

        [NotMapped]
        public string? FileBase64String { get; set; }

        [NotMapped]
        public bool? HasFile { get; set; }
        [NotMapped]
        public string? BinaryData { get; set; }
        [NotMapped]
        public string? PatientCode { get; set; }
    }
}