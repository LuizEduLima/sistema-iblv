using IBVL.Domain.Entities;

namespace IBVL.Domain.Test
{
    public class UsuarioTeste
    {

        [Fact(DisplayName = "Usu�rio ValidateResult")]
        public void Usuario_ValidateResult_True()
        {
            var usuario = new Usuario("LUIZ EDUARDO", "luiz@gmail.com","abc123");

           var UsuarioValidatorResult= usuario.Validate;         
            Assert.True(UsuarioValidatorResult.IsValid);

        }


        [Fact(DisplayName ="Usu�rio campo data atualiza��o preenchida")]
        public void Usuario_DataAtualizacao_Preenchida_Retorna_True()
        {
            var usuario = new Usuario("LUIZ EDUARDO", "luiz@gmail.com", "abc123");
            usuario.DataAtualizacao = DateTime.UtcNow;
            Assert.True(usuario.DataAtualizacao.HasValue);
        }

        [Fact(DisplayName = "Usu�rio campo data atualiza��o sem preenchimento")]
        public void Usuario_DataAtualizacao_Nao_Preenchida_Retorna_False()
        {
            var usuario = new Usuario("LUIZ EDUARDO", "luiz@gmail.com", "abc123");
            
            Assert.False(usuario.DataAtualizacao.HasValue);
        }

        [Fact(DisplayName = "Usu�rio campo Ativo Ativado")]
        public void Usuario_Campo_Ativo_True()
        {
            var usuario = new Usuario("LUIZ EDUARDO", "luiz@gmail.com", "abc123");

            Assert.False(usuario.DataAtualizacao.HasValue);
            usuario.Ativar();
            Assert.True(usuario.Ativo());
        }

        [Fact(DisplayName = "Usu�rio campo Ativo Desativado")]
        public void Usuario_Campo_Ativo_True_False()
        {
            var usuario = new Usuario("LUIZ EDUARDO", "luiz@gmail.com", "abc123");
           

            Assert.False(usuario.DataAtualizacao.HasValue);

            usuario.Desativar();
            Assert.False(usuario.Ativo());
        }
    }
}