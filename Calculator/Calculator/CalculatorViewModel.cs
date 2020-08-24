using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class CalculatorViewModel : INotifyPropertyChanged
    {
        #region Private Backing Fields

        private string m_Input;

        private string m_Output;

        #endregion

        public CalculatorViewModel()
        {
            Input = String.Empty;
            Output = String.Empty;
        }

        public CalculatorViewModel(string input, string output)
        {
            Input = input;
            Output = output;
        }

        public string Input
        {
            get { return m_Input; }

            set
            {
                if (m_Input != value)
                {
                    m_Input = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Output
        {
            get { return m_Output; }

            set
            {
                if (m_Output != value)
                {
                    m_Output = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string callerName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
        }
    }
}
