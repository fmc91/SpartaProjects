using NUnit.Framework;
using CalculatorLib;
using System.Collections.Generic;
using System;

namespace CalculatorTest
{
    public class Tests
    {
        // Infix: 8 * 3 - 10
        // RPN:   8 3 * 10 -
        [Test]
        public void Test1()
        {
            List<Token> input = new List<Token>
            {
                new ValueToken(8),
                new ValueToken(3),
                new BinaryOperatorToken(BinaryOperator.Multiply),
                new ValueToken(10),
                new BinaryOperatorToken(BinaryOperator.Subtract)
            };

            double expected = 14;
            double actual = Evaluator.Run(input);

            Assert.AreEqual(expected, actual);
        }

        // Infix: (28 - 4) / 6
        // RPN:   28 4 - 6 /
        [Test]
        public void Test2()
        {
            List<Token> input = new List<Token>
            {
                new ValueToken(28),
                new ValueToken(4),
                new BinaryOperatorToken(BinaryOperator.Subtract),
                new ValueToken(6),
                new BinaryOperatorToken(BinaryOperator.Divide)
            };

            double expected = 4;
            double actual = Evaluator.Run(input);

            Assert.AreEqual(expected, actual);
        }


        // Infix: √36 * 5
        // RPN:   36 √ 5 *
        [Test]
        public void Test3()
        {
            List<Token> input = new List<Token>
            {
                new ValueToken(36),
                new UnaryOperatorToken(UnaryOperator.SquareRoot),
                new ValueToken(5),
                new BinaryOperatorToken(BinaryOperator.Multiply)
            };

            double expected = 30;
            double actual = Evaluator.Run(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideByZeroTest()
        {
            List<Token> input = new List<Token>
            {
                new ValueToken(7),
                new ValueToken(0),
                new BinaryOperatorToken(BinaryOperator.Divide)
            };

            MathErrorException ex = Assert.Throws<MathErrorException>(() => Evaluator.Run(input));

            Assert.AreEqual("Math Error", ex.Message);
        }

        [Test]
        public void SquareRootNegative()
        {
            List<Token> input = new List<Token>
            {
                new ValueToken(1),
                new UnaryOperatorToken(UnaryOperator.Negative),
                new UnaryOperatorToken(UnaryOperator.SquareRoot)
            };

            MathErrorException ex = Assert.Throws<MathErrorException>(() => Evaluator.Run(input));

            Assert.AreEqual("Math Error", ex.Message);
        }
    }
}