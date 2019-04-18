using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task2
    {
        // Написать функцию, которая получает на вход массив и искомое число и возвращает 2 элемента в массиве, 
        // которые в сумме дадут это число (за n^2 решать не надо).
        public static Tuple<int, int> GetPair(int[] arr, int expectedResult)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Task2Test1()
        {
            var array = new []{ 5, 7, 1, 2, 12, 3, 4 };
            var actualResult = Task2.GetPair(array, 19);
            Assert.AreEqual(5, actualResult.Item1);
            Assert.AreEqual(12, actualResult.Item2);
        }

        [Test]
        public void Task2Test2()
        {
            var array = new[] { 5, 7, 1, 19, 2, 12, 0, 3, 4 };
            var actualResult = Task2.GetPair(array, 19);
            Assert.AreEqual(0, actualResult.Item1);
            Assert.AreEqual(19, actualResult.Item2);
        }

        [Test]
        public void Task2Test3()
        {
            var array = new[] { 5, 7, 1, 19, 5, 2, 12, 0, 3, 4 };
            var actualResult = Task2.GetPair(array, 10);
            Assert.AreEqual(5, actualResult.Item1);
            Assert.AreEqual(5, actualResult.Item2);
        }

        [Test]
        public void Task2Test4()
        {
            var array = new[] { 5, 7, 1, 19, 5, 2, 12, 0, 3, 4 };
            Assert.Throws<ArgumentOutOfRangeException>(() => Task2.GetPair(array, 10));
        }
    }
}
