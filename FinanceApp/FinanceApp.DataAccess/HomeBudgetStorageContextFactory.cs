using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FinanceApp.DataAccess
{
    public class HomeBudgetStorageContextFactory : IDesignTimeDbContextFactory<HomeBudgetStorageContext>
    {
        public HomeBudgetStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HomeBudgetStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-FGS0SEO7\\SQLEXPRESS01;Encrypt=false;Initial Catalog=HomeBudgetStorage;Integrated Security=True");
            return new HomeBudgetStorageContext(optionsBuilder.Options);
        }
    }
}
