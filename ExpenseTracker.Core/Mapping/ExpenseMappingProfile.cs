
using AutoMapper;
using ExpenseTracker.Core.Dtos;
using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Mapping
{
    public class ExpenseMappingProfile : Profile
    {
        public ExpenseMappingProfile()
        {
            CreateMap<Expense, ExpenseDto>();

            CreateMap<AddExpenseDto, Expense>();

            CreateMap<UpdateExpenseDto, Expense>().ReverseMap();
        }
    }
}
