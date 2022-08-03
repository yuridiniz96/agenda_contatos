using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Mvc.Models
{
    public class AccountRegisterModel
    {

        [MinLength(6, ErrorMessage = "Por favor, informe o nome completo.")]
        [MaxLength (50, ErrorMessage = "A quantidade máxima de caracteres é de {1}." )]
        [Required (ErrorMessage = "Por favor, informe seu nome.")]
        public string Nome { get; set; }


        [EmailAddress (ErrorMessage = "Por favor, informe um endereço de e-mail válido.")]
        [Required (ErrorMessage = "Por favor, informe seu Email.")]
        public string Email { get; set; }


        [MinLength (8, ErrorMessage = "A senha deve conter no minimo {1} caracteres.")]
        [MaxLength (20, ErrorMessage = "A senha deve conter no máximo {1} caracteres.")]
        [Required (ErrorMessage = "Por favor, informe sua Senha.")]
        public string Senha { get; set; }


        [Compare("Senha", ErrorMessage = "Senhas não conferem, por favor verifique.")]
        [Required (ErrorMessage = "Por favor, confirme sua senha.")]
        public string SenhaConfirmacao { get; set; }
    }
}
