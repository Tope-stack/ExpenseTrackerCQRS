using ExpenseTracker.Repo.Data;
using ExpenseTracker.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Service.Services
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext repositoryContext;
        private IExpenseService _expenseService;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
            
        }

        public IExpenseService ExpenseService
        {
            get
            {
                if (_expenseService is null)
                    _expenseService = new ExpenseService(repositoryContext);
                return _expenseService;
            }
        }

        public Task SaveAsync() => repositoryContext.SaveChangesAsync();
        
    }
}
