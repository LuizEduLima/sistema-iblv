

using IBLV.Application.Dtos.Membro;
using System.ComponentModel.DataAnnotations;

namespace IBLV.Application.Dtos.Endereco
{
    public class EnderecoDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Guid MembroId { get; set; }

     
    }
}
