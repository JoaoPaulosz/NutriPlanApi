using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Models
{
    public class Receita
    {
        [Key]
        public int receita_id {  get; set; }
        public string receita_nome { get; set; }
    }
}
