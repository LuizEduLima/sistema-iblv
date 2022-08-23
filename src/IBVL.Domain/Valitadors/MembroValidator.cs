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
                .MinimumLength(2)
                .MaximumLength(100);

            RuleFor(m => m.TelefoneCelular)
                .NotEmpty();

            RuleFor(m => m.DataDeNascimmento)
                .NotEmpty();

            //RuleFor(m => m.Endereco)
            //    .NotEmpty();

            RuleFor(m => m.EstadoCivil)
                .NotEmpty();

        }
    }
}
