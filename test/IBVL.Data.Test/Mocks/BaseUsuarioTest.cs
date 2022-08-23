using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Test.Mocks
{
    [Collection(nameof(UsuarioCollection))]
    public abstract class BaseUsuarioTest
    {

        public UsuariosTestsFixture _clienteTestFisture { get; }

        public BaseUsuarioTest(UsuariosTestsFixture clienteTestFisture)
        {
            _clienteTestFisture = clienteTestFisture;

        }
    }
 
}
