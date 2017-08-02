using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
	[TestFixture]
	public class StringAverageTest
	{
		[Test]
		[TestCase("zero nine five two", "four")]
		[TestCase("four six two three", "three")]
		[TestCase("one two three four five", "three")]
		[TestCase("five four", "four")]
		[TestCase("zero zero zero zero zero", "zero")]
		[TestCase("one one eight one", "two")]
		[TestCase("","n/a")]
		public void TestAverageString(string inputString, string expected)
		{
			var target=new StringAverage();

			var actual = target.GetStringAverage(inputString);

			Assert.AreEqual(expected, actual);
		}
	}
}
