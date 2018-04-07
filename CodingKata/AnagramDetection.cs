using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingKata
{
    public class AnagramDetection
    {
        public bool IsAnagram(string test, string original)
        {
            var result = test.ToLower().ToCharArray().ToList();
            foreach (var c2 in original.ToLower().ToCharArray())
            {
                if (result.Contains(c2))
                {
                    result.Remove(c2);
                }
                else
                {
                    return false;
                }
            }
            return result.Count == 0;
        }
    }
}