using System.ComponentModel.DataAnnotations;

namespace CSMVC.Validations
{
    public class ContainsLetterAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Password required.");
            }

            string letter = @"abcdefghijklmnopqrstuvwxyz";
            foreach (char item in letter)
            {
                foreach(char ch in (string)value)
                {
                    if (ch==item)
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult("Password must contain at least one letter.");
        }
    }
}
