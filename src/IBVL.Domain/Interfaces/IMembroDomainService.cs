using IBVL.Domain.Core;
using IBVL.Domain.Core.Enums;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Interfaces
{
    public interface IMembroDomainService:IDomainService<Membro>
    {
        Task<Membro> SouMembro(Membro membro);
        Task<Usuario> ObterUsuarioId(Guid id);

        Task<Membro> AdicionarFoto(Guid id, string foto);
        Task<Membro> AtualizarEstadoCivil(Guid id, EstadoCivil estadoCivil);
        Task<Membro> AdicionarEndereco(Guid id, Endereco endereco);
        Task<Membro> AtualizarEndereco(Guid id, Endereco endereco);
        Task<Membro> AtualizarNome(Guid id, string nome);
        Task<Membro> AtualizarTelefoneResidencia(Guid id, string telefoneResidencia);
        Task<Membro> AtualizarTelefoneCelular(Guid id, string telefoneCelular);
        Task<Membro> AtualizarTelefoneRecado(Guid id, string telefoneRecado);
    }
}
