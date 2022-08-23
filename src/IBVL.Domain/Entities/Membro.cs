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

        public string Nome { get;  set; }
        public DateTime DataDeNascimmento { get;  set; }
        public EstadoCivil EstadoCivil { get;  set; }
        public string TelefoneResidencia { get;  set; }
        public string TelefoneCelular { get;  set; }
        public string TelefoneContato { get;  set; }
        public string? Foto { get;  set; }
        public Endereco Endereco { get;  set; }
        public Guid UsuarioId { get; set; }
       // public Usuario Usuario { get; set; }

        public Membro() { }


        public Membro(string nome, DateTime dataDeNascimento,
                      string? foto, EstadoCivil estadoCivil,
                      string telefoneResidencia, string telefoneCelular,
                      string telefoneContato)
        {
            Nome = nome;
            DataDeNascimmento = dataDeNascimento;
            Foto = foto;
            EstadoCivil = estadoCivil;

            TelefoneResidencia = telefoneResidencia;
            TelefoneCelular = telefoneCelular;
            TelefoneContato = telefoneContato;
        }
        public Membro(string nome, DateTime dataDeNascimento,
                      EstadoCivil estadoCivil,
                      string telefoneResidencia, string telefoneCelular,
                      string telefoneContato,Endereco endereco)
        {
            Nome = nome;
            DataDeNascimmento = dataDeNascimento;         
            EstadoCivil = estadoCivil;

            TelefoneResidencia = telefoneResidencia;
            TelefoneCelular = telefoneCelular;
            TelefoneContato = telefoneContato;
            Endereco = endereco;
        }

        public override ValidationResult Validate => new MembroValidator().Validate(this);
        public void AdicionarFoto(string foto) => Foto = foto;
        public void AtualizarFoto(string foto) => Foto = foto;
        public void AtualizarEstadoCivil(EstadoCivil estadoCivil)
        {
            EstadoCivil = EstadoCivil;
        }
        public void AdicionarEndereco(Endereco novoendereco)
        {
            Endereco = novoendereco;
        }
        public void AtualizarEndereco(Endereco novoendereco)
        {
            Endereco = novoendereco;
        }
        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }
        public void AtualizarTelefoneResidencia(string numero) => TelefoneResidencia = numero;
        public void AtualizarTelefoneCelular(string numero) => TelefoneCelular = numero;
        public void AtualizarTelefoneRecado(string numero) => TelefoneContato = numero;
    }

}
