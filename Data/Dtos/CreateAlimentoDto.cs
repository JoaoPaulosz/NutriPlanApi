using NutriPlanApi.Models;
using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Data.Dtos
{
    public class CreateAlimentoDto
    {
        [Required]
        public Usuario usuario_id { get; set; }
        public string alimento_nome { get; set; }
    }
}
