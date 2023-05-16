using FinanceApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.DataAccess.CQRS.Commands
{
    public class DeleteMoneyCommand : CommandBase<Money,Money>
    {
        public override async Task<Money> Execute(HomeBudgetStorageContext context)
        {
            context.Money.Select(x=> x.Id == this.Parametr.Id);
            context.Money.Remove(this.Parametr);
            context.SaveChangesAsync();
            return this.Parametr;
        }
    }
}
