using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Complete_Bank_System.Models
{
    public class Complete_Bank_SystemContext : DbContext
    {
        public virtual DbSet<Employee> employees { get; set; }
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Account> accounts { get; set; }
        public virtual DbSet<Transactions> transactions { get; set; }
        public virtual DbSet<Loans> loans{ get; set; }
        public virtual DbSet<Audit_Logs> audit_Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.\\SQLexpress; Database=Bank;Trusted_Connection=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasIndex(c => c.CNN).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(E=>E.Employee_Name).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(C=>C.FullName).IsUnique();
            modelBuilder.Entity<Account>().HasIndex(A => A.AccountNumber).IsUnique();

        }
    }
}
