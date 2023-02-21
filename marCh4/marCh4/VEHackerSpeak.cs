using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh4
{
    internal class VEHackerSpeak
    {
        public static string HackerSpeak(string str)
        {
            var temp = str.Replace('a', '4');

            temp = temp.Replace('i', '1');
            temp = temp.Replace('s', '5');
            temp = temp.Replace('o', '0');
            temp = temp.Replace('e', '3');
            

            return temp;
        }

    }
}
