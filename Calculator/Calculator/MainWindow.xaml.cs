using System;
using System.Windows;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new CalculatorViewModel();

            InitHandlers();
        }

        public void InitHandlers()
        {
            OneBtn.Click += (s, e) => CharButtonClick?.Invoke('1');
            TwoBtn.Click += (s, e) => CharButtonClick?.Invoke('2');
            ThreeBtn.Click += (s, e) => CharButtonClick?.Invoke('3');
            FourBtn.Click += (s, e) => CharButtonClick?.Invoke('4');
            FiveBtn.Click += (s, e) => CharButtonClick?.Invoke('5');
            SixBtn.Click += (s, e) => CharButtonClick?.Invoke('6');
            SevenBtn.Click += (s, e) => CharButtonClick?.Invoke('7');
            EightBtn.Click += (s, e) => CharButtonClick?.Invoke('8');
            NineBtn.Click += (s, e) => CharButtonClick?.Invoke('9');
            ZeroBtn.Click += (s, e) => CharButtonClick?.Invoke('0');
            PointBtn.Click += (s, e) => CharButtonClick?.Invoke('.');
            MultiplyBtn.Click += (s, e) => CharButtonClick?.Invoke('×');
            DivideBtn.Click += (s, e) => CharButtonClick?.Invoke('÷');
            AddBtn.Click += (s, e) => CharButtonClick?.Invoke('+');
            SubtractBtn.Click += (s, e) => CharButtonClick?.Invoke('−');
            PowerBtn.Click += (s, e) => CharButtonClick?.Invoke('^');
            SqrtBtn.Click += (s, e) => CharButtonClick?.Invoke('√');
            OpenBracketBtn.Click += (s, e) => CharButtonClick?.Invoke('(');
            CloseBracketBtn.Click += (s, e) => CharButtonClick?.Invoke(')');

            DeleteBtn.Click += (s, e) => DeleteButtonClick?.Invoke();
            ClearBtn.Click += (s, e) => ClearButtonClick?.Invoke();
            EqualsBtn.Click += (s, e) => EqualsButtonClick?.Invoke();
            AnsBtn.Click += (s, e) => AnsButtonClick?.Invoke();
        }

        #region Events

        public event Action<char> CharButtonClick;
        public event Action DeleteButtonClick;
        public event Action ClearButtonClick;
        public event Action EqualsButtonClick;
        public event Action AnsButtonClick;

        #endregion
    }
}
