using NUnit.Framework;
using System.Collections.Generic;

namespace Day1
{
    public class Part1Tests
    {
        
        [Test]
        public void Test1()
        {
            List<int> input = new List<int>() {1, -2, 3, 1};
            int result = Part1.CalculateFrequency(input);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            List<int> input = new List<int>() {1, 1, 1};
            int result = Part1.CalculateFrequency(input);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test3()
        {
            List<int> input = new List<int>() {1, 1, -2};
            int result = Part1.CalculateFrequency(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test4()
        {
            List<int> input = new List<int>() {-1, -2, -3};
            int result = Part1.CalculateFrequency(input);
            Assert.AreEqual(-6, result);
        }
    }
}