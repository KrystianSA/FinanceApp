using FinanceApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FinanceApp.DataAccess.CQRS.Queries
{
    public class GetMoneyIdQuery : QueryBase<Money>
    {
        public int moneyId { get; set; }

        public override async Task<Money> Execute(HomeBudgetStorageContext context)
        {
            var money = await context.Money.FirstOrDefaultAsync(x=>x.Id== moneyId);
            return money;
        }
    }
}
