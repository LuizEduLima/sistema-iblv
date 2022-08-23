using IBVL.Domain.Core.Interfaces;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<Membro> AtualizarMeusDados(Membro membro);
        Task<bool> Ativar(Usuario usuario);
        Task<bool> Desativar(Usuario usuario);
     
    }
}
