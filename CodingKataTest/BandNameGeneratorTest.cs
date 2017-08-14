using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class BandNameGeneratorTest
    {
        [Test]
        [TestCase("", "")]
        [TestCase(null, "")]
        [TestCase("knife","The Knife")]
        [TestCase("tart", "Tartart")]
        [TestCase("sandles", "Sandlesandles")]
        [TestCase("bed", "The Bed")]
        public void Input_Empty_String_Should_Be_Empty(string inputString, string expected)
        {
            var target = new BandNameGenerator();

            var actual = target.GenerateBandName(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}

