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
       // public virtual Guid MembroId { get; set; }

        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Senha { get; private set; }
        public bool Ativo { get; private set; }

        public Membro? Membro { get; private set; }

        protected Usuario(){}
        public Usuario(string? nome, string? email, string? senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = true;
        }

        public override ValidationResult Validate => new UsuarioValidator().Validate(this);

      
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        
       




    }
}
