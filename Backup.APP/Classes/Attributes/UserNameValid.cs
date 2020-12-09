using Backup.APP.Library;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Backup.APP.Classes.Attributes
{
    public class UserNameValid : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Properties.DirectorySettings.GetFiles().Any(x => x.Name == value.ToString()))
            {
                return new ValidationResult("UserName já cadastrado", new string[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }
}
