using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required,StringLength(50)]
        public string FullName { get; set; }
        public string Address { get; set; }
        [Required, StringLength(20)]
        public string CNN { get; set; }
        public byte[]? Image { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(20)]
        [Required]
        public string Password { get; set; }
        public virtual List<Account> accounts { get; set; }
        public virtual List<Loans> loans { get; set; }

        public override string ToString()
        {
            return $"{CustomerId}-{FullName}-{Address}";
        }

    }
    
}
