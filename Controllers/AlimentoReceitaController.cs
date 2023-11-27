using Microsoft.AspNetCore.Mvc;
using NutriPlanApi.Data;
using NutriPlanApi.Models;

namespace NutriPlanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlimentoReceitaController :ControllerBase
    {
        private NutriPlanContext _context;
        public AlimentoReceitaController(NutriPlanContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult VinculaAlimentoReceita([FromForm] AlimentoReceita alimentoReceita)
        {
            _context.alimentoReceita.Add(alimentoReceita);
            _context.SaveChanges();
            return Ok(alimentoReceita);
        }
    }
}
