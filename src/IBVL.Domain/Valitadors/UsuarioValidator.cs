using FluentValidation;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Valitadors
{
    public class UsuarioValidator:AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Nome)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(100);

            RuleFor(u => u.Email)
               .NotEmpty()
               .EmailAddress();

            RuleFor(u => u.Senha)
               .NotEmpty()
               .MinimumLength(4)
               .MaximumLength(8);
              
        }
    }
}
