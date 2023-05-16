using AutoMapper;
using FinanceApp.DataAccess;
using FinanceApp.DataAccess.CQRS;
using FinanceApp.DataAccess.CQRS.Commands;
using FinanceApp.DataAccess.CQRS.Queries;
using FinanceApp.DataAccess.Entities;
using FinanceApp.Services.Api.Domain;
using FinanceApp.Services.Api.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Services.Api.Handler
{
    public class UpdateMoneyHandler : IRequestHandler<UpdateMoneyRequest, UpdateMoneyResponse>
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;
        private readonly IMapper _mapper;
        private readonly HomeBudgetStorageContext _context;

        public UpdateMoneyHandler(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IMapper mapper, HomeBudgetStorageContext context)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
            _mapper = mapper;
            _context = context;
        }

        public async Task<UpdateMoneyResponse> Handle(UpdateMoneyRequest request, CancellationToken cancellationToken)
        {
            var command = new UpdateMoneyCommand()
            {
                Parametr = new Money()
                {
                    Id = request.Id,
                    Description = request.Description,
                    Amount = request.Amount,
                    Date = request.Date,
                    TypeOfMoneyId = request.TypeOfMoneyId
                }
            };

            var updatedMoney = await _commandExecutor.Execute(command);

            var response = new UpdateMoneyResponse()
            {
                Data = _mapper.Map<Money>(updatedMoney)
            };

            return response;
        }
    }
}
