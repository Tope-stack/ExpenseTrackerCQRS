using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Service.Interfaces
{
    public interface IRepositoryManager
    {
        IExpenseService ExpenseService { get; }
        Task SaveAsync();
    }
}
