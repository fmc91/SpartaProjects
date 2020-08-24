using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLib
{
    public static class Lexer
    {
        private static char[] OperationChars = new char[] { '√', '^', '÷', '×', '+', '−' };

        private static Dictionary<char, UnaryOperator> UnaryOperators = new Dictionary<char, UnaryOperator>
        {
            {'+', UnaryOperator.Positive },
            {'−', UnaryOperator.Negative },
            {'√', UnaryOperator.SquareRoot }
        };

        private static Dictionary<char, BinaryOperator> BinaryOperators = new Dictionary<char, BinaryOperator>
        {
            {'^', BinaryOperator.Power },
            {'÷', BinaryOperator.Divide },
            {'×', BinaryOperator.Multiply },
            {'+', BinaryOperator.Add },
            {'−', BinaryOperator.Subtract }
        };

        private static bool IsOperationChar(char c)
        {
            return OperationChars.Contains(c);
        }

        private static bool IsUnaryOperationChar(char c)
        {
            return c == '+' || c == '−' || c == '√';
        }

        private static bool IsExclusiveUnaryOperationChar(char c)
        {
            return c == '√';
        }

        private static bool IsBracket(char c)
        {
            return c == '(' || c == ')';
        }

        public static List<Token> Tokenize(string input)
        {
            List<Token> output = new List<Token>();

            Token prevToken = null;
            
            string currentValue = String.Empty;

            void addCurrentValueToOutput()
            {
                if (currentValue != String.Empty)
                {
                    if (Double.TryParse(currentValue, out double parsedValue))
                        prevToken = new ValueToken(parsedValue);
                    else
                        throw new SyntaxErrorException();

                    output.Add(prevToken);
                    currentValue = String.Empty;
                }
            }

            bool inUnaryOperatorPosition()
            {
                return prevToken == null || prevToken is OperatorToken || prevToken is BracketToken b && b.Type == Bracket.Opening;
            }

            foreach (char c in input)
            {
                if (Char.IsWhiteSpace(c))
                {
                    addCurrentValueToOutput();
                }
                else if (Char.IsDigit(c) || c == '.')
                {
                    currentValue += c;
                }
                else if (IsOperationChar(c))
                {
                    addCurrentValueToOutput();

                    if (inUnaryOperatorPosition() && IsUnaryOperationChar(c))
                    {
                        prevToken = new UnaryOperatorToken(UnaryOperators[c]);
                        output.Add(prevToken);
                    }
                    else
                    {
                        if (IsExclusiveUnaryOperationChar(c))
                            throw new SyntaxErrorException();

                        prevToken = new BinaryOperatorToken(BinaryOperators[c]);
                        output.Add(prevToken);
                    }
                    
                }
                else if (IsBracket(c))
                {
                    addCurrentValueToOutput();

                    if (c == '(')
                    {
                        prevToken = new BracketToken(Bracket.Opening);
                        output.Add(prevToken);
                    }
                    else if (c == ')')
                    {
                        prevToken = new BracketToken(Bracket.Closing);
                        output.Add(prevToken);
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            addCurrentValueToOutput();

            return output;
        }
    }
}
