using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class BandNameGenerator
    {
        private string _inputString;
        public string GenerateBandName(string inputString)
        {            
            return string.IsNullOrEmpty(inputString) ? string.Empty : GetBandName(inputString);
        }

        private string GetBandName(string inputString)
        {
            _inputString = inputString.ToLower();

            var RemainChar = _inputString.Substring(1);

            var result = FirstChar().ToUpper() + RemainChar;

            return IsFirstAndLastCharTheSame() ? result += RemainChar : "The " + result;
        }

        private string FirstChar()
        {
            return _inputString.Substring(0, 1);
        }

        private bool IsFirstAndLastCharTheSame()
        {
            return FirstChar() == LastChar();
        }

        private string LastChar()
        {
            return _inputString.Substring(_inputString.Length - 1);
        }
    }
}
