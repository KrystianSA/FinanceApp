using AutoMapper;
using FinanceApp.DataAccess.CQRS;
using FinanceApp.DataAccess.CQRS.Queries;
using FinanceApp.Services.Api.Domain;
using MediatR;

namespace FinanceApp.Services.Api.Handler
{
    public class GetMoneyByIdHandler : IRequestHandler<GetMoneyByIdRequest, GetMoneyByIdResponse>
    {
        private readonly IMapper _mapper;
        private readonly IQueryExecutor _queryExecutor;

        public GetMoneyByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            _mapper = mapper;
            _queryExecutor = queryExecutor;
        }

        public async Task<GetMoneyByIdResponse> Handle(GetMoneyByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMoneyIdQuery() 
            {
                moneyId = request.moneyId
            };
            var money = await _queryExecutor.Execute(query);
            var mappedMoney = _mapper.Map<Api.Domain.Models.GetMoney>(money);
            var response = new GetMoneyByIdResponse() 
            {
                Data = mappedMoney,
            };
            return response;
        }
    }
}
