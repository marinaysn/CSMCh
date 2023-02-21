using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class M_CounterpartCharCode
    {

        public static int CounterpartCharCode(char symbol)
        {

            if (char.IsUpper(symbol)){
                return System.Convert.ToInt32(char.ToLower(symbol));
            }

            return System.Convert.ToInt32(char.ToUpper(symbol));
        }

        public static int CounterpartCharCode1(char symbol)
        {
            return char.IsUpper(symbol) ?
                (int)char.ToLower(symbol) :
                (int)char.ToUpper(symbol);
        }

        public static int CounterpartCharCode2(char symbol)
        {
            if (char.IsLower(symbol))
                symbol = char.ToUpper(symbol);
            else
                symbol = char.ToLower(symbol);

            return (int)symbol;
        }

        public static int CounterpartCharCode3(char symbol)
        {
            return char.IsUpper(symbol) ? (int)char.ToLower(symbol) : (int)char.ToUpper(symbol);
        }

    }
}


//Find the Characters Counterpart Char Code
//Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.

//Examples
//Given that:
//  -"A" char code is: 65
//  - "a" char code is: 97

//CounterpartCharCode("A") ➞ 97

//CounterpartCharCode("a") ➞ 65
//Notes
//The argument will always be a single character.
//Not all inputs will have a counterpart (e.g. numbers), in which case return the input 's char code.
