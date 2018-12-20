using NUnit.Framework;
using System.Collections.Generic;

namespace Day3
{
    public class Part2Test
    {
        
        [Test]
        public void Test1()
        {
            List<string> claims = new List<string>() {
                "#1 @ 1,3: 4x4",
                "#2 @ 3,1: 4x4",
                "#3 @ 5,5: 2x2"
            };

            int result = Part2.FindOnlyNonOverlappingClaim(claims);

            Assert.AreEqual(3, result);
        }

       
    }
}