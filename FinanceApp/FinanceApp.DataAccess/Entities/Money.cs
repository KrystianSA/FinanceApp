using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FinanceApp.DataAccess.Entities
{
    public class Money : EntityBase
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int TypeOfMoneyId { get; set; }
    }
}