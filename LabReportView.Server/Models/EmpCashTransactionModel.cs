using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class EmpCashTransactionModel
    {
        [Key]
        public int? CashTxnId { get; set; }
        public string? TransactionType { get; set; }
        public int? ReferenceNo { get; set; }
        public int? EmployeeId { get; set; }
        public double? InAmount { get; set; }
        public double? OutAmount { get; set; }
        public string? Description { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? IsActive { get; set; }

        public int? CounterID { get; set; }

        public int? PaymentModeSubCategoryId { get; set; }
        public int? PatientId { get; set; }
        public string? ModuleName { get; set; }
        public string? Remarks { get; set; }
        public bool? IsTransferredToAcc { get; set; }
    }
}
