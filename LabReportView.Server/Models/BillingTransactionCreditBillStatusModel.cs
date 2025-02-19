﻿using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BillingTransactionCreditBillStatusModel
    {
        [Key]
        public int? BillingCreditBillStatusId { get; set; }
        public int? FiscalYearId { get; set; }
        public int? BillingTransactionId { get; set; }
        public string? InvoiceNoFormatted { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? PatientVisitId { get; set; }
        public int? SchemeId { get; set; }
        public string? LiableParty { get; set; }
        public int? PatientId { get; set; }
        public int? CreditOrganizationId { get; set; }
        public string? MemberNo { get; set; }
        public decimal? SalesTotalBillAmount { get; set; }
        public decimal? ReturnTotalBillAmount { get; set; }
        public decimal? CoPayReceivedAmount { get; set; }
        public decimal? CoPayReturnAmount { get; set; }
        public decimal? NetReceivableAmount { get; set; }
        public decimal? NonClaimableAmount { get; set; }
        public bool? IsClaimable { get; set; }
        public int? ClaimSubmissionId { get; set; }
        public long? ClaimCode { get; set; }
        public int? SettlementId { get; set; }
        public string? SettlementStatus { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDocumentReceived { get; set; }
        public string? Remarks { get; set; }
        public DateTime? DocumentReceivedDate { get; set; }
    }
}
