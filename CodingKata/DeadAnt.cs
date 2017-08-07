using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingKata
{
    public class DeadAnt
    {
        public int CountDeadAnts(string inputString)
        {
            return string.IsNullOrEmpty(inputString) ? 0 : GetMax(inputString.Replace("ant", ""));
        }

        private int GetMax(string result)
        {
            var maxCount = result.GroupBy(c => c)
                         .Where(e => e.Key == 'a' || e.Key == 'n' || e.Key == 't')
                         .OrderByDescending(g => g.Count())
                         .FirstOrDefault();

            return maxCount == null ? 0 : maxCount.Count();
        }
    }
}
