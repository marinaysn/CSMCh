using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace marCh2
{
    public class M_collatz
    {
        static int nums = 0;
        public static int collatz1(int num)
        {

            nums++;
            if (num == 1)
            {
                int c = nums - 1;
                if (nums == 1)
                    c = nums;
                nums = 0;
                return c;
            }
            int i = num % 2;

            if (i == 0)
            {
                return collatz1(num / 2);
            }
            return collatz1(num * 3 + 1);

        }

        public static int collatz(int num)
        {
            int k = num % 2 < 1 ? num / 2 : 3 * num + 1;
            return num < 2 ? 0 : collatz(k) + 1;
        }

        public static int collatz2(int num)
        {
            int count = 0;

            while (true)
            {
                if (num == 1) break; // Reached 1.

                else if (num % 2 == 0)
                { // Even.
                    num = num / 2;
                    count++;
                }

                else
                { // Odd.
                    num = num * 3 + 1;
                    count++;
                }
            }

            return count;
        }


        public static int collatz3(int num)
        {
            int sum = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num = num * 3 + 1;
                sum++;
            }
            return sum;
        }

    }
}

//Consider the following operation on an arbitrary positive integer:

//If n is even -> n / 2
//If n is odd -> n * 3 + 1
//Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.

//See the following example, using 10 as the input, with 6 steps:

//10 is even - 10 / 2 = 5
//5 is odd - 5 * 3 + 1 = 16
//16 is even - 16 / 2 = 8
//8 is even - 8 / 2 = 4
//4 is even - 4 / 2 = 2
//2 is even - 2 / 2 = 1->Reached 1, so return 6
//Examples
//collatz(2) ➞ 1

//collatz(3) ➞ 7

//collatz(10) ➞ 6
//Notes
//For further information, check the Resources tab.
