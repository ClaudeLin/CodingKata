using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKata
{
    public class ROT13
    {
        private string input;
        private Dictionary<string, string> ROT13LookUp = new Dictionary<string, string>();

        public ROT13(string input)
        {
            this.input = input;
            InitLookUp();
        }

        private void InitLookUp()
        {
            ROT13LookUp.Add("A", "N");
            ROT13LookUp.Add("B", "O");
            ROT13LookUp.Add("C", "P");
            ROT13LookUp.Add("D", "Q");
            ROT13LookUp.Add("E", "R");
            ROT13LookUp.Add("F", "S");
            ROT13LookUp.Add("G", "T");
            ROT13LookUp.Add("H", "U");
            ROT13LookUp.Add("I", "V");
            ROT13LookUp.Add("J", "W");
            ROT13LookUp.Add("K", "X");
            ROT13LookUp.Add("L", "Y");
            ROT13LookUp.Add("M", "Z");
            ROT13LookUp.Add("N", "A");
            ROT13LookUp.Add("O", "B");
            ROT13LookUp.Add("P", "C");
            ROT13LookUp.Add("Q", "D");
            ROT13LookUp.Add("R", "E");
            ROT13LookUp.Add("S", "F");
            ROT13LookUp.Add("T", "G");
            ROT13LookUp.Add("U", "H");
            ROT13LookUp.Add("V", "I");
            ROT13LookUp.Add("W", "J");
            ROT13LookUp.Add("X", "K");
            ROT13LookUp.Add("Y", "L");
            ROT13LookUp.Add("Z", "M");
        }

        public string GetResult()
        {
            var inputs = input.ToCharArray();

            var result = new StringBuilder();
            string temp;
            foreach (var inputchar in inputs)
            {
                if (char.IsLetter(inputchar))
                {
                    if (char.IsLower(inputchar))
                    {
                        if (ROT13LookUp.TryGetValue(inputchar.ToString().ToUpper(), out temp))
                        {
                            temp = temp.ToLower();
                            result.Append(temp);
                            continue;
                        }
                    }

                    result.Append(ROT13LookUp[inputchar.ToString()]);
                    continue;
                }
                result.Append(inputchar);
            }

            return result.ToString();
        }
    }
}