using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class HReverseAndNot
    {


        public static string ReverseAndNot(int i) //=> Enumerable.Reverse(i).Select(x=>x.Reverse())
        {

            char[] charArray = i.ToString().ToCharArray();
            Array.Reverse(charArray);

            string abc = new string(charArray);

            return abc + i;
        }


        public static string ReverseAndNot2(int i) //=> Enumerable.Reverse(i).Select(x=>x.Reverse())
        {
            char[] charArray = i.ToString().ToCharArray();
            Array.Reverse(charArray);

            return new string(new string(charArray)) + i.ToString();
        }


        public static string ReverseAndNot3(int i)
        {
            return new string(("" + i).Reverse().ToArray()) + ("" + i);
        }

        public static string ReverseAndNot4(int i)
        {
            return $"{String.Concat(i.ToString().Reverse())}{i}";
        }

        public static string ReverseAndNot5(int i) => string.Concat(i.ToString().Reverse().ToArray()) + i;


    }
}
