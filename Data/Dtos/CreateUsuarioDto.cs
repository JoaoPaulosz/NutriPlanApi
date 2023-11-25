using System.ComponentModel.DataAnnotations;

namespace NutriPlanApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string UsuarioNome;
        [Required(ErrorMessage = "O email é obrigatório")]
        public string UsuarioEmail;
        [Range(4,10,ErrorMessage ="a senha deve ter no mínimo 4 e não pode ultrapassar 10 carácteres!")]
        [Required(ErrorMessage = "a senha é obrigatório")]
        public string UsuarioSenha;
        public string? UsuarioTelefone;
    }
}
