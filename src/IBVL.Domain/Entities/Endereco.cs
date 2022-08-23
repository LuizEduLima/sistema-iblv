
using FluentValidation.Results;
using IBVL.Domain.Core.AbstractValue;
using IBVL.Domain.Valitadors;
namespace IBVL.Domain.Entities
{
    public class Endereco : Entity
    {
        //[ForeignKey("MembroId")]
        public Guid MembroId { get; set; }
        public string Logradouro { get;  set; }
        public string Complemento { get;  set; }
        public string Numero { get;  set; }
        public string Cep { get;  set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Estado { get;  set; }
        public Membro Membro { get;   set; }

        public override ValidationResult Validate => new EnderecoValidator().Validate(this);

     

        public Endereco(string logradouro, string complemento,
                        string numero, string cep, string bairro,
                        string cidade, string estado,Guid membroId)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            MembroId = membroId;
         
        }

       
    }
}

