using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class MReverseCase
    {

        public static string ReverseCase(string str)
        {
            string reversedCase = new string(str.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                                  char.ToLower(c) : char.ToUpper(c)) : c).ToArray());

            return reversedCase;
        }

        public static string ReverseCase1(string str)
        {
            return string.Concat(str.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
        }

        public static string ReverseCase2(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                sb.Append(Char.IsUpper(ch) ? Char.ToLower(ch) : Char.ToUpper(ch));
            }
            return sb.ToString();
        }


        public static string ReverseCase3(string str)
        {
            string newString = "";
            char[] stringAsArrayOfChars = str.ToCharArray();
            for (int i = 0; i < stringAsArrayOfChars.Length; i++)
            {
                if (Char.IsLower(stringAsArrayOfChars[i]))
                    newString += (stringAsArrayOfChars[i] + "").ToUpper();
                else
                    newString += (stringAsArrayOfChars[i] + "").ToLower();

            }
            return newString;
        }


    }
}

//Reverse the Case
//Given a string, create a function to reverse the case.
//All lower-cased letters should be upper-cased, and vice versa.

//Examples
//ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

//ReverseCase("MANY THANKS") ➞ "many thanks"

//ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
