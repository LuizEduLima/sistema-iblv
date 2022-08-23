using Bogus;
using Bogus.DataSets;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Test.Mocks
{
    [CollectionDefinition(nameof(UsuarioCollection))]
    public class UsuarioCollection : ICollectionFixture<UsuariosTestsFixture> { }


    public class UsuariosTestsFixture : IDisposable
    {
        public Usuario GerarUsuarioValido()
        {
           var genero = new Faker().PickRandom<Name.Gender>();

            return new Faker<Usuario>("pt_BR")
                .CustomInstantiator(f => new Usuario(
                f.Name.FullName(genero),
                "",
                f.Internet.Password(8)))
                .RuleFor(u => u.Email,
                (f, u) =>
                f.Internet.Email(u.Nome.ToLower()));

            
        }
        public Usuario GerarUsuarioInValido()
        {
            var genero = new Faker().PickRandom<Name.Gender>();

            return new Faker<Usuario>("pt_BR")
               .CustomInstantiator(f => new Usuario(
                  "",
               f.Internet.Email(f.Name.FullName(genero)),
               f.Internet.Password(2)));
        }

        public void Dispose()
        {
          
        }
    }
}
