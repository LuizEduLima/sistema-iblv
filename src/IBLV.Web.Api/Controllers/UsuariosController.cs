using AutoMapper;
using IBLV.Application.Dtos.Usuarios;
using IBVL.Domain.Core;
using IBVL.Domain.Core.Enums;
using IBVL.Domain.Entities;
using IBVL.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBLV.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
       
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UsuariosController(IUnitOfWork unitOfWork, IMapper mapper)
        {         
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost("nova-conta")]
        public async Task<IActionResult> Post(Usuario usuario)  
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(usuario);
            }
            await _unitOfWork.usuarioRepository.AdicionarAsync(usuario);

            UsuarioDto result = _mapper.Map<UsuarioDto>(usuario);       
            
             return Ok(result);
        }

        [HttpGet("lista-usuarios")]
        public async Task<IActionResult> GetUsuario()
        {
            return Ok(await _unitOfWork.usuarioRepository.ObterTodosAsync());

        }
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            return Ok(await _unitOfWork.usuarioRepository.ObterPorIdAsync(id));

        }

        [HttpPost("desativar-usuario")]
        public async Task<IActionResult> DesativarUsuario(Guid id)
        {
            var usuario = await _unitOfWork.usuarioRepository.ObterPorIdAsync(id);
            usuario.Desativar();

            return Ok(await _unitOfWork.usuarioRepository.Desativar(usuario));
        }

        [HttpPost("ativar-usuario")]
        public async Task<IActionResult> AtivarUsuario(Guid id)
        {
            var usuario = await _unitOfWork.usuarioRepository.ObterPorIdAsync(id);
            usuario.Ativar();

            return Ok(await _unitOfWork.usuarioRepository.Ativar(usuario));
        }


        [HttpPut("atualizar-usuario/{id}")] 
        public async Task<IActionResult> Atualizar(Guid id, UsuarioDto usuario)
        {      

            if (!ModelState.IsValid) return BadRequest();

            if (id != usuario.Id) return BadRequest();         
           
            await _unitOfWork.usuarioRepository.AtualizarAsync(_mapper.Map<Usuario>(usuario));

            return Ok(usuario);
        }

    }
}
