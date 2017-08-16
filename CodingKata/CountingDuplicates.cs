using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class CountingDuplicates
    {
        private int _result = 0;
        private string _remainString = "";

        public int CountDuplicateChar(string inputString)
        {
            return string.IsNullOrEmpty(inputString) ? _result : GetDuplicateCount(inputString.Trim().ToLower());
        }
        private int GetDuplicateCount(string inputString)
        {
            _remainString = inputString;
            while (HasRemainString())
            {
                CheckDuplicateChar();
                UpdateRemainString();
            }

            return _result;
        }
        private string UpdateRemainString()
        {
            _remainString = _remainString.Replace(GetFirstChar(), "");
            return _remainString;
        }
        private void CheckDuplicateChar()
        {
            if(_remainString.Substring(1).Contains(GetFirstChar()))
            {
                _result++;
            }
        }
        private string GetFirstChar()
        {
            return _remainString.Substring(0, 1);
        }
        private bool HasRemainString()
        {
            return _remainString.Length > 0;
        }
    }
}
