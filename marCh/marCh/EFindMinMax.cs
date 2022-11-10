using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class EFindMinMax
    {

        public static double[] FindMinMax(double[] values) => new [] { values.Min(), values.Max() };
        


        public static double[] FindMinMax2(double[] values)
        {
            return new double[] { values.Min() , values.Max() };
        }


        public static double[] FindMinMax1(double[] values)
        {
            double[] arr = new double[2];
            arr[0] = values.Min();
            arr[1] = values.Max();

            return arr;
        }

    }
}
