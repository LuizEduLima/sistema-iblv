

using IBLV.Application.Dtos.Endereco;
using IBLV.Application.Dtos.Usuarios;

namespace IBLV.Application.Dtos.Membro
{
    public class MembroCreateDto
    {

        public Guid Id { get; set; }       
        public DateTime? DataCriacao { get; set; }
        public DateTime? DatataAtualizacao { get; set; }
        public string Nome { get; set; }
        public DateTime DateDeNascimmento { get; set; }
        public int EstadoCivil { get; set; }
        public string TelefoneResidencia { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneContato { get; set; }
        public string? Foto { get; set; }
        public EnderecoDto Endereco { get; set; }
        public Guid UsuarioId { get; set; }
       
       

    }
}
