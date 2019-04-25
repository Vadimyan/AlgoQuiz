using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task10
    {
        // Дана строка S длины N. Найти самую длинную подстроку S, встречающуюся в ней более одного раза.
        public static string GetMaxRepeatedSubstring(string s)
        {
            throw new NotImplementedException();
        }

        [Test]
        [TestCase("abcdefghijklmnopefghiqrstuvwxyz", "efghi")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "")]
        [TestCase("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("abcdefghijklmabnopqrstuvwxyz", "ab")]
        [TestCase("abcdefghijklmnopqrstuvwxyzz", "z")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "")]
        public void Task10Test(string s, string expectedResult)
        {
            var actualResult = Task10.GetMaxRepeatedSubstring(s);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
