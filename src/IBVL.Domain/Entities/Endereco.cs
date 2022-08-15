using FluentValidation.Results;
using IBVL.Domain.Core.AbstractValue;
using IBVL.Domain.Valitadors;

namespace IBVL.Domain.Entities
{
    public class Endereco : Entity
    {
        public Guid MembroId { get; set; }

        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public char Estado { get; private set; }

        //Rel EF
        public Membro Membro { get; set; }
        protected Endereco() { }

        public Endereco(string logradouro, string complemento,
                        string numero, string cep, string bairro,
                        string cidade, char estado)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }      
       
        public override ValidationResult Validate => new EnderecoValidator().Validate(this);
    }
}

