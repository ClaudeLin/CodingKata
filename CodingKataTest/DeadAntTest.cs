using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class DeadAntTest
    {
        [Test]
        [TestCase("",0)]
        [TestCase(null,0)]
        [TestCase("antt",1)]
        [TestCase("ant ant ant ant",0)]
        [TestCase("ant anantt aantnt",2)]
        [TestCase("ant ant .... a nt", 1)]
        [TestCase("ant aaanntttttttt 12qd3f3",8)]
        public void Input_Empty_String_Should_Be_0_DeadAnt(string inputString,int expected)
        {
            var target = new DeadAnt();

            var actual = target.CountDeadAnts(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}
