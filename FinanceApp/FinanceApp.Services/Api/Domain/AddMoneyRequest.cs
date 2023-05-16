using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Services.Api.Domain
{
    public class AddMoneyRequest : IRequest<AddMoneyResponse>
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int TypeOfMoneyId { get; set; }
    }
}
