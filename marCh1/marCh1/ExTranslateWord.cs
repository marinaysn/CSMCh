using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace marCh1
{
    public class ExTranslateWord
    {

        public static string TranslateWord(string word)
        {
            var i = word.IndexOfAny(new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' });
            if (i == -1) return word;
            else if (i == 0) return word + "yay";
            else
            {
                return ((char.IsUpper(word[0])) ? char.ToUpper(word[i]) : char.ToLower(word[i])) +
                    word.Substring(i + 1) + word.Substring(0, i).ToLower() + "ay";
            }
        }

        public static string TranslateSentence(string sentence)
        {
            return Regex.Replace(sentence, "[a-zA-Z]+", m => TranslateWord(m.Value));
        }


        public static string TranslateWord1(string word)
        {

            int lettersCounter = Regex.Matches(word, @"[A-Z]").Count;

            string str = "";
            string str1 = "";
            int flag = 0;
            char[] charArray = word.ToCharArray();
            string p = "";

            if (charArray.Length == 0)
            {
                return "";
            }

            for (int i = 0; i < charArray.Length; i++)
            {

                if (!(char.ToLower(charArray[i]) == 'a' || char.ToLower(charArray[i]) == 'o' || char.ToLower(charArray[i]) == 'e' || char.ToLower(charArray[i]) == 'i' || char.ToLower(charArray[i]) == 'u')
                   || Char.IsPunctuation(charArray[i]))
                {

                    if (charArray[i] == '"')
                    {
                        str = str + '"';
                    }
                    else
                    {
                        str = str + charArray[i];
                    }
                }

                else
                {
                    flag = i;
                    i = charArray.Length;
                }
            }

            for (int i = flag; i < charArray.Length; i++)
            {

                if (!Char.IsPunctuation(charArray[i]))
                {

                    str1 = str1 + charArray[i];
                }
                else
                {
                    p = p + charArray[i].ToString();
                }

            }

            if (flag > 0)
            {
                str1 = str1 + str + "ay" + p;
            }
            else
            {
                str1 = str1 + str + "yay" + p;
            }

            if (lettersCounter > 0)
            {
                str1 = str1.ToLower();
                str1 = char.ToUpper(str1[0]) + str1.Substring(1);
            }

            return str1;
        }

        public static string TranslateSentence1(string sentence)
        {
            int lettersCounter = Regex.Matches(sentence, @"[a-zA-Z]").Count;

            if (lettersCounter == 0)
            {
                return "";
            }

            string[] words = sentence.Split(' ');
            string finalSentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0] == '"')
                {
                    string temp = TranslateWord(words[i].Substring(1));
                    temp = temp.ToLower();
                    finalSentence = finalSentence + " " + '"' + char.ToUpper(temp[0]) + temp.Substring(1);
                }
                else
                {
                    if (i == 0)
                    {
                        finalSentence = TranslateWord(words[i]).ToLower();
                        finalSentence = char.ToUpper(finalSentence[0]) + finalSentence.Substring(1);
                    }
                    else
                    {
                        finalSentence = finalSentence + " " + TranslateWord(words[i]);
                    }

                }

            }

            return finalSentence.Trim();
        }


        
    }
}


//TranslateWord("flag") ➞ "agflay"

//TranslateWord("Apple") ➞ "Appleyay"

//TranslateWord("button") ➞ "uttonbay"

//TranslateWord("") ➞ ""

//TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."

//TranslateSentence("Do you think it is going to rain today?") ➞ "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"

