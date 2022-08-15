using IBVL.Domain.Core.AbstractValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Core.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task Adicionar(T entity);
        Task Atualizar(T entity);
        Task Remover(Guid id);
        T ObterPorId(Guid id);
        Task<IEnumerable<T>> ObterTodos();
        Task<IEnumerable<T>> BuscarGenerica(Func<Expression,bool>predicate);

    }
}
