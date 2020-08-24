using System;

namespace CalculatorLib
{
    public enum UnaryOperator { Positive, Negative, SquareRoot }

    public enum BinaryOperator { Power, Multiply, Divide, Add, Subtract }

    public enum Bracket { Opening, Closing }

    public enum Associativity { Left, Right }

    public abstract class Token { }

    public abstract class OperatorToken : Token
    {
        public int Precedence { get; protected set; }
    }

    public class UnaryOperatorToken : OperatorToken
    {
        public UnaryOperator Type { get; }

        public UnaryOperatorToken(UnaryOperator type)
        {
            Type = type;
            Precedence = 4;
        }
    }

    public class BinaryOperatorToken : OperatorToken
    {
        public BinaryOperator Type { get; }

        public Associativity Associativity { get; }

        public BinaryOperatorToken(BinaryOperator type)
        {
            Type = type;

            switch (Type)
            {
                case BinaryOperator.Power:
                    Precedence = 3;
                    Associativity = Associativity.Right;
                    break;

                case BinaryOperator.Divide:
                case BinaryOperator.Multiply:
                    Precedence = 2;
                    Associativity = Associativity.Left;
                    break;

                case BinaryOperator.Add:
                case BinaryOperator.Subtract:
                    Precedence = 1;
                    Associativity = Associativity.Left;
                    break;
            }
        }
    }

    public class BracketToken : Token
    {
        public Bracket Type { get; }

        public BracketToken(Bracket type)
        {
            Type = type;
        }
    }

    public class ValueToken : Token
    {
        public double Value { get; }

        public ValueToken(double value)
        {
            Value = value;
        }
    }
}
