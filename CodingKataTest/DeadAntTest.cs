using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class DeadAntTest
    {
        [Test]
        [TestCase("",0)]
        public void Input_Empty_String_Should_Be_0_DeadAnt(string inputString,int expected)
        {
            var target = new DeadAnt();

            var actual = target.CountDeadAnts(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}
