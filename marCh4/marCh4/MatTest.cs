using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh4
{
    internal class MatTest
    {


        public static long fibonacciBad(int n)
        {
            if (n <= 1)
                return n;
            else
                return fibonacciBad(n - 2) + fibonacciBad(n - 1);
        }

        public static long[] fibonacciGood(int n)
        {
            if (n <= 1)
            {
                long[] answer = { n, 0 };
                return answer;
            }
            else
            {
                long[] temp = fibonacciGood(n - 1); // returns {Fn−1, Fn−2} 

                long[] answer = { temp[0] + temp[1], temp[0] }; // we want {Fn, Fn−1}
                                                                
                return answer;

            }
        }


    }
}