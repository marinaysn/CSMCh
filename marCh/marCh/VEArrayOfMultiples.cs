using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class VEArrayOfMultiples
    {

        public static int[] ArrayOfMultiples(int num, int length)
        {
            int i = 0;
            int[] arr = new int[length];


            while (i < length)
            {
                arr[i] = num * ++i;
            }
            return arr;
        }


        public static int[] ArrayOfMultiples11(int num, int length)
        {
            int i = 0;
            int[] arr = new int[length];
            int total = num;
            arr[i] = total;
            i++;

            while (i < length)
            {
                total += num;
                arr[i] = total;
                i++;
            }
            return arr;
        }

        public static int[] ArrayOfMultiples1(int num, int length) => Enumerable.Range(1, length).Select(x => x * num).ToArray();
        public static int[] ArrayOfMultiples2(int num, int length) => Enumerable.Range(1, length).Select(i => num * i).ToArray();
        public static int[] ArrayOfMultiples7(int num, int length) => Enumerable.Range(1, length).Select(x => x * num).ToArray();


        public static int[] ArrayOfMultiples3(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num * (i + 1);
            }
            return multiples;
        }

        public static int[] ArrayOfMultiples4(int num, int length)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= length; i++)
                result.Add(num * i);
            return result.ToArray();
        }


    }
}
