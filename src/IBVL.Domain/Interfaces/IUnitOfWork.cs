

using IBVL.Domain.Interfaces;
using System;

namespace IBVL.Domain.Core
{
    public interface IUnitOfWork :IDisposable
    {
        IUsuarioRepository usuarioRepository { get; }
        IMembroRepository membroRepository { get; }

        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();

        Task<bool> Commit();
    }
}
