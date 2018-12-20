using NUnit.Framework;
using System.Collections.Generic;

namespace Day5
{
    public class Part1Test
    {

        [Test]
        public void Test5()
        {
            string sample = "aA";
            int result = Part1.GetRemainingPolymerCount(sample);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test6()
        {
            string sample = "abAB";
            int result = Part1.GetRemainingPolymerCount(sample);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test7()
        {
            string sample = "aabAAB";
            int result = Part1.GetRemainingPolymerCount(sample);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Test8()
        {
            string sample = "dabAcCaCBAcCcaDA";
            int result = Part1.GetRemainingPolymerCount(sample);
            Assert.AreEqual(10, result);
        }
    }
}