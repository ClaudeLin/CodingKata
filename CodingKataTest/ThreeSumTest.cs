using System;
using System.Collections.Generic;
using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture()]
    public class ThreeSumTest
    {
        [Test]
        [Ignore("skip first")]
        public void Test3Sum()
        {
            var target=new ThreeSum();
            var expected = new List<List<int>>()
            {
                new List<int> {1, 0, -1},
                new List<int> {1, 1, -2}
            };
            var inputs = new [] {1, 0, 1 - 2, -1};


            var actual = target.GetThreeSum(inputs);

            Assert.AreEqual(expected,actual);
        }
    }
}