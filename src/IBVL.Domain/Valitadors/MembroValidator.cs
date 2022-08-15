using FluentValidation;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Valitadors
{
    public class MembroValidator:AbstractValidator<Membro>
    {
        public MembroValidator()
        {
            RuleFor(m => m.Nome)
                .NotEmpty()
                .Length(100);

            RuleFor(m => m.TelefoneCelular)
                .NotEmpty();

            RuleFor(m => m.DateDeNascimmento)
                .NotEmpty();
            RuleFor(m => m.Endereco)
                .NotEmpty();

            RuleFor(m => m.EstadoCivil)
                .NotEmpty();

        }
    }
}
