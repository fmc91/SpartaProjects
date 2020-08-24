using System;
using System.Collections.Generic;
using System.Text;
using CalculatorLib;

namespace Calculator
{
    public class CalculatorController
    {
        private MainWindow AppWindow;

        private CalculatorViewModel ViewModel;

        private StringBuilder Expression;

        private string Output;

        private double PrevResult;

        public CalculatorController(MainWindow appWindow)
        {
            AppWindow = appWindow;

            ViewModel = (CalculatorViewModel)AppWindow.DataContext;

            InitHandlers();

            Expression = new StringBuilder();
        }

        private void InitHandlers()
        {
            AppWindow.CharButtonClick += OnCharButtonClick;
            AppWindow.DeleteButtonClick += OnDeleteButtonClick;
            AppWindow.ClearButtonClick += OnClearButtonClick;
            AppWindow.EqualsButtonClick += OnEqualsButtonClick;
            AppWindow.AnsButtonClick += OnAnsButtonClick;
        }

        private void OnCharButtonClick(char c)
        {
            Expression.Append(c);

            UpdateView();
        }

        private void OnDeleteButtonClick()
        {
            if (Expression.Length != 0)
                Expression.Remove(Expression.Length - 1, 1);

            UpdateView();
        }

        private void OnClearButtonClick()
        {
            Expression.Clear();

            Output = String.Empty;

            PrevResult = 0;

            UpdateView();
        }

        private void OnEqualsButtonClick()
        {
            string input = Expression.ToString();

            try
            {
                List<Token> tokenizedInput = Lexer.Tokenize(input);

                List<Token> rpnInput = Parser.ToRpn(tokenizedInput);

                PrevResult = Evaluator.Run(rpnInput);

                Output = PrevResult.ToString();
            }
            catch (MathErrorException ex)
            {
                PrevResult = 0;
                
                Output = ex.Message;
            }
            catch (SyntaxErrorException ex)
            {
                PrevResult = 0;

                Output = ex.Message;
            }

            UpdateView();

            Expression.Clear();
        }

        private void OnAnsButtonClick()
        {
            Expression.Append(PrevResult.ToString());

            UpdateView();
        }

        private void UpdateView()
        {
            ViewModel.Input = Expression.ToString();

            ViewModel.Output = Output;
        }
    }
}
