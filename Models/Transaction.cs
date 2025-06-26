using System.ComponentModel.DataAnnotations;

namespace BudgetTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public enum TransactionType
    {
        Income,
        Expense
    }
}