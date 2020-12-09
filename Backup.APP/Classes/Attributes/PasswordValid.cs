using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Backup.APP.Classes.Attributes
{
    public class PasswordValid : ValidationAttribute
    {
        private string Value;
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Value = value.ToString();

            var result = new string[]
            {
                HasWhiteSpace,
                HasLetterLower,
                HasNumbers,
                HasSimbols,
                HasLettersUpper
            }
            .Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (result.Any())
            {
                string errorMessage = "Senha inválida: \n\n";
                foreach (var item in result)
                {
                    errorMessage += $"* {item}\n";
                }

                return new ValidationResult(errorMessage, new string[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }

        private string HasWhiteSpace => Value.Any(x => char.IsWhiteSpace(x)) ? "Não é permitido espaços em branco" : string.Empty;
        private string HasLetterLower => !Value.Any(x => char.IsLower(x)) ? "Deve ter ao menos uma letra minúscula" : string.Empty;
        private string HasNumbers => !Value.Any(x => char.IsNumber(x)) ? "Deve ter ao menos um número" : string.Empty;
        private string HasSimbols => !Value.Any(x => char.IsSymbol(x)) ? "Deve ter ao menos um símbolo" : string.Empty;
        private string HasLettersUpper => !Value.Any(x => char.IsUpper(x)) ? "Deve ter ao menos uma letra maiuscula" : string.Empty;
    }
}
