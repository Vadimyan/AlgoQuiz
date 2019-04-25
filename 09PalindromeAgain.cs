using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task9
    {
        // Проверить является ли слово палиндромом, 
        // игнорируя регистр символов и все не буквенные символы в входной строке.
        public static bool IsPalindrome(string s)
        {
            throw new NotImplementedException();
        }

        [Test]
        [TestCase("Do Geese See God?", true)]
        [TestCase("   ", true)]
        [TestCase("ss", true)]
        [TestCase("sss", true)]
        [TestCase("s s", true)]
        [TestCase("?,,", true)]
        [TestCase("Do Geese sea God?", false)]
        public void Task9PositiveTest(string s, bool expectedResult)
        {
            var actualResult = Task9.IsPalindrome(s);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
