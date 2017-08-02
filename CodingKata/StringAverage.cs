using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingKata
{
	public class StringAverage
	{

		public string GetStringAverage(string inputString)
		{
			if (string.IsNullOrEmpty(inputString))
			{
				return "n/a";
			}
			var stringNums = ConvertToInt(inputString);
			return Enum.GetName(typeof(EnumStringNumberMapping), stringNums.Sum() / stringNums.Count);
		}

		private List<int> ConvertToInt(string inputString)
		{
			return inputString.ToLower().Split(' ').Select(str => (int)Enum.Parse(typeof(EnumStringNumberMapping), str)).ToList();
		}
	}
}
