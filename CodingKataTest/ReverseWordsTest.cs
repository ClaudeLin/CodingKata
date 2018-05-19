using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        [TestCase("Hi","iH",TestName = "one word reverse")]
        [TestCase("sihT si na !elpmaxe", "This is an example!", TestName = "code War Example")]
        [TestCase("","",TestName = "empty word")]
        [TestCase(null,null,TestName = "null word")]
        public void ReverseEachWord(string expected, string input)
        {
            var actual = input.ReverseEachWords();
            
            Assert.AreEqual(expected,actual);
        }
    }
}
