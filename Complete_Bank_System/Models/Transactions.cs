using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Transactions
    {
        public int TransactionsId { get; set; }
        [Required]
        public string TransactionType { get; set; } //Deposit , withdrawal 
        public DateTime TransationDate { get; set; }
        public decimal Amount { get; set; }
        [ForeignKey("acc")]
        public int AccId { get; set; }
        public virtual Account acc { get; set; }
        [ForeignKey("loan")]
        public int? LoanId { get; set; } 
        public virtual Loans loan { get; set; }
    }
}
