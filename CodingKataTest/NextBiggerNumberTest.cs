using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class NextBiggerNumberTest
    {
        [Test]
        [TestCase(12, 21)]
        //[TestCase(513,531)]
        //[TestCase(2017,2071)]
        //[TestCase(1342,1423)]
        public void TestGetNextBiggerNumber(int inputNum,int expected)
        {
            var target=new NextBiggerNumber();
            var actual = target.GetNextBiggerNumber(inputNum);

            Assert.AreEqual(expected,actual);

        }
    }
}
