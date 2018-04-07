using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class AnagramDetectionTest
    {
        [Test]
        public void IsAnagram()
        {
            var target = new AnagramDetection();

            var test = "A";
            var original = "A";
            var actual = target.IsAnagram(test, original);

            Assert.IsTrue(actual);
        }
    }
}
