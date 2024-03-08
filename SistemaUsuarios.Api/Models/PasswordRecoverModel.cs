using System.ComponentModel.DataAnnotations;

namespace SistemaUsuarios.Api.Models
{
    /// <summary>
    /// Modelo de dados para o serviço de recuperação de senha do usuário
    /// </summary>
    public class PasswordRecoverModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email para recuperação da senha.")]
        public string Email { get; set; }
    }
}
