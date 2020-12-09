using System.ComponentModel.DataAnnotations;

namespace Backup.APP.Classes.Attributes
{
    public class ComparePassword : CompareAttribute
    {
        public ComparePassword(string otherProperty) : base(otherProperty)
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (string.IsNullOrEmpty(validationResult.ErrorMessage))
            {
                return ValidationResult.Success;
            }
            
            return new ValidationResult("Senhas não conferem", new string[] { validationContext.MemberName });
        }
    }
}
