using System.Collections.Generic;

namespace CodingKata
{
    public class ThreeSum
    {
        public IList<IList<int>> GetThreeSum(int[] nums)
        {
            int[] remain = new int[nums.Length];
            int idx;
            var t = new TwoSum();
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                idx = nums[i];

                nums.CopyTo(remain, i + 1);

                var ele = t.GetTwoSumAns(remain, idx * -1);
                result.Add(ele);
            }

            return result;
        }
    }
}