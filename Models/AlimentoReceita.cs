using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NutriPlanApi.Models
{
    [Keyless]
    public class AlimentoReceita
    {
        [Key]
        public int alimento_id { get; set; }
        [Key]
        public int receita_id { get; set; }

        [JsonIgnore]
        public virtual List<Alimento> Alimentos { get; set; }
        [JsonIgnore]
        public virtual Receita Receita { get;}
    }
}
