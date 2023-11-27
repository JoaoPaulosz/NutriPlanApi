using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NutriPlanApi.Data;
using NutriPlanApi.Data.Dtos.Receita;
using NutriPlanApi.Models;

namespace NutriPlanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitaController :ControllerBase
    {
        private NutriPlanContext _context;
        private IMapper _mapper;
        public ReceitaController(NutriPlanContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CriaReceita([FromForm] CreateReceitaDto createReceitaDto)
        {
            Receita receita = _mapper.Map<Receita>(createReceitaDto);
            _context.receita.Add(receita);
            _context.SaveChanges();
            return Ok(receita);
        }
        [HttpGet("Id")]
        public IActionResult BuscaReceita(int id)
        {
            Receita receita = _context.receita.FirstOrDefault(x=> x.receita_id == id);
            if (receita == null)
            {
                return NotFound();
            }
            return Ok(receita);
        }
    }
}
