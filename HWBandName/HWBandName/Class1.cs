using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWBandName
{
    public class Class1
    {
        public static string BandNameGenerator(string str)
        {
            if (str.Trim().Length==0 || string.IsNullOrEmpty(str))
            {
                return "Null";
            }

            string lastChar = str.Substring(str.Length - 1, 1).ToUpper();
            string firstChar = str.Substring(0, 1).ToUpper();
            string bandName = str;

            if (lastChar == firstChar)
            {
                bandName = HasSameLetter(str);
            }
            else
            {
                bandName = NoSameLetter(str);
            }
            return bandName;
        }

        private static string HasSameLetter(string str)
        {
            str = toUpperTitle(str) + str.Substring(1, str.Length - 1);
            return str;
        }

        private static string NoSameLetter(string str)
        {
            str = "The " + toUpperTitle(str);
            return str;
        }

        private static string toUpperTitle(string str)
        {
            str = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
            return str;
        }
    }
}
