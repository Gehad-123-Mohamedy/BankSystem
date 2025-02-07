using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Audit_Logs
    {
        public int Id { get; set; }
        public string ActionType { get; set; }
        public DateTime ActionDate { get; set; }
        [Required]
        public int USerId { get; set; }
        [Required, StringLength(50)]
        public string UserType { get; set; }
        [Required, StringLength(100)]
        public String Desc { get; set; }
    }
}
