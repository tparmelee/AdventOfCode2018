using NUnit.Framework;
using System.Collections.Generic;

namespace Day2
{
    public class Part2Test
    {
        
        [Test]
        public void Test1()
        {
            List<string> input = new List<string>() {
                "abcde", "fghij", "klmno",
                "pqrst", "fguij", "axcye",
                "wvxyz"
            };
            string result = Part2.FindPrototypeBox(input);
            Assert.AreEqual("fgij", result);
        }

       
    }
}