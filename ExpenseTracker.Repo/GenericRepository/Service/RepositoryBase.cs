using ExpenseTracker.Repo.Data;
using ExpenseTracker.Repo.GenericRepository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Repo.GenericRepository.Service
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public async Task CreateAsync(T entity) => await Task.Run( () => RepositoryContext.Set<T>().Add(entity));
        

        public async Task DeleteAsync(T entity) => await Task.Run( () => RepositoryContext.Set<T>().Update(entity));
        

        public async Task<IQueryable<T>> FindAllAsync(bool trackChanges) => !trackChanges ? 
            await Task.Run(() => RepositoryContext.Set<T>().AsNoTracking()) : await Task.Run(() => RepositoryContext.Set<T>());


        public async Task UpdateAsync(T entity) => await Task.Run(() => RepositoryContext.Set<T>().Remove(entity));
        
    }
}
