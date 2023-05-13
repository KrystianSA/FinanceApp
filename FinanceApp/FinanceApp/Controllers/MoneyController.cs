using FinanceApp.Services.Api.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoneyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllMoney([FromQuery] GetMoneyRequest getMoneyRequest)
        {
            var response = await _mediator.Send(getMoneyRequest);
            return Ok(response);
        }
    }
}
