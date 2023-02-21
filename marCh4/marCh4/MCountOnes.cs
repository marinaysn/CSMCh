using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh4
{
    internal class MCountOnes
    {
        public static int CountOnes(int i)
        {
            var str = Convert.ToString(i, 2);
            return str.Select(c => c - '0').ToArray().Sum();
        }

    }
}
