using IBVL.Data.Context;
using IBVL.Data.Repositories;
using IBVL.Domain.Entities;
using IBVL.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Test.Mocks
{

    public class UsuarioRepositoryTest : BaseUsuarioTest
    {
        public UsuarioRepositoryTest(UsuariosTestsFixture clienteTestFisture) : base(clienteTestFisture)
        {

        }

        [Fact(DisplayName = "Adicionar Usuario com sucesso")]
        [Trait("Categoria", "Adicionar Usuario com sucesso")]
        public void AdicionarUsuario()
        {
            var usuario = _clienteTestFisture.GerarUsuarioValido();            

            var IusuarioRepo = new Mock<IUsuarioRepository>();      
         

            IusuarioRepo.Verify(u => u.AdicionarAsync(usuario), Times.Once);
        }

    }
}
