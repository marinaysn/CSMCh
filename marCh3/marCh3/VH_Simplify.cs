using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class VH_Simplify
    {

        public static string Simplify11(string str)
        {

            int[] convertedNums = Array.ConvertAll<string, int>(str.Split('/'), int.Parse);
            int num1, num2;

            if (convertedNums[0] > convertedNums[1])
            {
                num1 = convertedNums[0]; num2 = convertedNums[1];
            }
            else
            {
                num1 = convertedNums[1]; num2 = convertedNums[0];
            }

            if (num1 % num2 == 0 && num2 !=0 && convertedNums[0] > convertedNums[1])
            {
                return (num1 / num2).ToString();
            }

            while (num1 != num2)

            {
                if (num1 > num2)

                    num1 = num1 - num2;

                if (num2 > num1)

                    num2 = num2 - num1;

            }

             return (convertedNums[0] / num1 + "/" + convertedNums[1] / num1);
        }

        public static string Simplify1(string str)
        {
            int lhs = int.Parse(str.Split('/')[0]);
            int rhs = int.Parse(str.Split('/')[1]);
            int gcd = GetGCD(lhs, rhs);
            int num = lhs / gcd, denum = rhs / gcd;

            if (denum == 1) return $"{num}";
            else return $"{num}/{denum}";
        }

        private static int GetGCD(int a, int b) =>
            (a == 0) ? b : GetGCD(b % a, a);



        public static string Simplify(string str)
        {
            string[] array = str.Split('/');

            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);

            int min = a < b ? a : b;

            for (int i = min; i > 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a = a / i;
                    b = b / i;

                    str = b == 1 ? a.ToString() : $"{a}/{b}";
                    break;
                }
            }

            return str;
        }


        public static string Simplify3(string str)
        {
            var numbers = (str.Split('/').Select(x => Convert.ToInt32(x)));

            for (int i = numbers.First(); i > 1; i--)
            {
                if (numbers.First() % i == 0 && numbers.Last() % i == 0)
                {
                    if (numbers.Last() / i == 1)
                        return (numbers.First() / i).ToString();
                    return (numbers.First() / i).ToString() + '/' + numbers.Last() / i;
                }
            }

            return str;
        }


    }
}

//Simplified Fractions
//Create a function that returns the simplified version of a fraction.

//Examples
//Simplify("4/6") ➞ "2/3"

//Simplify("10/11") ➞ "10/11"

//Simplify("100/400") ➞ "1/4"

//Simplify("8/4") ➞ "2"
//Notes
//A fraction is simplified if there are no common factors (except 1) between the numerator and the denominator. For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.
//If improper fractions can be transformed into integers, do so in your code (see example #4).

