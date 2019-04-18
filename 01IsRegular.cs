using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task1
    {
        // На вход дана строка вида "(([])[({})])" (содержит разные скобки). 
        // Проверить, что строка содержит правильно вложенные друг в друга скобки.
        public static bool IsRegular(string s)
        {
            throw new Exception();
        }

        [Test]
        [TestCase("()", true)]
        [TestCase("(([])[({})])", true)]
        [TestCase("(([])([{})])", false)]
        [TestCase("{{{{{}}}}}", true)]
        [TestCase("", true)]
        public void Task01PositiveTest(string input, bool expectedResult)
        {
            var actualResult = Task1.IsRegular(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Task01NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => Task1.IsRegular(null));
        }
    }
}
