using IBVL.Data.Context;
using IBVL.Domain.Core;
using IBVL.Domain.Core.AbstractValue;
using IBVL.Domain.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Repositories
{
    public abstract class Repository<T> : IBaseRepository<T> where T : Entity
    {


        private readonly SqlServerContext _sqlServerContext;

        protected Repository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
           
        }

        public async Task AdicionarAsync(T entity)
        {
            await _sqlServerContext.Set<T>().AddAsync(entity);
            await _sqlServerContext.SaveChangesAsync();
        }

        public async Task AtualizarAsync(T entity)
        {
            _sqlServerContext.Set<T>().Update(entity);
             await _sqlServerContext.SaveChangesAsync();
            await Task.CompletedTask;
            
        }
        public async Task RemoverAsync(Guid id)
        {
            _sqlServerContext.Remove(id);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> BuscarGenericaAsync(Expression<Func<T, bool>> predicate)
        {
            return await _sqlServerContext.Set<T>().Where(predicate).ToListAsync();
        }

       
        public async Task<T> ObterPorIdAsync(Guid id)
        {
            return await _sqlServerContext.Set<T>().FirstOrDefaultAsync(t => t.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _sqlServerContext.Set<T>().AsNoTracking().ToListAsync();

        }

        
        public void Dispose()
        {
            _sqlServerContext?.Dispose();
        }

        public async Task<IEnumerable<T>> ObterTodosAsync(int page, int limit)
        {
            return await _sqlServerContext.Set<T>().AsNoTracking()
                .Skip(page)
                .Take(limit)
                .ToListAsync();
        }
    }
}
