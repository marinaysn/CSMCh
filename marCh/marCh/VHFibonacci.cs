using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class VHFibonacci
    {

        public static string FiboWord(int n)
        {

            string[] arr = new string[n];
            string str = "";
            int i = 2;

            if (n < 2)
            {
                return "invalid";
            }

            else
            {
                arr[0] = "b";
                arr[1] = "a";
            }

            while (i < n)
            {
                i++;
                arr[i-1] = Factorial(i, arr);
            }


            for (int j = 0; j < arr.Length; j++)
            {
                if (j == arr.Length-1)
                {
                    str = str + arr[j];
                }
                else
                {
                    str = str + arr[j] + ", ";
                }
                
            }

            return str;

        }

        public static string Factorial(int number, string[] arr)
        {
            if (number == 0)
                return " ";

            else
            {
                // arr[number] = arr[number] + arr[number];
                return arr[number-2] + arr[number-3]; ;//Recursive call  
            }


        }


        public static string FiboWord2(int n)
        {
            if (n < 2) return "invalid";
            var lst = new List<string> { "b", "a" };
            while (n > 2)
            {
                lst.Add(lst.Last() + lst[lst.Count - 2]);
                n--;
            }
            return string.Join(", ", lst);
        }


        public static string FiboWord3(int n)
        {
            string[] words = new string[n];
            if (n < 2) return "invalid";
            else
            {
                words[0] = "b";
                words[1] = "a";
                for (int i = 0; i < n - 2; i++)
                {
                    words[i + 2] = words[i + 1] + words[i];
                }
                return string.Join(", ", words);

            }
        }

        public static string FiboWord4(int n)
        {
            if (n < 3)
                return "invalid";
            List<string> seq = new List<string> { "b", "a" };
            for (int i = 3; i <= n; i++)
                seq.Add(string.Format("{0}{1}", seq[seq.Count - 1],
                                      seq[seq.Count - 2]));
            return string.Join(", ", seq);
        }




    }
}




//A Fibonacci Word is a specific sequence of binary digits (or symbols from any two-letter alphabet).
//The Fibonacci Word is formed by repeated concatenation in the same way that the Fibonacci numbers are formed by repeated addition.

//Create a function that takes a number n as an argument and returns the first n elements of the Fibonacci Word sequence.

//If n < 2, the function must return "invalid".

//Examples
//FiboWord(1) ➞ "invalid"

//FiboWord(3) ➞ "b, a, ab"

//FiboWord(7) ➞ "b, a, ab, aba, abaab, abaababa, abaababaabaab"
//Notes
//You can try solving this using a recursive approach.No bonus points just extra satisfaction!!
