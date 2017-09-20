using CodingKata;
using NUnit.Framework;

namespace CodingKataTest
{
    [TestFixture]
    public class TwoSumTest
    {
        private TwoSum target;
        private int[] expected;
        private int[] inputNums;
        private int targetNum;
        private int[] actual;
        [Test]
        public void Input_0_1_2_Target_1_Should_Be_0_1()
        {
            target = new TwoSum();
            expected = new[] { 0, 1 };
            inputNums =  new [] { 0,1,2 };
            targetNum = 1;

            actual = target.GetTwoSumAns(inputNums, targetNum);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_1_2_5_6_Target_11_Should_Be_2_3()
        {
            target = new TwoSum();
            expected = new[] {2,3};
            inputNums = new[] {1,2,5,6 };
            targetNum = 11;

            actual = target.GetTwoSumAns(inputNums, targetNum);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_2_3_4_8_9_Target_7_Should_Be_1_2()
        {
            target = new TwoSum();
            expected = new[] { 1,2 };
            inputNums = new[] { 2,3,4,8,9 };
            targetNum = 7;

            actual = target.GetTwoSumAns(inputNums, targetNum);

            Assert.AreEqual(expected, actual);
        }
    }
}
