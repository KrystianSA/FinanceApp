using FinanceApp.DataAccess.CQRS.Commands;

namespace FinanceApp.DataAccess.CQRS
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParametr, TResult>(CommandBase<TParametr, TResult> command);
    }
}
