using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace marCh
{
    public class HWeekAfter
    {

        public static string WeekAfter(string date)
        {

            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", null).AddDays(7);
            
            return d.ToString("dd/MM/yyyy");

        }

        public static string WeekAfter1(string date)
        {
            var d = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture).AddDays(7);
            return $"{d.Day:00}/{d.Month:00}/{d.Year}";
        }

        public static string WeekAfter3(string date)
        {
            CultureInfo enGB = new CultureInfo("en-GB");
            int[] dmy = date.Split('/').Select(s => int.Parse(s)).ToArray();
            DateTime dateTime = new DateTime(dmy[2], dmy[1], dmy[0]);
            return dateTime.AddDays(7.0d).ToString("d", enGB);
        }

        public static string WeekAfter4(string date) => DateTime
        .ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        .AddDays(7)
        .ToString("dd/MM/yyyy");
    }


}



//A Week Later
//Create a function which takes in a date as a string, and returns the date a week after.

//Examples
//WeekAfter("12/03/2020") ➞ "19/03/2020"

//WeekAfter("21/12/1989") ➞ "28/12/1989"

//WeekAfter("01/01/2000") ➞ "08/01/2000"
//Notes
//Note that dates will be given in day/month/year format.
//Single digit numbers should be zero padded.

