using NUnit.Framework;
using System.Collections.Generic;

namespace Day6
{
    public class Part1Test
    {
        
        [Test]
        public void Test1()
        {
            List<string> data = new List<string>() {
                "1, 1", "1, 6", "8, 3",
                "3, 4", "5, 5", "8, 9"
            };

            int result = Part1.MaxNonInfiniteSpace(data);
            Assert.AreEqual(17, result);
        }

    }
}