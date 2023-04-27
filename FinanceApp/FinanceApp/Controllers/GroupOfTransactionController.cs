using FinanceApp.DataAccess;
using FinanceApp.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupOfTransactionController : ControllerBase
    {
        private readonly IRepository<GroupOfTransaction> _moneyRepository;

        public GroupOfTransactionController(IRepository<GroupOfTransaction> moneyRepository)
        {
            _moneyRepository = moneyRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<GroupOfTransaction> GetAllMoney()
        {
            return _moneyRepository.GetAll();
        }

        [HttpGet]
        [Route("GroupOfTransactionId")]
        public GroupOfTransaction GetMoneyById(int moneyId)
        {
            return _moneyRepository.GetById(moneyId);
        }
    }
}
