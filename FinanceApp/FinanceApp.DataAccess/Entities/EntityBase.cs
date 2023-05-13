using System.ComponentModel.DataAnnotations;

namespace FinanceApp.DataAccess.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
