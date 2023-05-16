using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Services.Api.Domain.Models
{
    public class GetMoney
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
