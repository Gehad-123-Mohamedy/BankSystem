using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Employee_Name{ get; set; }
        public string JobTitle { get; set; }
        public DateTime hireDate { get; set; }
        [Required,StringLength(20)]
        public string password { get; set; }
        public decimal salary { get; set; }
    }
}
