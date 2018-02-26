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
    public class ROT13Test
    {
        [Test]
        [TestCase("","")]
        [TestCase("A","N")]
        [TestCase("a","n")]
        [TestCase("A a","N n")]
        [TestCase("ROT13 example.", "EBG13 rknzcyr.")]
        public void TestROT13(string input,string expected)
        {
            var target = new ROT13(input);

            var actual = target.GetResult();

            Assert.AreEqual(expected,actual);
        }
    }
}
