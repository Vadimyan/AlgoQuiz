using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task6
    {
        // Даны два массива. Входит ли первый массив во второй как подпоследовательность?
        public static bool Contains(int[] arr1, int[] arr2)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Task6Test1()
        {
            var arr1 = new int[] { 7, 3, 7, 7, 3, 6, 8, 9, 6, 4, 7, 4, 32, 22, 65, 6, 44, 3, 8, 0, -6, 5 };
            var arr2 = new int[] { 6, 8, 9, 6 };
            var actual = Task6.Contains(arr1, arr2);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Task6Test2()
        {
            var arr1 = new int[] { 7, 3, 7, 7, 3, 6, 8, 9, 6, 4, 7, 4, 32, 22, 65, 6, 44, 3, 8, 0, -6, 5 };
            var arr2 = new int[] { 6, 8, 9, 6 };
            var actual = Task6.Contains(arr1, arr1);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Task6Test3()
        {
            var arr1 = new int[] { 7, 3, 7, 7, 3, 6, 8, 9, 6, 4, 7, 4, 32, 22, 65, 6, 44, 3, 8, 0, -6, 5 };
            var arr2 = new int[] { 6, 8, 9, 6, 0 };
            var actual = Task6.Contains(arr1, arr2);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Task6Test4()
        {
            var arr1 = new int[] { 7, 3, 7, 7, 3, 6, 8, 9, 6, 4, 7, 4, 32, 22, 65, 6, 44, 3, 8, 0, -6, 5 };
            var arr2 = new int[] { -6, 5 };
            var actual = Task6.Contains(arr1, arr2);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Task6Test5()
        {
            var arr1 = new int[] { 7, 3, 7, 7, 3, 6, 8, 9, 6, 4, 7, 4, 32, 22, 65, 6, 44, 3, 8, 0, -6, 5 };
            var arr2 = new int[] { -3, 0, -6, 5 };
            var actual = Task6.Contains(arr1, arr2);
            Assert.AreEqual(false, actual);
        }
    }
}
