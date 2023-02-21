using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh3
{
    internal class M_GreaterThanOne
    {

        public static bool GreaterThanOne(string str)
        {
            int[] convertedNums = System.Array.ConvertAll<string, int>(str.Split('/'), int.Parse);

            return convertedNums[0] > convertedNums[1];

        }

        public static bool GreaterThanOne1(string str)
        {
            double[] arr = Array.ConvertAll(str.Split('/'), double.Parse);
            return arr[0] / arr[1] > 1;
        }

        public static bool GreaterThanOne2(string str)
        {
            return double.Parse(str.Split('/')[0]) > double.Parse(str.Split('/')[1]);
        }

    }
}
