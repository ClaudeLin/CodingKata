using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class CountingDuplicatesTest
    {
        [Test]
        [TestCase("", 0)]
        //[TestCase(null, 0)]
        //[TestCase("abcde", 0)]
        //[TestCase("aabbcde", 2)]
        //[TestCase("aabBcde", 2,"","should ignore case")]
        //[TestCase("Indivisibility", 1)]
        //[TestCase("Indivisibilities", 2,"", "characters may not be adjacent")]
        public void Input_String_Counting_Duplicates_As_expected(string inputString, int expected)
        {
            var target = new CountingDuplicates();

            var actual = target.CountDuplicateChar(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}
