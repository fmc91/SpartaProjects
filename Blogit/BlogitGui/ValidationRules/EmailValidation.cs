using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace BlogitGui
{
    public class EmailValidation : ValidationRule
    {
        private Regex m_emailRegex;

        public EmailValidation()
        {
            m_emailRegex = new Regex(@"\A[\w_]+(\.?[\w_]+)*@[\w_]+(-[\w_]+)*(\.[\w_]+(-[\w_]+)*)+\z");
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = (string)value;

            if (m_emailRegex.IsMatch(input))
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, "Invalid email address");
        }
    }
}
