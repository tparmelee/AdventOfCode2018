using NUnit.Framework;
using System.Collections.Generic;

namespace Day2
{
    public class Part1Test
    {
        
        [Test]
        public void Test1()
        {
            List<string> input = new List<string>() {"abcdef", "bababc", "abbcde", 
                                                "abcccd", "aabcdd", "abcdee", "ababab"};
            int result = Part1.CalculateCheckSum(input);
            Assert.AreEqual(12, result);
        }

    }
}