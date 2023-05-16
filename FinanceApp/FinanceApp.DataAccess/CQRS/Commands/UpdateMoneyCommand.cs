using FinanceApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.DataAccess.CQRS.Commands
{
    public class UpdateMoneyCommand : CommandBase<Money, Money>
    {
        public override async Task<Money> Execute(HomeBudgetStorageContext context)
        {
            context.Money.Update(this.Parametr);
            await context.SaveChangesAsync();
            return this.Parametr ;
        }
    }
}
