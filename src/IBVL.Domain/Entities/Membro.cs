using FluentValidation.Results;
using IBVL.Domain.Core.AbstractValue;
using IBVL.Domain.Core.Enums;
using IBVL.Domain.Valitadors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Entities
{
    public class Membro : Entity
    {
     
        public string Nome { get; private set; }
        public DateTime DateDeNascimmento { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public string TelefoneResidencia { get; private set; }
        public string TelefoneCelular { get; private set; }
        public string TelefoneContato { get; private set; }

        public string? Foto { get; set; }

    
        public  Endereco Endereco { get; private set; }
        public Guid UsuarioId { get; private set; }
        public  Usuario Usuario { get; set; }

        protected Membro()
        {

        }
      

        public Membro(string nome, DateTime dataDeNascimento, string? foto, EstadoCivil estadoCivil,
                     string telefoneResidencia, string telefoneCelular,
                      string telefoneContato)
        {
            Nome = nome;
            DateDeNascimmento = dataDeNascimento;
            Foto = foto;
            EstadoCivil = estadoCivil;
            
            TelefoneResidencia = telefoneResidencia;
            TelefoneCelular = telefoneCelular;
            TelefoneContato = telefoneContato;
        }

        public override ValidationResult Validate => new MembroValidator().Validate(this);

        public void AdicionarFoto(string foto) => Foto = foto;
        public void AtualizarEstaoCivil(EstadoCivil estadoCivil)
        {
            EstadoCivil = EstadoCivil;
        }
        public void AtualizarEndereco(Endereco novoendereco)
        {
            Endereco = novoendereco;
        }
        public void AtualizarTelefoneResidencia(string numero) => TelefoneResidencia = numero;
        public void AtualizarTelefoneCelular(string numero) => TelefoneCelular = numero;
        public void AtualizarTelefoneRecado(string numero) => TelefoneContato = numero;
    }

}
