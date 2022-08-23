using IBVL.Domain.Core.AbstractValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Core.Interfaces
{
    public interface IBaseRepository<T>: IRepository, IDisposable where T : Entity
    {
        Task AdicionarAsync(T entity);
        Task AtualizarAsync(T entity);
        Task RemoverAsync(Guid id);
        Task<T> ObterPorIdAsync(Guid id);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<IEnumerable<T>> ObterTodosAsync(int page, int limit);
        Task<IEnumerable<T>> BuscarGenericaAsync(Expression<Func<T, bool>> predicate);
      

    }
}
