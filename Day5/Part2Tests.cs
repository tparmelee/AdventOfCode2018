using NUnit.Framework;
using System.Collections.Generic;

namespace Day5
{
    public class Part2Test
    {
        
        [Test]
        public void Test1()
        {
            string sample = "dabAcCaCBAcCcaDA";
            int result = Part2.FindPolymerOfShortestLength(sample);
            Assert.AreEqual(4, result);
        }

       
    }
}