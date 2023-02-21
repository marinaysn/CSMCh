using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh1
{
    public class MFindLargest
    {

        //M.Y. -2022-11-14
        public static double[] FindLargest(double[][] values)
        {
            double[] arr = new double[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                arr[i] = values[i].Max();
            }
            return arr;
        }

        public static double[] FindLargest1(double[][] values)
        {
            return values.Select(v => v.Max()).ToArray();
        }

    }
}
