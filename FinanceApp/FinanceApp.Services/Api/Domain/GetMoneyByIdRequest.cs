using MediatR;

namespace FinanceApp.Services.Api.Domain
{
    public class GetMoneyByIdRequest : IRequest<GetMoneyByIdResponse>
    {
        public int moneyId { get; set; }
    }
}
