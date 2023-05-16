using AutoMapper;
using AutoMapper.Execution;
using FinanceApp.DataAccess.CQRS;
using FinanceApp.DataAccess.CQRS.Commands;
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
    public class AddMoneyHandler : IRequestHandler<AddMoneyRequest, AddMoneyResponse>
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IMapper _mapper;

        public AddMoneyHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            _commandExecutor = commandExecutor;
            _mapper = mapper;
        }
        public async Task<AddMoneyResponse> Handle(AddMoneyRequest request, CancellationToken cancellationToken)
        {
            var money = _mapper.Map<Money>(request);

            var command = new AddMoneyCommand()
            {
                Parametr = money
            };

            var moneyFromDb = await _commandExecutor.Execute(command);
            return new AddMoneyResponse()
            {
                Data = moneyFromDb
            };
        }
    }
}
