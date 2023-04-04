using ExpenseTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Repo.Data
{
    public class ExpenseData : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasData(
                new Expense
                {
                    Id = 1,
                    ExpenseDate = DateTime.Now,
                    MerchantName = "Bank",
                    Amount = 12000,
                    Category = Category.Business
                }, 
                new Expense
                {
                    Id = 2,
                    ExpenseDate = DateTime.Now.AddMinutes(5),
                    MerchantName = "Slot",
                    Amount = 50000,
                    Category = Category.Personal
                },
                new Expense
                {
                    Id = 3,
                    ExpenseDate = DateTime.Now.AddMinutes(10),
                    MerchantName = "Transport",
                    Amount = 2000,
                    Category = Category.Personal
                },
                new Expense
                {
                    Id = 4,
                    ExpenseDate = DateTime.Now.AddMinutes(15),
                    MerchantName = "Game",
                    Amount = 10000,
                    Category = Category.Social
                });
                
        }
    }
}
