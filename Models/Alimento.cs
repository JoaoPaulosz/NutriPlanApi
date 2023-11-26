using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Models
{
    public class Alimento
    {
        public string alimento_nome {  get; set; }
        public virtual Usuario Usuario { get; set; }
        public int usuario_id {  get; set; }
        [Key]
        public int alimento_id { get; set; }
    }
}
