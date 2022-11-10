using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace marCh
{
    public class MIndexOfCapitals
    {

        public static int[] IndexOfCapitals(string str)
        {
            List<int> nums = new List<int>();

            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsUpper(arr[i]))
                {
                    nums.Add(i);
                }
            }

            int[] num = new int[nums.Count];

            for (int i = 0; i < nums.Count; i++)
            {
                num[i] = nums[i];
            }

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write(num[i] + " ");
            //}

            return num;
        }

    }
}
