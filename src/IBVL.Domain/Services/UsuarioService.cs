using IBVL.Domain.Core;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Services
{
    public class UsuarioService : IDomainService<Usuario>
    {

        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Usuario> AdicionarAsync(Usuario usuario)
        {
            await _unitOfWork.usuarioRepository.AdicionarAsync(usuario);
            return usuario;
        }

        public async Task<Usuario> AtualizarAsync(Usuario usuario)
        {
            await _unitOfWork.usuarioRepository.AtualizarAsync(usuario);
            return usuario;
        }

        public async Task ExcluirAsync(Usuario usuario)
        {
            await _unitOfWork.usuarioRepository.AtualizarAsync(usuario);
           
        }

        public async Task<Usuario> ObterPorIdAsync(Guid id)
        {

          return await _unitOfWork.usuarioRepository.ObterPorIdAsync(id);
            
        }

        public async Task<List<Usuario>> ObterTodosAsync(int page, int limit)
        {
            var list= await _unitOfWork.usuarioRepository.ObterTodosAsync(page, limit);
            return list.ToList();
        }
    }
}
