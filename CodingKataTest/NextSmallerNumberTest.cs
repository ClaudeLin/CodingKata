using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class NextSmallerNumberTest
    {
        [Test]
        [TestCase(1,-1)]
        [TestCase(-1,-1)]
        [TestCase(11,-1)]
        [TestCase(21,12)]
        public void TestNextSmallerNumber(long inputNum,long expected)
        {
            var target = new NextSmallerNumber();

            var actual = target.GetNextSmaller(inputNum);

            Assert.AreEqual(expected,actual);
        }
    }
}
