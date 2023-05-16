using FinanceApp.DataAccess.CQRS.Commands;

namespace FinanceApp.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly HomeBudgetStorageContext _context;

        public CommandExecutor(HomeBudgetStorageContext context)
        {
            _context = context;
        }

        public Task<TResult> Execute<TParametr, TResult>(CommandBase<TParametr, TResult> command)
        {
            return command.Execute(_context);
        }
    }
}
