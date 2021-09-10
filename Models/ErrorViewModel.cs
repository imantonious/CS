using System.ComponentModel.DataAnnotations;

namespace CSMVC.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class ContainsLetter : ValidationAttribute
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

    public class ContainsNumber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Password required.");
            }

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
