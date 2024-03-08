using System.ComponentModel.DataAnnotations;

namespace SistemaUsuarios.Api.Models
{
    /// <summary>
    /// classe de modelo de dados para o serviço de autenticação de usuário
    /// </summary>
    public class LoginModel
    {
        [Required(ErrorMessage = "Por favor, informe um e-mail de acesso")]
        [EmailAddress(ErrorMessage = "Por favor, informe o email de acesso")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor, informe a senha de acesso")]
        public string Senha { get; set; }
    }
}