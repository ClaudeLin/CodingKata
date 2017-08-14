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
        private IEnumerable<string> _inputString = new List<string>();

        public string GetStringAverage(string inputString)
		{            
            if (!ValidateInputString(inputString))
            {
                return _emptyInputValue;
            }

			var stringNums = ConvertStringToInt();

            return stringIntMapping.FirstOrDefault(x => x.Value == stringNums.Sum() / stringNums.Count).Key;
        }

        private bool ValidateInputString(string inputString)
        {
            if ( string.IsNullOrEmpty(inputString))
            {
                return false;
            }

            _inputString = inputString.ToLower().Split(' ').AsEnumerable();

            foreach (var item in _inputString)
            {
                if (!stringIntMapping.ContainsKey(item))
                {
                    return false;
                }
            }

            return true;
        }

        private List<int> ConvertStringToInt()
		{
			return _inputString.Select(str => stringIntMapping[str]).ToList();
		}
	}
}
