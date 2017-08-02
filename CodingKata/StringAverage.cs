using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingKata
{
	public class StringAverage
	{
		private readonly Dictionary<string,int> stringIntMapping=new Dictionary<string, int>()
		{
			{"zero",0},
			{"one",1},
			{"two",2},
			{"three",3},
			{"four",4},
			{"five",5},
			{"six",6},
			{"seven",7},
			{"eight",8},
			{"nine",9}
		};

		private const string _emptyInputValue = "n/a";

		public string GetStringAverage(string inputString)
		{
			if (string.IsNullOrEmpty(inputString))
			{
				return _emptyInputValue;
			}
			var stringNums = ConvertStringToInt(inputString);

			return stringIntMapping.FirstOrDefault(x => x.Value == stringNums.Sum()/stringNums.Count).Key;
		}

		private List<int> ConvertStringToInt(string inputString)
		{
			return inputString.ToLower().Split(' ').Select(str => stringIntMapping[str]).ToList();
		}
	}
}
