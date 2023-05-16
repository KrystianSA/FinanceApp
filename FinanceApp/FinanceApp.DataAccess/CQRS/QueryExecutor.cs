using FinanceApp.DataAccess.CQRS.Queries;

namespace FinanceApp.DataAccess.CQRS
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly HomeBudgetStorageContext _context;

        public QueryExecutor(HomeBudgetStorageContext context)
        {
            _context = context;
        }

        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(_context);
        }
    }
}
