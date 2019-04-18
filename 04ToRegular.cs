using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task4
    {
        // Дана неправильная скобочная последовательность из круглых скобок. 
        // Нужно добавить в нее наименьшее количество скобок, чтобы получилась правильная последовательность.
        // Можно добавлять скобки разных способом, поэтому посмотрите на тестовые данные чтобы узнать нужный.
        public static string ToRegular(string input)
        {
            throw new NotImplementedException();
        }

        [Test]
        [TestCase("))())(", "(())()()()")]
        [TestCase("))))", "(((())))")]
        [TestCase("()()()", "()()()")]
        [TestCase("((()))(", "((()))()")]
        public void Task4PositiveTest(string input, string expectedResult)
        {
            var actualResult = Task4.ToRegular(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
