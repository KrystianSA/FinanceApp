using FinanceApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.DataAccess
{
    public class HomeBudgetStorageContext : DbContext
    {
        public HomeBudgetStorageContext(DbContextOptions<HomeBudgetStorageContext> options) : base(options)
        {

        }

        public DbSet<Money> Money { get; set; }
        public DbSet<GroupOfTransaction> GroupOfTransaction { get; set; }
        public DbSet<Salary> Bills { get; set; }
        public DbSet<Bills> Salary { get; set; }
        public DbSet<Savings> Savings { get; set;}
        public DbSet<Expenses> Expenses { get; set; }
    }
}
