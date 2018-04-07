using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class AnagramDetectionTest
    {
        [Test]
        [TestCase("foefet", "toffee")]
        [TestCase("Buckethead", "DeathCubeK")]
        [TestCase("Twoo", "Woot")]
        public void IsAnagram(string test, string original)
        {
            var target = new AnagramDetection();
          
            var actual = target.IsAnagram(test, original);

            Assert.IsTrue(actual);
        }

        [Test]
        [TestCase("apple", "pale")]
        public void IsNotAnagram(string test, string original)
        {
            var target = new AnagramDetection();

            var actual = target.IsAnagram(test, original);

            Assert.IsFalse(actual);
        }
    }
}
