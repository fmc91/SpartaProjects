using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlogitGui
{
    public class SignupViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool m_passwordsDontMatch;

        private bool m_passwordTooShort;

        public bool ValidationError { get; set; }

        public string ValidationMessage { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public bool PasswordTooShort
        {
            get { return m_passwordTooShort; }

            set
            {
                if (m_passwordTooShort != value)
                {
                    m_passwordTooShort = value;
                    NotifyOfPropertyChanged();
                }
            }
        }

        public bool PasswordsDontMatch
        {
            get { return m_passwordsDontMatch; }

            set
            {
                if (m_passwordsDontMatch != value)
                {
                    m_passwordsDontMatch = value;
                    NotifyOfPropertyChanged();
                }
            }
        }

        private void NotifyOfPropertyChanged([CallerMemberName] string callerName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
        }
    }
}
