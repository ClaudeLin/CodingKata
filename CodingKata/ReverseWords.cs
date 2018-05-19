using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingKata
{
    public static class ReverseWords
    {
        public static string ReverseEachWords(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            var words = str.Split(' ');
            var results = new List<string>();
            char[] temp;
            foreach (var word in words)
            {
                temp = word.ToCharArray();
                Array.Reverse(temp);
                results.Add(new string(temp));
            }
            return results.Aggregate(string.Empty, (current, result) => current + " " + result).Substring(1);
        }
    }
}