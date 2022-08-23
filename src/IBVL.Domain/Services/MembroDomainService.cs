using IBVL.Domain.Core;
using IBVL.Domain.Core.Enums;
using IBVL.Domain.Entities;
using IBVL.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Services
{
    public class MembroDomainService : IMembroDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MembroDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Membro> AdicionarAsync(Membro membro)
        {
            await _unitOfWork.membroRepository.AdicionarAsync(membro);
            return membro;
        }

        public async Task<Membro> AdicionarEndereco(Guid id, Endereco endereco)
        {
            var membro = await ObterMembro(id);
            membro.AdicionarEndereco(endereco);

            return await AtualizarMembro(membro);

        }

        public async Task<Membro> AdicionarFoto(Guid id, string foto)
        {
            var membro = await ObterMembro(id);
            membro.AdicionarFoto(foto);
            return await AtualizarMembro(membro);
        }

        public async Task<Membro> AtualizarAsync(Membro membro)
        {
            return await AtualizarMembro(membro);
        }

        public async Task<Membro> AtualizarEndereco(Guid id, Endereco endereco)
        {
            var membro = await ObterMembro(id);
            membro.AtualizarEndereco(endereco);
            return await AtualizarMembro(membro);
        }

        public async Task<Membro> AtualizarEstadoCivil(Guid id, EstadoCivil estadoCivil)
        {
            var membro = await ObterMembro(id);
            membro.AtualizarEstadoCivil(estadoCivil);
            return await AtualizarMembro(membro);

        }

        public async Task<Membro> AtualizarNome(Guid id, string nome)
        {
            var membro = await ObterMembro(id);
            membro.AtualizarNome(nome);
            return await AtualizarMembro(membro);
        }

        public async Task<Membro> AtualizarTelefoneCelular(Guid id, string telefoneCelular)
        {
            var membro = await ObterMembro(id);
            membro.AtualizarTelefoneCelular(telefoneCelular);
            return await AtualizarMembro(membro);
        }

        public async Task<Membro> AtualizarTelefoneRecado(Guid id, string telefoneRecado)
        {
            var membro = await ObterMembro(id);
            membro.AtualizarTelefoneRecado(telefoneRecado);
            return await AtualizarMembro(membro);
        }

        public async Task<Membro> AtualizarTelefoneResidencia(Guid id, string telefoneResidencia)
        {
            var membro = await ObterMembro(id);
            membro.AtualizarTelefoneResidencia(telefoneResidencia);
            return await AtualizarMembro(membro);
        }

        public async Task ExcluirAsync(Membro membro)
        {
           await  _unitOfWork.membroRepository.RemoverAsync(membro.Id);
        }

        public async Task<Membro> ObterPorIdAsync(Guid id)
        {
            return await ObterMembro(id);
        }

        public async Task<List<Membro>> ObterTodosAsync(int page, int limit)
        {
            var lista= await _unitOfWork.membroRepository.ObterTodosAsync(page, limit);
            return lista.ToList();
        }

        public async Task<Membro> SouMembro(Membro membro)
        {
            await _unitOfWork.membroRepository.AdicionarAsync(membro);

            return membro;
        }
        public async Task<Usuario> ObterUsuarioId(Guid id)
        {
            return await _unitOfWork.usuarioRepository.ObterPorIdAsync(id);
        }
        private async Task<Membro> ObterMembro(Guid id)
        {
            return await _unitOfWork.membroRepository.ObterPorIdAsync(id);
        }
        private async Task<Membro> AtualizarMembro(Membro membro)
        {
            await _unitOfWork.membroRepository.AtualizarAsync(membro);
            return membro;
        }

       
    }
}
