using IBVL.Data.Context;
using IBVL.Domain.Entities;
using IBVL.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {

        public UsuarioRepository(SqlServerContext sqlServerContext) :
            base(sqlServerContext) { }

        public async Task<bool> Ativar(Usuario usuario)
        {
            usuario.Ativar();

            using (var db = new SqlServerContext())
            {
                var cmd = db.Database.ExecuteSqlRaw("update USUARIOS set ativo={0} where Id = {1}", usuario.Ativo, usuario.Id);
               
            }
                //usuario.Ativar();
                //await base.AtualizarAsync(usuario);
                return usuario.Ativo;
        }

        public Task<Membro> AtualizarMeusDados(Membro membro)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Desativar(Usuario usuario)
        {
            usuario.Desativar();
            await base.AtualizarAsync(usuario);
            return usuario.Ativo;
        }

        
    }
}
