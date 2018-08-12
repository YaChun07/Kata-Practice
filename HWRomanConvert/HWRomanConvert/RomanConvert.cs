using System.Collections.Generic;

namespace HWRomanConvert
{
    public class RomanConvert
    {
        private Dictionary<int, string> _romanDigits;

        public string Solution(int n)
        {
            _romanDigits = new Dictionary<int, string>
            {
                {1000,"M" },
                {900,"CM" },
                {500,"D" },
                {400,"CD" },
                {100,"C" },
                {90,"XC" },
                {50,"L" },
                {40,"XL" },
                {10,"X" },
                {9,"IX" },
                {5,"V" },
                {4,"IV" },
                {1,"I" }
            };

            return GetRomanString(n);
        }

        private string GetRomanString(int remaining)
        {
            var romString = "";

            while (remaining != 0)
            {
                foreach (var rom in _romanDigits)
                {
                    if (remaining >= rom.Key)
                    {
                        romString += rom.Value;
                        remaining -= rom.Key;
                        break; 
                    }
                }
               
            }
            return romString;
        }
    }
}