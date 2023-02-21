using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh1
{
    public class MGetMiddle
    {
        public static string GetMiddle(string str)
        {
            int iLength = str.Length;
            string str2;

            if (iLength == 1)
            {
                return str;
            }
            else
            {
                if (iLength % 2 == 0)
                {
                    str2 = "" + str[iLength/2 -1 ] + str[iLength/2];
                }
                else
                {
                    str2 = "" + str[iLength / 2];
                }
            }

            return str2;

        }

        public static string GetMiddle1(string str)
        {
            return str.Substring((str.Length - 1) / 2, 2 - (str.Length % 2));
        }

        public static string GetMiddle2(string str)
        {
            int i = 1 - str.Length % 2;
            return str.Substring(str.Length / 2 - i, 1 + i);
        }

        public static string GetMiddle4(string str) =>
            (str.Length % 2 == 0) ?
            str.Substring(str.Length / 2 - 1, 2) :
            str.Substring(str.Length / 2, 1);

        public static string GetMiddle5(string str)
        {
            if (str.Length % 2 == 0)        // is even        
                return str[(str.Length / 2) - 1].ToString() + str[str.Length / 2].ToString();
            else
                return str[(str.Length / 2)].ToString();
        }

    }
}
