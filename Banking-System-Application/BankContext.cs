using Banking_System_Application.com.bank.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application
{
    public class BankContext : DbContext
    {
        public BankContext() { }

        public BankContext(DbContextOptions<BankContext> options) : base(options) 
        { }

        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Integrated Security=true;Database=BankingSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    public class BankContextFactory : IDesignTimeDbContextFactory<BankContext>
    {
        public BankContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankContext>();
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Integrated Security=true;Database=BankingSystem;Trusted_Connection=True;TrustServerCertificate=True;");

            return new BankContext(optionsBuilder.Options);
        }
    }
}
