using System;
using System.Collections.Generic;

namespace CalculatorLib
{
    public static class Evaluator
    {
        private static Dictionary<UnaryOperator, Func<double, double>> UnaryOperations =
                   new Dictionary<UnaryOperator, Func<double, double>>
        {
            { UnaryOperator.Positive, a => a },

            { UnaryOperator.Negative, a => -a },

            { UnaryOperator.SquareRoot, SquareRoot }
        };

        private static Dictionary<BinaryOperator, Func<double, double, double>> BinaryOperations =
                   new Dictionary<BinaryOperator, Func<double, double, double>>
        {
            { BinaryOperator.Power, (a, b) => Math.Pow(a, b) },

            { BinaryOperator.Divide, Divide },

            { BinaryOperator.Multiply, (a, b) => a * b },

            { BinaryOperator.Add, (a, b) => a + b },

            { BinaryOperator.Subtract, (a, b) => a - b }
        };

        private static double SquareRoot(double a)
        {
            double result = Math.Sqrt(a);

            if (Double.IsNaN(result))
                throw new MathErrorException();

            return result;
        }

        private static double Divide(double a, double b)
        {
            if (b == 0)
                throw new MathErrorException();

            return a / b;
        }

        public static double Run(List<Token> input)
        {
            Stack<ValueToken> values = new Stack<ValueToken>();

            foreach (Token token in input)
            {
                if (token is ValueToken valueToken)
                {
                    values.Push(valueToken);
                }
                else if (token is UnaryOperatorToken unaryOpToken)
                {
                    double operand;

                    if (values.TryPop(out ValueToken operandToken))
                        operand = operandToken.Value;
                    else
                        throw new SyntaxErrorException();

                    double newValue = UnaryOperations[unaryOpToken.Type](operand);

                    values.Push(new ValueToken(newValue));
                }
                else if (token is BinaryOperatorToken binaryOpToken)
                {
                    double rOperand, lOperand;

                    if (values.TryPop(out ValueToken rOperandToken))
                        rOperand = rOperandToken.Value;
                    else
                        throw new SyntaxErrorException();

                    if (values.TryPop(out ValueToken lOperandToken))
                        lOperand = lOperandToken.Value;
                    else
                        throw new SyntaxErrorException();

                    double newValue = BinaryOperations[binaryOpToken.Type](lOperand, rOperand);
                    values.Push(new ValueToken(newValue));
                }
            }

            if (values.Count != 1)
                throw new SyntaxErrorException();

            return values.Pop().Value;
        }

    }
}
