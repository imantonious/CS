using System.ComponentModel.DataAnnotations;

namespace CSMVC.Validations
{
    public class ContainsSpecialCharacter : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Password required.");
            }

            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (char spch in specialChar)
            {
                foreach(char ch in (string)value)
                {
                    if (ch == spch)
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult("Password must contain at least one special character.");
        }
    }
}