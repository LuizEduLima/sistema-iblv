using IBVL.Data.Context;
using IBVL.Domain.Core;
using IBVL.Domain.Core.Enums;
using IBVL.Domain.Entities;
using IBVL.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Data.Repositories
{
    public class MembroRepository : Repository<Membro>, IMembroRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public MembroRepository(IUnitOfWork unitOfWork, SqlServerContext sqlServerContext) :
            base(sqlServerContext)
        {
            _unitOfWork = unitOfWork;
        }


    }
}
