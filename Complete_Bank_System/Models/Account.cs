using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        [StringLength(50)]
        [Required]
        public string AccountType { get; set; } // Saving , Checking 
        [Required]
        public decimal Balance { get; set; }
        [ForeignKey("customer")]
        public int CustomerId { get; set; }
        public virtual Customer customer { get; set; }
        public DateTime OpeningDate { get; set; }
        public virtual List<Transactions>? trans { get; set; }
        [Required]
        public int AccountNumber { get; set; }

        public override string ToString()
        {
            return $"AccNum :{AccountNumber}- Type :{AccountType}- Balance :{Balance}";
        }

    }

}
