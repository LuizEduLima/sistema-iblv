using IBVL.Domain.Core.AbstractValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Core
{
    public interface IDomainService<T> where T : Entity    
    {
        Task<T>AdicionarAsync(T entity);
        Task<T> AtualizarAsync(T entity);
        Task ExcluirAsync(T entity);

        Task<List<T>> ObterTodosAsync(int page, int limit);
       Task<T> ObterPorIdAsync(Guid id);

    }
}
