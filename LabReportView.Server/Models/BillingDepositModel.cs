using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BillingDepositModel
    {
        [Key]
        public int? DepositId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public int? BillingTransactionId { get; set; }
        public string? TransactionType { get; set; }
        public decimal? InAmount { get; set; }
        public decimal? OutAmount { get; set; }
        public string? Remarks { get; set; }
        public int? DepositHeadId { get; set; }
        public int? CreditOrganizationId { get; set; }
        public string? ModuleName { get; set; }
        public string? OrganizationOrPatient { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? FiscalYearId { get; set; }
        public int? ReceiptNo { get; set; }
        public int? CounterId { get; set; }
        public int? PrintCount { get; set; }
        public string? PaymentMode { get; set; }
        public string? PaymentDetails { get; set; }
        public string? VisitType { get; set; }

        [NotMapped]
        public string? FiscalYear { get; set; }
        [NotMapped]
        public string? BillingUser { get; set; }
        public BillingTransactionModel? BillingTransaction { get; set; }
        public int? SettlementId { get; set; }

        public decimal? DepositBalance { get; set; }

        public bool? IsActive { get; set; }
        public bool? IsTransferTransaction { get; set; }
        public string? ModifiedRemarks { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public string? CareOf { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public bool? IsDepositRefundedUsingDepositReceiptNo { get; set; }
        [NotMapped]
        public List<EmpCashTransactionModel>? empCashTransactionModel { get; set; }
        [NotMapped]
        public int? SelectedDepositId { get; set; }
        public int? StoreId { get; set; }
        public int? InvoiceId { get; set; }
        [NotMapped]
        public List<PHRMEmployeeCashTransaction>? PHRMEmployeeCashTransactions { get; set; }
        public string? CareOfContact { get; set; }
        [NotMapped]
        public string? DepositorName { get; set; }
        [NotMapped]
        public string? DepositorContact { get; set; }

        public BillingDepositModel()
        {
            OrganizationOrPatient = "patient";
        }
    }
}
