using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NutriPlanApi.Data;
using NutriPlanApi.Data.Dtos;
using NutriPlanApi.Models;
using NutriPlanApi.Services;
using System.Security.Cryptography;

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
            usuario.usuario_senha = CalculateMd5.CalculateMD5Hash(usuario.usuario_senha);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Login),new {Email = usuario.usuario_email, Senha = usuario.usuario_senha},usuario);
        }
        [HttpGet]
        public IActionResult Login([FromQuery]string email, [FromQuery] string senha)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.usuario_email == email && x.usuario_senha == CalculateMd5.CalculateMD5Hash(senha));
            if(usuario == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(usuario);
            }
            
        }
    }
}
