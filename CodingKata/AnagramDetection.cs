using System.Linq;

namespace CodingKata
{
    public class AnagramDetection
    {
        public bool IsAnagram(string test, string original)
        {
            if (test.Length != original.Length)
            {
                return false;
            }

            var result = test.ToLower().ToCharArray().ToList();
            foreach (var c in original.ToLower().ToCharArray())
            {
                if (!result.Contains(c))
                {
                    return false;
                }
                result.Remove(c);
            }
            return result.Count == 0;
        }
    }
}