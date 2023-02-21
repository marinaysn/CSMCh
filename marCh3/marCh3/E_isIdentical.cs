using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class E_isIdentical
    {

        public static bool isIdentical1(string str)
        {
            return str.Select(i => i).Distinct().Count() == 1;
        }

        public static bool isIdentical(string str) => str.Select(i => i).Distinct().Count() == 1;
        

    }
}
