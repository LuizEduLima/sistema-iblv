using IBVL.Data.Context;
using IBVL.Domain.Core;
using IBVL.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SqlServerContext _sqlServerContext;
        private IDbContextTransaction _dbContextTransaction;
        public UnitOfWork(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public IUsuarioRepository usuarioRepository => new UsuarioRepository(_sqlServerContext);

        public IMembroRepository membroRepository => new MembroRepository(this,_sqlServerContext);

        public void BeginTransaction()
        {
            _dbContextTransaction = _sqlServerContext.Database.BeginTransaction();
        }       

        public void CommitTransaction()
        {
            _dbContextTransaction.Commit();
        }
      
        public void RollBackTransaction()
        {
            _dbContextTransaction.Rollback();
        }

        public void Dispose()
        {
            _dbContextTransaction?.Dispose();
            _sqlServerContext?.Dispose();
        }
        public async Task<bool> Commit()
        {
            return _sqlServerContext.SaveChanges() > 0;
        }

    }
}
