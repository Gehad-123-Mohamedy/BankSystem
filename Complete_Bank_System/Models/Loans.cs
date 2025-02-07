using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Loans
    {
        public int LoansId { get; set; }
        [Required]
        [StringLength(50)]
        public string LoanType { get; set; } //personal , auto  ,mortgage
        [ForeignKey("customer")]
        public int CustomerId { get; set; }
        public virtual Customer customer { get; set; }
        [Required]
        public decimal LoanAmount { get; set; }
        [Required]
        public int LoanTerm { get; set; }
        [Required]
        public string RepaymentStatus { get; set; }
        public virtual List<Transactions> transaction { get; set; }

    }

    
}
