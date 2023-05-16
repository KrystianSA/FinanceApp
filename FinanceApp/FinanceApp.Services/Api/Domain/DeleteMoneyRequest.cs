using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Services.Api.Domain
{
    public class DeleteMoneyRequest : IRequest<DeleteMoneyResponse>
    {
        public int moneyId { get; set; }
    }
}
