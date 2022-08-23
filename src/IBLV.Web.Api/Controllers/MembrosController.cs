using AutoMapper;
using IBLV.Application.Dtos.Membro;
using IBLV.Application.Dtos.Usuarios;
using IBVL.Domain.Entities;
using IBVL.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBLV.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembrosController : ControllerBase
    {
        public readonly IMembroDomainService _membroDomainService;
        public IMapper _mapper;

        public MembrosController(IMembroDomainService membroDomainService, 
                                 IMapper mapper)
        {
            _membroDomainService = membroDomainService;
            _mapper = mapper;
        }

        [HttpPost("soumembro")]
        public async Task<IActionResult> SouMembro(Guid usuarioId, MembroDto membroDto)
        {
            var usuario = await _membroDomainService.ObterUsuarioId(usuarioId);
            membroDto.UsuarioId = usuario.Id;
            var membro = _mapper.Map<Membro>(membroDto);
           

            await _membroDomainService.SouMembro(membro);

            return Ok(membro);

            
        }
    }
}
