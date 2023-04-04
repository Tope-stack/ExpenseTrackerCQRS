using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Repo.GenericRepository.Interface
{
    public interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> FindAllAsync(bool trackChanges);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity); 
        Task DeleteAsync(T entity); 
    }
}
