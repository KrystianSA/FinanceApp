using AutoMapper;
using FinanceApp.DataAccess.CQRS;
using FinanceApp.DataAccess.CQRS.Commands;
using FinanceApp.DataAccess.CQRS.Queries;
using FinanceApp.DataAccess.Entities;
using FinanceApp.Services.Api.Domain;
using MediatR;

namespace FinanceApp.Services.Api.Handler
{
    public class DeleteMoneyHandler : IRequestHandler<DeleteMoneyRequest, DeleteMoneyResponse>
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;
        private readonly IMapper _mapper;

        public DeleteMoneyHandler(ICommandExecutor commandExecutor,IQueryExecutor queryExecutor, IMapper mapper)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }
        public async Task<DeleteMoneyResponse> Handle(DeleteMoneyRequest request, CancellationToken cancellationToken)
        {
            var money = new GetMoneyIdQuery()
            {
               moneyId = request.moneyId
            };
            var moneyFromDb = await _queryExecutor.Execute(money);
            var moneyToDelete = _mapper.Map<Money>(moneyFromDb);
            var command = new DeleteMoneyCommand()
            {
                Parametr = moneyToDelete
            };
            var response = await _commandExecutor.Execute(command);
            return null;
        }
    }
}
