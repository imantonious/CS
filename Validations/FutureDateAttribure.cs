using System;
using System.ComponentModel.DataAnnotations;

namespace CSMVC.Validations
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (value == null)
            {
                return new ValidationResult("Date required.");
            }

            DateTime? dateValue = value as DateTime?;

            if (dateValue < DateTime.Now)
            {
                return new ValidationResult("Date must be in the future.");
            }

            return ValidationResult.Success;
        }
    }
}