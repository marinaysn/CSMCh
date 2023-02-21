using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh2
{
    public class VH_PaulCipher
    {
        public static string PaulCipher(string txt)
        {
            string str = "";
            int index = 0;
            int temp = 0;

            for (int i = 0; i< txt.Length; i++)
            {
                char c = txt[i];
                if (Char.IsLetter(c))
                {

                        if ((char.ToUpper(c) - 64) + index > 26)
                        {
                            temp = 26 - (char.ToUpper(c) - 64);
                            temp = index - temp;
                        }
                        else
                        {
                            temp = (char.ToUpper(c) - 64) + index;  
                        }

                        
                        c = (Char)((64 + temp));
                        index = char.ToUpper(txt[i]) - 64;

                }

                str = str + c;
            }
            return str;

        }


    }
}

/*
 Paul Cipher
In Paul Cipher, only alpha characters will be encoded with the following rules:

All alpha characters will be treated as uppercase letters.
The first alpha character will not change (except for switching to upper case).
All subsequent alpha characters will be shifted toward "Z" by the alphabetical position of the previous alpha character (wrap back to "A" if "Z" is passed).
he1lo would be encoded as follows:

PaulCipher("he1lo") ➞ "HM1QA"

h -> H (First character to be changed to uppercase)
e -> M (H is the previous alpha character and 8th letter in the alphabets. E + 8 = M)
1 -> 1 (Keep all characters other than alphabets as it is)
l -> Q (E is the previous alpha character and 5th letter in the alphabets. L + 5 = Q)
o -> A (L is the previous alpha character and 12th letter in the alphabets. O + 12 = A)
Given a string txt, return the encoded message. See the below examples for a better understanding:

Examples
PaulCipher("muBas41r") ➞ "MHWCT41K"

PaulCipher("a1rForce") ➞ "A1SXUGUH"

PaulCipher("MATT") ➞ "MNUN"

 */