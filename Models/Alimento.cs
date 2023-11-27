using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NutriPlanApi.Models
{
    public class Alimento
    {
        public string alimento_nome {  get; set; }
        [JsonIgnore]
        public virtual Usuario Usuario { get; set; }
        public int usuario_id {  get; set; }
        [Key]
        public int alimento_id { get; set; }
    }
}
