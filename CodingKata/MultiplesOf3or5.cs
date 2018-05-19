using System.Collections.Generic;
using System.Linq;

namespace CodingKata
{
    public class MultiplesOf3or5
    {
        public int GetMultiplesSum(int input)
        {
            var list = new List<int>();

            for (var i = 1; i < input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    list.Add(i);
                }
            }

            return list.Sum();
        }
    }
}