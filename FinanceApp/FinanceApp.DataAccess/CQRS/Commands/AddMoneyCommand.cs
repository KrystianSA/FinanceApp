using FinanceApp.DataAccess.Entities;

namespace FinanceApp.DataAccess.CQRS.Commands
{
    public class AddMoneyCommand : CommandBase<Money, Money>
    {
        public override async Task<Money> Execute(HomeBudgetStorageContext context)
        {
            await context.Money.AddAsync(this.Parametr);
            await context.SaveChangesAsync();
            return this.Parametr;
        }
    }
}
