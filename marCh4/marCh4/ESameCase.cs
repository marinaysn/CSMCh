using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh4
{
    internal class ESameCase
    {

        public static bool SameCase1(string str)
        {

            bool b = false;

            b = str.Any(char.IsUpper);

            if (b)
            {
                b = str.Any(char.IsLower);
                return b == true ? false: true;
            }

            else
            {

                return true;
            }

        }

        public static bool SameCase(string str)
       => str == str.ToUpper() || str == str.ToLower();


    }
}
