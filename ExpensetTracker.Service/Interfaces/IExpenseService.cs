using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Service.Interfaces
{
    public interface IExpenseService
    {
        Task<IEnumerable<Expense>> GetAllExpenses(bool trackChanges);
        //Task<Expense> GetExpense(Guid id, bool trackChanges);
        Task CreateExpense(Expense expense);
        Task UpdateExpense(Guid id, Expense expense);    
        Task DeleteExpense(Expense expense);
    }
}
