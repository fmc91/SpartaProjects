using System;
using System.Collections.Generic;

namespace BlogitGui
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            ValidationMessage = String.Empty;
        }

        public bool ValidationError { get; set; }

        public string ValidationMessage { get; set; }
    }
}
