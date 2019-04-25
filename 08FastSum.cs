using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task8
    {
        // Дан массив. Сделав его предобработку, научиться быстро находить сумму чисел на отрезке[L, R].
        public static int GetSum(int[] arr, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }

        private static readonly int[] testArray = new int[] 
        {
            13, 57, 48, 95, 36,
            33, 57, 31, 1, 7,
            -6, 12, 5, 8, 98,
            -43, 81, 14, 25, 6,
            16
        };

        [Test]
        [TestCase(5, 7, 121)]
        [TestCase(5, 10, 129)]
        [TestCase(10, 10, -6)]
        [TestCase(10, 12, 11)]
        public void Task8Test(int l, int r, int expectedSum)
        {
            var actualSum = Task8.GetSum(testArray, l, r);
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
