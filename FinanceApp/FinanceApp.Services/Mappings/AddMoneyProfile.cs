using AutoMapper;
using FinanceApp.DataAccess.Entities;
using FinanceApp.Services.Api.Domain;
using FinanceApp.Services.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Services.Mappings
{
    public class AddMoneyProfile : Profile
    {
        public AddMoneyProfile()
        {
            CreateMap<AddMoneyRequest, Money>();
            CreateMap<Money, Api.Domain.Models.AddMoney>();
        }
    }
}
