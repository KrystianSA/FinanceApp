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
        public DbSet<TypeOfMoney> TypeOfMoney { get; set; }
    }
}
