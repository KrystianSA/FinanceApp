using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FinanceApp.DataAccess.Entities
{
    public class Money : EntityBase
    {
        public GroupOfTransaction GroupOfTransaction { get; set; }
        public Salary Salary { get; set; }
        public Bills Bills { get; set; }
        public Savings Savings { get; set; }
        public Expenses Expenses { get; set; }

        public int GroupOfTransactionId { get; set; }
        public int SalaryId { get; set; }   
        public int BillsId { get; set; }
        public int SavingsId { get; set; }       
        public int ExpensesId { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}