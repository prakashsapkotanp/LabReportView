﻿using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class ImagingRequisitionModel
    {
        [Key]
        public int? ImagingRequisitionId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public string? PrescriberName { get; set; }
        public int? ImagingTypeId { get; set; }
        public string? ImagingTypeName { get; set; }
        public int? ImagingItemId { get; set; }
        public string? ImagingItemName { get; set; }
        public string? ProcedureCode { get; set; }
        public DateTime? ImagingDate { get; set; }
        public string? RequisitionRemarks { get; set; }
        public string? OrderStatus { get; set; }
        public int? PrescriberId { get; set; }
        public string? BillingStatus { get; set; }
        public string? Urgency { get; set; }

        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public int? DiagnosisId { get; set; }

        public string? WardName { get; set; }

        public bool? IsActive { get; set; }
        public int? BillCancelledBy { get; set; }
        public DateTime? BillCancelledOn { get; set; }
        public bool? IsReportSaved { get; set; }
        public virtual VisitModel? Visit { get; set; }

        public virtual PatientModel? Patient { get; set; }

        public virtual ImagingReportModel? ImagingReport { get; set; }
        public virtual RadiologyImagingItemModel? ImagingItem { get; set; }
        public bool? HasInsurance { get; set; }
        public bool? IsScanned { get; set; }
        public int? ScannedBy { get; set; }
        public DateTime? ScannedOn { get; set; }
        public string? ScanRemarks { get; set; }
        public int? FilmTypeId { get; set; }
        public int? FilmQuantity { get; set; }
        public int? BillingTransactionItemId { get; set; }
        public int? ServiceItemId { get; set; }
    }
}
