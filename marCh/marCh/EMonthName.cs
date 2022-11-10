using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class EMonthName
    {

        public static string MonthName(int num)
        {

            if (num > 0 && num < 13)
            {

                return new DateTimeFormatInfo().GetMonthName(num).ToString();
            }
            return "";

        }

        public static string MonthName5(int num)
        {

            if (num > 0 && num < 13)
            {

                DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                return dtfi.GetMonthName(num).ToString();
            }
            return "";

        }


        public static string MonthName1(int num)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }

        public static string MonthName2(int num)
        {
            string[] str = new string[]
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            return str[num - 1];

        }

        public static string MonthName3(int num)
        {
            return new DateTime(1, num, 1).ToString("MMMM");
        }


        public static string MonthName4(int num)
        {
            return new DateTimeFormatInfo().GetMonthName(num);
        }

    }
}




//Convert Number to Corresponding Month Name
//Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
//For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.

//Number	Month Name
//1	January
//2	February
//3	March
//4	April
//5	May
//6	June
//7	July
//8	August
//9	September
//10	October
//11	November
//12	December
//Examples
//MonthName(3) ➞ "March"

//MonthName(12) ➞ "December"

//MonthName(6) ➞ "June"
//Notes
//You can expect only integers ranging from 1 to 12 as test input.
//If you get stuck on a challenge, find help in the Resources tab.
//If you're really stuck, unlock solutions in the Solutions tab.



