using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task11
    {
        // Даны массивы A и B из целых чисел. В каждом из массивов все числа уникальны. 
        // Нужно посчитать количество чисел, которые присутствуют только в одном из массивов.
        public static int FindSymmetricDifferenceSize(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Task11Test1()
        {
            var arr1 = new[]
            {
                1, 2, 4, 3, 9,
                8, 6, 7, 5, 0,
                -5, -4, -3, -2, -1
            };
            var arr2 = new[] { 5, 4, 3, 2, 1 };
            var actualResult1 = FindSymmetricDifferenceSize(arr1, arr2);
            var actualResult2 = FindSymmetricDifferenceSize(arr2, arr1);
            var expectedResult = 10;
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        public void Task11Test2()
        {
            var arr1 = new[]
            {
                1, 2, 4, 3, 9,
                8, 6, 7, 5, 0,
                -5, -4, -3, -2, -1
            };
            var arr2 = new[] { 5, 4, 3, 2, 1, 10, 14, 17, 21, 25 };
            var actualResult1 = FindSymmetricDifferenceSize(arr1, arr2);
            var actualResult2 = FindSymmetricDifferenceSize(arr2, arr1);
            var expectedResult = 15;
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        public void Task11Test3()
        {
            var arr1 = new[]
            {
                1, 2, 4, 3, 9,
                8, 6, 7, 5, 0,
                -5, -4, -3, -2, -1
            };
            var arr2 = new[] { 10, 14, 17, 21, 25 };
            var actualResult1 = FindSymmetricDifferenceSize(arr1, arr2);
            var actualResult2 = FindSymmetricDifferenceSize(arr2, arr1);
            var expectedResult = 20;
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        public void Task11Test4()
        {
            var arr1 = new[]
            {
                1, 2, 4, 3, 9,
                8, 6, 7, 5, 0,
                -5, -4, -3, -2, -1
            };
            var arr2 = new[]
            {
                -5, -4, -3, -2, -1,
                8, 6, 7, 5, 0,
                1, 2, 4, 3, 9,
            };
            var actualResult1 = FindSymmetricDifferenceSize(arr1, arr2);
            var actualResult2 = FindSymmetricDifferenceSize(arr2, arr1);
            var expectedResult = 0;
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }
    }
}
