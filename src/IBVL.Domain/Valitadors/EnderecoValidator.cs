using FluentValidation;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Valitadors
{
    public class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(e => e.Estado)
                .NotEmpty();


            RuleFor(e => e.Bairro)
              .NotEmpty()
              .MinimumLength(2)
              .MaximumLength(80);

            RuleFor(e => e.Logradouro)
               .NotEmpty()
               .MinimumLength(2)
               .MaximumLength(60);

            RuleFor(e => e.Cep)
              .NotEmpty()
              .Length(8);
            RuleFor(e => e.Cidade)
              .NotEmpty()
              .Length(50);


            RuleFor(e => e.Complemento)
           .NotEmpty()
           .Length(100);

            RuleFor(e => e.Numero)
            .NotEmpty()
            .Length(12);

            



        }
    }
}
