using IBVL.Domain.Core.Interfaces;
using IBVL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBVL.Domain.Interfaces
{
    public interface IMembroRepository: IRepository, IBaseRepository<Membro>
    {
        
    }
}
