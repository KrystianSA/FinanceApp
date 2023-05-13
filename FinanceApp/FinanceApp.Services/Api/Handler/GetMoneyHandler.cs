using FinanceApp.DataAccess;
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
        private readonly IRepository<Money> _moneyRepository;

        public GetMoneyHandler(IRepository<Money> moneyRepository)
        {
            _moneyRepository = moneyRepository;
        }

        public Task<GetMoneyResponse> Handle(GetMoneyRequest request, CancellationToken cancellationToken)
        {
            var money = _moneyRepository.GetAll();

            var domainMoney = money.Select(x => new Domain.Models.Money()
            { 
                Description = x.Description,
                Amount = x.Amount,
                Date = x.Date,
            });

            var response = new GetMoneyResponse()
            {
                Data = domainMoney.ToList()
            };

            return Task.FromResult(response);
        }
    }
}
