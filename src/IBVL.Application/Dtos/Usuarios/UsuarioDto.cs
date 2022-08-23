
using IBLV.Application.Dtos.Membro;

namespace IBLV.Application.Dtos.Usuarios
{
    public class UsuarioDto
    {
        public Guid  Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public bool Ativo { get; set; }
       
       // public MembroDto? MembroDto { get; set; }
    }
}
