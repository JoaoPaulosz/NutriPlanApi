using NutriPlanApi.Models;
using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Data.Dtos.Alimento
{
    public class CreateAlimentoDto
    {
        [Required]
        public int usuario_id { get; set; }
        public string alimento_nome { get; set; }
    }
}
