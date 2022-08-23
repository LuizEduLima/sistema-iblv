using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Core.AbstractValue
{
    public abstract class Entity
    {

        public Guid Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        private DateTime? _dataAtualizacao;

        public Entity()
        {
            Id = Guid.NewGuid();

            DataCriacao = DateTime.UtcNow;
        }
        public abstract ValidationResult Validate { get; }

        public DateTime? DataAtualizacao
        {
            get { return _dataAtualizacao; }
            set { _dataAtualizacao = _dataAtualizacao.HasValue == false ? DateTime.UtcNow : value; }
        }
    }
}
