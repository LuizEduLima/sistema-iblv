using FluentValidation.Results;
using IBVL.Domain.Core.AbstractValue;
using IBVL.Domain.Valitadors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Entities
{
    public class Usuario : Entity
    {
        public virtual Guid MembroId { get; set; }

        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Senha { get; private set; }

        public virtual Membro? Membro { get; set; }

        public Usuario(string? nome, string? email, string? senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public override ValidationResult Validate => new UsuarioValidator().Validate(this);

        private bool _ativo;

        public void Ativar() => _ativo = true;
        public void Desativar() => _ativo = false;
        public bool Ativo() => _ativo;

        public void SouMembro(Membro membro)
        {
            Membro = membro;
        }
        public void AtualizarMeusDados(Membro membro)
        {
            Membro = membro;
        }




    }
}
