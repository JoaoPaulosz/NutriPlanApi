using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Models
{
    public class Refeicao
    {
        [Key]
        public int refeicao_id { get; set; }
        public string refeicao_nome { get; set; }
        public int receita_id { get; set; }
    }
}
