namespace FinanceApp.DataAccess.CQRS.Commands
{
    public abstract class CommandBase<TParametr, TResult>
    {
        public TParametr Parametr { get; set; }
        public abstract Task<TResult> Execute(HomeBudgetStorageContext context);
    }
}
