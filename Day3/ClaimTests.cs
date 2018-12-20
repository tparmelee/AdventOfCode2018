using NUnit.Framework;
using System.Collections.Generic;

namespace Day3
{
    public class ClaimTests
    {

        [Test]
        public void Test1()
        {
            string testClaim = "#123 @ 3,2: 5x4";
            Claim desired = new Claim
            {
                id = 123,
                left = 3,
                top = 2,
                width = 5,
                height = 4
            };

            Claim parsed = Claim.Parse(testClaim);

            Assert.AreEqual(desired.id, parsed.id);
            Assert.AreEqual(desired.left, parsed.left);
            Assert.AreEqual(desired.top, parsed.top);
            Assert.AreEqual(desired.width, parsed.width);
            Assert.AreEqual(desired.height, parsed.height);
        }

    }
}