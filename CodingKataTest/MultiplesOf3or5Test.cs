using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class MultiplesOf3or5Test
    {
        [Test]
        [TestCase(23,10)]
        [TestCase(60,16)]
        public void TestMultiplesSum(int expected,int input)
        {
            var target = new MultiplesOf3or5();
            var actual=target.GetMultiplesSum(input);

            Assert.AreEqual(expected,actual);
        }
    }
}
