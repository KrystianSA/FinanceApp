using FinanceApp.DataAccess.CQRS.Queries;

namespace FinanceApp.DataAccess.CQRS
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
