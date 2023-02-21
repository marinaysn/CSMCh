using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class E_Factorial
    {
        public static int Factorial(int num)
        {
            int num2 = 1;
            while (num != 1)
            {
                num2 = num2 * num;
                num = num - 1;
            }
            return num2;
        }

        public static int Factorial1(int n) => n < 2 ? 1 : n * Factorial1(n - 1);

        public static int Factorial2(int num)
        {
            int result = 1;
            if (num == 0) { return 0; }
            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;

        }



    }
}
