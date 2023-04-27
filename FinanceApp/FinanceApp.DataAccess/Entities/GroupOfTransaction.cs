using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.DataAccess.Entities
{
    public class GroupOfTransaction : EntityBase
    {
        public int Name { get; set; }
        public List<Money> Money { get; set; }
    }
}
