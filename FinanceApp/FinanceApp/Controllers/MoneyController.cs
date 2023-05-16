using FinanceApp.DataAccess.Entities;
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

        [HttpGet]
        [Route("{moneyId}")]
        public async Task<IActionResult> GetMoneyId([FromRoute] int moneyId)
        {
            var request = new GetMoneyByIdRequest()
            {
                moneyId = moneyId
            };

            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddMoney([FromBody] AddMoneyRequest addMoneyRequest)
        {
            var response = await _mediator.Send(addMoneyRequest);
            return Ok(response);
        }

        [HttpDelete]
        [Route("{moneyId}")]

        public async Task<IActionResult> DeleteMoney([FromRoute] int moneyId)
        {
            var request = new DeleteMoneyRequest()
            {
                moneyId = moneyId
            };

            var reposonse = await _mediator.Send(request);
            return Ok(reposonse);
        }

        [HttpPut]
        [Route("{moneyId}")]
        public async Task<IActionResult> UpdateMoney([FromRoute] int moneyId, [FromBody] UpdateMoneyRequest updateMoneyRequest)
        {
            var request = new UpdateMoneyRequest
            {
                Id = moneyId,
                Description = updateMoneyRequest.Description,
                Amount = updateMoneyRequest.Amount,
                Date = updateMoneyRequest.Date,
                TypeOfMoneyId = updateMoneyRequest.TypeOfMoneyId
            };

            await _mediator.Send(request);
            return Ok();
        }
    }
}
