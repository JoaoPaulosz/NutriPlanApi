using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NutriPlanApi.Data;
using NutriPlanApi.Data.Dtos;
using NutriPlanApi.Models;

namespace NutriPlanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private NutriPlanContext _context;
        private IMapper _mapper;
        public UsuarioController(NutriPlanContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaUsuario([FromForm] CreateUsuarioDto createUsuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(createUsuarioDto);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }
    }
}
