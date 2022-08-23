
namespace IBLV.Application.Dtos.Usuarios
{
    public class UsuarioCreateDto
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }       
        public bool Ativo { get; set; }
    }
}
