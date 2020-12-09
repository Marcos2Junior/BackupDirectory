using Backup.APP.Classes.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Backup.APP.Models
{
    public class NewAccount
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Deve ter entre 5 e 10 caracteres")]
        [UserNameValid]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Deve ter entre 8 e 20 caracteres")]
        [PasswordValid]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [ComparePassword(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Deve ter entre 10 e 50 caracteres")]
        public string PasswordHint { get; set; }

        [ConcordTerms]
        public bool ConcordTerms { get; set; }
    }
}
