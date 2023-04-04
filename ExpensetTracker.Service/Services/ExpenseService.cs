using ExpenseTracker.Core.Models;
using ExpenseTracker.Repo.Data;
using ExpenseTracker.Repo.GenericRepository.Service;
using ExpenseTracker.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Service.Services
{
    public class ExpenseService : RepositoryBase<Expense>, IExpenseService
    {
        public ExpenseService(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public async Task CreateExpense(Expense expense) => await CreateAsync(expense);
       

        public async Task DeleteExpense(Expense expense) => await DeleteAsync(expense);
        

        public async Task<IEnumerable<Expense>> GetAllExpenses(bool trackChanges) 
            => await FindAllAsync(trackChanges).Result.OrderBy(x => x.Id).ToListAsync();


        //public Task<Expense> GetExpense(Guid id, bool trackChange);


        public async Task UpdateExpense(Guid id, Expense expense) => await UpdateAsync(expense);
        
    }
}
