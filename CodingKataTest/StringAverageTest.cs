using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
	[TestFixture]
	public class StringAverageTest
	{
		[Test]
		[TestCase("zero nine five two", "four")]
		public void TestAverageString(string inputString, string expected)
		{
			var target=new StringAverage();

			var actual = target.GetStringAverage(inputString);

			Assert.AreEqual(expected, actual);

			//Assert.AreEqual("four", Kata.AverageString("zero nine five two"));
			//Assert.AreEqual("three", Kata.AverageString("four six two three"));
			//Assert.AreEqual("three", Kata.AverageString("one two three four five"));
			//Assert.AreEqual("four", Kata.AverageString("five four"));
			//Assert.AreEqual("zero", Kata.AverageString("zero zero zero zero zero"));
			//Assert.AreEqual("two", Kata.AverageString("one one eight one"));
			//Assert.AreEqual("n/a", Kata.AverageString(""));
		}
	}
}
