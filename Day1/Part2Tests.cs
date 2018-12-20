using NUnit.Framework;
using System.Collections.Generic;

namespace Day1
{
    public class Part2Tests
    {
        
        [Test]
        public void Test1()
        {
            List<int> input = new List<int>() {1, -2, 3, 1};
            int result = Part2.CalculateFirstRepeatedFrequency(input);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            List<int> input = new List<int>() {1, -1};
            int result = Part2.CalculateFirstRepeatedFrequency(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test3()
        {
            List<int> input = new List<int>() {3, 3, 4, -2, -4};
            int result = Part2.CalculateFirstRepeatedFrequency(input);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Test4()
        {
            List<int> input = new List<int>() {-6, 3, 8, 5, -6};
            int result = Part2.CalculateFirstRepeatedFrequency(input);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test5()
        {
            List<int> input = new List<int>() {7, 7, -2, -7, -4};
            int result = Part2.CalculateFirstRepeatedFrequency(input);
            Assert.AreEqual(14, result);
        }
    }
}