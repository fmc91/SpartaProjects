using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;

namespace BlogitGui
{
    public class UsernameValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = (string)value;

            bool valid = true;

            foreach (char c in input)
            {
                if (!IsValidUserNameChar(c))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                return ValidationResult.ValidResult;

            else
                return new ValidationResult(false, "Username can only contain letters, numeric digits and underscores");
        }

        private bool IsValidUserNameChar(char c) => Char.IsLetterOrDigit(c) || c == '_';
    }
}
