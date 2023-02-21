using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class H_CanFind
    {
        public static bool CanFind(string[] bigrams, string[] words)
        {
            int count = 0;
            foreach ( string i in bigrams)
            {              
                foreach (string j in words)
                {
                    if (j.Contains(i) == true)
                    {
                        count++;
                        break;
                    }
                }             
            }
            return (count == bigrams.Length) ? true : false;
        }

        public static bool CanFind1(string[] bigrams, string[] words)
        {
            return bigrams.All(b => words.Any(w => w.Contains(b)));
        }

        public static bool CanFind2(string[] bigrams, string[] words)
        {
            foreach (var bigram in bigrams)
            {
                if (!words.Any(word => word.Contains(bigram)))
                    return false;
            }

            return true;
        }

    }
}


//Do All Bigrams Exist?
//You are given an input array of bigrams, and an array of words.

//Write a function that returns true if every single bigram from this array can be found at least once in an the list of words.

//Examples
//CanFind(new string[] { "at", "be", "th", au" }, new string[] { "beautiful", "the", "hat" }) ➞ true

//CanFind(new string[] { "ay", "be", "ta", cu" }, new string[] { "maybe", "beta", "abet", "course" }) ➞ false
//// "cu" does not exist in any of the words.

//CanFind(new string[] { "th", "fo", "ma", or" }, new string[] { "the", "many", "for", "forest" }) ➞ true

//CanFind(new string[] { "oo", "mi", "ki", la" }, new string[] { "milk", "chocolate", "cooks" }) ➞ false
//Notes
//A bigram is string of two consecutive characters in the same word.
//If the array of words is empty, return false.


