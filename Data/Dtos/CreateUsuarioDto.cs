using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string usuario_nome { get; set; }
        public string usuario_email { get; set; }
        public string usuario_senha { get; set; }
        public string? usuario_telefone { get; set; }
    }
}
