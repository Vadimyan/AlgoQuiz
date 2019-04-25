using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task5
    {
        // В массиве чисел найти подмассив длины m с максимальной суммой, вернуть эту сумму.
        // Запрещается использовать другие массивы.
        public static int GetMaxSubarray(int[] arr, int m)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Task5Test1()
        {
            var arr = new[] { 1, 2, 6, 4, 7, 2, -5, 2, 11 };
            var actual = Task5.GetMaxSubarray(arr, 3);
            Assert.AreEqual(17, actual);
        }

        [Test]
        public void Task5Test2()
        {
            var arr = new[] { 1, 2, 6, 4, 7, 2, -5, 2, 11 };
            var actual = Task5.GetMaxSubarray(arr, 2);
            Assert.AreEqual(13, actual);
        }

        [Test]
        public void Task5Test3()
        {
            var arr = new[] { 1, 2, 6, 4, 7, 2, -5, 2, 11 };
            var actual = Task5.GetMaxSubarray(arr, 1);
            Assert.AreEqual(11, actual);
        }

        [Test]
        public void Task5Test4()
        {
            var arr = new[] { -1, -2, -6, -4, -7, -2, -5, -2, -11 };
            var actual = Task5.GetMaxSubarray(arr, 2);
            Assert.AreEqual(-3, actual);
        }
    }
}
