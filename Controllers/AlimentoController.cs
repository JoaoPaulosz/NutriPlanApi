using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NutriPlanApi.Data;
using NutriPlanApi.Data.Dtos.Alimento;
using NutriPlanApi.Models;

namespace NutriPlanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlimentoController : ControllerBase
    {
        private NutriPlanContext _context;
        private IMapper _mapper;
        public AlimentoController(NutriPlanContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("id")]
        public IActionResult BuscaAlimentoPorId(int id)
        {
            Alimento aliemento = _context.alimento.FirstOrDefault(x => x.alimento_id == id);
            if (aliemento == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(aliemento);
            }
        }

        [HttpPost]
        public IActionResult CriaAlimento([FromForm] CreateAlimentoDto createAlimentoDto)
        {
            Alimento alimento = _mapper.Map<Alimento>(createAlimentoDto);
            _context.alimento.Add(alimento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscaAlimentoPorId), new { Id = alimento.alimento_id }, alimento);
        }
        [HttpGet]
        public IActionResult BuscaListaAlimentos()
        {
            List<Alimento> alimentos = _context.alimento.ToList();
            return Ok(alimentos);
        }
    }
}
