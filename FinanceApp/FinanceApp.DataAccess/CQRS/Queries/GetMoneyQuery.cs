using FinanceApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.DataAccess.CQRS.Queries
{
    public class GetMoneyQuery : QueryBase<List<Money>>
    {
        public override Task<List<Money>> Execute(HomeBudgetStorageContext context)
        {
            return context.Money.ToListAsync();
        }
    }
}
