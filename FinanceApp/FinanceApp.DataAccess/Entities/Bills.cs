using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.DataAccess.Entities
{
    public class Bills : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        List<Money> Money { get; set; }
    }
}
