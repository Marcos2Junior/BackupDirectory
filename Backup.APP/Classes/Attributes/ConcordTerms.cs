using System.ComponentModel.DataAnnotations;

namespace Backup.APP.Classes.Attributes
{
    public class ConcordTerms : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value.ToString() != bool.TrueString)
            {
                return new ValidationResult("Necessário concordar com os termos e condições", new string[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }
}
