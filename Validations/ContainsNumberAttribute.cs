using System.ComponentModel.DataAnnotations;

namespace CSMVC.Validations
{
    public class ContainsNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Password required.");
            }

            System.Console.WriteLine(value);

            string numbers = @"0123456789";
            foreach (char num in numbers)
            {
                foreach(char ch in (string)value)
                {
                    if (ch == num)
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult("Password must contain at least one number");
        }
    }
}