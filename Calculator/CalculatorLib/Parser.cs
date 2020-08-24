using System;
using System.Collections.Generic;

namespace CalculatorLib
{
    public static class Parser
    {
        public static List<Token> ToRpn(List<Token> input)
        {
            List<Token> output = new List<Token>();

            Stack<Token> symbolStack = new Stack<Token>();

            foreach (Token token in input)
            {
                if (token is ValueToken)
                {
                    output.Add(token);
                }
                else if (token is UnaryOperatorToken unaryOpToken)
                {
                    symbolStack.Push(unaryOpToken);
                }
                else if (token is BinaryOperatorToken binaryOpToken)
                {
                    while
                    (
                        symbolStack.Count != 0                &&
                        !(symbolStack.Peek() is BracketToken) &&
                        (
                            ((OperatorToken)symbolStack.Peek()).Precedence > binaryOpToken.Precedence   ||
                            ((OperatorToken)symbolStack.Peek()).Precedence == binaryOpToken.Precedence  &&
                            binaryOpToken.Associativity == Associativity.Left
                        )
                    )
                    {
                        output.Add(symbolStack.Pop());
                    }

                    symbolStack.Push(binaryOpToken);
                }
                else if (token is BracketToken bracketToken)
                {
                    if (bracketToken.Type == Bracket.Opening)
                    {
                        symbolStack.Push(bracketToken);
                    }
                    else if (bracketToken.Type == Bracket.Closing)
                    {
                        Token poppedToken;

                        do
                        {
                            if (symbolStack.Count == 0)
                                throw new SyntaxErrorException();

                            poppedToken = symbolStack.Pop();

                            if (!(poppedToken is BracketToken))
                                output.Add(poppedToken);

                        } while (!(poppedToken is BracketToken));
                    }
                }
            }

            Token poppedSymbol;

            while (symbolStack.Count != 0)
            {
                poppedSymbol = symbolStack.Pop();

                if (poppedSymbol is BracketToken)
                    throw new SyntaxErrorException();

                output.Add(poppedSymbol);
            }

            return output;
        }
    }
}
