using AutoMapper;
using FinanceApp.DataAccess.CQRS;
using FinanceApp.DataAccess.CQRS.Queries;
using FinanceApp.DataAccess.Entities;
using FinanceApp.Services.Api.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Services.Api.Handler
{
    public class GetMoneyHandler : IRequestHandler<GetMoneyRequest, GetMoneyResponse>
    {
        private readonly IMapper _mapper;
        private readonly IQueryExecutor _queryExecutor;

        public GetMoneyHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            _mapper = mapper;
            _queryExecutor = queryExecutor;
        }

        public async Task<GetMoneyResponse> Handle(GetMoneyRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMoneyQuery() { };

            var money = await _queryExecutor.Execute(query);

            var moneyMapped = _mapper.Map<List<Api.Domain.Models.GetMoney>>(money);

            var response = new GetMoneyResponse()
            {
                Data = moneyMapped
            };

            return response;
        }
    }
}
