using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class BillingTransactionModel
    {

        [Key]
        public int? BillingTransactionId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? CounterId { get; set; }
        public DateTime? PaidDate { get; set; }
        public string TransactionType { get; set; }
        public double? TotalQuantity { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountPercent { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TaxTotal { get; set; }
        public double? TotalAmount { get; set; }
        public double? PaidAmount { get; set; }
        public double? DepositAmount { get; set; }
        public double? DepositAvailable { get; set; }
        public double? DepositUsed { get; set; }
        public double? DepositReturnAmount { get; set; }
        public double? DepositBalance { get; set; }
        public string Remarks { get; set; }
        public double? Tender { get; set; }
        public double? Change { get; set; }

        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? PrintCount { get; set; }

        public string PaymentMode { get; set; }
        public string PaymentDetails { get; set; }
        public string BillStatus { get; set; }

        public int? FiscalYearId { get; set; }
        [NotMapped]
        public string FiscalYear { get; set; }
        public int? InvoiceNo { get; set; }

        public virtual PatientModel Patient { get; set; }
        public virtual List<BillingTransactionItemModel> BillingTransactionItems { get; set; }

        public bool? ReturnStatus { get; set; }

        public int? TaxId { get; set; }
        public string InvoiceCode { get; set; }
        public double? TaxableAmount { get; set; }
        public bool? IsRemoteSynced { get; set; }
        public bool? IsRealtime { get; set; }

        public int? SettlementId { get; set; }

        public double? NonTaxableAmount { get; set; }
        public int? PaymentReceivedBy { get; set; }
        public int? PaidCounterId { get; set; }

        public int? PackageId { get; set; }
        public string PackageName { get; set; }

        public bool? IsInsuranceBilling { get; set; }
        public bool? IsInsuranceClaimed { get; set; }
        public DateTime? InsuranceClaimedDate { get; set; }
        public int? InsuranceProviderId { get; set; }

        public double? ExchangeRate { get; set; }
        public int? OrganizationId { get; set; }
        [NotMapped]
        public string OrganizationName { get; set; }

        [NotMapped]
        public int? ReceiptNo { get; set; }
        [NotMapped]
        public int? CreditNoteNumber { get; set; }

        public DateTime? InsTransactionDate { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }

        public int? PartialReturnTxnId { get; set; }
        public decimal? AdjustmentTotalAmount { get; set; }
        [NotMapped]
        public string BillingUserName { get; set; }

        public string InvoiceType { get; set; }

        public string LabTypeName { get; set; }

        public Int64? ClaimCode { get; set; }
        public decimal? ReceivedAmount { get; set; }

        [NotMapped]
        public bool? IsCoPayment { get; set; }

        [NotMapped]
        public virtual List<EmpCashTransactionModel> EmployeeCashTransaction { get; set; }
        public List<BillingTransactionCreditBillStatusModel> BillingTransactionCreditBillStatus { get; set; }
        [NotMapped]
        public int? PatientMapPriceCategoryId { get; set; }
        [NotMapped]
        public decimal? CoPaymentCreditAmount { get; set; }
        [NotMapped]
        public bool? IsMedicarePatientBilling { get; set; }

        public int? SchemeId { get; set; }
        [NotMapped]
        public string MemberNo { get; set; }
        public string OtherCurrencyDetail { get; set; }
        [NotMapped]
        public bool? IsProvisionalDischargeCleared { get; set; }

        public static BillingTransactionModel GetCloneWithItems(BillingTransactionModel txnToClone)
        {
            BillingTransactionModel retTxnModel = new BillingTransactionModel()
            {
                BillingTransactionId = txnToClone.BillingTransactionId,
                BillingTransactionItems = txnToClone.BillingTransactionItems,
                FiscalYearId = txnToClone.FiscalYearId,
                InvoiceCode = txnToClone.InvoiceCode,
                InvoiceNo = txnToClone.InvoiceNo,
                SubTotal = txnToClone.SubTotal,
                DiscountAmount = txnToClone.DiscountAmount,
                DiscountPercent = txnToClone.DiscountPercent,
                SettlementId = txnToClone.SettlementId,
                BillStatus = txnToClone.BillStatus,
                PaymentMode = txnToClone.PaymentMode,
                PaymentDetails = txnToClone.PaymentDetails,
                CreatedOn = txnToClone.CreatedOn,
                CreatedBy = txnToClone.CreatedBy,
                CounterId = txnToClone.CounterId,
                DepositAmount = txnToClone.DepositAmount,
                DepositBalance = txnToClone.DepositBalance,
                PatientId = txnToClone.PatientId,
                IsRealtime = txnToClone.IsRealtime,
                IsRemoteSynced = txnToClone.IsRemoteSynced,
                PatientVisitId = txnToClone.PatientVisitId,
                Remarks = txnToClone.Remarks,
                TaxableAmount = txnToClone.TaxableAmount,
                TaxId = txnToClone.TaxId,
                TaxTotal = txnToClone.TaxTotal,
                TransactionType = txnToClone.TransactionType,
                PaidAmount = txnToClone.PaidAmount,
                PaidDate = txnToClone.PaidDate,
                TotalAmount = txnToClone.TotalAmount,
                TotalQuantity = txnToClone.TotalQuantity,
                DepositReturnAmount = txnToClone.DepositReturnAmount,
                Change = txnToClone.Change,
                PrintCount = txnToClone.PrintCount,
                Tender = txnToClone.Tender,
                ReturnStatus = txnToClone.ReturnStatus,
                InvoiceType = txnToClone.InvoiceType,
                LabTypeName = txnToClone.LabTypeName
            };
            return retTxnModel;
        }
    }
}
