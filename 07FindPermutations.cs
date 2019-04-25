using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuiz
{
    public class Task7
    {
        // Даны два массива из целых чисел от 1 до 100: длины n и длины N (n < N). 
        // Определить для каждого подмассива второго массива длины n, является ли он перестановкой первого массива.
        public static bool[] FindPermutations(int[] bigArray, int[] smallArray)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Task7Test1()
        {
            var bigArr = new[] 
            {
                1, 8, 8, 6, 4,
                3, 3, 2, 6, 8,
                8, 6, 1, 6, 8,
                8, 5, 4
            };
            var smallArr = new[] { 6, 1, 8, 8 };
            var actual = Task7.FindPermutations(bigArr, smallArr);
            Assert.AreEqual(true, actual[0]);
            Assert.AreEqual(false, actual[1]);
            Assert.AreEqual(false, actual[2]);
            Assert.AreEqual(false, actual[3]);
            Assert.AreEqual(false, actual[4]);
            Assert.AreEqual(false, actual[5]); // 3 3 2 6
            Assert.AreEqual(false, actual[6]);
            Assert.AreEqual(false, actual[7]);
            Assert.AreEqual(false, actual[8]); // 6 8 8 6
            Assert.AreEqual(true, actual[9]); // 8 8 6 1
            Assert.AreEqual(false, actual[10]);
            Assert.AreEqual(false, actual[11]);
            Assert.AreEqual(true, actual[12]); // 1 6 8 8
            Assert.AreEqual(false, actual[13]);
            Assert.AreEqual(false, actual[14]);
        }

        [Test]
        public void Task7Test2()
        {
            var bigArr = new[]
            {
                1, 8, 8, 6, 4,
                3, 3, 2, 6, 8,
                8, 6, 1, 6, 8,
                8, 5, 4
            };
            var smallArr = new[] { 6, 9, 8, 8 };
            var actual = Task7.FindPermutations(bigArr, smallArr);
            Assert.AreEqual(false, actual[0]);
            Assert.AreEqual(false, actual[1]);
            Assert.AreEqual(false, actual[2]);
            Assert.AreEqual(false, actual[3]);
            Assert.AreEqual(false, actual[4]);
            Assert.AreEqual(false, actual[5]); // 3 3 2 6
            Assert.AreEqual(false, actual[6]);
            Assert.AreEqual(false, actual[7]);
            Assert.AreEqual(false, actual[8]); // 6 8 8 6
            Assert.AreEqual(false, actual[9]); // 8 8 6 1
            Assert.AreEqual(false, actual[10]);
            Assert.AreEqual(false, actual[11]);
            Assert.AreEqual(false, actual[12]); // 1 6 8 8
            Assert.AreEqual(false, actual[13]);
            Assert.AreEqual(false, actual[14]);
        }
    }
}
