using AutoMapper;
using FinanceApp.DataAccess.Entities;
using System.Runtime.CompilerServices;

namespace FinanceApp.Services.Mappings
{
    public class GetMoneyProfile : Profile
    {
        public GetMoneyProfile()
        {
            CreateMap<Money, Api.Domain.Models.GetMoney>()
                .ForMember(x => x.Description, y => y.MapFrom(z => z.Description))
                .ForMember(x => x.Amount, y => y.MapFrom(z => z.Amount))
                .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));
        }
    }
}
