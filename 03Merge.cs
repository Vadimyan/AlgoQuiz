using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task3
    {
        // Написать функцию, которая принимает на вход 2 отсортированных массива целых чисел 
        // и возвращает отсортированный массив, состоящий из элементов исходных массивов.
        public static int[] Merge(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Task3Test1()
        {
            var arr1 = new[] { 1, 3, 5 };
            var arr2 = new[] { 2, 4, 6 };
            var actualResult = Task3.Merge(arr1, arr2);
            Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, actualResult);
        }

        [Test]
        public void Task3Test2()
        {
            var arr1 = new[] { 1, 3, 5 };
            var arr2 = new[] { 2, 3, 3, 3 };
            var actualResult = Task3.Merge(arr1, arr2);
            Assert.AreEqual(new[] { 1, 2, 3, 3, 3, 3, 5 }, actualResult);
        }

        [Test]
        public void Task3Test3()
        {
            var arr1 = new[] { -5, 11, 16 };
            var arr2 = new int[0];
            var actualResult = Task3.Merge(arr1, arr2);
            Assert.AreEqual(new[] { -5, 11, 16 }, actualResult);
        }


    }
}
