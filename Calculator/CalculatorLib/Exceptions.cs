using System;

namespace CalculatorLib
{
    public class SyntaxErrorException : Exception
    {
        public SyntaxErrorException() : base("Syntax Error") { }
    }

    public class MathErrorException : Exception
    {
        public MathErrorException() : base("Math Error") { }
    }
}
