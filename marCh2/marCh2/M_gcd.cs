using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh2
{
    public class M_gcd
    {

        public static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }

            int num = n1 % n2;

            return gcd(n2, num);

        }

    }
}
