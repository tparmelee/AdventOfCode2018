using NUnit.Framework;
using System.Collections.Generic;

namespace Day5
{
    public class PolymerTests
    {
        
        [Test]
        public void Test1()
        {
            string sample = "aA";
            Polymer polymer = new Polymer(sample);
            Assert.AreEqual("", polymer.Reacted);
        }

        [Test]
        public void Test2()
        {
            string sample = "abAB";
            Polymer polymer = new Polymer(sample);
            Assert.AreEqual("abAB", polymer.Reacted);
        }

        [Test]
        public void Test3()
        {
            string sample = "aabAAB";
            Polymer polymer = new Polymer(sample);
            Assert.AreEqual("aabAAB", polymer.Reacted);
        }

        [Test]
        public void Test4()
        {
            string sample = "dabAcCaCBAcCcaDA";
            Polymer polymer = new Polymer(sample);
            Assert.AreEqual("dabCBAcaDA", polymer.Reacted);
        }


    }
}