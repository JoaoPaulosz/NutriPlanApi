using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Models
{
    public class Usuario
    {
        [Key]
        public int usuario_id { get; set; }
        public string usuario_nome { get; set; }
        public string usuario_email { get; set; }
        public string usuario_senha { get; set; }
        public string? usuario_telefone { get; set; }
    }
}
