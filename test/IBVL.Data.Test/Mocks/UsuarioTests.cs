using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Test.Mocks
{
   
    public class UsuarioTests: BaseUsuarioTest
    {
        public UsuarioTests(UsuariosTestsFixture clienteTestFisture) : base(clienteTestFisture)
        {
        }

        [Fact(DisplayName = "Novo Usuário Válido")]
        [Trait("Usuário", "Usuario válido")]
        public void Usuario_NovoUsuario_Deve_Estar_Valido()
        {
            
             var usuario = _clienteTestFisture.GerarUsuarioValido();

            Assert.True(usuario.Validate.IsValid);

        }

        [Fact(DisplayName = "Novo Usuário Inválido")]
        [Trait("Usuário", "Usuario inválido")]
        public void Usuario_NovoUsuario_Deve_Estar_In_Valido()
        {

            var usuario = _clienteTestFisture.GerarUsuarioInValido();

            Assert.False(usuario.Validate.IsValid);

        }

    }
}
